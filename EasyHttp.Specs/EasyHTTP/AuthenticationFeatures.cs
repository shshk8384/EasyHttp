﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Machine.Specifications;

namespace EasyHttp.Specs.EasyHTTP
{

    [Subject("Authentication")]
    public class when_performing_a_get_that_requires_authentication_with_valid_data
    {
        Establish context = () =>
        {
            easyHttp = new EasyHttp();
        };

        Because of = () =>
        {
            _httpResponse = easyHttp.WithBasicAuthentication("iis_test_user", "logitech100!!!")
                .Get("http://localhost/testsite");

        };

        It should_process_the_request_correctly = () =>
        {
            
        };

        static EasyHttp easyHttp;
        static HttpResponse _httpResponse;
    }

  
}