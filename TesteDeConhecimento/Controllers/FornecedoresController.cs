using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using TesteDeConhecimento.Models.Context;
using TesteDeConhecimento.Models.Entities;

namespace TesteDeConhecimento.Controllers
{
    [EnableCors(origins: "http://localhost:3000", headers: "*", methods: "*")]
    public class FornecedoresController : ApiController
    {
        private TesteDeConhecimentoContext db = new TesteDeConhecimentoContext();

        // insert
        public IHttpActionResult PostFornecedor(Fornecedor fornecedor)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState); // 400

            db.Fornecedores.Add(fornecedor);
            db.SaveChanges();

            return CreatedAtRoute("DefaultApi", new { id = fornecedor.Id }, fornecedor); // 201
        }

        // selecão
        public IHttpActionResult GetFornecedor(int id)
        {
            if (id <= 0)
                return BadRequest("O id deve ser um número maior que zero");

            var fornecedor = db.Fornecedores.Find(id);

            if (fornecedor == null)
                return NotFound();

            return Ok(fornecedor);
        }

        // alteração
        public IHttpActionResult PutFornecedor(int id, Fornecedor fornecedor)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState); // 400

            if (id != fornecedor.Id)
                return BadRequest("O id informado na url é diferente do id informado no corpo da requisição");

            if (db.Fornecedores.Count(f => f.Id == id) == 0)
                return NotFound();

            db.Entry(fornecedor).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent);
        }

        // exclusão
        public IHttpActionResult DeleteFornecedor(int id)
        {
            if (id <= 0)
                return BadRequest("O id deve ser um número maior que zero");

            var fornecedor = db.Fornecedores.Find(id);

            if (fornecedor == null)
                return NotFound();

            db.Fornecedores.Remove(fornecedor);
            db.SaveChanges();

            return StatusCode(HttpStatusCode.NoContent); // 204
        } 

        // listagem
        public IHttpActionResult GetFornecedores()
        {
            var fornecedores = db.Fornecedores.OrderBy(f => f.DataDeInclusao);

            return Ok(fornecedores); // 200
        }

    }
}
