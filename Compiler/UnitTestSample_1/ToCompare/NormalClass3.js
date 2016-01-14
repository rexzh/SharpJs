enyo.kind({
    name: "UnitTestSample_1.NormalClass3",
    kind: "enyo.Object",

    _counter : 0,
    increaseBy : function(x){
        this._counter += x;
    },

    increase : function(){
        this._counter++;
    },

    reset : function(){
        this._counter = 0;
    }
});
