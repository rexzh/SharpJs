enyo.kind({
    name: "UnitTestSample_1.Switch",
    kind: "enyo.Object",

    test : function(x){
        var r = 0;
        switch (x) {
            case 0:
                x++;
                break;
            case 1:
                x += 2;
                break;
            case 2:
                x--;
                return -1;
            case 3:
                throw new Error();
            case 4:
                r = 100;
                break;
            default:
                x *= 2;
                break;
        }

        return r;
    }
});
