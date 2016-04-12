
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public class Operation {

    /**
     * 
     */
    public Operation() {
    }

    /**
     * 
     */
    private double numberA;

    public double NumberA
    {
        get { return numberA; }
        set { numberA = value; }
    }

    /**
     * 
     */
    private double numberB;

    public double NumberB
    {
        get { return numberB; }
        set { numberB = value; }
    }

    /**
     * @return
     */
    public virtual double GetResult() {
        // TODO implement here
        return 0.0D;
    }

}