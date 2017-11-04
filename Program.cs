
//
//
//

using System;
using System.Xml;

using XmlDemo;



namespace Main {


class XMlDemo {



static
void
Main(string[] args) {

    XmlTools    xtDoc   = new XmlTools();
    LogTools    log     = new LogTools();

    xtDoc.Load("tdResult.xml");


    //  login call status
    //  =================


    log.Log( "result   = " +  xtDoc.Lookup( "//amtd/result" )                               );
    log.Log( "user-id  = " +  xtDoc.Lookup( "//amtd/xml-log-in/user-id")     )              ;
    log.Log( "xchange  = " +  xtDoc.Lookup( "//amtd/xml-log-in/authorizations/options360")  );
    log.Log( "acct-id  = " +  xtDoc.Lookup("//amtd/xml-log-in/accounts/account/account-id") );
    log.Log( "acct-id  = " +  xtDoc.Lookup("//amtd/xml-log-in/accounts/account/account-id") );
    log.Log( "xchstat  = " +  xtDoc.Lookup("//amtd/xml-log-in/exchange-status")             );

    xtDoc.ListResearch();








    Console.ReadKey();
    return;

}   //  end of Main()

    
    
}   //  end of MainClass

}   //  end of namespace

