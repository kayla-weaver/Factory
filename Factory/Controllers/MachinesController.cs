using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Factory.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;

namespace Factory 
{
  public class MachinesController : Controller 
  {
    private readonly FactoryContext _db;
    public MachinesController(FactoryContext db)
    {
      _db = db;
    }
  }
}