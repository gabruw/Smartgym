﻿using Auxiliary;
using Domain.Repository;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Smartgym.Controllers
{
    public class AlunoController : Controller
    {
        private readonly IAlunoRepository _alunoRepository;
        private readonly IContaRepository _contaRepository;
        private readonly IEnderecoRepository _enderecoRepository;
        private readonly IHostingEnvironment _hosting;

        private Geradores newGerador = new Geradores();
        private DataTable newDataTable = new DataTable();

        public AlunoController(IAlunoRepository alunoRepository, IContaRepository contaRepository, IEnderecoRepository enderecoRepository, IHostingEnvironment hosting)
        {
            _alunoRepository = alunoRepository;
            _contaRepository = contaRepository;
            _enderecoRepository = enderecoRepository;
            _hosting = hosting;
        }

        // GET: Aluno
        public ActionResult Index()
        {
            var alunoDTO = _alunoRepository.GetAll();

            return View("~/Views/Main/AlunoMain.cshtml", alunoDTO);
        }

        [HttpPost]
        public IActionResult GetAllAlunos()
        {
            var requestFormData = Request.Form;

            var alunoDTO = _alunoRepository.GetAll();

            var listAlunoForm = newDataTable.AlunoDataProcessForm(alunoDTO, requestFormData);

            var count = alunoDTO.Count();

            dynamic response = new
            {
                Data = listAlunoForm,
                Draw = requestFormData["draw"],
                RecordsFiltered = count,
                RecordTotal = count,
            };

            return Ok(response);
        }

        // GET: Aluno/Create
        public ActionResult Create()
        {
            return View("~/Views/Register/AlunoRegister.cshtml");
        }

        // POST: Aluno/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create(IFormCollection collection)
        {
            try
            {
                var nomeArquivo = string.Empty;

                if (collection.Files.Count == 1)
                {
                    var caminhoArquivo = Path.GetTempFileName();
                    nomeArquivo = newGerador.GetFileName(collection["nomeCompleto"], collection.Files[0].ContentType.Split("/")[1]);
                    var filePath = Path.Combine(_hosting.WebRootPath, "img", "Recebido", "Perfil", "Aluno", nomeArquivo);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await collection.Files[0].CopyToAsync(stream);
                    }
                }
                else
                {
                    nomeArquivo = "img/Cadastro/Default_Image.png";
                }

                // Conta
                Domain.DTO.Conta contaDTO = new Domain.DTO.Conta();
                contaDTO.EmailConta = collection["email"];
                contaDTO.SenhaConta = collection["senha"];

                // Endereço
                Domain.DTO.Endereco enderecoDTO = new Domain.DTO.Endereco();
                enderecoDTO.CepEndereco = newGerador.EraseEspecialAndReturnInt(collection["cep"]);
                enderecoDTO.RuaEndereco = collection["rua"];
                enderecoDTO.BairroEndereco = collection["bairro"];
                enderecoDTO.NumeroEndereco = newGerador.EraseEspecialAndReturnInt(collection["numero"]);
                enderecoDTO.ComplementoEndereco = newGerador.EraseEspecialAndReturnInt(collection["complemento"]);

                // Aluno
                Domain.DTO.Aluno alunoDTO = new Domain.DTO.Aluno();
                alunoDTO.ContaAluno = contaDTO;
                alunoDTO.EnderecoAluno = enderecoDTO;
                alunoDTO.PermissaoAluno = 1;
                alunoDTO.MatriculaAluno = newGerador.GerarMatricula(collection["nomeCompleto"]);
                alunoDTO.NomeAluno = collection["nomeCompleto"];
                alunoDTO.CpfAluno = newGerador.EraseEspecialAndReturnLong(collection["cpf"]);
                alunoDTO.DataNascimentoAluno = DateTime.Parse(collection["dataNascimento"], new CultureInfo("pt-BR"));
                alunoDTO.TelefoneAluno = newGerador.EraseEspecialAndReturnLong(collection["telefone"]);
                alunoDTO.CelularAluno = newGerador.EraseEspecialAndReturnLong(collection["celular"]);
                alunoDTO.SexoAluno = newGerador.EraseEspecialAndReturnInt(collection["sexo"]);
                alunoDTO.ImagemAluno = "/img/Recebido/Perfil/Aluno/" + nomeArquivo;

                _alunoRepository.Incluid(alunoDTO);

                Created("Aluno/Create", alunoDTO);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View("~/Views/_GenericalExceptionView.cshtml", ex);
            }
        }

        // GET: Aluno/Edit/5
        public ActionResult Edit(long id)
        {
            var alunoDTO = _alunoRepository.GetbyId(id);

            return View("~/Views/Edit/AlunoEdit.cshtml", alunoDTO);
        }

        // POST: Aluno/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit(int id, IFormCollection collection)
        {
            try
            {
                // Aluno OLD
                var alunoDTOOld = _alunoRepository.GetbyId(id);

                // Conta
                Domain.DTO.Conta contaDTO = new Domain.DTO.Conta();
                contaDTO.EmailConta = collection["email"];
                contaDTO.SenhaConta = collection["senha"];

                // Endereço
                Domain.DTO.Endereco enderecoDTO = new Domain.DTO.Endereco();
                enderecoDTO.CepEndereco = newGerador.EraseEspecialAndReturnInt(collection["cep"]);
                enderecoDTO.RuaEndereco = collection["rua"];
                enderecoDTO.BairroEndereco = collection["bairro"];
                enderecoDTO.NumeroEndereco = newGerador.EraseEspecialAndReturnInt(collection["numero"]);
                enderecoDTO.ComplementoEndereco = newGerador.EraseEspecialAndReturnInt(collection["complemento"]);

                // Aluno
                Domain.DTO.Aluno alunoDTO = new Domain.DTO.Aluno();
                alunoDTO.ContaAluno = contaDTO;
                alunoDTO.EnderecoAluno = enderecoDTO;
                alunoDTO.MatriculaAluno = alunoDTOOld.MatriculaAluno;
                alunoDTO.NomeAluno = collection["nomeCompleto"];
                alunoDTO.CpfAluno = newGerador.EraseEspecialAndReturnLong(collection["cpf"]);
                alunoDTO.DataNascimentoAluno = DateTime.Parse(collection["dataNascimento"], new CultureInfo("pt-BR"));
                alunoDTO.TelefoneAluno = newGerador.EraseEspecialAndReturnLong(collection["telefone"]);
                alunoDTO.CelularAluno = newGerador.EraseEspecialAndReturnLong(collection["celular"]);
                alunoDTO.SexoAluno = newGerador.EraseEspecialAndReturnInt(collection["sexo"]);

                var nomeArquivo = string.Empty;

                if (collection.Files.Count == 1)
                {
                    var caminhoArquivo = Path.GetTempFileName();
                    nomeArquivo = newGerador.GetFileName(collection["nomeCompleto"], collection.Files[0].ContentType.Split("/")[1]);
                    var filePath = Path.Combine(_hosting.WebRootPath, "img", "Recebido", "Perfil", "Aluno", nomeArquivo);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        await collection.Files[0].CopyToAsync(stream);
                    }

                    var imgPath = Path.Combine(_hosting.WebRootPath, "img", "Recebido", "Perfil", "Aluno", alunoDTOOld.ImagemAluno);

                    try
                    {
                        System.IO.File.Delete(imgPath);
                    }
                    catch
                    {

                    }

                    alunoDTO.ImagemAluno = "/img/Recebido/Perfil/Aluno/" + nomeArquivo;
                }
                else if (alunoDTOOld.ImagemAluno.Length < 0)
                {
                    alunoDTO.ImagemAluno = "img/Cadastro/Default_Image.png"; ;
                }
                else
                {
                    alunoDTO.ImagemAluno = alunoDTOOld.ImagemAluno;
                }

                _alunoRepository.Update(alunoDTO);

                Created("Aluno/Edit", alunoDTO);

                return RedirectToAction(nameof(Index));
            }
            catch (Exception ex)
            {
                return View("~/Views/_GenericalExceptionView.cshtml", ex);
            }
        }

        // GET: Aluno/Delete/5
        public ActionResult Delete(long id)
        {
            var alunoDTO = _alunoRepository.GetbyId(id);
            var contaDTO = alunoDTO.ContaAluno;
            var enderecoDTO = alunoDTO.EnderecoAluno;

            var imgPath = Path.Combine(_hosting.WebRootPath, "img", "Recebido", "Perfil", "Aluno", alunoDTO.ImagemAluno);

            try
            {
                System.IO.File.Delete(imgPath);
            }
            catch
            {

            }

            _alunoRepository.Remove(alunoDTO);
            _contaRepository.Remove(contaDTO);
            _enderecoRepository.Remove(enderecoDTO);

            return View("~/Views/Main/AlunoMain.cshtml");
        }
    }
}