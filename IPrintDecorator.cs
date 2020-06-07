
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public abstract class IPrintDecorator : IPrint {

    private IPrint printDecorator;
    public IPrintDecorator(IPrint print) {
        this.printDecorator = print;
    }

    public virtual void print(String[] archivo)
    {
        printDecorator.print(archivo);
    }
}