enyo.kind({
    name: "UnitTestSample_1.NormalClass1",
    kind: "enyo.Object",

    _x : 0,
    reset : function(){
        this._x = 0;
    },

    add : function(y){
        return this._x + y;
    }
});