
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

public class XmlPrintDecorator : IPrintDecorator {

    public XmlPrintDecorator(IPrint print):base(print) {
        
    }

    public override void print(string[] archivo){
        Console.WriteLine("\tCONVIRTIENDO");
        base.print(archivo);
        Console.WriteLine("\tA ARCHIVO XML");
        for(int i=1;i<archivo.Length;i++){
            printXML(archivo[i]);
        }
    }

    public void printXML(String archivo){
        String fichero = archivo;
        String contenido = String.Empty;
            if (File.Exists(fichero))
            {
                contenido = File.ReadAllText(fichero);
                string[] lineas = contenido.Split(Environment.NewLine);
                foreach (string linea in lineas)
                {
                    String str = linea;
                    Console.WriteLine("?xml version='1.0' encoding= 'utf-8' standalone= 'yes'");
                    Console.WriteLine("<!-- cadena>");
                    Console.WriteLine("<TipoDatos>");
                    Console.WriteLine("     <TipoDato Numero = '01'>");
                    Console.WriteLine("         <Descripcion>"+linea+"</Descripcion>");
                    Console.WriteLine("     </TipoDato>");
                    Console.WriteLine("</TipoDato>\n");
            }
        }
    }

}