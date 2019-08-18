using Proiect_DAW.Models;
using System;
using System.Collections.Generic;
using System.Linq;

public class UnitOfWork : IDisposable
{
    public DatabaseEntities entities = null;
    public UnitOfWork()
    {
        entities = new DatabaseEntities();
    }

    // add all the repository handles here
    List<Books> mbooks = null;

    // add all the repository getters here
    public List<Books> booklist
    {
        get
        {
            if (mbooks == null)
            {
                mbooks = entities.Books.ToList();
            }
            return mbooks;
        }
    }



    public void SaveChanges()
    {
        entities.SaveChanges();
    }


    private bool disposed = false;

    protected virtual void Dispose(bool disposing)
    {
        if (!this.disposed)
        {
            if (disposing)
            {
                entities.Dispose();
            }
        }
        this.disposed = true;
    }

    public void Dispose()
    {
        Dispose(true);
        GC.SuppressFinalize(this);
    }

}