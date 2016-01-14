enyo.kind({
    name: "UnitTestSample_1.Operators",
    kind: "enyo.Object",

    unary : function(){
        var x = 0;
        var y = -x;
        var z = +x;
        var u = x++;
        var v = ++x;
        --x;
        x--;
        var a = ~x;
    },

    binary : function(){
        var x = 0, y = 5;
        var z = x + y;
        var u = x - y;
        var w = x * y;
        var v = x / y;
        var m = x % y;
        z += 5;
        z *= 5;
        z -= 5;
        z /= 5;
        z %= 5;
    },

    bit : function(){
        var x = 0, y = 1, z = 5;
        z = x >> 1;
        z = y << 1;
        var a = 0, b = 0;
        var c = a & b;
        c = a | b;
        c = a ^ b;
        b = ~a;
        a ^= b;
    },

    logic : function(){
        var b1 = true, b2 = false;
        var b = b1 && b2;
        b = b1 || b2;
        b = b1 ^ b2;
        b = !b1;
        var x = 0, y = 10;
        b = x > y;
        b = x >= y;
        b = x < y;
        b = x <= y;
        b = x == y;
        b = x != y;
    },

    other : function(){
        var x = 10;
        var y = x || 0;
        var z = (x != null) ? x : y;
    }
});
