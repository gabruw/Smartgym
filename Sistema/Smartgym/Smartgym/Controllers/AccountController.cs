﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Domain.Repository;
using Microsoft.AspNetCore.Mvc;

namespace Smartgym.Controllers
{
    public class AccountController : Controller
    {
        private readonly IContaRepository _contaRepository;
        private readonly IAlunoRepository _alunoRepository;
        private readonly IProfessorRepository _professorRepository;

        public AccountController(IContaRepository contaRepository, IAlunoRepository alunoRepository, IProfessorRepository professorRepository)
        {
            _contaRepository = contaRepository;
            _alunoRepository = alunoRepository;
            _professorRepository = professorRepository;
        }

        public IActionResult Login()
        {
            return View("~/Views/Account/Login.cshtml");
        }

        // POST: Account/CheckLogin
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CheckLogin(Models.Conta newConta)
        {
            Domain.DTO.Conta contaDTO = new Domain.DTO.Conta();
            contaDTO.EmailConta = newConta.EmailConta;
            contaDTO.SenhaConta = newConta.SenhaConta;

            var idConta = _contaRepository.Logar(contaDTO);

            var permissao = 0;

            if (idConta != 0)
            {
                if (idConta != -1)
                {
                    var alunoDTO = new Domain.DTO.Aluno();
                    var professorDTO = new Domain.DTO.Professor();

                    alunoDTO = _alunoRepository.GetbyId(idConta);

                    if(string.IsNullOrEmpty(alunoDTO.NomeAluno))
                    {
                        professorDTO = _professorRepository.GetbyId(idConta);

                        permissao = professorDTO.PermissaoProfessor;
                    }
                    else
                    {
                        permissao = alunoDTO.PermissaoAluno;
                    }
                }
                else
                {
                    ViewBag.Erro = "Senha incorreta.";
                    return View("~/Views/Account/Login.cshtml");
                }
            }
            else
            {
                ViewBag.Erro = "Email incorreto.";
                return View("~/Views/Account/Login.cshtml");
            }

            return View("~/Views/Home/Main.cshtml", permissao);
        }

        public IActionResult SemAutorizacao()
        {
            return View();
        }

        public IActionResult SemPermissao()
        {
            return View();
        }
    }
}