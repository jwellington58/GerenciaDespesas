﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TesteMobills.Models;
using TesteMobills.Services;

namespace TesteMobills.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DespesasController : ControllerBase
    {
        public DespesaService _service;
        public DespesasController(Context context)
        {
            _service = new DespesaService(context);
        }


        [HttpGet]
        public IQueryable<Despesa> GetAll()
        {
            return _service.GetAll();
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var entity = _service.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            return Ok(entity);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Despesa entity)
        {

            if (entity == null)
            {
                return BadRequest("A entidade não pode ser null");
            }
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            return Ok(_service.Create(entity));
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, [FromBody] Despesa entity)
        {
            if (entity == null)
            {
                return BadRequest();
            }
            _service.Update(entity, id);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var entity = _service.GetById(id);
            if (entity == null)
            {
                return NotFound();
            }
            _service.Delete(id);
            return Ok();
        }
        [HttpGet("soma")]
        public IActionResult Soma()
        {
            return Ok(this._service.Somatorio());
        }
    }
}
