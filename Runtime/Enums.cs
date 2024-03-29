﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine;

namespace U.Universal.Web
{
    
    public enum HttpVerb
    {
        GET,
        POST,
        PUT,
        DELETE,
    }

    public enum HttpStatusCode
    {
        Accepted = 202,
        AlreadyReported = 208,
        Ambiguous = 300,
        BadGateway = 502,
        BadRequest = 400,
        Conflict = 409,
        Continue = 100,
        Created = 201,
        EarlyHints = 103,
        ExpectationFailed = 417,
        FailedDependency = 424,
        Forbidden = 403,
        Found = 302,
        GatewayTimeout = 504,
        Gone = 410,
        HttpVersionNotSupported = 505,
        IMUsed = 226,
        InsufficientStorage = 507,
        InternalServerError = 500,
        LengthRequired = 411,
        Locked = 423,
        LoopDetected = 508,
        MethodNotAllowed = 405,
        MisdirectedRequest = 421,
        Moved = 301,
        MovedPermanently = 301,
        MultipleChoices = 300,
        MultiStatus = 207,
        NetworkAuthenticationRequired = 511,
        NoContent = 204,
        NonAuthoritativeInformation = 203,
        NotAcceptable = 406,
        NotExtended = 510,
        NotFound = 404,
        NotImplemented = 501,
        NotModified = 304,
        OK = 200,
        PartialContent = 206,
        PaymentRequired = 402,
        PermanentRedirect = 308,
        PreconditionFailed = 412,
        PreconditionRequired = 428,
        Processing = 102,
        ProxyAuthenticationRequired = 407,
        Redirect = 302,
        RedirectKeepVerb = 307,
        RedirectMethod = 303,
        RequestedRangeNotSatisfiable = 416,
        RequestEntityTooLarge = 413,
        RequestHeaderFieldsTooLarge = 431,
        RequestTimeout = 408,
        RequestUriTooLong = 414,
        ResetContent = 205,
        SeeOther = 303,
        ServiceUnavailable = 503,
        SwitchingProtocols = 101,
        TemporaryRedirect = 307,
        TooManyRequests = 429,
        Unauthorized = 401,
        UnavailableForLegalReasons = 451,
        UnprocessableEntity = 422,
        UnsupportedMediaType = 415,
        Unused = 306,
        UpgradeRequired = 426,
        UseProxy = 305,
        VariantAlsoNegotiates = 506,
    }

}
