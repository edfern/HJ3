
using System;
using System.IO;

public class CsvIPrintDecorator : IPrintDecorator {

   public CsvIPrintDecorator(IPrint decorator): base(decorator){

   }

    public override void print(String[] archivo){
        Console.WriteLine("\tCONVIRTIENDO");
        base.print(archivo);
        Console.WriteLine("\tA ARCHIVO CSV");
        for(int i=1; i<archivo.Length;i++){
            printCSV(archivo[i]);
        }
        
   }

    public void printCSV(String archivo) {
    String fichero = archivo;
    String contenido = String.Empty;

    if (File.Exists(fichero))
    {
        contenido = File.ReadAllText(fichero);
        string[] lineas = contenido.Split(Environment.NewLine);
        foreach (string linea in lineas)
        {
            String str = linea;
            Console.WriteLine("{0}",str.Replace(' ',','));
        }
    }
    }

}