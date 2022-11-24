// Console.WriteLine("Задача: \n  Написать программу, которая из имеющегося массива строк \n" +  
//                    "формирует новый массив из строк, длина которых меньше, либо равна 3 символам.");

// Console.WriteLine("");

// string [] FillingStringArray (string sizeArray)
// {
    
//      int convertSizeArray = Convert.ToInt32(sizeArray);
      
//      string [] stringArray = new string [convertSizeArray];

//        for (int i=0; i < convertSizeArray ; i++)
//        {
        
//            Console.Write("Введите слово ");
           
//            stringArray[i] = Convert.ToString(Console.ReadLine());
        
//        }
     
//           return stringArray;
    
// }

// void ShowStringArray(string[] stringArray)
//      {
//         int count=0;

//         for(int i=0; i < stringArray.Length ; i++)
//         {  
//             if (stringArray[i].Length <= 3)
//                  {                  
//                   Console.Write(stringArray[i] + "; ");                  
//                   count++;
//                  }   

//        }         

//             if (count == 0)
//             {
//                 Console.Write("в массиве нет строк, чья длина был бы меньше или равна трём символам");                  
//             }        

// }

// Console.Write("Введите размер массива ");
// Console.Write("");
// string sizeArray = Convert.ToString(Console.ReadLine());
// string [] fillingArray =  FillingStringArray (sizeArray);
// Console.Write("[ ");
// ShowStringArray(fillingArray);
// Console.Write("]");