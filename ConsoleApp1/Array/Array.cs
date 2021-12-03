using System;
using System.Collections;
using System.Collections.Generic;

namespace ConsoleApp1.Array
{
    class Array<T>:IEnumerable,ICloneable
    {
        public int Count { get; private set; } //dışarıdan okunabilir sınıf içinde yazılır oalcak. 

        private T[] InnerList; //veri organizasyonu buradan yapılacak. 

        public int Capacity => InnerList.Length;//dizinin boyutunu sorgulayacaktır. değişecek olursa yeni dizi tanımlanacak ve yeni diziye atanackak. ///
        //bir nesne oluşturulduğu zaman otomatik olarak yapılandırıcı sınıfa sahip olması gerekir. hali hazırda bir

        public Array()
        {
            //geriye dönüşü olmayan bir tipi oluşturmuş oluruz.
            InnerList = new T[1288];
            Count = 0;
        

        }
        public void Add(T item) //ekleyeceğimz 
        {
            //T dizin türünden item ile atama yapabiliriz. 
            if(InnerList.Length==Count)
            {
                DoubleArray();
            }
            InnerList[Count] = item;
            Count++;
        }

        public void DoubleArray()
        { 
            //NASIL BİR algoritma yazabilirim?=

            var temp = new T[InnerList.Length * 2]; //elimizde 4 gözlü bir dizi yapısı olacaktır. bu şekilde iki katı artarak devam edecektir. 
            //bu temp üzerinde geçerlidir. 
            for (int i = 0; i < InnerList.Length; i++)
            {
               temp[i] = InnerList[i];        

            }// bu for döngüsü yerine. ;
           // System.Array.Copy(InnerList, temp, InnerList.Length); //kaynak, hedef, ne kadar kopyalama(kaç elemana bağlı ) inner list kadar diyoruz. 
            //InnerList = temp; //innerlist güncelledik. 

        }

        //DİZİNİ sonundaki elemanı silen eleman olacaktır. 
        public T Remove()
        {
            if(Count==0)
            {
                throw new Exception("There is no more item to be removed from the array.");//odak noktası olmamakla berabaer, bu söz konusu işlemleri görüp ona göre işlem yapılsın. 
            }
            if(InnerList.Length/4==Count)
            {
                HalfArray();
            }

            var temp = InnerList[Count - 1]; //ilk durumda 4 elemanlı bir yapı olsun. count =1 olursa; her ekleme de bir daha artar. silme yapacağım bir eksiğini bir öncesini dikkate almalıyım ki silebileyim. 
            if(Count>0)
            Count--;//count 1 eksilttik. 

            return temp;

        }

        public void HalfArray()
        {
            if (InnerList.Length>2)
            {
                var temp = new T[InnerList.Length / 2];
                System.Array.Copy(InnerList, temp, temp.Length/4);
                InnerList = temp; //inner list güncelledik. temp atadık. 
            }

        }

        public object Clone()
        {
            //bir kopyasını oluşturup istenen kişiye dönüş yapılabilinir. 
            //kopyalama yeteneği olabilir. countcapacity gibi özellikler olur 
            //biz burada colleciton yapısını 
            throw new NotImplementedException();
        }

        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
