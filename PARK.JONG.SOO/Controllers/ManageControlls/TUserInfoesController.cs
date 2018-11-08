using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using PARK.JONG.SOO.Data;
using PARK.JONG.SOO.Models.ManageViewModel;

namespace PARK.JONG.SOO.Controllers.ManageControlls
{
    public class TUserInfoesController : Controller
    {
        private readonly ApplicationDbContext _context;

        public TUserInfoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: TUserInfoes
        public async Task<IActionResult> Index()
        {
            return View(await _context.TUserInfo.ToListAsync());
        }

        // GET: TUserInfoes/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUserInfo = await _context.TUserInfo
                .FirstOrDefaultAsync(m => m.Bunho == id);
            if (tUserInfo == null)
            {
                return NotFound();
            }

            return View(tUserInfo);
        }

        // GET: TUserInfoes/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: TUserInfoes/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Bunho,UserName,Password,ConfirmPassword,OrgCd,AssignedIp,Email,Telephone,Mobilephone,UserType,UserAuth,DutyType,MenuAuth,LoginYn,LockYn,LastLoginDt,CreateUserId,CreateDt,UpdateUserId,UpdateDt,SortOrder,PwdchangeYn,JikgupName,DutytypeName")] TUserInfo tUserInfo)
        {
            if (ModelState.IsValid)
            {
                _context.Add(tUserInfo);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tUserInfo);
        }

        // GET: TUserInfoes/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUserInfo = await _context.TUserInfo.FindAsync(id);
            if (tUserInfo == null)
            {
                return NotFound();
            }
            return View(tUserInfo);
        }

        // POST: TUserInfoes/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Bunho,UserName,Password,ConfirmPassword,OrgCd,AssignedIp,Email,Telephone,Mobilephone,UserType,UserAuth,DutyType,MenuAuth,LoginYn,LockYn,LastLoginDt,CreateUserId,CreateDt,UpdateUserId,UpdateDt,SortOrder,PwdchangeYn,JikgupName,DutytypeName")] TUserInfo tUserInfo)
        {
            if (id != tUserInfo.Bunho)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(tUserInfo);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!TUserInfoExists(tUserInfo.Bunho))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(tUserInfo);
        }

        // GET: TUserInfoes/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var tUserInfo = await _context.TUserInfo
                .FirstOrDefaultAsync(m => m.Bunho == id);
            if (tUserInfo == null)
            {
                return NotFound();
            }

            return View(tUserInfo);
        }

        // POST: TUserInfoes/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            var tUserInfo = await _context.TUserInfo.FindAsync(id);
            _context.TUserInfo.Remove(tUserInfo);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool TUserInfoExists(string id)
        {
            return _context.TUserInfo.Any(e => e.Bunho == id);
        }
    }
}
