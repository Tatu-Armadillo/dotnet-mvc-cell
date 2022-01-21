using cell.Models;
using System.Collections.Generic;

namespace cell.Repository
{
    public interface ICellRepository
    {
        Cell Create(Cell cell);
        Cell FindById(long id);
        List<Cell> FindAll();
        Cell Update(Cell cell);  
        void Delete(long id);
        bool Exists(long id);


    }
}
