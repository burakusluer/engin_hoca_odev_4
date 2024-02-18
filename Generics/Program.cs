MyList<string> sehirler2 = new MyList<string>();
sehirler2.Add("selam");
sehirler2.Add("selam0");
sehirler2.Add("selam1");
sehirler2.Add("selam2");
sehirler2.Add("selam3");
sehirler2.Add("selam4");
sehirler2.Add("selam5");
foreach (string sehir in sehirler2)
{
    Console.WriteLine(sehir);
}
/// <summary>
/// List like custom design
/// </summary>
/// <typeparam name="T">its a generic type for class array</typeparam>
class MyList<T>
{
    #region MyCode
    //private T[] dizi;
    //public MyList()
    //{
    //    this.dizi = new T[0];
    //}
    //public void Add(T item)
    //{

    //    T[] dizi2 = new T[dizi.Length];
    //    for (int i = 0; i < dizi.Length; i++)
    //    {
    //        dizi2[i] = dizi[i];
    //    }
    //    dizi[dizi.Length - 1] = item;

    //}

    //public int Count() { return dizi.Length; }


    #endregion

    T[] _array;
    T[] _tempArray;
    public MyList()
    {
        _array = new T[0];
    }

    public void Add(T item)
    {
        _tempArray = _array;
        _array = new T[_tempArray.Length + 1];
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length - 1] = item;
    }

    public T[] getListArray()
    {
        return _array;
    }

    //hoca indexerlardan bahsediyor
    public T this[int index]
    {
        get { return _array[index]; }
        set { _array[index] = value; }
    }
    //işlevsel
    //IEnumerable ile direkt olarak foreach idiom patterne çevirilebiliyor
    public int Count() { return _array.Length; }

}