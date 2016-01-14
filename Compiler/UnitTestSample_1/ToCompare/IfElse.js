enyo.kind({
    name: "UnitTestSample_1.IfElse",
    kind: "enyo.Object",

    test : function(x){
        if ( x < 0 ) {
            return -1;
        } else {
            if ( x > 0 ) {
                return 1;
            }
        }

        return 0;
    },

    stringTest : function(s){
        if ( s != null ) {
            return false;
        } else {
            return true;
        }

    },

    hasData : function(x){
        if ( x == 0 ) {
            return false;
        }

        return true;
    }
});
