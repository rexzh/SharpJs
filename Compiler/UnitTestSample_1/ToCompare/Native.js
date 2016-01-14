enyo.kind({
    name: "UnitTestSample_1.Native",
    kind: "enyo.Object",

    complex : function(){
        //**Js Native code start
        
            var x = eval("5 + 6");
            var y = x;
            
        //**Js Native code end
    }
});