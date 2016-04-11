
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

/**
 * 
 */
public interface MusicPlayer {

    /**
     * @return
     */
    public Instrument getInstrument();

    /**
     * @param instrument 
     * @return
     */
    public void setInstrument(Instrument instrument);

    /**
     * @return
     */
    public void play();

}