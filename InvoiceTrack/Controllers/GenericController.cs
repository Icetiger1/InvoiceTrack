using InvoiceTrack.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace InvoiceTrack.Controllers
{
    public abstract class GenericController<T> : Controller
    where T : class
    {
        protected static DataContext _dataSource;

        public GenericController(DataContext dataContext)
        {
            _dataSource = dataContext;
        }

        public virtual async Task<IActionResult> Index()
        {
            var model = await _dataSource.Set<T>().ToListAsync();
            return View(model);
        }

        [HttpGet]
        public virtual async Task<IActionResult> GetAll()
        {
            var model = await _dataSource.Set<T>().FindAsync();
            return View(model);
        }

        [HttpGet]
        public virtual async Task<IActionResult> Get(int id)
        {
            var model = _dataSource.Set<T>().FindAsync(id);
            return View(model);
        }

        [HttpPost]
        public virtual async Task<IActionResult> Create(T item)
        {
            await _dataSource.Set<T>().AddAsync(item);

            return RedirectToAction("Index");
        }

        [HttpPut]
        public virtual async Task<IActionResult> Edit(int id)
        {
            if (id != null)
            {
                T item = await _dataSource.Set<T>().FindAsync(id);
                if (item != null)
                {
                    _dataSource.Set<T>().Update(item);
                    await _dataSource.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }

        [HttpDelete("{id}")]
        public virtual async Task<IActionResult> Delete(int id)
        {
            if (id != null)
            {
                T? item = await _dataSource.Set<T>().FindAsync(id);
                if (item != null)
                {
                    _dataSource.Set<T>().Remove(item);
                    await _dataSource.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}
