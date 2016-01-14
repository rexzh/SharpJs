enyo.kind({
    name: "UnitTestSample_1.Loop",
    kind: "enyo.Object",

    arr1 : [1, 2, 3, 4, 5],
    arr2 : [1, 2, 3, 4, 5],
    forFunc : function(){
        for (var i = 0; i < this.arr1.length; i++) {
            this.arr1[i]++;
        }
    },

    forEachFunc : function(){
        for (var __idx$a = 0; __idx$a < this.arr2.length; __idx$a++) {
            var a = this.arr2[__idx$a];
            var b = a;
        }
    },

    continueBreakFunc : function(){
        var idx = -1;
        for (var i = 0; i < this.arr1.length; i++) {
            if ( this.arr1[i] > 0 ) {
                continue;
            } else {
                idx = i;
                break;
            }

        }
        return idx;
    },

    whileFunc : function(){
        var l = this.arr1.length;
        while (l > 0) {
            if ( this.arr1[l] < 0 ) {
                break;
            }

            l--;
        }
    },

    doWhileFunc : function(){
        var idx = 0;
        var count = 0;
        do {
            if ( this.arr2[idx] > 0 ) {
                count++;
            }

            idx++;
        } while (idx < this.arr2.length);
        return count;
    }
});
