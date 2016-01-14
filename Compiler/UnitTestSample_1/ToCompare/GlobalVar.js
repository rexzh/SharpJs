enyo.kind({
    name: "UnitTestSample_1.GlobalVar",
    kind: "enyo.Object",

    step1 : function(){
        x = 10;
    },

    step2 : function(){
        x++;
    },

    do : function(){
        this.step1();
        this.step2();
    }
});
