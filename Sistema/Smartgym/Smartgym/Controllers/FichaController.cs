﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Auxiliary;
using Domain.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Smartgym.Controllers
{
    public class FichaController : Controller
    {
        private readonly IFichaRepository _fichaRepository;
        private readonly IExercicioRepository _exercicioRepository;
        private readonly ISerieRepository _serieRepository;
        private readonly IAlunoRepository _alunoRepository;
        private readonly IProfessorRepository _professorRepository;

        private Geradores newGerador = new Geradores();
        private DataTable newDataTable = new DataTable();

        public FichaController(IFichaRepository fichaRepository, IExercicioRepository exercicioRepository, ISerieRepository serieRepository, 
            IAlunoRepository alunoRepository, IProfessorRepository professorRepository)
        {
            _fichaRepository = fichaRepository;
            _exercicioRepository = exercicioRepository;
            _serieRepository = serieRepository;
            _alunoRepository = alunoRepository;
            _professorRepository = professorRepository;
        }

        // GET: Ficha
        public ActionResult Index()
        {
            return View("~/Views/Main/FichaMain.cshtml");
        }

        [HttpPost]
        public IActionResult GetAllFichas()
        {
            var requestFormData = Request.Form;

            var fichaDTO = _fichaRepository.GetAll();

            var listFichaForm = newDataTable.FichaDataProcessForm(fichaDTO, requestFormData);

            var count = fichaDTO.Count();

            dynamic response = new
            {
                Data = listFichaForm,
                Draw = requestFormData["draw"],
                RecordsFiltered = count,
                RecordTotal = count,
            };

            return Ok(response);
        }

        // GET: Ficha/Create
        public ActionResult Create()
        {
            return View("~/Views/Register/FichaRegister.cshtml");
        }

        // POST: Ficha/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                var idAluno = Int64.Parse(collection["idAluno"]);
                var idProfessor = Int64.Parse(collection["idProfessor"]);

                if(idAluno > 1 || idProfessor > 1)
                {
                    // Ficha
                    Domain.DTO.Ficha fichaDTO = new Domain.DTO.Ficha();
                    fichaDTO.IdAlunoFicha = idAluno;
                    fichaDTO.IdProfessorFicha = idProfessor;

                    var fichaReturn = _fichaRepository.IncluidAndReturnId(fichaDTO);

                    // Série
                    Domain.DTO.Serie serieDTO = new Domain.DTO.Serie();
                    serieDTO.IdFichaSerie = fichaReturn.IdFicha;
                    serieDTO.NomeSerie = collection["nomeSerie"];
                }
               




                List<Domain.DTO.Exercicio> exercicios = new List<Domain.DTO.Exercicio>();

                foreach(var exercicio in collection){
                    Domain.DTO.Exercicio exercicioDTO = new Domain.DTO.Exercicio();
                    exercicioDTO.NomeExercicio = collection["nomeExercicio"];
                    exercicioDTO.ObservacaoExercicio = collection["observacaoExercicio"];

                    exercicios.Add(exercicioDTO);
                }
                

               

                

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: Ficha/Edit/5
        public ActionResult Edit(long id)
        {
            var fichaDTO = _fichaRepository.GetbyId(id);

            return View("~/Views/Edit/FichaEdit.cshtml", fichaDTO);
        }

        // POST: Ficha/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(long id, IFormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // POST: Ficha/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(long id, IFormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}