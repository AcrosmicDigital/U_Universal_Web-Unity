using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;
using U.Universal.Web;

public class UnityFetch_Test
{

    [Test]
    public async void SimpleFetchSimplePasses()
    {

        var response = await UnityFetch.Fetch("http://www.google.com");
        var body = await response.Text();

        Debug.Log("R: " + body);

    }

}



