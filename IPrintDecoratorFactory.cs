using System;
public class IPrintDecoratorFactory {
    public IPrintDecoratorFactory() {
    }
    public String getIPrinterDecorator(String [] whatFormat) {

       Console.WriteLine(whatFormat);
       int error = 0;

       for(int i=1;i<whatFormat.Length;i++){
           switch(whatFormat[i]){
               case "csv":
               Console.WriteLine("Se econtro formato csv");
               IPrint csv = new CsvIPrintDecorator(new TextoPlano());
               csv.print(whatFormat);
               error = 1;
               break;
               case "json":
               Console.WriteLine("Se econtro formato json");
               IPrint json = new JsonPrintDecorator(new TextoPlano());
               json.print(whatFormat);
               error = 1;
               break;
               case "xml":
               Console.WriteLine("Se econtro formato xml");
               IPrint xml = new XmlPrintDecorator(new TextoPlano());
               xml.print(whatFormat);
               error = 1;
               break;
               case "html":
               Console.WriteLine("Se econtro formato html");
               IPrint html = new HtmlPrintDecorator(new TextoPlano());
               html.print(whatFormat);
               error = 1;
               break;
               default:
               error = 0;
               break;
           }
       }
       if(error==0){
           Console.WriteLine("No se ha encontrado el formato especificado");
       }
    return "";
    }
}