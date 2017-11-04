
//
//
//

using System;
using System.Xml;


namespace XmlDemo {


public
class
XmlTools {

    bool            bStatus;

    XmlDocument     xdDoc;
    XmlNodeList     xnlNodeList;


public
XmlTools () {

    bStatus = true;

    xdDoc = new XmlDocument();

    if ( xdDoc == null )    {
        bStatus = false;
    }
    //  ================
}

 
public
void
Load ( String sInFilePathToXmlDoc ) {

    if ( Error() )
        return;    XmlNodeList myList = xdDoc.GetElementsByTagName("account");

    xdDoc.Load( sInFilePathToXmlDoc);
    return;
}


public
String
Lookup ( String sInXPath ) {

    XmlNode xnNode;
    if ( Error() )
        return "";

    xnNode = xdDoc.SelectSingleNode(sInXPath);

    if (xnNode == null) {
        bStatus = false;
        return "";
    }

    return xnNode.InnerText;
    //  ====================
}


public
bool
Normal()   {

    if ( bStatus == true )  {
        return true;
    }
    return false;
}   //===========


public
bool
Error()   {

    if ( bStatus == false )  {
        return true;
    }
    return false;
}   //===========





public
void
ListResearch()   {

    /*
    foreach (XmlNode node in companyList)
    {
        XmlElement companyElement = (XmlElement)node;

        IE = companyElement.GetElementsByTagName("IE")[0].InnerText;
        FF = companyElement.GetElementsByTagName("FF")[0].InnerText;
        GC = companyElement.GetElementsByTagName("CH")[0].InnerText;
        OP = companyElement.GetElementsByTagName("OP")[0].InnerText;
        xmlCompanyID = companyElement.Attributes["ID"].InnerText;
    }
    */
    
    XmlNodeList xnlNodeList = xdDoc.GetElementsByTagName("account");

    foreach (XmlNode xnNode in xnlNodeList)
    {
        XmlElement e = (XmlElement)xnNode;

        Console.WriteLine( "acct-id  = " + e.GetElementsByTagName("account-id")[0].InnerText    );
        Console.WriteLine( "cdi      = " + e.GetElementsByTagName("cdi")[0].InnerText           );
    }
}









}   //  end of xmlTools class


}   //  end of xmlTools namespace
