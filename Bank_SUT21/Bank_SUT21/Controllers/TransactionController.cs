using Bank_SUT21.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Bank_SUT21.Controllers
{
    public class TransactionController : Controller
    {
        private readonly TransactionDbContext _context;

        public TransactionController(TransactionDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            return View(await _context.Transcations.ToArrayAsync());
        }

        //Read Transaction/AddOrEdit

        public IActionResult CreateOrUpdate(int id)
        {
            if (id == 0)
            {
                return View(new Transaction());
            }
            else
            {
                return View(_context.Transcations.Find(id));
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateOrUpdate([Bind("TranscationID, AccoutnNumber, HolderName, BankName, SWIFTCode, Amount, Date")] Transaction transaction)
        {
            if (ModelState.IsValid)
            {
                if (transaction.TransationID == 0)
                {
                    transaction.Date = DateTime.Now;
                    _context.Add(transaction);
                }
                else
                {
                    _context.Update(transaction);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            return View(transaction);
        }

        //Post : Transaction/Delete

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            //var transactionToDelete = _context.Transcations.FindAsync(id);
            //_context.Transcations.Remove(transactionToDelete);
            //await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}