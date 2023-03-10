﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mefit_backend.models;
using mefit_backend.models.domain;
using AutoMapper;
using mefit_backend.Service;
using mefit_backend.Services;
using mefit_backend.models.DTO;
using mefit_backend.Exceptions;

namespace mefit_backend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ImpairmentsController : ControllerBase
    {
        private readonly IImpairmentService _impairmentService;
        private readonly IMapper _mapper;

        public ImpairmentsController(IImpairmentService impairmentService, IMapper mapper)
        {
            _impairmentService = impairmentService;
            _mapper = mapper;
        }

        // GET: api/Impairments
        [HttpGet]
        public async Task<ActionResult<IEnumerable<GetImpairmentDTO>>> GetImpairments()
        {
            return Ok(_mapper.Map<IEnumerable<GetImpairmentDTO>>(await _impairmentService.GetImpairments()));
        }

        // GET: api/Impairments/5
        [HttpGet("{id}")]
        public async Task<ActionResult<GetImpairmentDTO>> GetImpairment(int id)
        {
            try
            {
                return Ok(_mapper.Map<GetImpairmentDTO>(await _impairmentService.GetImpairmentById(id)));
            }
            catch (ImpairmentNotFoundException ex)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = ex.Message
                });
            }
        }

        // PUT: api/Impairments/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutImpairment(int id, PutImpairmentDTO putImpairmentDTO)
        {
            Impairment impairment = _mapper.Map<Impairment>(putImpairmentDTO);

            if (id != impairment.Id)
            {
                return BadRequest();
            }

            try
            {
                await _impairmentService.UpdateImpairment(impairment);
            }
            catch (ImpairmentNotFoundException ex)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = ex.Message
                });
            }

            return NoContent();
        }

        // POST: api/Impairments
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Impairment>> PostImpairment(PostImpairmentDTO impairmentDTO)
        {
            var impairment = _mapper.Map<Impairment>(impairmentDTO);

            await _impairmentService.CreateImpairment(impairment);  

            return CreatedAtAction("GetImpairment", new { id = impairment.Id }, impairment);
        }

        // DELETE: api/Impairments/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteImpairment(int id)
        {
            try
            {
                await _impairmentService.DeleteImpairment(id);
            }
            catch (ImpairmentNotFoundException ex)
            {
                return NotFound(new ProblemDetails
                {
                    Detail = ex.Message
                });
            }

            return NoContent();
        }

        //private bool ImpairmentExists(int id)
        //{
        //    return _context.Impairments.Any(e => e.Id == id);
        //}
    }
}