
//
//
//

using System;


namespace XmlDemo {


public
class
LogTools {

    bool            bStatus;


public
LogTools () {

    bStatus = true;

    //  ================
}

 
public
bool
Log ( String sInMsg ) {

    System.Console.WriteLine( sInMsg );
    return true;
}




}   //  end of xmlTools class


}   //  end of xmlTools namespace
