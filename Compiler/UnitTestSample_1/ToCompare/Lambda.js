enyo.kind({
    name: "UnitTestSample_1.Lambda",
    kind: "enyo.Object",

    m1 : function(){
        var func = function (x) {
            return x > 0;
        };
    },

    m2 : function(){
        var func = function (x) {
            return x > 0;
        };
    },

    m3 : function(){
        var func = function (x) {
            return x > 0;
        };
    },

    m4 : function(){
        var func = function (x) {
            x++;
        };
    },

    m5 : function(){
        var func = function (x, y) {
            x++;
            y++;
        };
    },

    d1 : function(){
        var f = function (x) {
            x++;
        };
    },

    d2 : function(){
        var f = function (x) {
            return x + 1;
        };
    },

    _X : function(func){
    },

    test1 : function(){
        this._X(function (x) {
            x++;
        });
    },

    test2 : function(){
        this._X(function (x) {
            x++;
            x = 0;
        });
    },

    test3 : function(){
        this._X(function (x) {
            x++;
        });
    },

    test4 : function(){
        this._X(function (x) {
            x++;
        });
    }
});
