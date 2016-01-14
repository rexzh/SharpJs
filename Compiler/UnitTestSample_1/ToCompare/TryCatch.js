enyo.kind({
    name: "UnitTestSample_1.TryCatch",
    kind: "enyo.Object",

    doSomething : function(){
        throw new Error("err");
    },

    doClean : function(){
    },

    doHandle : function(obj){
    },

    tC : function(){
        try {
            this.doSomething();
        } catch (e) {
            this.doHandle(e);
        }
    },

    tC1 : function(){
        try {
            this.doSomething();
        } catch (e) {
            this.doHandle(null);
        }
    },

    tF : function(){
        try {
            this.doSomething();
        } finally {
            this.doClean();
        }
    },

    tCF : function(){
        try {
            this.doSomething();
        } catch (e) {
            this.doHandle(e);
        } finally {
            this.doClean();
        }
    },

    multiCatch : function(){
        try {
            this.doSomething();
        } catch (e) {
            if (e.name == "EvalError") {
                this.doHandle(e);
            } else if (e.name == "RangeError") {
                this.doHandle(e);
            } else {
                this.doHandle(null);
            }
        } finally {
            this.doClean();
        }
    }
});
