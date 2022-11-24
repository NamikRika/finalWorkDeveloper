string [] FillingStringArray (string sizeArray)
{
    string userText = "";
     int convertSizeArray = Convert.ToInt32(sizeArray);
      
     string [] stringArray = new string [convertSizeArray];

       for (int i=0; i < convertSizeArray ; i++)
       {
        
           Console.Write("Введите слово ");
           userText =  Convert.ToString(Console.ReadLine());
           stringArray[i] = userText;
        
       }
     
          return stringArray;
    
}

void ShowStringArray(string[] stringArray)
     {
        for(int i=0; i < stringArray.Length ; i++)
       {
          Console.Write(stringArray[i]);
       }

}


Console.Write("Введите размер массива ");
string sizeArray = Convert.ToString(Console.ReadLine());
// FillingStringArray(sizeArray);
string [] fillingArray =  FillingStringArray (sizeArray);
ShowStringArray(fillingArray);