using System;
using System.Collections.Generic;
using System.Linq;
using cell.Data.Context;
using cell.Models;

namespace cell.Repository.Implementations
{
    public class CellRepositoryImplemetation : ICellRepository
    {
        private MySQLContext context;

        public CellRepositoryImplemetation(MySQLContext context) 
        {
            this.context = context;
        }

        public Cell FindById(long id)
        {
            return this.context.Cells.SingleOrDefault(p =>p.Id.Equals(id));
        }

        public List<Cell> FindAll()
        {
            return this.context.Cells.ToList();
        }

        public Cell Create(Cell cell)
        {
            try 
            {
                this.context.Add(cell);
                this.context.SaveChanges();
            } 
            catch(Exception) 
            {
                throw;
            }
            return cell;
        }

        public Cell Update(Cell cell)
        {
            if(!Exists(cell.Id))
            {
                return new Cell();
            }

            var result = this.context.Cells.SingleOrDefault(p =>p.Id.Equals(cell.Id));
            if(result != null){
                try 
                {
                    this.context.Entry(result).CurrentValues.SetValues(cell);
                    this.context.SaveChanges();
                } 
                catch(Exception) 
                {
                    throw;
                }
            }
            return cell;
        }

        public void Delete(long id)
        {
            var result = this.context.Cells.SingleOrDefault(p =>p.Id.Equals(id));
            if(result != null)
            {
                try 
                {
                    this.context.Cells.Remove(result);
                    this.context.SaveChanges();
                } 
                catch(Exception) 
                {
                    throw;
                }
            }

        }                
        public  bool Exists(long id) {
            return this.context.Cells.Any(p =>p.Id.Equals(id));
        }

    }
}
