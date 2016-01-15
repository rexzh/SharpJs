enyo.kind({
    name: "UnitTestSample_1.JsonObjectInitializer",
    kind: "enyo.Object",

    followClass : function(){
        var p = {"x": 0, "y": 1};
    },

    emptyListInit : function(){
        var l = [];
    },

    listInit : function(){
        var l = [1, 2, 3, 4];
    },

    emptyGenericListInit : function(){
        var l = [];
    },

    genericListInit : function(){
        var l = [1, 2, 3, 4];
    },

    emptyHashTableInit : function(){
        var t = {};
    },

    hashTableInit : function(){
        var t = {"x": 1, "y": 2};
    },

    emptyDictionaryInit : function(){
        var t = {};
    },

    dictionaryInit : function(){
        var t = {"x": 1, "y": 2};
    },

    dictionaryInit2 : function(){
        var t = {"x": 1, "y": 2};
    }
});
