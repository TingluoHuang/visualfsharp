// #Regression #Conformance #DataExpressions 
// Verify that nameof doesn't work on const string
//<Expects id="FS3215" span="(5,9)" status="error">This expression does not have a name.</Expects>

let x = nameof(1+2)

exit 0