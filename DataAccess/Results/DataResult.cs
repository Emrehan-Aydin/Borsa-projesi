using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Utilities.Results
{
    // Generic Referans Sistem çıktıları ve veri yolu sınıfı
    public class DataResult<T>:Result,IDataResult<T>
    {
        // veri ataması Constructor 
        public DataResult(T data , bool success,string message):base(success,message)
        {
            Data = data;
        }
        // veri ataması 2. Constructor 
        public DataResult(T data,bool success):base(success)
        {
            Data = data;
        }
        // Generic Type Data
        public T Data { get; }
    }
}
