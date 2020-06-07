
using System;
using System.IO;

public class JsonPrintDecorator : IPrintDecorator {

    public JsonPrintDecorator(IPrint print):base(print) {
    }
    public override void print(string[] archivo){
        Console.WriteLine("\tCONVIRTIENDO");
        base.print(archivo);
        Console.WriteLine("\tA ARCHIVO JSON");
        for(int i=1;i<archivo.Length;i++){
            printJson(archivo[i]);
        }        
    }
    public void printJson(String archivo){
        String fichero = archivo;
        String contenido = String.Empty;
            if (File.Exists(fichero))
            {
                contenido = File.ReadAllText(fichero);
                string[] lineas = contenido.Split(Environment.NewLine);
                foreach (string linea in lineas)
                {
                    String str = linea;
                    Console.WriteLine("{ \"cadena\":\""+linea+"\" }");
            }
        }
    }

}