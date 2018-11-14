function ULSpEN(){var o=new Object;o.ULSTeamName="Windows SharePoint Services 4";o.ULSFileName="CUI.debug.js";return o;}
if (typeof(IEnumerator) == "undefined") {
  var IEnumerator = function() {};
  IEnumerator.prototype = {get_current: null, moveNext: null, reset: null};
  IEnumerator.registerInterface("IEnumerator");
}

if (typeof(IEnumerable) == "undefined") {
  var IEnumerable = function() {};
  IEnumerable.prototype = {getEnumerator: null};
  IEnumerable.registerInterface("IEnumerable");
}

Type.registerNamespace('CUI');
Type.registerNamespace('CUI.Page');
if (typeof(CUI.Page.PageComponent) == "undefined")
{
  CUI.Page.ICommandHandler=function(){};
  CUI.Page.ICommandHandler.registerInterface('CUI.Page.ICommandHandler');
  CUI.Page.PageComponent=function(){};
  CUI.Page.PageComponent.prototype={init:function(){},getGlobalCommands:function(){ULSpEN:;return null;},getFocusedCommands:function(){ULSpEN:;return null;},handleCommand:function(commandId,properties,sequence){ULSpEN:;return false;},canHandleCommand:function(commandId){ULSpEN:;return false;},isFocusable:function(){ULSpEN:;return false;},receiveFocus:function(){ULSpEN:;return false;},yieldFocus:function(){ULSpEN:;return true;},getId:function(){ULSpEN:;return'PageComponent';}};
  CUI.Page.PageComponent.registerClass('CUI.Page.PageComponent',null,CUI.Page.ICommandHandler);
}


Type.registerNamespace('CUI');

CUI.IRootBuildClient = function() {}
CUI.IRootBuildClient.registerInterface('CUI.IRootBuildClient');


CUI.CommandType = function() {}
CUI.CommandType.prototype = {
    general: 1, 
    tabSelection: 2, 
    optionSelection: 3, 
    menuCreation: 4, 
    preview: 5, 
    previewRevert: 6, 
    optionPreview: 7, 
    optionPreviewRevert: 8, 
    ignoredByMenu: 9, 
    menuClose: 10, 
    rootEvent: 11
}
CUI.CommandType.registerEnum('CUI.CommandType', false);


CUI.ISelectableControl = function() {}
CUI.ISelectableControl.registerInterface('CUI.ISelectableControl');


CUI.QueryRecord = function() {}
CUI.$create_QueryRecord = function() {ULSpEN:;
    return new CUI.QueryRecord();
}


CUI.DataQueryType = function() {}
CUI.DataQueryType.prototype = {
    none: 0, 
    all: 1, 
    ribbonVisibleTabDeep: 2, 
    ribbonShallow: 3, 
    ribbonTab: 4, 
    root: 5
}
CUI.DataQueryType.registerEnum('CUI.DataQueryType', false);


CUI.GalleryElementDimensions = function() {}
CUI.GalleryElementDimensions.prototype = {
    size16by16: 1, 
    size32by32: 2, 
    size48by48: 3, 
    size64by48: 4, 
    size72by96: 5, 
    size96by72: 6, 
    size96by96: 7, 
    size128by128: 8, 
    size190by30: 9, 
    size190by40: 10, 
    size190by50: 11, 
    size190by60: 12
}
CUI.GalleryElementDimensions.registerEnum('CUI.GalleryElementDimensions', false);


CUI.IMenuItem = function() {}
CUI.IMenuItem.registerInterface('CUI.IMenuItem');


CUI.ContextualColor = function() {}
CUI.ContextualColor.prototype = {
    none: 0, 
    darkBlue: 1, 
    lightBlue: 2, 
    teal: 3, 
    orange: 4, 
    green: 5, 
    magenta: 6, 
    yellow: 7, 
    purple: 8
}
CUI.ContextualColor.registerEnum('CUI.ContextualColor', false);


CUI.DeclarativeTemplateBuildContext = function() {}
CUI.$create_DeclarativeTemplateBuildContext = function() {ULSpEN:;
    return new CUI.DeclarativeTemplateBuildContext();
}


CUI.CommandInformation = function() {}
CUI.$create_CommandInformation = function() {ULSpEN:;
    return new CUI.CommandInformation();
}


CUI.IModalController = function() {}
CUI.IModalController.registerInterface('CUI.IModalController');


CUI.Direction = function() {}
CUI.Direction.prototype = {
    LTR: 0, 
    RTL: 1
}
CUI.Direction.registerEnum('CUI.Direction', false);


CUI.DisabledCommandInfoProperties = function() {}
CUI.$create_DisabledCommandInfoProperties = function() {ULSpEN:;
    return new CUI.DisabledCommandInfoProperties();
}


CUI.ImgContainerType = function() {}
CUI.ImgContainerType.prototype = {
    div: 1, 
    span: 2, 
    anchor: 3
}
CUI.ImgContainerType.registerEnum('CUI.ImgContainerType', false);


CUI.ImgContainerSize = function() {}
CUI.ImgContainerSize.prototype = {
    none: 0, 
    size5by3: 1, 
    size13by13: 2, 
    size16by16: 3, 
    size32by32: 4, 
    size48by48: 5, 
    size64by48: 6, 
    size72by96: 7, 
    size96by72: 8, 
    size96by96: 9, 
    size56by24: 10, 
    size2by16: 11
}
CUI.ImgContainerSize.registerEnum('CUI.ImgContainerSize', false);


CUI.PMarker = function() {}
CUI.PMarker.prototype = {
    beginSession: 1, 
    endSession: 2, 
    perfCUIRibbonInitStart: 7103, 
    perfCUIRibbonInitPercvdEnd: 7104, 
    perfCUIRibbonTabSwitchWarmStart: 7105, 
    perfCUIRibbonTabSwitchWarmPercvdEnd: 7106, 
    perfCUIRibbonTabSwitchWarmEnd: 7107, 
    perfCUIRibbonCompleteConstruction: 7108, 
    perfCUIRibbonQueryDataStart: 7109, 
    perfCUIRibbonQueryDataEnd: 7110, 
    perfWSSWikiUpdatePanelStart: 7111, 
    perfWSSWikiUpdatePanelEnd: 7112, 
    perfWSSWebPartComponentMouseClickStart: 7186, 
    perfWSSWebPartComponentMouseClickEnd: 7187, 
    perfCUIAddAndPositionBackFrameStart: 7188, 
    perfCUIAddAndPositionBackFrameEnd: 7189, 
    perfCUIFlyoutAnchorOnClickStart: 7190, 
    perfCUIFlyoutAnchorOnClickEnd: 7191, 
    perfCUIDropDownOnArrowButtonClickStart: 7192, 
    perfCUIDropDownOnArrowButtonClickEnd: 7193, 
    perfWSSBreadcrumbStart: 7386, 
    perfWSSBreadcrumbEnd: 7387, 
    perfWSSSelectOrDeselectAllStart: 7388, 
    perfWSSSelectOrDeselectAllEnd: 7389, 
    perfWSSSelectItemStart: 7390, 
    perfWSSSelectItemEnd: 7391, 
    perfWSSFilterSortStart: 7392, 
    perfWSSFilterSortEnd: 7393, 
    perfWSSMMUOpenStart: 7394, 
    perfWSSMMUOpenEnd: 7395, 
    perfWSSECBClickStart: 7396, 
    perfWSSECBClickEnd: 7397, 
    perfSPSSaveStatusNoteBegin: 7634, 
    perfSPSSaveStatusNoteEnd: 7635, 
    perfWSSCalendarRenderStart: 7644, 
    perfWSSCalendarRenderEnd: 7645, 
    perfPLTxInstrumentStart: 7698, 
    perfPLTxInstrumentEnd: 7699, 
    perfCUIRibbonButtonOnClickStart: 7700, 
    perfCUIRibbonButtonOnClickEnd: 7701, 
    perfCUIRibbonInsertTableOnClickStart: 7702, 
    perfCUIRibbonInsertTableOnClickEnd: 7703, 
    perfCUIRibbonToggleButtonOnClickStart: 7704, 
    perfCUIRibbonToggleButtonOnClickEnd: 7705, 
    perfWSSDialogShow: 7706, 
    perfWSSDialogClosed: 7707, 
    perfWSSRTEDialogOnLoadEnd: 7708, 
    perfWSSRTEDialogOnOkButtonClickStart: 7709, 
    perfWSSRTEAutoCompleteSetResultsStart: 7710, 
    perfWSSRTEAutoCompleteSetResultsEnd: 7711, 
    perfCUIRibbonEditWikiPageStart: 7735, 
    perfCUIRibbonEditWikiPageEnd: 7736
}
CUI.PMarker.registerEnum('CUI.PMarker', false);


CUI.BuildOptions = function() {
}
CUI.BuildOptions.prototype = {
    lazyMenuInit: false,
    trimmedIds: null,
    attachToDOM: false,
    validateServerRendering: false,
    fixedPositioningEnabled: false,
    dataExtensions: null,
    clientID: null
}


CUI.BuildContext = function() {
}


CUI.DataNodeWrapper = function(node) {ULSpEN:;
    this.$a_0 = node;
}
CUI.DataNodeWrapper.getFirstChildNodeWithName = function($p0, $p1) {
    var $v_0 = CUI.DataNodeWrapper.getNodeChildren($p0);
    var $v_1 = $v_0.length;
    var $v_2 = null;
    for (var $v_3 = 0; $v_3 < $v_1; $v_3++) {
        $v_2 = $v_0[$v_3];
        var $v_4 = $v_2.name;
        if ($v_4 === $p1) {
            return $v_2;
        }
    }
    return null;
}
CUI.DataNodeWrapper.getNodeName = function($p0) {
    return $p0.name;
}
CUI.DataNodeWrapper.getNodeChildren = function($p0) {
    var $v_0 = $p0.children;
    if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
        return CUI.DataNodeWrapper.get_$CX_0();
    }
    return $v_0;
}
CUI.DataNodeWrapper.get_$CX_0 = function() {ULSpEN:;
    if (CUI.ScriptUtility.isNullOrUndefined(CUI.DataNodeWrapper.$61_0)) {
        CUI.DataNodeWrapper.$61_0 = [];
    }
    return CUI.DataNodeWrapper.$61_0;
}
CUI.DataNodeWrapper.getNodeAttributes = function($p0) {
    return $p0.attrs;
}
CUI.DataNodeWrapper.getNodeAttribute = function($p0, $p1) {
    var $v_0 = $p0.attrs;
    return $v_0[$p1];
}
CUI.DataNodeWrapper.prototype = {
    $a_0: null,
    
    get_node: function() {ULSpEN:;
        return this.$a_0;
    },
    set_node: function($p0) {
        this.$a_0 = $p0;
        return $p0;
    },
    
    get_name: function() {ULSpEN:;
        return CUI.DataNodeWrapper.getNodeName(this.$a_0);
    },
    
    get_children: function() {ULSpEN:;
        return CUI.DataNodeWrapper.getNodeChildren(this.$a_0);
    },
    
    get_attributes: function() {ULSpEN:;
        return CUI.DataNodeWrapper.getNodeAttributes(this.$a_0);
    },
    
    get_hasChildren: function() {ULSpEN:;
        return CUI.DataNodeWrapper.getNodeChildren(this.$a_0).length > 0;
    }
}


CUI.Builder = function(options, elmPlaceholder, rootBuildClient) {ULSpEN:;
    this.$80 = Function.createDelegate(this, this.$CR_0);
    this.$8s = Function.createDelegate(this, this.$7Z_0);
    this.$s_0 = options;
    if (CUI.ScriptUtility.isNullOrUndefined(this.$s_0.trimmedIds)) {
        this.$s_0.trimmedIds = {};
    }
    this._elmPlaceholder = elmPlaceholder;
    this.$1R_0 = rootBuildClient;
    this.$22_0 = this.$8s;
    $addHandler(window, 'unload', this.$22_0);
}
CUI.Builder.$CA = function($p0) {
    var $v_0 = CUI.NativeUtility.createXMLDocFromString($p0);
    if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
        return null;
    }
    return CUI.Builder.$CB($v_0);
}
CUI.Builder.$CB = function($p0) {
    return eval('(' + CUI.Builder.convertNodeToJSON($p0.documentElement) + ')');
}
CUI.Builder.convertNodeToJSON = function(node) {ULSpEN:;
    var $v_0;
    $v_0 = '{';
    $v_0 += '\"name\" : \"';
    $v_0 += CUI.NativeUtility.ecmaScriptStringLiteralEncode(node.nodeName);
    $v_0 += '\",';
    $v_0 += '\"attrs\": {';
    var $v_1 = node.attributes;
    if (!CUI.ScriptUtility.isNullOrUndefined(node.attributes)) {
        var $v_3 = $v_1.length;
        if ($v_3 > 0) {
            var $v_4 = true;
            for (var $v_5 = 0; $v_5 < $v_3; $v_5++) {
                var $v_6 = $v_1.item($v_5);
                if ($v_4) {
                    $v_4 = false;
                }
                else {
                    $v_0 += ',';
                }
                $v_0 += '\"';
                $v_0 += CUI.NativeUtility.ecmaScriptStringLiteralEncode($v_6.name);
                $v_0 += '\"';
                $v_0 += ':\"';
                $v_0 += CUI.NativeUtility.ecmaScriptStringLiteralEncode($v_6.value);
                $v_0 += '\"';
            }
        }
    }
    $v_0 += '}';
    var $v_2 = node.childNodes;
    if ($v_2) {
        var $v_7 = $v_2.length;
        if ($v_7 > 0) {
            $v_0 += ',';
            $v_0 += 'children:[';
            var $v_8 = true;
            for (var $v_9 = 0; $v_9 < $v_7; $v_9++) {
                var $v_A = $v_2[$v_9];
                if ($v_A.nodeName === '#text') {
                    continue;
                }
                if ($v_8) {
                    $v_8 = false;
                }
                else {
                    $v_0 += ',';
                }
                $v_0 += CUI.Builder.convertNodeToJSON($v_A);
            }
            $v_0 += ']';
        }
    }
    $v_0 += '}';
    return $v_0;
}
CUI.Builder.applyDataNodeExtensions = function(data, extensions) {ULSpEN:;
    var $v_0 = data.attrs;
    if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
        return data;
    }
    var $v_1 = $v_0['Id'];
    var $v_2 = extensions[$v_1];
    if (!CUI.ScriptUtility.isNullOrUndefined($v_2)) {
        var $v_9 = null;
        var $v_A = Number.MAX_VALUE;
        var $v_B = $v_2.length;
        for (var $v_C = 0; $v_C < $v_B; $v_C++) {
            var $v_D = $v_2[$v_C];
            if (!$v_D) {
                return null;
            }
            var $v_E = CUI.DataNodeWrapper.getNodeAttribute($v_D, 'Sequence');
            if (CUI.ScriptUtility.isNullOrUndefined($v_E)) {
                if (CUI.ScriptUtility.isNullOrUndefined($v_9)) {
                    $v_9 = $v_D;
                }
                continue;
            }
            var $v_F = parseInt($v_E);
            if ($v_F < $v_A) {
                $v_9 = $v_D;
                $v_A = $v_F;
            }
        }
        if (!CUI.ScriptUtility.isNullOrUndefined($v_9)) {
            data = $v_9;
        }
    }
    var $v_3 = (data)['children'];
    if (CUI.ScriptUtility.isNullOrUndefined($v_3)) {
        $v_3 = [];
        (data)['children'] = $v_3;
    }
    var $v_4 = [];
    var $v_5 = $v_3.length;
    for (var $v_G = 0; $v_G < $v_5; $v_G++) {
        Array.add($v_4, $v_3[$v_G]);
    }
    var $v_6 = extensions[$v_1 + '._children'];
    if (!CUI.ScriptUtility.isNullOrUndefined($v_6)) {
        var $v_H = $v_6.length;
        for (var $v_I = 0; $v_I < $v_H; $v_I++) {
            Array.add($v_4, $v_6[$v_I]);
        }
        ($v_4).sort(CUI.Builder.$C8_0);
    }
    var $v_7 = [];
    var $v_8 = $v_4.length;
    for (var $v_J = 0; $v_J < $v_8; $v_J++) {
        var $v_K = CUI.Builder.applyDataNodeExtensions($v_4[$v_J], extensions);
        if (!CUI.ScriptUtility.isNullOrUndefined($v_K)) {
            Array.add($v_7, $v_K);
        }
    }
    (data)['children'] = $v_7;
    return data;
}
CUI.Builder.$C8_0 = function($p0, $p1) {
    var $v_0 = CUI.DataNodeWrapper.getNodeAttribute($p0, 'Sequence');
    var $v_1 = CUI.DataNodeWrapper.getNodeAttribute($p1, 'Sequence');
    if (CUI.ScriptUtility.isNullOrUndefined($v_1) && (CUI.ScriptUtility.isNullOrUndefined($v_0))) {
        return 0;
    }
    if (CUI.ScriptUtility.isNullOrUndefined($v_1)) {
        return -1;
    }
    if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
        return 1;
    }
    var $v_2 = parseInt($v_0);
    var $v_3 = parseInt($v_1);
    if ($v_2 < $v_3) {
        return -1;
    }
    else if ($v_2 > $v_3) {
        return 1;
    }
    return 0;
}
CUI.Builder.prototype = {
    $1R_0: null,
    $22_0: null,
    
    $7Z_0: function($p0) {
        this.dispose();
    },
    
    $7a: function($p0) {
        $p0.$2v_1 = this.$s_0.fixedPositioningEnabled;
    },
    
    dispose: function() {ULSpEN:;
        this.$0_0 = null;
        this.$s_0 = null;
        this._elmPlaceholder = null;
        this.$1R_0 = null;
        this.$12_0 = null;
        $removeHandler(window, 'unload', this.$22_0);
        this.$22_0 = null;
    },
    
    $0_0: null,
    
    get_root: function() {ULSpEN:;
        return this.$0_0;
    },
    set_root: function(value) {ULSpEN:;
        this.$0_0 = value;
        return value;
    },
    
    $2Y_0: false,
    
    get_inQuery: function() {ULSpEN:;
        return this.$2Y_0;
    },
    set_inQuery: function(value) {ULSpEN:;
        this.$2Y_0 = value;
        return value;
    },
    
    $12_0: null,
    
    get_dataSource: function() {ULSpEN:;
        return this.$12_0;
    },
    set_dataSource: function(value) {ULSpEN:;
        this.$12_0 = value;
        return value;
    },
    
    _elmPlaceholder: null,
    
    get_placeholder: function() {ULSpEN:;
        return this._elmPlaceholder;
    },
    
    $s_0: null,
    
    isIdTrimmed: function(id) {ULSpEN:;
        return this.$s_0.trimmedIds[id];
    },
    
    isNodeTrimmed: function(dataNode) {ULSpEN:;
        var $v_0 = CUI.DataNodeWrapper.getNodeAttribute(dataNode, 'Id');
        return this.$s_0.trimmedIds[$v_0];
    },
    
    $1f: function($p0, $p1) {
        var $v_0 = null;
        var $v_1 = $p0.name;
        switch ($v_1) {
            case 'ToggleButton':
                $v_0 = this.$C2_0($p0, $p1);
                break;
            case 'ComboBox':
                $v_0 = this.$Bj_0($p0, $p1);
                break;
            case 'DropDown':
                $v_0 = this.$Bk_0($p0, $p1);
                break;
            case 'Button':
                $v_0 = this.$Bf_0($p0, $p1);
                break;
            case 'SplitButton':
                $v_0 = this.$Bz_0($p0, $p1);
                break;
            case 'FlyoutAnchor':
                $v_0 = this.$Bl_0($p0, $p1);
                break;
            case 'GalleryButton':
                $v_0 = this.$9x_0($p0, $p1, null);
                break;
            case 'InsertTable':
                $v_0 = this.$Bo_0($p0, $p1);
                break;
            case 'Label':
                $v_0 = this.$Bs_0($p0, $p1);
                break;
            case 'MRUSplitButton':
                $v_0 = this.$Bu_0($p0, $p1);
                break;
            case 'Spinner':
                $v_0 = this.$By_0($p0, $p1);
                break;
            case 'TextBox':
                $v_0 = this.$C1_0($p0, $p1);
                break;
            case 'ColorPicker':
                $v_0 = this.$Bi_0($p0, $p1);
                break;
            case 'CheckBox':
                $v_0 = this.$Bh_0($p0, $p1);
                break;
            case 'Separator':
                $v_0 = this.$Bx_0($p0, $p1);
                break;
            default:
                var $v_2 = $p0.attrs;
                var $v_3 = $v_2['Classname'];
                if (CUI.ScriptUtility.isNullOrUndefined($v_3)) {
                    throw Error.create('Unable to create Control with tagname: ' + $v_1);
                }
                break;
        }
        return $v_0;
    },
    
    $37: function($p0, $p1, $p2) {
        var $v_0 = $p0.attrs;
        var $v_1 = this.$0_0.$A6($v_0['Id'], $v_0['Title'], $v_0['Description'], $v_0['MaxWidth']);
        if (this.$s_0.lazyMenuInit && $p2) {
            $v_1.$7k(this.$80, $p0, $p1);
            return $v_1;
        }
        this.$AE_0($v_1, $p0, $p1);
        return $v_1;
    },
    
    $AE_0: function($p0, $p1, $p2) {
        var $v_0 = CUI.DataNodeWrapper.getNodeChildren($p1);
        var $v_1 = $v_0.length;
        var $v_2 = null;
        for (var $v_3 = 0; $v_3 < $v_1; $v_3++) {
            $v_2 = $v_0[$v_3];
            var $v_4 = $v_2.name;
            if ($v_4 !== 'MenuSection') {
                throw Error.create('Tags with the name: ' + $v_4 + ' cannot be children of Menu tags.');
            }
            if (this.isNodeTrimmed($v_2)) {
                continue;
            }
            var $v_5 = this.$Bt_0($v_2, $p2);
            $p0.addChild($v_5);
        }
    },
    
    $CR_0: function($p0, $p1, $p2) {
        var $v_0 = $p0;
        this.$AE_0($v_0, $p1, $p2);
        $v_0.$4v(true);
        return $v_0;
    },
    
    $Bt_0: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = $v_0['DisplayMode'];
        if (CUI.ScriptUtility.isNullOrUndefined($v_1)) {
            $v_1 = 'Menu';
        }
        var $v_2 = this.$0_0.$A7($v_0['Id'], $v_0['Title'], $v_0['Description'], ($v_0['Scrollable']) === 'true', $v_0['MaxHeight'], $v_1);
        var $v_3 = CUI.DataNodeWrapper.getNodeName((CUI.DataNodeWrapper.getNodeChildren($p0))[0]);
        if ($v_3 === 'Controls') {
            var $v_4 = CUI.DataNodeWrapper.getNodeChildren((CUI.DataNodeWrapper.getNodeChildren($p0))[0]);
            var $v_5 = $v_4.length;
            var $v_6 = null;
            for (var $v_7 = 0; $v_7 < $v_5; $v_7++) {
                $v_6 = $v_4[$v_7];
                if (this.isNodeTrimmed($v_6)) {
                    continue;
                }
                var $v_8 = this.$1f($v_6, $p1);
                $v_2.addChild($v_8.createComponentForDisplayMode($v_1));
            }
        }
        else if ($v_3 === 'Gallery') {
            var $v_9 = this.$Bm_0((CUI.DataNodeWrapper.getNodeChildren($p0))[0], $p1, true);
            $v_2.addChild($v_9);
        }
        return $v_2;
    },
    
    $Bm_0: function($p0, $p1, $p2) {
        var $v_0 = $p0.attrs;
        var $v_1 = $p0.attrs;
        var $v_2 = this.$0_0.$CI($v_1.Id, $v_0['Title'], $v_0['Description'], $v_1);
        var $v_3 = ($p2) ? 'Menu' : 'Default';
        var $v_4 = CUI.DataNodeWrapper.getNodeChildren($p0);
        var $v_5 = $v_4.length;
        var $v_6 = null;
        for (var $v_7 = 0; $v_7 < $v_5; $v_7++) {
            $v_6 = $v_4[$v_7];
            if (this.isNodeTrimmed($v_6)) {
                continue;
            }
            var $v_8;
            switch (CUI.DataNodeWrapper.getNodeName($v_6)) {
                case 'GalleryButton':
                    $v_8 = this.$9x_0($v_6, $p1, $v_1.ElementDimensions);
                    break;
                default:
                    $v_8 = this.$1f($v_6, $p1);
                    break;
            }
            $v_2.addChild($v_8.createComponentForDisplayMode($v_3));
        }
        return $v_2;
    },
    
    $9x_0: function($p0, $p1, $p2) {
        var $v_0;
        if (CUI.ScriptUtility.isNullOrEmptyString($p2)) {
            var $v_3 = $p0.attrs;
            $p2 = $v_3['ElementDimensions'];
        }
        if (CUI.ScriptUtility.isNullOrEmptyString($p2)) {
            $v_0 = 2;
        }
        else {
            $v_0 = CUI.Gallery.$A0($p2);
        }
        var $v_1 = $p0.attrs;
        var $v_2 = new CUI.Controls.GalleryButton(this.$0_0, $v_1.Id, $v_1, $v_0);
        return $v_2;
    },
    
    $C2_0: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = new CUI.Controls.ToggleButton(this.$0_0, $v_0.Id, $v_0);
        return $v_1;
    },
    
    $Bh_0: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = new CUI.Controls.CheckBox(this.$0_0, $v_0.Id, $v_0);
        return $v_1;
    },
    
    $Bi_0: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = CUI.DataNodeWrapper.getNodeChildren(CUI.DataNodeWrapper.getFirstChildNodeWithName($p0, 'Colors'));
        var $v_2 = new Array($v_1.length);
        var $v_3 = $v_1.length;
        for (var $v_5 = 0; $v_5 < $v_3; $v_5++) {
            var $v_6 = new CUI.Controls.ColorStyle();
            var $v_7 = CUI.DataNodeWrapper.getNodeAttributes($v_1[$v_5]);
            var $v_8 = $v_7['Title'];
            $v_6.Title = (CUI.ScriptUtility.isNullOrUndefined($v_8)) ? $v_7['Alt'] : $v_8;
            $v_6.Color = $v_7['Color'];
            $v_6.DisplayColor = $v_7['DisplayColor'];
            $v_6.Style = $v_7['Style'];
            $v_2[$v_5] = $v_6;
        }
        var $v_4 = new CUI.Controls.ColorPicker(this.$0_0, $v_0.Id, $v_0, $v_2);
        return $v_4;
    },
    
    $Bj_0: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = CUI.DataNodeWrapper.getNodeChildren($p0);
        var $v_2 = null;
        var $v_3 = $p0.attrs;
        var $v_4 = null;
        if (!CUI.Utility.$v($v_3.PopulateDynamically)) {
            $v_2 = this.$37($v_1[0], $p1, false);
            $v_4 = {};
            var $v_6 = CUI.DataNodeWrapper.getNodeChildren($v_1[0]);
            var $v_7 = $v_6.length;
            for (var $v_8 = 0; $v_8 < $v_7; $v_8++) {
                var $v_9 = CUI.DataNodeWrapper.getNodeChildren($v_6[$v_8]);
                var $v_A = CUI.DataNodeWrapper.getNodeChildren($v_9[0]);
                var $v_B = $v_A.length;
                for (var $v_C = 0; $v_C < $v_B; $v_C++) {
                    var $v_D = $v_A[$v_C].attrs;
                    var $v_E = $v_D['LabelText'];
                    var $v_F = $v_D['MenuItemId'];
                    $v_4[$v_E] = $v_F;
                }
            }
        }
        var $v_5 = new CUI.Controls.ComboBox(this.$0_0, $v_0.Id, $v_0, $v_2);
        $v_5.set_menuItems($v_4);
        return $v_5;
    },
    
    $Bk_0: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = CUI.DataNodeWrapper.getNodeChildren($p0);
        var $v_2 = null;
        var $v_3 = $p0.attrs;
        if (!CUI.Utility.$v($v_3.PopulateDynamically)) {
            $v_2 = this.$37($v_1[0], $p1, false);
        }
        var $v_4 = new CUI.Controls.DropDown(this.$0_0, $v_0.Id, $v_0, $v_2);
        return $v_4;
    },
    
    $Bf_0: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = new CUI.Controls.Button(this.$0_0, $v_0.Id, $v_0);
        return $v_1;
    },
    
    $Bz_0: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = CUI.DataNodeWrapper.getNodeChildren($p0);
        var $v_2 = null;
        if (!CUI.Utility.$v($v_0.PopulateDynamically)) {
            $v_2 = this.$37($v_1[0], $p1, true);
        }
        var $v_3 = new CUI.Controls.SplitButton(this.$0_0, $v_0.Id, $v_0, $v_2);
        return $v_3;
    },
    
    $Bl_0: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = CUI.DataNodeWrapper.getNodeChildren($p0);
        var $v_2 = null;
        var $v_3 = $p0.attrs;
        if (!CUI.Utility.$v($v_3.PopulateDynamically)) {
            $v_2 = this.$37($v_1[0], $p1, true);
        }
        var $v_4 = new CUI.Controls.FlyoutAnchor(this.$0_0, $v_0.Id, $v_0, $v_2);
        return $v_4;
    },
    
    $Bo_0: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = new CUI.Controls.InsertTable(this.$0_0, $v_0.Id, $v_0);
        return $v_1;
    },
    
    $Bs_0: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = new CUI.Controls.Label(this.$0_0, $v_0.Id, $v_0);
        return $v_1;
    },
    
    $Bu_0: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = CUI.DataNodeWrapper.getNodeChildren($p0);
        var $v_2 = null;
        var $v_3 = $p0.attrs;
        if (!CUI.Utility.$v($v_3.PopulateDynamically)) {
            $v_2 = this.$37($v_1[0], $p1, false);
        }
        var $v_4 = new CUI.Controls.MRUSplitButton(this.$0_0, $v_0.Id, $v_0, $v_2);
        return $v_4;
    },
    
    $Bx_0: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = new CUI.Controls.Separator(this.$0_0, $v_0.Id, $v_0);
        return $v_1;
    },
    
    $By_0: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = new CUI.Controls.Spinner(this.$0_0, $v_0.Id, $v_0, this.$C6_0($p0));
        return $v_1;
    },
    
    $C1_0: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = new CUI.Controls.TextBox(this.$0_0, $v_0.Id, $v_0);
        return $v_1;
    },
    
    $79_0: function($p0) {
        if (typeof($p0) === 'string') {
            return parseFloat($p0);
        }
        return $p0;
    },
    
    $C9_0: function($p0) {
        if (typeof($p0) === 'string') {
            return parseInt($p0);
        }
        return $p0;
    },
    
    $C6_0: function($p0) {
        var $v_0 = CUI.DataNodeWrapper.getNodeChildren($p0);
        var $v_1 = new Array($v_0.length);
        var $v_2 = $v_0.length;
        for (var $v_3 = 0; $v_3 < $v_2; $v_3++) {
            var $v_4 = $v_0[$v_3];
            var $v_5 = CUI.DataNodeWrapper.getNodeAttributes($v_4);
            $v_1[$v_3] = CUI.Controls.Spinner.createUnit($v_5['Name'], this.$C5_0(CUI.DataNodeWrapper.getNodeChildren($v_4)), this.$79_0($v_5['MinimumValue']), this.$79_0($v_5['MaximumValue']), this.$C9_0($v_5['DecimalDigits']), this.$79_0($v_5['Interval']));
        }
        return $v_1;
    },
    
    $C5_0: function($p0) {
        var $v_0 = new Array($p0.length);
        var $v_1 = $p0.length;
        for (var $v_2 = 0; $v_2 < $v_1; $v_2++) {
            var $v_3 = $p0[$v_2];
            var $v_4 = CUI.DataNodeWrapper.getNodeAttributes($v_3);
            $v_0[$v_2] = $v_4['Value'];
        }
        return $v_0;
    },
    
    applyDataExtensions: function(data) {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$s_0.dataExtensions)) {
            return CUI.Builder.applyDataNodeExtensions(data, this.$s_0.dataExtensions);
        }
        else {
            return data;
        }
    }
}


CUI.CommandEventArgs = function(id, type, source, pars) {ULSpEN:;
    CUI.CommandEventArgs.initializeBase(this);
    this.$6_1 = id;
    this.$2z_1 = pars;
    this.$31_1 = source;
    this.$G_1 = type;
}
CUI.CommandEventArgs.prototype = {
    $6_1: null,
    $6s_1: 0,
    $2z_1: null,
    $31_1: null,
    $G_1: 0,
    $6B_1: null,
    
    get_id: function() {ULSpEN:;
        return this.$6_1;
    },
    
    get_parameters: function() {ULSpEN:;
        return this.$2z_1;
    },
    
    get_sequenceNumber: function() {ULSpEN:;
        return this.$6s_1;
    },
    set_sequenceNumber: function($p0) {
        this.$6s_1 = $p0;
        return $p0;
    },
    
    get_source: function() {ULSpEN:;
        return this.$31_1;
    },
    
    get_sourceControl: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$31_1) && CUI.ControlComponent.isInstanceOfType(this.$31_1)) {
            return (this.$31_1).$M_1;
        }
        return null;
    },
    
    get_type: function() {ULSpEN:;
        return this.$G_1;
    },
    
    get_properties: function() {ULSpEN:;
        return this.$2z_1;
    },
    
    get_commandInfo: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$6B_1)) {
            this.$6B_1 = new CUI.CommandInformation();
        }
        return this.$6B_1;
    }
}


CUI.Component = function(root, id, title, description) {ULSpEN:;
    this._componentWidth = -1;
    this._componentHeight = -1;
    this._componentTopPosition = -1;
    this._componentLeftPosition = -1;
    this.$6_0 = id;
    this.$0_0 = root;
    this.$1S_0 = title;
    this.$6H_0 = description;
    this.createChildArray();
}
CUI.Component.prototype = {
    $6_0: null,
    $2q_0: null,
    $K_0: null,
    $0_0: null,
    $4_0: null,
    $g_0: true,
    $5l_0: true,
    $1Q_0: true,
    $5U_0: false,
    $6H_0: null,
    $1S_0: null,
    
    createChildArray: function() {ULSpEN:;
        this.$7D();
    },
    
    $7D: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$4_0)) {
            this.$4_0 = new CUI.List();
        }
    },
    
    get_id: function() {ULSpEN:;
        return this.$6_0;
    },
    set_id: function(value) {ULSpEN:;
        this.$6_0 = value;
        return value;
    },
    
    get_$2: function() {ULSpEN:;
        return this.$2q_0;
    },
    set_$2: function($p0) {
        this.$2q_0 = $p0;
        return $p0;
    },
    
    get_root: function() {ULSpEN:;
        return this.$0_0;
    },
    
    get_parent: function() {ULSpEN:;
        return this.$K_0;
    },
    set_parent: function(value) {ULSpEN:;
        this.$K_0 = value;
        return value;
    },
    
    $x: function() {
    },
    
    $2j: function() {ULSpEN:;
        return false;
    },
    
    $2i: function() {ULSpEN:;
        return false;
    },
    
    $1r: function() {
    },
    
    $3x: function() {
    },
    
    $5n: function($p0) {
        return false;
    },
    
    $AN: function($p0) {
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_0 = $$enum_1_0.get_current();
            if ($v_0.$6_0 === $p0) {
                return $v_0;
            }
        }
        return null;
    },
    
    getChild: function(id) {ULSpEN:;
        return this.$AN(id);
    },
    
    getChildByTitle: function(title) {ULSpEN:;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_0 = $$enum_1_0.get_current();
            if ($v_0.get_title() === title) {
                return $v_0;
            }
        }
        return null;
    },
    
    addChild: function(child) {ULSpEN:;
        this.$34(child, true);
    },
    
    $34: function($p0, $p1) {
        this.$9p($p0, -1, $p1);
    },
    
    addChildAtIndex: function(child, index) {ULSpEN:;
        this.$9p(child, index, true);
    },
    
    $9p: function($p0, $p1, $p2) {
        if ($p2) {
            this.ensureCorrectChildType($p0);
        }
        if (!CUI.ScriptUtility.isNullOrUndefined($p0.$K_0)) {
            throw Error.create('This child cannot be added because it has already been added \n to another Component in the hierarchy.  \n You must first call child.Parent.RemoveChild(child)');
        }
        if ($p1 === -1) {
            this.$4_0.add($p0);
        }
        else {
            this.$4_0.insert($p1, $p0);
        }
        $p0.$K_0 = this;
        this.$w();
    },
    
    removeChild: function(id) {ULSpEN:;
        var $v_0 = this.$AN(id);
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            throw Error.create('The child with id: ' + id + ' is not as child of this Component');
        }
        this.$4_0.remove($v_0);
        $v_0.$K_0 = null;
        this.$w();
    },
    
    removeChildren: function() {ULSpEN:;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_0 = $$enum_1_0.get_current();
            if ($v_0) {
                $v_0.$K_0 = null;
            }
        }
        this.$4_0.clear();
        this.$w();
    },
    
    ensureCorrectChildType: function(child) {ULSpEN:;
        return;
    },
    
    initRootMember: function(root) {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$0_0)) {
            throw Error.create('Root member has already been set for this Component.');
        }
        this.$0_0 = root;
    },
    
    get_visible: function() {ULSpEN:;
        return this.$5l_0;
    },
    set_visible: function(value) {ULSpEN:;
        this.set_$64(value);
        return value;
    },
    
    get_$64: function() {ULSpEN:;
        return this.get_visible();
    },
    set_$64: function($p0) {
        var $v_0 = this.$5l_0;
        this.$5l_0 = $p0;
        if ($v_0 !== this.$5l_0) {
            this.$w();
        }
        return $p0;
    },
    
    get_enabled: function() {ULSpEN:;
        return this.$1Q_0;
    },
    set_enabled: function(value) {ULSpEN:;
        if (this.$1Q_0 === value && this.$5U_0) {
            return;
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$K_0) && !this.$K_0.get_enabled() && value) {
            throw Error.create('This Component with id: ' + this.$6_0 + ' cannot be Enabled because its parent is Disabled');
        }
        this.$1Q_0 = value;
        this.$5U_0 = true;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_0 = $$enum_1_0.get_current();
            $v_0.set_enabled(value);
        }
        this.onEnabledChanged(value);
        return value;
    },
    
    onEnabledChanged: function(enabled) {
    },
    
    $E4: function($p0) {
        var $v_0 = this.$1Q_0 !== $p0;
        this.$1Q_0 = $p0;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$4_0)) {
            var $$enum_2_0 = this.$4_0.getEnumerator();
            while ($$enum_2_0.moveNext()) {
                var $v_1 = $$enum_2_0.get_current();
                $v_1.$E4($p0);
            }
        }
        if ($v_0) {
            this.onEnabledChanged($p0);
        }
    },
    
    get_title: function() {ULSpEN:;
        return this.$1S_0;
    },
    set_title: function(value) {ULSpEN:;
        this.$1S_0 = value;
        this.$w();
        return value;
    },
    
    get_description: function() {ULSpEN:;
        return this.$6H_0;
    },
    set_description: function(value) {ULSpEN:;
        this.$6H_0 = value;
        this.$w();
        return value;
    },
    
    _lastWidthUpdate: 0,
    _lastHeightUpdate: 0,
    
    get_$77: function() {ULSpEN:;
        return this._componentHeight;
    },
    
    _lastTopUpdate: 0,
    
    get_$4p: function() {ULSpEN:;
        return this._componentTopPosition;
    },
    
    _lastLeftUpdate: 0,
    
    valueIsDirty: function(lastUpdate) {ULSpEN:;
        if (CUI.Ribbon.isInstanceOfType(this.$0_0)) {
            var $v_0 = this.$0_0;
            return lastUpdate < $v_0.get_$D8();
        }
        return false;
    },
    
    $7l: function($p0) {
        this.$g_0 = $p0;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$4_0)) {
            return;
        }
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_0 = $$enum_1_0.get_current();
            $v_0.$7l($p0);
        }
    },
    
    $w: function() {ULSpEN:;
        if (this.$g_0 || this.$4X_0) {
            return;
        }
        this.$g_0 = true;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$K_0)) {
            this.$K_0.$w();
        }
    },
    
    $4X_0: false,
    
    $L: function() {ULSpEN:;
        this.$g_0 = false;
    },
    
    $2O: function() {ULSpEN:;
        if (this.$g_0) {
            this.$L();
        }
    },
    
    $36: function($p0) {
        this.$3v();
        this.$N();
        this.$g_0 = false;
        if ($p0) {
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$4_0)) {
                var $$enum_3_0 = this.$4_0.getEnumerator();
                while ($$enum_3_0.moveNext()) {
                    var $v_0 = $$enum_3_0.get_current();
                    $v_0.$36($p0);
                }
            }
        }
    },
    
    $3v: function() {ULSpEN:;
        var $v_0 = $get(this.$6_0);
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            this.set_$2($v_0);
        }
        else {
            throw Error.create('Attempting to attach to Id: ' + this.$6_0 + ' but this id is not present in the DOM');
        }
    },
    
    $N: function() {
    },
    
    $m: function() {ULSpEN:;
        if (!this.$2q_0) {
            this.$2q_0 = CUI.Utility.$3(this.get_domElementTagName());
            this.$2q_0.className = this.get_cssClass();
            this.$2q_0.id = this.$6_0;
        }
    },
    
    get_domElementTagName: function() {ULSpEN:;
        return 'span';
    },
    
    get_cssClass: function() {ULSpEN:;
        return '';
    },
    
    get_visibleInDOM: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$K_0)) {
            return false;
        }
        return this.$K_0.get_visibleInDOM();
    },
    
    $50: function() {ULSpEN:;
        if (!this.get_visible()) {
            return false;
        }
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_0 = $$enum_1_0.get_current();
            if ($v_0.$50()) {
                return true;
            }
        }
        return false;
    },
    
    ensureDOMElementAndEmpty: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this.$m();
        }
        else {
            this.set_$2(CUI.Utility.removeChildNodes(this.get_$2()));
        }
    },
    
    appendChildrenToElement: function(elm) {ULSpEN:;
        var $v_0 = document.createDocumentFragment();
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_1 = $$enum_1_0.get_current();
            $v_1.$m();
            $v_0.appendChild($v_1.get_$2());
            $v_1.$2O();
        }
        elm.appendChild($v_0);
    },
    
    raiseCommandEvent: function(commandId, type, properties) {ULSpEN:;
        var $v_0 = this.$0_0.$CF(commandId, type, this, properties);
        this.$B4($v_0);
    },
    
    $B4: function($p0) {
        if (this.$1g($p0) && !CUI.ScriptUtility.isNullOrUndefined(this.$K_0)) {
            this.$K_0.$B4($p0);
        }
        this.$Av($p0);
    },
    
    $1g: function($p0) {
        return true;
    },
    
    $Av: function($p0) {
    },
    
    getTextValue: function() {ULSpEN:;
        return null;
    },
    
    receiveFocus: function() {
    },
    
    onMenuClosed: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$4_0)) {
            return;
        }
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_0 = $$enum_1_0.get_current();
            $v_0.onMenuClosed();
        }
    },
    
    $3U_0: null,
    $5I_0: null,
    $5J_0: null,
    
    $7k: function($p0, $p1, $p2) {
        this.$3U_0 = $p0;
        this.$5I_0 = $p1;
        this.$5J_0 = $p2;
    },
    
    $6G_0: false,
    
    doDelayedInit: function() {ULSpEN:;
        if (this.$6G_0) {
            return;
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$3U_0)) {
            throw Error.create('No delayedinit handler present in this component: ' + this.$6_0);
        }
        this.$6G_0 = true;
        this.$3U_0(this, this.$5I_0, this.$5J_0);
    },
    
    $4v: function($p0) {
        if ($p0) {
            this.$3U_0 = null;
            this.$5I_0 = null;
            this.$5J_0 = null;
            this.$w();
        }
        this.$6G_0 = false;
    },
    
    get_needsDelayIniting: function() {ULSpEN:;
        return !CUI.ScriptUtility.isNullOrUndefined(this.$3U_0);
    },
    
    $2P: function() {ULSpEN:;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_0 = $$enum_1_0.get_current();
            $v_0.$2P();
        }
    },
    
    $4Z_0: null,
    
    get_$40: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$4Z_0)) {
            this.$4Z_0 = new Date();
            this.$4Z_0.setTime(0);
        }
        return this.$4Z_0;
    },
    set_$40: function($p0) {
        this.$4Z_0 = $p0;
        return $p0;
    },
    
    get_$B5: function() {ULSpEN:;
        return this.get_$40().getTime() < this.$0_0.get_$40().getTime();
    },
    
    $B2: function() {ULSpEN:;
        if (this.get_$B5()) {
            this.$2P();
        }
    },
    
    dispose: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$4_0)) {
            var $$enum_2_0 = this.$4_0.getEnumerator();
            while ($$enum_2_0.moveNext()) {
                var $v_0 = $$enum_2_0.get_current();
                $v_0.dispose();
            }
            this.$4_0 = null;
        }
        this.$K_0 = null;
        this.$0_0 = null;
        this.$5I_0 = null;
        this.$3U_0 = null;
        this.$5J_0 = null;
        this.$2q_0 = null;
    }
}


CUI.ContextMenu = function(root, id, title, description, maxWidth) {ULSpEN:;
    CUI.ContextMenu.initializeBase(this, [ root, id, title, description, maxWidth ]);
}
CUI.ContextMenu.prototype = {
    
    $L: function() {ULSpEN:;
        if (this.get_needsDelayIniting()) {
            this.doDelayedInit();
        }
        this.ensureDOMElementAndEmpty();
        if (CUI.ScriptUtility.isNullOrUndefined(this.$Q_1)) {
            this.$Q_1 = CUI.Utility.$3('div');
            this.$Q_1.className = 'ms-cui-contextmenu-inner';
        }
        this.get_$2().appendChild(this.$Q_1);
        this.appendChildrenToElement(this.$Q_1);
        CUI.ContextMenu.callBaseMethod(this, '$L');
    },
    
    get_cssClass: function() {ULSpEN:;
        return 'ms-cui-contextmenu';
    }
}


CUI.ContextMenuDock = function(root, id) {ULSpEN:;
    CUI.ContextMenuDock.initializeBase(this, [ root, id, '', '' ]);
}
CUI.ContextMenuDock.prototype = {
    
    $L: function() {ULSpEN:;
        this.ensureDOMElementAndEmpty();
        this.appendChildrenToElement(this.get_$2());
        CUI.ContextMenuDock.callBaseMethod(this, '$L');
    },
    
    ensureCorrectChildType: function($p0) {
        if (!CUI.ControlComponent.isInstanceOfType($p0)) {
            throw Error.create('Only children of type Control can be added to Strips.');
        }
    },
    
    get_visibleInDOM: function() {ULSpEN:;
        return true;
    }
}


CUI.ContextMenuLauncher = function(root, id, properties, menu) {ULSpEN:;
    CUI.ContextMenuLauncher.initializeBase(this, [ root, id, properties, menu ]);
}
CUI.ContextMenuLauncher.prototype = {
    $5X_2: null,
    $6y_2: null,
    $9n_2: 0,
    $9o_2: 0,
    
    $Ah: function($p0, $p1) {
        this.$6y_2 = $p1;
        this.$5X_2 = this.getMenuPosition($p0, null);
        this.launchMenu(null);
        this.$B_1.$1r();
        return true;
    },
    
    launchContextMenuAt: function($p0, $p1, $p2) {
        this.$9n_2 = $p1;
        this.$9o_2 = $p2;
        this.$6y_2 = $p0;
        this.launchMenu(null);
        this.$B_1.$1r();
        return true;
    },
    
    positionMenu: function($p0, $p1) {
        if (this.$5X_2) {
            this.$B_1.get_$2().style.top = this.$5X_2.y + 'px';
            this.$B_1.get_$2().style.left = this.$5X_2.x + 'px';
            this.$B_1.get_$2().style.position = 'absolute';
        }
        else {
            $p0.style.top = '0px';
            $p0.style.left = '0px';
            var $v_0 = this.getAllElementDimensions($p0, this.$6y_2);
            $v_0['launcherLeft'] = this.$9n_2;
            $v_0['launcherTop'] = this.$9o_2;
            $v_0['launcherWidth'] = 0;
            $v_0['launcherHeight'] = 0;
            this.$0_0.$7m($p0, $v_0, false);
        }
    },
    
    getMenuPosition: function($p0, $p1) {
        var $v_0 = new Sys.UI.Bounds(0, 0, 0, 0);
        if (!$p0) {
            $p0 = window.event;
        }
        $v_0.y = $p0.clientY;
        $v_0.x = $p0.clientX;
        return $v_0;
    }
}


CUI.ContextMenuRootProperties = function() {ULSpEN:;
    CUI.ContextMenuRootProperties.initializeBase(this);
}
CUI.ContextMenuRootProperties.prototype = {
    CommandMenuOpen: null,
    CommandMenuClose: null
}


CUI.ContextMenuRoot = function(id, properties) {ULSpEN:;
    this.$5H_2 = {};
    CUI.ContextMenuRoot.initializeBase(this, [ id, properties ]);
}
CUI.ContextMenuRoot.prototype = {
    
    refresh: function() {ULSpEN:;
        this.$L();
        CUI.ContextMenuRoot.callBaseMethod(this, '$L');
    },
    
    $L: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this.$m();
        }
        this.set_$2(CUI.Utility.removeChildNodes(this.get_$2()));
        this.appendChildrenToElement(this.get_$2());
        this.$g_0 = false;
    },
    
    get_rootType: function() {ULSpEN:;
        return 'ContextMenu';
    },
    
    get_$18: function() {ULSpEN:;
        if (!CUI.ContextMenuRoot.callBaseMethod(this, 'get_$18')) {
            var $v_0 = new CUI.BuildOptions();
            $v_0.lazyMenuInit = false;
            CUI.ContextMenuRoot.callBaseMethod(this, 'set_$18', [ new CUI.Builder($v_0, null, null) ]);
            CUI.ContextMenuRoot.callBaseMethod(this, 'get_$18').$0_0 = this;
        }
        return CUI.ContextMenuRoot.callBaseMethod(this, 'get_$18');
    },
    set_$18: function($p0) {
        CUI.ContextMenuRoot.callBaseMethod(this, 'set_$18', [ $p0 ]);
        return $p0;
    },
    
    get_contextMenuRootProperties: function() {ULSpEN:;
        return this.$5_1;
    },
    
    ensureCorrectChildType: function(child) {ULSpEN:;
        if (!CUI.ContextMenuDock.isInstanceOfType(child)) {
            throw Error.create('Only children of type ContextMenuDock can be added to a ContextMenuRoot');
        }
    },
    
    createContextMenu: function(props, id, title, description, maxWidth) {ULSpEN:;
        var $v_0 = new CUI.ContextMenu(this, id, title, description, null);
        if (!props) {
            props = new CUI.Controls.ContextMenuControlProperties();
        }
        props.CommandMenuOpen = this.get_contextMenuRootProperties().CommandMenuOpen;
        props.CommandMenuClose = this.get_contextMenuRootProperties().CommandMenuClose;
        var $v_1 = new CUI.Controls.ContextMenuControl(this, id + 'Launcher', props, $v_0);
        this.$5H_2[id] = $v_1;
        var $v_2 = new CUI.ContextMenuDock(this, 'dock' + id);
        $v_2.addChild($v_1.createComponentForDisplayMode('Menu'));
        this.addChild($v_2);
        this.refresh();
    },
    
    showContextMenu: function(id, triggeringEvent, focusedElement) {ULSpEN:;
        var $v_0 = this.$5H_2[id];
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            throw Error.create('The context menu \"' + id + '\" does not exist');
        }
        $v_0.$Ah(triggeringEvent, focusedElement);
    },
    
    showContextMenuAt: function(id, elmHadFocus, x, y) {ULSpEN:;
        var $v_0 = this.$5H_2[id];
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            throw Error.create('The context menu \"' + id + '\" does not exist');
        }
        $v_0.launchContextMenuAt(elmHadFocus, x, y);
    }
}


CUI.ControlProperties = function() {
}
CUI.ControlProperties.prototype = {
    Command: null,
    Id: null,
    TemplateAlias: null,
    ToolTipDescription: null,
    ToolTipHelpKeyWord: null,
    ToolTipImage32by32: null,
    ToolTipImage32by32Class: null,
    ToolTipImage32by32Top: null,
    ToolTipImage32by32Left: null,
    ToolTipSelectedItemTitle: null,
    ToolTipShortcutKey: null,
    ToolTipTitle: null,
    LabelCss: null
}


CUI.Control = function(root, id, properties) {ULSpEN:;
    this.$3J = Function.createDelegate(this, this.onDblClick);
    this.$8H = Function.createDelegate(this, this.onHelpKeyPress);
    this.$7y = Function.createDelegate(this, this.$X);
    this.$65 = Function.createDelegate(this, this.launchToolTip);
    this.$0_0 = root;
    this.$6_0 = id;
    this.$5_0 = properties;
    this.$k_0 = [];
    this.$4F_0 = ',';
    this.$2n_0 = {};
    root.$Du(this);
}
CUI.Control.createStandardControlDOMElement = function($p0, $p1, $p2, $p3, $p4, $p5) {
    var $v_0 = $p3;
    return CUI.Control.createStandardControlDOMElementCore($p0, $p1, $p2, $v_0.Id, $v_0.Image32by32, $v_0.Image32by32Class, $v_0.Image32by32Top, $v_0.Image32by32Left, $v_0.Image16by16, $v_0.Image16by16Class, $v_0.Image16by16Top, $v_0.Image16by16Left, $v_0.LabelText, $v_0.LabelCss, $v_0.Alt, $v_0.Description, $v_0.ToolTipTitle, $p4, $p5);
}
CUI.Control.createStandardControlDOMElementCore = function($p0, $p1, $p2, $p3, $p4, $p5, $p6, $p7, $p8, $p9, $p10, $p11, $p12, $p13, $p14, $p15, $p16, $p17, $p18) {
    if (CUI.ScriptUtility.isNullOrUndefined($p12)) {
        $p12 = '';
    }
    var $v_0 = false;
    var $v_1 = true;
    var $v_2 = CUI.Utility.$4q();
    var $v_3 = null;
    if ($p2 === 'Large') {
        $v_3 = 'ms-cui-ctl-large';
    }
    else if ($p2 === 'Medium') {
        $v_3 = 'ms-cui-ctl-medium';
    }
    else if ($p2 === 'Menu16' || $p2 === 'Menu') {
        $v_3 = 'ms-cui-ctl-menu';
        $v_0 = true;
    }
    else if ($p2 === 'Menu32') {
        $v_3 = 'ms-cui-ctl-menu ms-cui-ctl-menu32';
        $v_0 = true;
    }
    else {
        $v_3 = 'ms-cui-ctl';
    }
    CUI.Utility.ensureCSSClassOnElement($v_2, $v_3);
    if ($p2 === 'Menu') {
        CUI.Utility.ensureCSSClassOnElement($v_2, 'ms-cui-textmenuitem');
    }
    if (!CUI.ScriptUtility.isNullOrUndefined($p16)) {
        $v_2.setAttribute('aria-describedby', $p3 + '_ToolTip');
    }
    $v_2.setAttribute('mscui:controltype', $p0.get_$15());
    var $v_4 = CUI.Utility.$3('img');
    var $v_5 = null;
    var $v_6 = null;
    var $v_7 = null;
    var $v_8 = null;
    var $v_9 = 0;
    $v_4.alt = '';
    $p14 = (CUI.ScriptUtility.isNullOrEmptyString($p14)) ? $p12 : $p14;
    $v_2.setAttribute('role', $p0.get_$1e());
    if (CUI.Controls.FlyoutAnchor.isInstanceOfType($p0)) {
        $v_2.setAttribute('aria-haspopup', 'true');
    }
    if (CUI.ScriptUtility.isNullOrEmptyString($p16)) {
        $v_2.title = $p14;
        $v_4.alt = $p14;
        $v_1 = false;
    }
    if ($p2 === 'Large' || $p2 === 'Menu32') {
        $v_5 = $p4;
        $v_6 = $p5;
        $v_7 = $p6;
        $v_8 = $p7;
        $v_9 = 4;
    }
    else {
        $v_5 = $p8;
        $v_6 = $p9;
        $v_7 = $p10;
        $v_8 = $p11;
        $v_9 = 3;
    }
    var $v_A = CUI.Utility.$j(2, $v_9, $v_5, $v_6, $v_4, true, false, $v_7, $v_8);
    var $v_B = CUI.Utility.$3('span');
    $v_B.className = ($p2 === 'Large') ? 'ms-cui-ctl-largeIconContainer' : 'ms-cui-ctl-iconContainer';
    $v_B.appendChild($v_A);
    var $v_C = null;
    var $v_D = null;
    if ($v_1) {
        $v_D = CUI.Utility.$2h($p14);
    }
    if ($p2 !== 'Small' || $p18) {
        $v_C = CUI.Utility.$3('span');
        if ($p2 !== 'Small') {
            if ($p2 === 'Large') {
                CUI.Utility.ensureCSSClassOnElement($v_C, 'ms-cui-ctl-largelabel');
                $v_C.innerHTML = CUI.Utility.$AH($p12, $p18);
            }
            else {
                var $v_I = $p12;
                if ($p18) {
                    $v_I = $v_I + ' ';
                }
                CUI.Utility.ensureCSSClassOnElement($v_C, 'ms-cui-ctl-mediumlabel');
                CUI.UIUtility.setInnerText($v_C, $v_I);
            }
            if (!CUI.ScriptUtility.isNullOrEmptyString($p13)) {
                $v_C.style.cssText = $p13;
            }
        }
        else {
            CUI.Utility.ensureCSSClassOnElement($v_C, 'ms-cui-ctl-smalllabel');
            CUI.UIUtility.setInnerText($v_C, ' ');
        }
    }
    else if ($v_1) {
        $v_C = CUI.Utility.$2h($p14);
    }
    var $v_E = null;
    if ($p18) {
        var $v_J = CUI.Utility.$3('img');
        $v_J.alt = '';
        if (CUI.ScriptUtility.isNullOrEmptyString($p16)) {
            $v_J.alt = $p14;
        }
        $v_E = CUI.Utility.$j(2, 1, $p1.$5_1.ImageDownArrow, $p1.$5_1.ImageDownArrowClass, $v_J, true, false, $p1.$5_1.ImageDownArrowTop, $p1.$5_1.ImageDownArrowLeft);
    }
    var $v_F = null;
    var $v_G = null;
    var $v_H = null;
    if ($p2 === 'Menu32') {
        $v_F = CUI.Utility.$3('span');
        $v_F.className = 'ms-cui-ctl-menulabel';
        CUI.Utility.ensureCSSClassOnElement($v_C, 'ms-cui-btn-title');
        $v_F.appendChild($v_C);
        if (!CUI.ScriptUtility.isNullOrUndefined($p15)) {
            $v_G = CUI.Utility.$3('span');
            CUI.Utility.ensureCSSClassOnElement($v_G, 'ms-cui-btn-menu-description');
            CUI.Utility.$2k($v_G, $p15);
            $v_G.style.display = 'block';
            $v_F.appendChild($v_G);
        }
        $v_H = CUI.Utility.$3('span');
        $v_H.className = 'ms-cui-ctl-menu32clear';
        $v_H.innerHTML = '&nbsp;';
    }
    $v_2.appendChild($v_B);
    if (!CUI.ScriptUtility.isNullOrUndefined($v_C)) {
        if (!CUI.ScriptUtility.isNullOrUndefined($v_F)) {
            $v_2.appendChild($v_F);
            $v_2.appendChild($v_H);
        }
        else {
            $v_2.appendChild($v_C);
            if ($p2 === 'Small' && $p18 && $v_1) {
                $v_2.appendChild($v_D);
            }
        }
        if (!CUI.ScriptUtility.isNullOrUndefined($v_E)) {
            $v_C.appendChild($v_E);
        }
    }
    if ($v_0) {
        var $v_K = CUI.Utility.$A3();
        $v_2.appendChild($v_K);
    }
    return $v_2;
}
CUI.Control.createTwoAnchorControlDOMElementCore = function($p0, $p1, $p2, $p3, $p4, $p5, $p6, $p7, $p8, $p9, $p10, $p11, $p12, $p13, $p14, $p15) {
    var $v_0 = true;
    if (CUI.ScriptUtility.isNullOrUndefined($p12)) {
        $p12 = '';
    }
    var $v_1 = CUI.Utility.$3('span');
    if ($p2 === 'Large') {
        $v_1.className = 'ms-cui-ctl-large';
    }
    else if ($p2 === 'Medium') {
        $v_1.className = 'ms-cui-ctl ms-cui-ctl-medium';
    }
    else {
        $v_1.className = 'ms-cui-ctl ms-cui-ctl-small';
    }
    if (!CUI.ScriptUtility.isNullOrUndefined($p14)) {
        $v_1.setAttribute('aria-describedby', $p3 + '_ToolTip');
    }
    $v_1.setAttribute('mscui:controltype', $p0.get_$15());
    var $v_2 = CUI.Utility.$4q();
    var $v_3 = CUI.Utility.$4q();
    $v_2.className = 'ms-cui-ctl-a1';
    $v_3.className = 'ms-cui-ctl-a2';
    $p13 = (CUI.ScriptUtility.isNullOrEmptyString($p13)) ? $p12 : $p13;
    $v_2.setAttribute('role', $p0.get_$1e());
    $v_3.setAttribute('role', $p0.get_$1e());
    $v_3.setAttribute('aria-haspopup', 'true');
    var $v_4 = CUI.Utility.$3('span');
    $v_4.className = 'ms-cui-ctl-a1Internal';
    var $v_5 = CUI.Utility.$3('img');
    var $v_6 = null;
    var $v_7 = null;
    var $v_8 = null;
    var $v_9 = null;
    var $v_A = 0;
    $v_5.alt = '';
    if (CUI.ScriptUtility.isNullOrEmptyString($p14)) {
        $v_2.title = $p13;
        $v_3.title = $p13;
        $v_5.alt = $p13;
        $v_0 = false;
    }
    if ($p2 === 'Large' || $p2 === 'Menu32') {
        $v_6 = $p4;
        $v_7 = $p5;
        $v_8 = $p6;
        $v_9 = $p7;
        $v_A = 4;
    }
    else {
        $v_6 = $p8;
        $v_7 = $p9;
        $v_8 = $p10;
        $v_9 = $p11;
        $v_A = 3;
    }
    var $v_B = CUI.Utility.$j(2, $v_A, $v_6, $v_7, $v_5, true, false, $v_8, $v_9);
    var $v_C = null;
    var $v_D = null;
    if ($v_0) {
        $v_C = CUI.Utility.$2h($p13);
        $v_D = CUI.Utility.$2h($p13);
    }
    var $v_E = null;
    if ($p2 !== 'Small' || $p15) {
        $v_E = CUI.Utility.$3('span');
        if ($p2 !== 'Small') {
            if ($p2 === 'Large') {
                CUI.Utility.ensureCSSClassOnElement($v_E, 'ms-cui-ctl-largelabel');
                $v_E.innerHTML = CUI.Utility.$AH($p12, $p15);
            }
            else if ($p2 === 'Medium') {
                CUI.Utility.ensureCSSClassOnElement($v_E, 'ms-cui-ctl-mediumlabel');
                CUI.UIUtility.setInnerText($v_E, $p12);
            }
        }
    }
    var $v_F = null;
    if ($p15) {
        var $v_G = CUI.Utility.$3('img');
        if (CUI.ScriptUtility.isNullOrEmptyString($p14)) {
            $v_G.alt = $p13;
        }
        $v_F = CUI.Utility.$j(2, 1, $p1.$5_1.ImageDownArrow, $p1.$5_1.ImageDownArrowClass, $v_G, true, false, $p1.$5_1.ImageDownArrowTop, $p1.$5_1.ImageDownArrowLeft);
    }
    $v_1.appendChild($v_2);
    $v_1.appendChild($v_3);
    $v_2.appendChild($v_4);
    $v_4.appendChild($v_B);
    if (!CUI.ScriptUtility.isNullOrUndefined($v_E)) {
        if ($p2 === 'Large') {
            $v_3.appendChild($v_E);
            if ($v_0) {
                $v_2.appendChild($v_C);
            }
        }
        else {
            $v_4.appendChild($v_E);
            if ($v_0) {
                $v_3.appendChild($v_D);
            }
        }
        if ($p2 === 'Small' && $v_0) {
            $v_2.appendChild($v_C);
        }
    }
    if (!CUI.ScriptUtility.isNullOrUndefined($v_F)) {
        if ($p2 === 'Large') {
            $v_E.appendChild($v_F);
        }
        else {
            $v_3.appendChild($v_F);
        }
    }
    return $v_1;
}
CUI.Control.prototype = {
    $0_0: null,
    $6_0: null,
    $k_0: null,
    $5_0: null,
    $4F_0: null,
    $2n_0: null,
    $1T_0: null,
    $5j_0: false,
    $70_0: null,
    $6z_0: null,
    $1Q_0: false,
    $5U_0: false,
    
    get_controlProperties: function() {ULSpEN:;
        return this.$5_0;
    },
    
    $6w_0: null,
    
    get_stateProperties: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$6w_0)) {
            this.$6w_0 = {};
        }
        return this.$6w_0;
    },
    
    $6C_0: null,
    
    get_commandProperties: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$6C_0)) {
            this.$6C_0 = {};
        }
        return this.$6C_0;
    },
    
    get_templateAlias: function() {ULSpEN:;
        return this.$5_0.TemplateAlias;
    },
    
    get_$15: function() {ULSpEN:;
        return 'Control';
    },
    
    get_$1e: function() {ULSpEN:;
        return 'button';
    },
    
    ensureValidDisplayMode: function($p0) {
        if (this.$4F_0.indexOf(',' + $p0 + ',') !== -1) {
            return;
        }
        throw Error.create('The display mode with name: ' + $p0 + ' is not valid for this control with id: ' + this.$6_0);
    },
    
    refreshDOMElements: function() {ULSpEN:;
        this.onStateChanged();
        if (!this.get_enabled()) {
            this.onEnabledChanged(false);
        }
    },
    
    onStateChanged: function() {
    },
    
    $6D_0: null,
    
    getDOMElementForDisplayMode: function($p0) {
        this.ensureValidDisplayMode($p0);
        var $v_0 = this.$2n_0[$p0];
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return $v_0;
        }
        this.$6D_0 = $p0;
        $v_0 = this.createDOMElementForDisplayMode($p0);
        this.$6D_0 = null;
        if (CUI.ScriptUtility.isNullOrEmptyString($v_0.id)) {
            $v_0.id = this.$6_0 + '-' + $p0;
        }
        this.storeElementForDisplayMode($v_0, $p0);
        this.refreshDOMElements();
        return $v_0;
    },
    
    storeElementForDisplayMode: function($p0, $p1) {
        this.$2n_0[$p1] = $p0;
    },
    
    $35: function($p0) {
        var $v_0 = $get(this.$6_0 + '-' + $p0);
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            this.storeElementForDisplayMode($v_0, $p0);
        }
    },
    
    $O: function($p0) {
    },
    
    createComponentForDisplayMode: function($p0) {
        var $v_0 = this.createComponentForDisplayModeInternal($p0);
        Array.add(this.$k_0, $v_0);
        return $v_0;
    },
    
    get_components: function() {ULSpEN:;
        return this.$k_0;
    },
    
    createComponentForDisplayModeInternal: function($p0) {
        var $v_0 = this.$0_0.$CH(this.$6_0 + '-' + $p0 + this.$0_0.$27(), $p0, this);
        return $v_0;
    },
    
    dispose: function() {ULSpEN:;
        this.releaseEventHandlers();
        this.$0_0 = null;
        this.$k_0 = null;
        this.$4F_0 = null;
        var $$dict_1_0 = this.$2n_0;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_0 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            delete this.$2n_0[$v_0.key];
        }
        this.$2n_0 = null;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$1T_0)) {
            this.$1T_0.dispose();
        }
    },
    
    releaseEventHandlers: function() {ULSpEN:;
        var $$dict_1_0 = this.$2n_0;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_0 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            CUI.Utility.$7d($v_0.value);
        }
    },
    
    get_id: function() {ULSpEN:;
        return this.$6_0;
    },
    
    get_root: function() {ULSpEN:;
        return this.$0_0;
    },
    
    addDisplayMode: function($p0) {
        if (this.$4F_0.indexOf(',' + $p0 + ',') !== -1) {
            return;
        }
        this.$4F_0 += $p0 + ',';
    },
    
    ensureCorrectChildType: function($p0) {
        if (!(CUI.ToolTip.isInstanceOfType($p0))) {
            throw Error.create('Child Components may not be added to this type of ControlComponent.');
        }
    },
    
    get_displayedComponent: function() {ULSpEN:;
        var $v_0 = this.$k_0.length;
        for (var $v_1 = 0; $v_1 < $v_0; $v_1++) {
            var $v_2 = this.$k_0[$v_1];
            if ($v_2.get_visibleInDOM()) {
                return $v_2;
            }
        }
        return null;
    },
    
    $1g: function($p0) {
        return true;
    },
    
    $Av: function($p0) {
    },
    
    onMenuClosed: function() {
    },
    
    onClick: function($p0) {
        $p0.preventDefault();
    },
    
    onDblClick: function($p0) {
        $p0.preventDefault();
        if (!this.get_enabled()) {
            return;
        }
        if (Sys.Browser.agent === Sys.Browser.InternetExplorer) {
            this.onClick($p0);
        }
    },
    
    onBeginFocus: function() {ULSpEN:;
        window.clearInterval(this.$0_0.$2d_1);
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$0_0.$33_1)) {
            if (this.$0_0.$33_1.$6_0 === this.$6_0) {
                this.launchToolTip();
                return;
            }
            else {
                this.$0_0.$2f();
                this.$0_0.$2d_1 = window.setTimeout(this.$65, 500);
            }
        }
        else {
            this.$0_0.$2d_1 = window.setTimeout(this.$65, 500);
        }
    },
    
    onEndFocus: function() {ULSpEN:;
        window.clearInterval(this.$0_0.$2d_1);
        if (this.$5j_0) {
            this.$0_0.$2d_1 = window.setTimeout(this.$7y, 100);
        }
    },
    
    onToolTipOpenned: function() {ULSpEN:;
        this.$70_0 = this.$8H;
        this.$6z_0 = this.$1T_0.$1H;
        $addHandler(document, 'keydown', this.$70_0);
        $addHandler(document, 'click', this.$6z_0);
    },
    
    onToolTipClosed: function() {ULSpEN:;
        $removeHandler(document, 'keydown', this.$70_0);
        $removeHandler(document, 'click', this.$6z_0);
    },
    
    onHelpKeyPress: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$1T_0)) {
            this.$1T_0.$Ar($p0);
        }
    },
    
    launchToolTip: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$0_0)) {
            return;
        }
        window.clearInterval(this.$0_0.$2d_1);
        if (this.$5j_0) {
            return;
        }
        if ((!CUI.ScriptUtility.isNullOrUndefined(this.$0_0.$33_1)) && (this.$0_0.$33_1.$6_0 !== this.$6_0)) {
            this.$0_0.$2f();
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$5_0.ToolTipTitle)) {
            return;
        }
        this.$1T_0 = new CUI.ToolTip(this.$0_0, this.$6_0 + '_ToolTip', this.$5_0.ToolTipTitle, this.$5_0.ToolTipDescription, this.$5_0);
        if (!this.get_enabled()) {
            var $v_1 = new CUI.DisabledCommandInfoProperties();
            $v_1.Icon = this.$0_0.$5_1.ToolTipDisabledCommandImage16by16;
            $v_1.IconClass = this.$0_0.$5_1.ToolTipDisabledCommandImage16by16Class;
            $v_1.IconTop = this.$0_0.$5_1.ToolTipDisabledCommandImage16by16Top;
            $v_1.IconLeft = this.$0_0.$5_1.ToolTipDisabledCommandImage16by16Left;
            $v_1.Title = this.$0_0.$5_1.ToolTipDisabledCommandTitle;
            $v_1.Description = this.$0_0.$5_1.ToolTipDisabledCommandDescription;
            $v_1.HelpKeyWord = this.$0_0.$5_1.ToolTipDisabledCommandHelpKey;
            this.$1T_0.$1C_1 = $v_1;
        }
        var $v_0 = this.get_displayedComponent();
        $v_0.$7D();
        $v_0.addChild(this.$1T_0);
        this.$1T_0.$CT();
        this.$5j_0 = true;
        this.$0_0.$33_1 = this;
        this.onToolTipOpenned();
    },
    
    $X: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$0_0)) {
            window.clearInterval(this.$0_0.$2d_1);
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$1T_0)) {
            this.$1T_0.$Aa();
            this.$5j_0 = false;
            this.onToolTipClosed();
            CUI.UIUtility.removeNode(this.$1T_0.get_$2());
            this.$1T_0 = null;
        }
    },
    
    get_enabled: function() {ULSpEN:;
        return this.$1Q_0;
    },
    set_enabled: function($p0) {
        if (this.$1Q_0 === $p0 && this.$5U_0) {
            return;
        }
        this.$1Q_0 = $p0;
        this.$5U_0 = true;
        this.onEnabledChanged($p0);
        return $p0;
    },
    
    get_enabledInternal: function() {ULSpEN:;
        return this.$1Q_0;
    },
    set_enabledInternal: function($p0) {
        this.$1Q_0 = $p0;
        return $p0;
    },
    
    $E3: function($p0) {
        this.$1Q_0 = $p0;
        this.onEnabledChanged($p0);
    },
    
    $4y: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$5_0.Command)) {
            this.pollForStateAndUpdateInternal(this.$5_0.Command, null, null, false);
        }
    },
    
    pollForStateAndUpdateInternal: function($p0, $p1, $p2, $p3) {
        var $v_0 = (this.$0_0.$B1($p0, $p1, $p2, $p3) & 1) > 0;
        this.set_enabled($v_0);
        return $v_0;
    },
    
    getTextValue: function() {ULSpEN:;
        return '';
    },
    
    receiveFocus: function() {
    },
    
    $2i: function() {ULSpEN:;
        return this.$AI_0();
    },
    
    $2j: function() {ULSpEN:;
        return this.$AI_0();
    },
    
    $AI_0: function() {ULSpEN:;
        var $v_0 = this.get_displayedComponent();
        if (!CUI.MenuItem.isInstanceOfType($v_0)) {
            return false;
        }
        if (!($v_0).get_$1G()) {
            (this).receiveFocus();
            return true;
        }
        return false;
    },
    
    $C7: function() {
    },
    
    $5p: function() {ULSpEN:;
        var $v_0 = this.get_displayedComponent();
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return null;
        }
        return $v_0.get_$2();
    },
    
    $7o: function() {ULSpEN:;
        return false;
    }
}


CUI.ControlComponent = function(root, id, displayMode, control) {ULSpEN:;
    CUI.ControlComponent.initializeBase(this, [ root, id, displayMode, '' ]);
    this.$M_1 = control;
}
CUI.ControlComponent.prototype = {
    $M_1: null,
    
    get_displayMode: function() {ULSpEN:;
        return this.get_title();
    },
    
    createChildArray: function() {
    },
    
    $L: function() {ULSpEN:;
        this.$g_0 = false;
    },
    
    $3v: function() {ULSpEN:;
        this.$M_1.$35(this.get_displayMode());
    },
    
    $N: function() {ULSpEN:;
        this.$M_1.$O(this.get_displayMode());
    },
    
    get_$2: function() {ULSpEN:;
        return this.$M_1.getDOMElementForDisplayMode(this.get_title());
    },
    set_$2: function($p0) {
        throw Error.create('Cannot set the DOM Element of ControlComponents.  They get their DOM Elements from the Control.');
        return $p0;
    },
    
    get_componentElement: function() {ULSpEN:;
        return CUI.ControlComponent.callBaseMethod(this, 'get_$2');
    },
    
    get_enabled: function() {ULSpEN:;
        return this.$M_1.get_enabled();
    },
    set_enabled: function($p0) {
        this.$M_1.set_enabled($p0);
        return $p0;
    },
    
    get_$EM: function() {ULSpEN:;
        if ((this._componentWidth === -1 || this.valueIsDirty(this._lastWidthUpdate)) && !CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this._componentWidth = this.get_$2().offsetWidth;
        }
        return this._componentWidth;
    },
    
    get_$77: function() {ULSpEN:;
        if ((this._componentHeight === -1 || this.valueIsDirty(this._lastHeightUpdate)) && !CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this._componentHeight = this.get_$2().offsetHeight;
        }
        return this._componentHeight;
    },
    
    get_$4p: function() {ULSpEN:;
        if ((this._componentTopPosition === -1 || this.valueIsDirty(this._lastTopUpdate)) && !CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this._componentTopPosition = CUI.UIUtility.calculateOffsetTop(this.get_$2());
        }
        return this._componentTopPosition;
    },
    
    get_$EN: function() {ULSpEN:;
        if ((this._componentLeftPosition === -1 || this.valueIsDirty(this._lastLeftUpdate)) && !CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this._componentLeftPosition = CUI.UIUtility.calculateOffsetLeft(this.get_$2());
        }
        return this._componentLeftPosition;
    },
    
    $E4: function($p0) {
        this.$M_1.$E3($p0);
    },
    
    $4m: function($p0) {
        return this.$M_1.createComponentForDisplayMode(this.get_displayMode());
    },
    
    onEnabledChanged: function($p0) {
        this.$M_1.onEnabledChanged($p0);
    },
    
    ensureCorrectChildType: function($p0) {
        this.$M_1.ensureCorrectChildType($p0);
    },
    
    $1g: function($p0) {
        return this.$M_1.$1g($p0);
    },
    
    $Av: function($p0) {
        this.$M_1.$Av($p0);
    },
    
    get_textValue: function() {ULSpEN:;
        return (this.$M_1).getTextValue();
    },
    
    $2P: function() {ULSpEN:;
        this.$M_1.$4y();
    },
    
    receiveFocus: function() {ULSpEN:;
        (this.$M_1).receiveFocus();
    },
    
    onMenuClosed: function() {ULSpEN:;
        (this.$M_1).onMenuClosed();
    },
    
    $50: function() {ULSpEN:;
        return this.$M_1.$7o();
    },
    
    dispose: function() {ULSpEN:;
        this.$M_1.dispose();
        this.$M_1 = null;
        CUI.ControlComponent.callBaseMethod(this, 'dispose');
    }
}


CUI.DataQueryResult = function() {
}
CUI.DataQueryResult.prototype = {
    success: false,
    id: null,
    queryData: null,
    contextData: null
}


CUI.DataQuery = function() {
}
CUI.DataQuery.prototype = {
    dataUrl: null,
    version: null,
    lcid: null,
    id: null,
    queryType: 0,
    handler: null,
    data: null
}


CUI.DataSource = function(dataUrl, version, lcid) {ULSpEN:;
    this.$8F = Function.createDelegate(this, this.onDataReturned);
    this.$6E_0 = dataUrl;
    this.$71_0 = version;
    this.$6c_0 = lcid;
    this.$BS_0 = {};
}
CUI.DataSource.prototype = {
    $6E_0: null,
    $BS_0: null,
    $71_0: null,
    $6c_0: null,
    
    get_dataUrl: function() {ULSpEN:;
        return this.$6E_0;
    },
    
    get_version: function() {ULSpEN:;
        return this.$71_0;
    },
    
    get_lcid: function() {ULSpEN:;
        return this.$6c_0;
    },
    
    runQuery: function(query) {ULSpEN:;
        var $v_0 = this.$71_0;
        if (!CUI.ScriptUtility.isNullOrUndefined(query.version)) {
            $v_0 = query.version;
        }
        var $v_1 = this.$6c_0;
        if (!CUI.ScriptUtility.isNullOrUndefined(query.lcid)) {
            $v_1 = query.lcid;
        }
        var $v_2 = this.$6E_0;
        if (!CUI.ScriptUtility.isNullOrUndefined(query.dataUrl)) {
            $v_2 = query.dataUrl;
        }
        var $v_3;
        var $v_4 = null;
        if ($v_2.indexOf('?') === -1) {
            $v_3 = $v_2 + '?ver=';
        }
        else {
            $v_3 = $v_2 + '&ver=';
        }
        $v_3 = $v_3 + $v_0 + '&id=' + query.id + '&lcid=' + $v_1 + '&qt=';
        switch (query.queryType) {
            case 1:
                $v_4 = 'all';
                break;
            case 4:
                $v_4 = 'ribbontab';
                break;
            case 3:
                $v_4 = 'ribbonshallow';
                break;
            case 5:
                $v_4 = 'root';
                break;
            case 2:
                $v_4 = 'ribbonvisibletabdeep';
                break;
        }
        $v_3 += $v_4;
        CUI.PMetrics.perfMark(7109);
        var $v_5 = new Sys.Net.WebRequest();
        $v_5.set_httpVerb('GET');
        $v_5.set_url($v_3);
        var $v_6 = new CUI.QueryRecord();
        $v_6.id = query.id;
        $v_6.queryType = query.queryType;
        $v_6.data = query.data;
        $v_6.handler = query.handler;
        $v_5.set_userContext($v_6);
        $v_5.add_completed(this.$8F);
        $v_5.invoke();
    },
    
    onDataReturned: function(executor) {ULSpEN:;
        CUI.PMetrics.perfMark(7110);
        var $v_0 = executor.get_webRequest().get_userContext();
        var $v_1 = new CUI.DataQueryResult();
        $v_1.contextData = $v_0.data;
        $v_1.id = $v_0.id;
        if (executor.get_responseAvailable()) {
            $v_1.success = true;
            $v_1.queryData = executor.get_object();
            $v_0.handler($v_1);
        }
        else {
            $v_1.success = false;
            $v_0.handler($v_1);
        }
    }
}


CUI.Gallery = function(root, id, title, description, properties) {ULSpEN:;
    this.$7_1 = -1;
    CUI.Gallery.initializeBase(this, [ root, id, title, description ]);
    this.$3D_1 = properties;
    this.$4l_1 = parseInt(this.$3D_1.Width);
    this.$5N_1 = CUI.Gallery.$A0(this.$3D_1.ElementDimensions);
}
CUI.Gallery.$A0 = function($p0) {
    switch ($p0) {
        case 'Size16by16':
            return 1;
        case 'Size32by32':
            return 2;
        case 'Size48by48':
            return 3;
        case 'Size64by48':
            return 4;
        case 'Size72by96':
            return 5;
        case 'Size96by72':
            return 6;
        case 'Size96by96':
            return 7;
        case 'Size128by128':
            return 8;
        case 'Size190by30':
            return 9;
        case 'Size190by40':
            return 10;
        case 'Size190by50':
            return 11;
        case 'Size190by60':
            return 12;
        default:
            throw Error.argument('s', 'The parameter s is not a valid GalleryElementDimension');
    }
}
CUI.Gallery.prototype = {
    $3D_1: null,
    $5N_1: 0,
    $4l_1: 0,
    $6r_1: null,
    
    get_domElementTagName: function() {ULSpEN:;
        return 'table';
    },
    
    get_cssClass: function() {ULSpEN:;
        return 'ms-cui-gallery';
    },
    
    $L: function() {ULSpEN:;
        this.ensureDOMElementAndEmpty();
        var $v_0 = CUI.Utility.$3('tbody');
        this.get_$2().appendChild($v_0);
        this.appendChildrenToElement($v_0);
    },
    
    appendChildrenToElement: function($p0) {
        var $v_0 = Math.ceil(this.$4_0.$P_0 / this.$4l_1);
        var $v_1;
        var $v_2;
        var $v_3;
        var $v_4 = 0;
        for (var $v_5 = 0; $v_5 < $v_0; $v_5++) {
            $v_1 = CUI.Utility.$3('tr');
            for (var $v_6 = 0; $v_6 < this.$4l_1; $v_6++) {
                $v_2 = CUI.Utility.$3('td');
                $v_2.className = 'ms-cui-gallery-td ms-cui-gallery-element-' + CUI.GalleryElementDimensions.toString(this.$5N_1);
                if ($v_4 < this.$4_0.$P_0) {
                    $v_3 = this.$4_0.get_item($v_4++);
                    $v_3.$m();
                    $v_2.appendChild($v_3.get_$2());
                    $v_3.$2O();
                }
                $v_1.appendChild($v_2);
            }
            $p0.appendChild($v_1);
        }
    },
    
    $6o_1: false,
    
    $1g: function($p0) {
        if (this.$6o_1) {
            return true;
        }
        if ($p0.$G_1 === 3) {
            var $v_0 = $p0.$31_1;
            if (!(CUI.ISelectableControl.isInstanceOfType($v_0.$M_1))) {
                return CUI.Gallery.callBaseMethod(this, '$1g', [ $p0 ]);
            }
            var $v_1 = $v_0.$M_1;
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$6r_1)) {
                this.$6r_1.deselect();
            }
            this.$6r_1 = $v_1;
        }
        if ($p0.$G_1 === 3 || $p0.$G_1 === 7 || $p0.$G_1 === 8) {
            var $v_2;
            switch ($p0.$G_1) {
                case 3:
                    $v_2 = this.$3D_1.Command;
                    break;
                case 7:
                    $v_2 = this.$3D_1.CommandPreview;
                    break;
                case 8:
                    $v_2 = this.$3D_1.CommandRevert;
                    break;
                default:
                    $v_2 = this.$3D_1.Command;
                    break;
            }
            this.$6o_1 = true;
            this.raiseCommandEvent($v_2, $p0.$G_1, $p0.$2z_1);
            this.$6o_1 = false;
            CUI.Gallery.callBaseMethod(this, '$1g', [ $p0 ]);
            return false;
        }
        return CUI.Gallery.callBaseMethod(this, '$1g', [ $p0 ]);
    },
    
    $x: function() {ULSpEN:;
        if (!this.$4_0.$P_0) {
            return;
        }
        this.$7_1 = 0;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_0 = $$enum_1_0.get_current();
            $v_0.$x();
        }
    },
    
    $1r: function() {ULSpEN:;
        if (!this.$4_0.$P_0) {
            return;
        }
        if (this.$7_1 > -1) {
            (this.$4_0.get_item(this.$7_1)).$x();
        }
        this.$7_1 = 0;
        (this.$4_0.get_item(this.$7_1)).$1r();
    },
    
    $3x: function() {ULSpEN:;
        var $v_0 = this.$4_0.$P_0;
        if (!$v_0) {
            return;
        }
        if (this.$7_1 > -1) {
            (this.$4_0.get_item(this.$7_1)).$x();
        }
        this.$7_1 = $v_0 - 1;
        (this.$4_0.get_item(this.$7_1)).$3x();
    },
    
    $5n: function($p0) {
        if (!this.$4_0.$P_0) {
            return false;
        }
        var $v_0 = 0;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_1 = $$enum_1_0.get_current();
            if ($v_1.$5n($p0)) {
                if (this.$7_1 > -1) {
                    (this.$4_0.get_item(this.$7_1)).$x();
                }
                this.$7_1 = $v_0;
                return true;
            }
            $v_0++;
        }
        return false;
    },
    
    $2j: function() {ULSpEN:;
        if (this.$7_1 === -1) {
            this.$7_1 = this.$4_0.$P_0 - 1;
        }
        var $v_0 = this.$7_1;
        var $v_1 = this.$4_0.getEnumeratorAtPos($v_0);
        while ($v_1.movePrevious()) {
            if (($v_1.get_current()).$2j()) {
                if ($v_0 !== this.$7_1) {
                    (this.$4_0.get_item(this.$7_1)).$x();
                    this.$7_1 = $v_0;
                }
                return true;
            }
            $v_0--;
        }
        (this.$4_0.get_item(this.$7_1)).$x();
        this.$7_1 = -1;
        return false;
    },
    
    $2i: function() {ULSpEN:;
        if (this.$7_1 === -1) {
            this.$7_1 = 0;
        }
        var $v_0 = this.$7_1;
        var $v_1 = this.$4_0.getEnumeratorAtPos($v_0);
        while ($v_1.moveNext()) {
            if (($v_1.get_current()).$2i()) {
                if ($v_0 !== this.$7_1) {
                    (this.$4_0.get_item(this.$7_1)).$x();
                    this.$7_1 = $v_0;
                }
                return true;
            }
            $v_0++;
        }
        (this.$4_0.get_item(this.$7_1)).$x();
        this.$7_1 = -1;
        return false;
    },
    
    ensureCorrectChildType: function($p0) {
        if (!CUI.ControlComponent.isInstanceOfType($p0)) {
            throw Error.create('Galleries can only have children controls of type GalleryButton');
        }
        var $v_0 = $p0;
        if (!CUI.Controls.GalleryButton.isInstanceOfType($v_0.$M_1)) {
            throw Error.create('Galleries can only have children of type GalleryButton');
        }
    },
    
    get_elementDimensions: function() {ULSpEN:;
        return this.$5N_1;
    },
    set_elementDimensions: function($p0) {
        this.$5N_1 = $p0;
        return $p0;
    },
    
    get_width: function() {ULSpEN:;
        return this.$4l_1;
    },
    set_width: function($p0) {
        this.$4l_1 = $p0;
        return $p0;
    }
}


CUI.Jewel = function(id, properties) {ULSpEN:;
    CUI.Jewel.initializeBase(this, [ id, properties ]);
}
CUI.Jewel.prototype = {
    $9V_2: null,
    
    refresh: function() {ULSpEN:;
        this.$L();
        CUI.Jewel.callBaseMethod(this, 'refresh');
    },
    
    $L: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this.$m();
        }
        this.set_$2(CUI.Utility.removeChildNodes(this.get_$2()));
        this.appendChildrenToElement(this.get_$2());
        this.$g_0 = false;
    },
    
    ensureCorrectChildType: function(child) {ULSpEN:;
        if (!CUI.ControlComponent.isInstanceOfType(child)) {
            throw Error.create('The child \"' + child.$6_0 + '\" is not a ControlComponent');
        }
        if (!CUI.Controls.JewelMenuLauncher.isInstanceOfType((child).$M_1)) {
            throw Error.create('Only children of type JewelMenuLauncher can be added to a Jewel');
        }
    },
    
    get_cssClass: function() {ULSpEN:;
        return 'ms-cui-jewel ' + CUI.Jewel.callBaseMethod(this, 'get_cssClass');
    },
    
    get_rootType: function() {ULSpEN:;
        return 'Jewel';
    },
    
    get_visibleInDOM: function() {ULSpEN:;
        return true;
    },
    
    get_$D6: function() {ULSpEN:;
        return this.get_$18();
    },
    set_$D6: function($p0) {
        this.set_$18($p0);
        return $p0;
    },
    
    $Cq: function() {ULSpEN:;
        this.$9V_2.$Cs();
    }
}


CUI.JewelBuildContext = function() {ULSpEN:;
    CUI.JewelBuildContext.initializeBase(this);
}
CUI.JewelBuildContext.prototype = {
    jewel: null,
    jewelId: null
}


CUI.JewelBuildOptions = function() {ULSpEN:;
    CUI.JewelBuildOptions.initializeBase(this);
}


CUI.JewelBuilder = function(options, elmPlaceholder, rootBuildClient) {ULSpEN:;
    this.$8t = Function.createDelegate(this, this.$Aw_1);
    CUI.JewelBuilder.initializeBase(this, [ options, elmPlaceholder, rootBuildClient ]);
    if (CUI.ScriptUtility.isNullOrUndefined(elmPlaceholder)) {
        throw Error.create('Jewel placeholder DOM element is null or undefined.');
    }
}
CUI.JewelBuilder.prototype = {
    
    get_jewel: function() {ULSpEN:;
        return this.$0_0;
    },
    set_jewel: function(value) {ULSpEN:;
        this.$0_0 = value;
        return value;
    },
    
    buildJewel: function(jewelId) {ULSpEN:;
        if (this.$2Y_0) {
            return false;
        }
        if (this.isIdTrimmed(jewelId)) {
            return true;
        }
        var $v_0 = new CUI.JewelBuildContext();
        $v_0.jewelId = jewelId;
        this.$2Y_0 = true;
        var $v_1 = new CUI.DataQuery();
        $v_1.id = $v_0.jewelId;
        $v_1.queryType = 5;
        $v_1.handler = this.$8t;
        $v_1.data = $v_0;
        this.$12_0.runQuery($v_1);
        return true;
    },
    
    $Bp: function($p0, $p1) {
        var $v_0 = new CUI.DataQueryResult();
        $v_0.success = true;
        $v_0.queryData = $p0;
        $v_0.contextData = $p1;
        this.$Aw_1($v_0);
    },
    
    $Aw_1: function($p0) {
        var $v_0 = $p0.contextData;
        $p0.queryData = this.applyDataExtensions($p0.queryData);
        var $v_1 = CUI.DataNodeWrapper.getFirstChildNodeWithName($p0.queryData, 'Jewel');
        this.set_jewel(this.$Bq_1($v_1, $v_0));
        this.get_jewel().set_$D6(this);
        this.$1R_0.onComponentCreated(this.get_jewel(), this.get_jewel().$6_0);
        if (this.get_$D7_1().attachToDOM) {
            this.get_jewel().$36(true);
        }
        else {
            this.get_jewel().$L();
            this._elmPlaceholder.appendChild(this.get_jewel().get_$2());
            CUI.Utility.ensureCSSClassOnElement(this._elmPlaceholder, 'loaded');
        }
        this.$7a(this.get_jewel());
        this.$1R_0.onComponentBuilt(this.get_jewel(), this.get_jewel().$6_0);
    },
    
    $Bq_1: function($p0, $p1) {
        if (CUI.ScriptUtility.isNullOrUndefined($p0)) {
            throw Error.create('No Jewel element was present in the data');
        }
        var $v_0 = new CUI.DataNodeWrapper($p0);
        this.set_jewel(new CUI.Jewel($v_0.get_attributes()['Id'], $v_0.get_attributes()));
        var $v_1 = this.$Br_1($p0, $p1);
        this.get_jewel().addChild($v_1.createComponentForDisplayMode('Default'));
        this.get_jewel().$9V_2 = $v_1;
        return this.get_jewel();
    },
    
    $Br_1: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = CUI.DataNodeWrapper.getNodeChildren($p0);
        var $v_2 = null;
        var $v_3 = $p0.attrs;
        if (!CUI.Utility.$v($v_3.PopulateDynamically)) {
            $v_2 = this.$37($v_1[0], $p1, false);
        }
        var $v_4 = new CUI.Controls.JewelMenuLauncher(this.get_jewel(), $v_0.Id, $v_0, $v_2);
        return $v_4;
    },
    
    get_$D7_1: function() {ULSpEN:;
        return this.$s_0;
    }
}


CUI.Menu = function(root, id, title, description, maxWidth) {ULSpEN:;
    this.$7_1 = -1;
    CUI.Menu.initializeBase(this, [ root, id, title, description ]);
    this.$6e_1 = maxWidth;
}
CUI.Menu.prototype = {
    $Q_1: null,
    $BQ_1: null,
    $BN_1: null,
    $3p_1: null,
    $6e_1: null,
    
    $L: function() {ULSpEN:;
        if (this.get_needsDelayIniting()) {
            this.doDelayedInit();
        }
        this.ensureDOMElementAndEmpty();
        var $v_0 = this.$0_0._textDirection;
        var $v_1 = this.get_$2();
        var $v_2 = this.$Q_1;
        if (!$v_0) {
            $v_1.style.direction = 'ltr';
        }
        else if ($v_0 === 1) {
            CUI.Utility.ensureCSSClassOnElement($v_1, 'ms-cui-rtl');
            $v_1.style.direction = 'rtl';
        }
        if (CUI.ScriptUtility.isNullOrUndefined($v_2)) {
            $v_2 = CUI.Utility.$3('div');
            $v_2.className = 'ms-cui-smenu-inner';
        }
        $v_1.setAttribute('role', 'menu');
        $v_1.appendChild($v_2);
        if (!CUI.ScriptUtility.isNullOrEmptyString(this.$6e_1)) {
            $v_1.style.maxWidth = this.$6e_1;
        }
        this.appendChildrenToElement($v_2);
        CUI.Menu.callBaseMethod(this, '$L');
        $addHandler($v_1, 'contextmenu', CUI.Utility.get_returnFalseHandler());
    },
    
    get_cssClass: function() {ULSpEN:;
        return 'ms-cui-menu';
    },
    
    get_domElementTagName: function() {ULSpEN:;
        return 'div';
    },
    
    ensureCorrectChildType: function($p0) {
        if (!CUI.MenuSection.isInstanceOfType($p0)) {
            throw Error.create('Only MenuSection Components can be added to Menu Components.');
        }
    },
    
    get_innerDiv: function() {ULSpEN:;
        return this.$Q_1;
    },
    set_innerDiv: function($p0) {
        this.$Q_1 = $p0;
        return $p0;
    },
    
    $5a_1: null,
    
    get_$B0: function() {ULSpEN:;
        return this.$5a_1;
    },
    set_$B0: function($p0) {
        if ($p0 && !CUI.ScriptUtility.isNullOrUndefined(this.$5a_1)) {
            this.$0_0.$2e(this.$5a_1);
        }
        this.$5a_1 = $p0;
        return $p0;
    },
    
    get_$EM: function() {ULSpEN:;
        if (this._componentWidth === -1 && !CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this._componentWidth = this.get_$2().offsetWidth;
        }
        return this._componentWidth;
    },
    
    get_$77: function() {ULSpEN:;
        if (this._componentHeight === -1 && !CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this._componentHeight = this.get_$2().offsetHeight;
        }
        return this._componentHeight;
    },
    
    get_$4p: function() {ULSpEN:;
        if (this._componentTopPosition === -1 && !CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this._componentTopPosition = CUI.UIUtility.calculateOffsetTop(this.get_$2());
        }
        return this._componentTopPosition;
    },
    
    get_$EN: function() {ULSpEN:;
        if (this._componentLeftPosition === -1 && !CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this._componentLeftPosition = CUI.UIUtility.calculateOffsetLeft(this.get_$2());
        }
        return this._componentLeftPosition;
    },
    
    $D5: function() {ULSpEN:;
        this._componentWidth = -1;
        this._componentHeight = -1;
        this._componentTopPosition = -1;
        this._componentLeftPosition = -1;
    },
    
    $2P: function() {ULSpEN:;
        this.set_$40(new Date());
        CUI.Menu.callBaseMethod(this, '$2P');
    },
    
    $x: function() {ULSpEN:;
        if (!this.$4_0.$P_0) {
            return;
        }
        this.$7_1 = 0;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_0 = $$enum_1_0.get_current();
            $v_0.$x();
        }
    },
    
    $1r: function() {ULSpEN:;
        if (!this.$4_0.$P_0) {
            return;
        }
        this.$7_1 = 0;
        (this.$4_0.get_item(0)).$1r();
        this.$2i();
    },
    
    $3x: function() {ULSpEN:;
        var $v_0 = this.$4_0.$P_0;
        if (!$v_0) {
            return;
        }
        this.$7_1 = $v_0 - 1;
        (this.$4_0.get_item(this.$7_1)).$3x();
        this.$2j();
    },
    
    $5n: function($p0) {
        if (!this.$4_0.$P_0) {
            return false;
        }
        this.$7_1 = 0;
        var $v_0 = 0;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_1 = $$enum_1_0.get_current();
            if ($v_1.$5n($p0)) {
                this.$7_1 = $v_0;
                return true;
            }
            $v_0++;
        }
        return false;
    },
    
    $2j: function() {ULSpEN:;
        if (this.$7_1 === -1) {
            this.$7_1 = this.$4_0.$P_0 - 1;
        }
        var $v_0 = this.$4_0.getEnumeratorAtPos(this.$7_1);
        var $v_1 = this.$7_1;
        while ($v_0.movePrevious()) {
            if (($v_0.get_current()).$2j()) {
                this.$7_1 = $v_1;
                return true;
            }
            $v_1--;
        }
        this.$7_1 = -1;
        return false;
    },
    
    $2i: function() {ULSpEN:;
        if (this.$7_1 === -1) {
            this.$7_1 = 0;
        }
        var $v_0 = this.$4_0.getEnumeratorAtPos(this.$7_1);
        var $v_1 = this.$7_1;
        while ($v_0.moveNext()) {
            if (($v_0.get_current()).$2i()) {
                this.$7_1 = $v_1;
                return true;
            }
            $v_1++;
        }
        this.$7_1 = -1;
        return false;
    },
    
    $AR: function($p0) {
        return this.$AS_1(this, $p0);
    },
    
    $AS_1: function($p0, $p1) {
        var $v_0;
        if (CUI.ControlComponent.isInstanceOfType($p0)) {
            var $v_2 = $p0;
            if (CUI.ISelectableControl.isInstanceOfType($v_2.$M_1)) {
                var $v_3 = $v_2.$M_1;
                if ($v_3.getMenuItemId() === $p1) {
                    return $v_3;
                }
            }
        }
        var $v_1 = $p0.$4_0;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_1)) {
            var $$enum_2_0 = $v_1.getEnumerator();
            while ($$enum_2_0.moveNext()) {
                var $v_4 = $$enum_2_0.get_current();
                $v_0 = this.$AS_1($v_4, $p1);
                if ($v_0) {
                    return $v_0;
                }
            }
        }
        return null;
    },
    
    $D1: function() {ULSpEN:;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_0 = $$enum_1_0.get_current();
            var $$enum_3_0 = $v_0.$4_0.getEnumerator();
            while ($$enum_3_0.moveNext()) {
                var $v_1 = $$enum_3_0.get_current();
                if ($v_1.get_visible()) {
                    return true;
                }
            }
        }
        return false;
    },
    
    get_visibleInDOM: function() {ULSpEN:;
        return this.$6b_1;
    },
    
    $6b_1: false,
    
    dispose: function() {ULSpEN:;
        CUI.Menu.callBaseMethod(this, 'dispose');
        this.$Q_1 = null;
        this.$BQ_1 = null;
        this.$BN_1 = null;
        this.$3p_1 = null;
        try {
            $removeHandler(this.get_$2(), 'contextmenu', CUI.Utility.get_returnFalseHandler());
        }
        catch ($$e_1_0) {
        }
    }
}


CUI.MenuItem = function(root, id, displayMode, control) {ULSpEN:;
    CUI.MenuItem.initializeBase(this, [ root, id, displayMode, control ]);
}
CUI.MenuItem.prototype = {
    $9O_2: false,
    
    get_$1G: function() {ULSpEN:;
        return this.$9O_2;
    },
    set_$1G: function($p0) {
        this.$9O_2 = $p0;
        return $p0;
    },
    
    $5n: function($p0) {
        if (CUI.ISelectableControl.isInstanceOfType(this.$M_1)) {
            var $v_0 = this.$M_1;
            if ($v_0.getMenuItemId() === $p0) {
                if (this.get_visible() && this.get_enabled()) {
                    this.receiveFocus();
                    this.set_$1G(true);
                    return true;
                }
            }
        }
        return false;
    },
    
    $2j: function() {ULSpEN:;
        if (!this.get_visible()) {
            return false;
        }
        this.set_$1G(this.$M_1.$2j());
        return this.get_$1G();
    },
    
    $2i: function() {ULSpEN:;
        if (!this.get_visible()) {
            return false;
        }
        this.set_$1G(this.$M_1.$2i());
        return this.get_$1G();
    },
    
    $x: function() {ULSpEN:;
        this.set_$1G(false);
    }
}


CUI.MenuLauncherControlProperties = function() {ULSpEN:;
    CUI.MenuLauncherControlProperties.initializeBase(this);
}
CUI.MenuLauncherControlProperties.prototype = {
    CacheMenuVersions: null,
    CommandMenuOpen: null,
    CommandMenuClose: null,
    CommandValueId: null,
    PopulateDynamically: null,
    PopulateOnlyOnce: null,
    PopulateQueryCommand: null
}


CUI.BrowserUtility = function() {
}
CUI.BrowserUtility.$Ag = function() {ULSpEN:;
    return Sys.Browser.agent === Sys.Browser.Firefox || Sys.Browser.name.toLowerCase().indexOf('firefox') !== -1 || (navigator.userAgent).toLowerCase().indexOf('gecko') !== -1;
}


CUI.MenuLauncher = function(root, id, properties, menu) {ULSpEN:;
    this.$94 = Function.createDelegate(this, this.$Dh_1);
    this.$7w = Function.createDelegate(this, this.addAndPositionBackFrameInternal);
    this.$5b_1 = -1;
    CUI.MenuLauncher.initializeBase(this, [ root, id, properties ]);
    this.$B_1 = menu;
}
CUI.MenuLauncher.dictToInt = function($p0, $p1) {
    return $p0[$p1];
}
CUI.MenuLauncher.prototype = {
    $i_1: false,
    _selectedControl: null,
    
    get_menuLaunched: function() {ULSpEN:;
        return this.$i_1;
    },
    
    $B_1: null,
    $1E_1: false,
    
    get_launchedByKeyboard: function() {ULSpEN:;
        return this.$1E_1;
    },
    set_launchedByKeyboard: function($p0) {
        this.$1E_1 = $p0;
        return $p0;
    },
    
    $2W_1: null,
    
    get_elmHadFocus: function() {ULSpEN:;
        return this.$2W_1;
    },
    set_elmHadFocus: function($p0) {
        this.$2W_1 = $p0;
        return $p0;
    },
    
    $3W_1: null,
    
    get_$9u_1: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$3W_1)) {
            this.$3W_1 = CUI.Utility.$A4();
        }
        return this.$3W_1;
    },
    
    launchMenu: function($p0, $p1) {
        if (this.$i_1) {
            return false;
        }
        this.$2W_1 = $p0;
        if (CUI.Utility.$v(this.get_$1_1().PopulateDynamically)) {
            this.pollForDynamicMenu(true, $p1);
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$B_1)) {
            return false;
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$4e_1)) {
            this.$4e_1();
            this.$4e_1 = null;
        }
        this.$B_1.$2O();
        if (!this.$B_1.$D1()) {
            return false;
        }
        var $v_0 = this.get_displayedComponent();
        $v_0.$7D();
        $v_0.$4X_0 = true;
        $v_0.addChild(this.$B_1);
        $v_0.$4X_0 = false;
        this.$B_1.$B2();
        this.$B_1.$D5();
        var $v_1 = CUI.Ribbon.isInstanceOfType(this.$0_0);
        var $v_2 = null;
        var $v_3 = false;
        if ($v_1) {
            $v_2 = this.$0_0;
            $v_3 = $v_2.get_$52();
            $v_2.set_$52(false);
        }
        var $v_4 = this.$B_1.get_$2();
        $v_4.style.visibility = 'hidden';
        $v_4.style.position = 'absolute';
        $v_4.style.top = '0px';
        $v_4.style.left = '0px';
        $v_4.style.zIndex = 1001;
        document.body.appendChild($v_4);
        if (CUI.Utility.$3B() && this.$0_0._textDirection === 1) {
            var $v_5 = $v_4.offsetWidth;
            $v_5 = ($v_5 >= 18) ? $v_5 - 18 : 0;
            var $v_6 = $v_5 + 'px';
            var $v_7 = this.$B_1.$4_0;
            var $$enum_2_0 = $v_7.getEnumerator();
            while ($$enum_2_0.moveNext()) {
                var $v_8 = $$enum_2_0.get_current();
                var $v_9 = $v_8.$4_0;
                var $$enum_4_0 = $v_9.getEnumerator();
                while ($$enum_4_0.moveNext()) {
                    var $v_A = $$enum_4_0.get_current();
                    if (CUI.MenuItem.isInstanceOfType($v_A)) {
                        $v_A.get_$2().style.width = $v_6;
                    }
                }
            }
        }
        this.positionMenu($v_4, $v_0.get_$2());
        if (Sys.Browser.agent === Sys.Browser.InternetExplorer) {
            this.addAndPositionBackFrame();
        }
        this.$0_0.$Be(this, this.$2W_1);
        this.$0_0.$BX(this);
        $v_4.style.visibility = 'visible';
        this.$i_1 = true;
        this.$B_1.$6b_1 = true;
        this.$Cr_1();
        if ($v_1) {
            $v_2.set_$52($v_3);
        }
        return true;
    },
    
    $Cr_1: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$B_1.$3p_1) && !CUI.ScriptUtility.isNullOrUndefined(this._selectedControl)) {
            var $v_0 = this._selectedControl;
            var $v_1 = $v_0.get_displayedComponent();
            if (CUI.MenuItem.isInstanceOfType($v_1)) {
                this.$B_1.$3p_1 = $v_1;
            }
        }
        if (this.$1E_1) {
            this.$B_1.$1r();
        }
        else {
            var $v_2 = this.$B_1.$3p_1;
            if (!CUI.ScriptUtility.isNullOrUndefined($v_2)) {
                var $v_3 = $v_2.$M_1;
                if (CUI.Controls.ToggleButton.isInstanceOfType($v_3) && CUI.ISelectableControl.isInstanceOfType($v_3)) {
                    var $v_4 = $v_3;
                    if (!this.$B_1.$5n($v_4.getMenuItemId())) {
                        this.$B_1.$1r();
                    }
                }
            }
        }
    },
    
    addAndPositionBackFrame: function() {ULSpEN:;
        if (this.$5b_1 !== -1) {
            window.clearTimeout(this.$5b_1);
        }
        this.$5b_1 = window.setTimeout(this.$7w, 50);
    },
    
    addAndPositionBackFrameInternal: function() {ULSpEN:;
        CUI.PMetrics.perfMark(7188);
        document.body.appendChild(this.get_$9u_1());
        CUI.Utility.$B3(this.get_$9u_1(), this.$B_1.get_$2());
        CUI.PMetrics.perfMark(7189);
    },
    
    onModalBodyClick: function($p0) {
        $p0.stopPropagation();
        this.$1E_1 = false;
        this.$0_0.$2e(this);
    },
    
    onModalBodyMouseOver: function($p0) {
    },
    
    onModalBodyMouseOut: function($p0) {
    },
    
    onModalContextMenu: function($p0) {
        $p0.stopPropagation();
        if (!CUI.BrowserUtility.$Ag()) {
            $p0.preventDefault();
        }
        this.$1E_1 = false;
        this.$0_0.$2e(this);
    },
    
    onModalKeyPress: function($p0) {
        if ($p0) {
            if ($p0.rawEvent) {
                if ($p0.rawEvent.keyCode === 27) {
                    $p0.stopPropagation();
                    this.$1E_1 = true;
                    this.$0_0.$2e(this);
                }
                if ($p0.rawEvent.keyCode === 9) {
                    if ($p0.shiftKey) {
                        if (!this.$B_1.$2j()) {
                            this.$B_1.$3x();
                        }
                        $p0.preventDefault();
                    }
                    else {
                        if (!this.$B_1.$2i()) {
                            this.$B_1.$1r();
                        }
                        $p0.preventDefault();
                    }
                }
                if ($p0.rawEvent.keyCode === 40) {
                    if (!this.$B_1.$2i()) {
                        this.$B_1.$1r();
                    }
                    $p0.preventDefault();
                    $p0.stopPropagation();
                }
                if ($p0.rawEvent.keyCode === 38) {
                    if (!this.$B_1.$2j()) {
                        this.$B_1.$3x();
                    }
                    $p0.preventDefault();
                    $p0.stopPropagation();
                }
                if (CUI.Controls.FlyoutAnchor.isInstanceOfType(this)) {
                    if (($p0.rawEvent.keyCode === 39 && !this.$0_0._textDirection) || ($p0.rawEvent.keyCode === 37 && this.$0_0._textDirection === 1)) {
                        if (!this.$B_1.$2i()) {
                            this.$B_1.$1r();
                        }
                        $p0.preventDefault();
                        $p0.stopPropagation();
                    }
                    if (($p0.rawEvent.keyCode === 37 && !this.$0_0._textDirection) || ($p0.rawEvent.keyCode === 39 && this.$0_0._textDirection === 1)) {
                        if (!this.$B_1.$2j()) {
                            this.$B_1.$3x();
                        }
                        $p0.preventDefault();
                        $p0.stopPropagation();
                    }
                }
            }
        }
    },
    
    positionMenu: function($p0, $p1) {
        this.$0_0.$Dn($p0, $p1);
    },
    
    getAllElementDimensions: function($p0, $p1) {
        return this.$0_0.$7K($p0, $p1);
    },
    
    $4o: function() {ULSpEN:;
        if (!this.$i_1) {
            return;
        }
        $clearHandlers(this.$B_1.get_$2());
        CUI.UIUtility.removeNode(this.$B_1.get_$2());
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$3W_1)) {
            CUI.UIUtility.removeNode(this.$3W_1);
        }
        this.$B_1.onMenuClosed();
        var $v_0 = this.$B_1.$K_0;
        $v_0.$4X_0 = true;
        $v_0.removeChild(this.$B_1.$6_0);
        $v_0.$4X_0 = false;
        this.$i_1 = false;
        this.$B_1.$6b_1 = false;
        this.$0_0.$CZ(this);
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$2W_1) && this.$1E_1) {
            this.$2W_1.focus();
        }
        this.$2W_1 = null;
        this.$1E_1 = false;
        this.onLaunchedMenuClosed();
    },
    
    onMenuClosed: function() {
    },
    
    onLaunchedMenuClosed: function() {ULSpEN:;
        this.$B_1.$x();
    },
    
    ensureCorrectChildType: function($p0) {
        if ((!CUI.Menu.isInstanceOfType($p0)) && (!(CUI.ToolTip.isInstanceOfType($p0)))) {
            throw Error.create('This Component can only have Menu and ToolTip Components as children.');
        }
    },
    
    $1g: function($p0) {
        if (this.$i_1 && $p0.$G_1 !== 4 && $p0.$G_1 !== 5 && $p0.$G_1 !== 6 && $p0.$G_1 !== 7 && $p0.$G_1 !== 8 && $p0.$G_1 !== 9 && $p0.$G_1 !== 10) {
            if (!CUI.ScriptUtility.isNullOrUndefined($p0.get_sourceControl())) {
                var $v_0 = $p0.get_sourceControl().get_displayedComponent();
                this.$B_1.$3p_1 = $v_0;
            }
            this.$0_0.$2e(this);
        }
        return true;
    },
    
    $9c_1: false,
    $4e_1: null,
    
    pollForDynamicMenu: function($p0, $p1) {
        if (this.$9c_1 && CUI.Utility.$v(this.get_$1_1().PopulateOnlyOnce)) {
            return;
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_1().PopulateQueryCommand)) {
            return;
        }
        var $v_0 = ({});
        var $v_1;
        if (CUI.Utility.$v(this.get_$1_1().CacheMenuVersions)) {
            $v_1 = {};
            var $$dict_2_0 = this.$3Q_1;
            for (var $$key_2_1 in $$dict_2_0) {
                var $v_3 = { key: $$key_2_1, value: $$dict_2_0[$$key_2_1] };
                $v_1[$v_3.key] = true;
            }
            $v_0.CachedVersions = $v_1;
        }
        var $v_2 = this.$0_0.$4w(this.get_$1_1().PopulateQueryCommand, this.get_$1_1().PopulateQueryCommand, $v_0);
        if ($v_2) {
            var $v_4 = null;
            var $v_5 = null;
            if (!CUI.ScriptUtility.isNullOrUndefined($v_0.PopulationJSON)) {
                $v_5 = $v_0.PopulationJSON;
            }
            else if (!CUI.ScriptUtility.isNullOrUndefined($v_0.PopulationXML)) {
                $v_5 = CUI.Builder.$CA($v_0.PopulationXML);
            }
            if (!CUI.ScriptUtility.isNullOrUndefined($v_5)) {
                $v_4 = this.$0_0.get_$18().$37($v_5, new CUI.BuildContext(), false);
                if (!CUI.ScriptUtility.isNullOrUndefined($v_4)) {
                    this.$9c_1 = true;
                    if (CUI.Utility.$v(this.get_$1_1().CacheMenuVersions) && !CUI.ScriptUtility.isNullOrUndefined($v_0.PopulationVersion)) {
                        this.get_cachedMenuVersions()[$v_0.PopulationVersion] = $v_4;
                    }
                }
            }
            else if (!CUI.ScriptUtility.isNullOrUndefined($v_0.PopulationVersion)) {
                $v_4 = this.get_cachedMenuVersions()[$v_0.PopulationVersion];
            }
            else if ($p0 && -1 !== $v_0.PollAgainInterval) {
                this.$4e_1 = $p1;
                window.setTimeout(this.$94, $v_0.PollAgainInterval);
                this.$B_1 = null;
            }
            if (!CUI.ScriptUtility.isNullOrUndefined($v_4)) {
                this.$B_1 = $v_4;
                this.onDynamicMenuPopulated();
            }
        }
    },
    
    $Dh_1: function() {ULSpEN:;
        this.launchMenu(this.$2W_1, this.$4e_1);
    },
    
    onDynamicMenuPopulated: function() {
    },
    
    get_$1_1: function() {ULSpEN:;
        return this.$5_0;
    },
    
    $3Q_1: null,
    
    get_cachedMenuVersions: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$3Q_1)) {
            this.$3Q_1 = {};
        }
        return this.$3Q_1;
    },
    
    dispose: function() {ULSpEN:;
        CUI.MenuLauncher.callBaseMethod(this, 'dispose');
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$B_1)) {
            this.$B_1.dispose();
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$3Q_1)) {
            var $$dict_2_0 = this.$3Q_1;
            for (var $$key_2_1 in $$dict_2_0) {
                var $v_0 = { key: $$key_2_1, value: $$dict_2_0[$$key_2_1] };
                var $v_1 = $v_0.value;
                $v_1.dispose();
            }
        }
        this._selectedControl = null;
        this.$B_1 = null;
        this.$3W_1 = null;
    }
}


CUI.MenuSection = function(root, id, title, description, scrollable, maxheight, displayMode) {ULSpEN:;
    this.$7_1 = -1;
    CUI.MenuSection.initializeBase(this, [ root, id, title, description ]);
    this.$9g_1 = scrollable;
    this.$6d_1 = maxheight;
    this.$6I_1 = displayMode;
}
CUI.MenuSection.prototype = {
    $9g_1: false,
    $6d_1: null,
    $6I_1: null,
    $3f_1: null,
    $D_1: null,
    $2D_1: null,
    
    $L: function() {ULSpEN:;
        this.ensureDOMElementAndEmpty();
        this.$3f_1 = CUI.Utility.$3('div');
        this.$3f_1.className = 'ms-cui-menusection';
        this.get_$2().appendChild(this.$3f_1);
        if (!CUI.ScriptUtility.isNullOrUndefined(this.get_title())) {
            this.$D_1 = CUI.Utility.$3('div');
            CUI.UIUtility.setInnerText(this.$D_1, this.get_title());
            this.$D_1.className = 'ms-cui-menusection-title';
            this.$3f_1.appendChild(this.$D_1);
        }
        this.$2D_1 = CUI.Utility.$3('ul');
        this.$2D_1.className = 'ms-cui-menusection-items';
        var $v_0;
        if (this.$6I_1 === 'Menu32') {
            if (!this.$0_0._textDirection) {
                $v_0 = 'ms-cui-menusection-items32';
            }
            else {
                $v_0 = 'ms-cui-menusection-items32rtl';
            }
            var $v_1 = this.$K_0;
            if (CUI.Menu.isInstanceOfType($v_1)) {
                CUI.Utility.ensureCSSClassOnElement($v_1.get_$2(), 'ms-cui-menu32');
            }
        }
        else if (this.$6I_1 === 'Menu16') {
            if (!this.$0_0._textDirection) {
                $v_0 = 'ms-cui-menusection-items16';
            }
            else {
                $v_0 = 'ms-cui-menusection-items16rtl';
            }
        }
        else {
            $v_0 = '';
        }
        if ($v_0 !== '') {
            CUI.Utility.ensureCSSClassOnElement(this.$2D_1, $v_0);
        }
        if (this.$9g_1) {
            this.$2D_1.style.overflowY = 'auto';
            this.$2D_1.style.position = 'relative';
        }
        if (!CUI.ScriptUtility.isNullOrEmptyString(this.$6d_1)) {
            this.$2D_1.style.maxHeight = this.$6d_1;
        }
        this.$3f_1.appendChild(this.$2D_1);
        this.appendChildrenToElement(this.$2D_1);
    },
    
    get_domElementTagName: function() {ULSpEN:;
        return 'div';
    },
    
    appendChildrenToElement: function($p0) {
        var $v_0;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_1 = $$enum_1_0.get_current();
            $v_0 = CUI.Utility.$3('li');
            $v_0.className = 'ms-cui-menusection-items';
            $v_1.$m();
            $v_0.appendChild($v_1.get_$2());
            $p0.appendChild($v_0);
            $v_1.$2O();
        }
    },
    
    $x: function() {ULSpEN:;
        if (!this.$4_0.$P_0) {
            return;
        }
        this.$7_1 = 0;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_0 = $$enum_1_0.get_current();
            $v_0.$x();
        }
    },
    
    $1r: function() {ULSpEN:;
        if (!this.$4_0.$P_0) {
            return;
        }
        if (this.$7_1 > -1) {
            (this.$4_0.get_item(this.$7_1)).$x();
        }
        this.$7_1 = 0;
        (this.$4_0.get_item(this.$7_1)).$1r();
    },
    
    $3x: function() {ULSpEN:;
        var $v_0 = this.$4_0.$P_0;
        if (!$v_0) {
            return;
        }
        if (this.$7_1 > -1) {
            (this.$4_0.get_item(this.$7_1)).$x();
        }
        this.$7_1 = $v_0 - 1;
        (this.$4_0.get_item(this.$7_1)).$3x();
    },
    
    $5n: function($p0) {
        if (!this.$4_0.$P_0) {
            return false;
        }
        var $v_0 = 0;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_1 = $$enum_1_0.get_current();
            if ($v_1.$5n($p0)) {
                if (this.$7_1 > -1) {
                    (this.$4_0.get_item(this.$7_1)).$x();
                }
                this.$7_1 = $v_0;
                return true;
            }
            $v_0++;
        }
        return false;
    },
    
    $2j: function() {ULSpEN:;
        var $v_0 = this.$4_0.$P_0;
        if (this.$7_1 === -1) {
            this.$7_1 = $v_0 - 1;
        }
        var $v_1 = this.$7_1;
        var $v_2 = this.$4_0.getEnumeratorAtPos($v_1);
        while ($v_2.movePrevious()) {
            if (($v_2.get_current()).$2j()) {
                if ($v_1 !== this.$7_1) {
                    (this.$4_0.get_item(this.$7_1)).$x();
                    this.$7_1 = $v_1;
                }
                return true;
            }
            $v_1--;
        }
        if ($v_0 > 0) {
            (this.$4_0.get_item(this.$7_1)).$x();
        }
        this.$7_1 = -1;
        return false;
    },
    
    $2i: function() {ULSpEN:;
        if (this.$7_1 === -1) {
            this.$7_1 = 0;
        }
        var $v_0 = this.$4_0.getEnumeratorAtPos(this.$7_1);
        var $v_1 = this.$7_1;
        while ($v_0.moveNext()) {
            if (($v_0.get_current()).$2i()) {
                if ($v_1 !== this.$7_1) {
                    if (!CUI.ScriptUtility.isNullOrUndefined(this.$4_0.get_item(this.$7_1))) {
                        (this.$4_0.get_item(this.$7_1)).$x();
                    }
                    this.$7_1 = $v_1;
                }
                return true;
            }
            $v_1++;
        }
        if (this.$4_0.$P_0 > 0) {
            (this.$4_0.get_item(this.$7_1)).$x();
        }
        this.$7_1 = -1;
        return false;
    },
    
    ensureCorrectChildType: function($p0) {
        if (!CUI.MenuItem.isInstanceOfType($p0) && !CUI.Gallery.isInstanceOfType($p0) && !CUI.GroupPopup.isInstanceOfType($p0)) {
            throw Error.create('MenuSections can only have children of type MenuItem, Gallery or GroupPopup.');
        }
    },
    
    $BF: function($p0) {
        this.$1S_0 = $p0;
        CUI.UIUtility.setInnerText(this.$D_1, $p0);
    },
    
    dispose: function() {ULSpEN:;
        CUI.MenuSection.callBaseMethod(this, 'dispose');
        this.$2D_1 = null;
        this.$D_1 = null;
        this.$3f_1 = null;
    }
}


CUI.QAT = function(id, properties) {ULSpEN:;
    CUI.QAT.initializeBase(this, [ id, properties ]);
}
CUI.QAT.prototype = {
    
    refresh: function() {ULSpEN:;
        this.$L();
        CUI.QAT.callBaseMethod(this, 'refresh');
    },
    
    $L: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this.$m();
        }
        this.set_$2(CUI.Utility.removeChildNodes(this.get_$2()));
        this.appendChildrenToElement(this.get_$2());
        this.$g_0 = false;
    },
    
    ensureCorrectChildType: function(child) {ULSpEN:;
        if (!CUI.ControlComponent.isInstanceOfType(child)) {
            throw Error.create('Only children of type ControlComponent can be added to a QAT');
        }
    },
    
    get_cssClass: function() {ULSpEN:;
        return 'ms-cui-QAT ' + CUI.QAT.callBaseMethod(this, 'get_cssClass');
    },
    
    get_rootType: function() {ULSpEN:;
        return 'QAT';
    },
    
    get_visibleInDOM: function() {ULSpEN:;
        return true;
    },
    
    get_$Ds: function() {ULSpEN:;
        return this.get_$18();
    },
    set_$Ds: function($p0) {
        this.set_$18($p0);
        return $p0;
    }
}


CUI.QATBuildContext = function() {ULSpEN:;
    CUI.QATBuildContext.initializeBase(this);
}
CUI.QATBuildContext.prototype = {
    QAT: null,
    qatId: null
}


CUI.QATBuildOptions = function() {ULSpEN:;
    CUI.QATBuildOptions.initializeBase(this);
}


CUI.QATBuilder = function(options, elmPlaceholder, rootBuildClient) {ULSpEN:;
    this.$8u = Function.createDelegate(this, this.$DY_1);
    CUI.QATBuilder.initializeBase(this, [ options, elmPlaceholder, rootBuildClient ]);
    if (CUI.ScriptUtility.isNullOrUndefined(elmPlaceholder)) {
        throw Error.create('QAT placeholder DOM element is null or undefined.');
    }
}
CUI.QATBuilder.prototype = {
    
    get_QAT: function() {ULSpEN:;
        return this.$0_0;
    },
    set_QAT: function(value) {ULSpEN:;
        this.$0_0 = value;
        return value;
    },
    
    buildQAT: function(qatId) {ULSpEN:;
        if (this.$2Y_0) {
            return false;
        }
        if (this.isIdTrimmed(qatId)) {
            return true;
        }
        var $v_0 = new CUI.QATBuildContext();
        $v_0.qatId = qatId;
        this.$2Y_0 = true;
        var $v_1 = new CUI.DataQuery();
        $v_1.id = $v_0.qatId;
        $v_1.queryType = 5;
        $v_1.handler = this.$8u;
        $v_1.data = $v_0;
        this.$12_0.runQuery($v_1);
        return true;
    },
    
    $DY_1: function($p0) {
        var $v_0 = $p0.contextData;
        $p0.queryData = this.applyDataExtensions($p0.queryData);
        this.set_QAT(this.$Bv_1(CUI.DataNodeWrapper.getFirstChildNodeWithName($p0.queryData, 'QAT'), $v_0));
        this.get_QAT().set_$Ds(this);
        this.$1R_0.onComponentCreated(this.get_QAT(), this.get_QAT().$6_0);
        if (this.get_$Dt_1().attachToDOM) {
            this.get_QAT().$36(true);
        }
        else {
            this.get_QAT().$L();
            this._elmPlaceholder.appendChild(this.get_QAT().get_$2());
            CUI.Utility.ensureCSSClassOnElement(this._elmPlaceholder, 'loaded');
        }
        this.$7a(this.get_QAT());
        this.$1R_0.onComponentBuilt(this.get_QAT(), this.get_QAT().$6_0);
    },
    
    $Bv_1: function($p0, $p1) {
        if (CUI.ScriptUtility.isNullOrUndefined($p0)) {
            throw Error.create('No QAT element was present in the data');
        }
        var $v_0 = new CUI.DataNodeWrapper($p0);
        this.set_QAT(new CUI.QAT($v_0.get_attributes()['Id'], $v_0.get_attributes()));
        var $v_1 = CUI.DataNodeWrapper.getNodeChildren(CUI.DataNodeWrapper.getFirstChildNodeWithName($v_0.$a_0, 'Controls'));
        for (var $v_2 = 0; $v_2 < $v_1.length; $v_2++) {
            if (!this.isNodeTrimmed($v_1[$v_2])) {
                var $v_3 = this.$1f($v_1[$v_2], $p1);
                this.get_QAT().addChild($v_3.createComponentForDisplayMode('Small'));
            }
        }
        return this.get_QAT();
    },
    
    get_$Dt_1: function() {ULSpEN:;
        return this.$s_0;
    }
}


CUI.RibbonPeripheralSection = function() {
}


CUI.ContextualGroup = function(id, title, color, command) {ULSpEN:;
    this.$6_0 = id;
    this.$1S_0 = title;
    this.$3S_0 = color;
    this.$y_0 = command;
}
CUI.ContextualGroup.$5o = function($p0) {
    switch ($p0) {
        case 1:
            return 'db';
        case 2:
            return 'lb';
        case 3:
            return 'tl';
        case 4:
            return 'or';
        case 5:
            return 'gr';
        case 6:
            return 'mg';
        case 7:
            return 'yl';
        case 8:
            return 'pp';
        default:
            return '';
    }
}
CUI.ContextualGroup.prototype = {
    $6_0: null,
    $1S_0: null,
    $3S_0: 0,
    $y_0: null,
    $2c_0: 0,
    
    get_id: function() {ULSpEN:;
        return this.$6_0;
    },
    
    get_count: function() {ULSpEN:;
        return this.$2c_0;
    },
    
    get_title: function() {ULSpEN:;
        return this.$1S_0;
    },
    
    get_color: function() {ULSpEN:;
        return this.$3S_0;
    },
    
    get_command: function() {ULSpEN:;
        return this.$y_0;
    },
    
    $1Y_0: null,
    $D_0: null,
    $1z_0: null,
    
    get_$2: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$1Y_0)) {
            this.$1Y_0 = CUI.Utility.$3('li');
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$6_0)) {
                this.$1Y_0.id = this.$6_0;
            }
            this.$1Y_0.className = 'ms-cui-cg';
            var $v_0 = CUI.ContextualGroup.$5o(this.$3S_0);
            if ($v_0 !== '') {
                CUI.Utility.ensureCSSClassOnElement(this.$1Y_0, 'ms-cui-cg-' + $v_0);
            }
            var $v_1 = CUI.Utility.$3('div');
            $v_1.className = 'ms-cui-cg-i';
            $v_1.title = this.$1S_0;
            this.$1Y_0.appendChild($v_1);
            this.$D_0 = CUI.Utility.$3('div');
            this.$D_0.className = 'ms-cui-cg-t';
            $v_1.appendChild(this.$D_0);
            var $v_2 = CUI.Utility.$3('span');
            $v_2.className = 'ms-cui-cg-t-i';
            CUI.UIUtility.setInnerText($v_2, this.$1S_0);
            this.$D_0.appendChild($v_2);
            this.$1z_0 = CUI.Utility.$3('ul');
            this.$1z_0.className = 'ms-cui-ct-ul';
            this.$1Y_0.appendChild(this.$1z_0);
            this.$2c_0 = 0;
        }
        return this.$1Y_0;
    },
    
    $Bd: function() {ULSpEN:;
        var $v_0 = $get(this.$6_0);
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            this.$1Y_0 = $v_0;
            this.$D_0 = this.$1Y_0.childNodes[0].childNodes[0];
            this.$1z_0 = this.$1Y_0.childNodes[1];
        }
    },
    
    $BZ: function($p0) {
        this.$1z_0.appendChild($p0);
        this.$2c_0++;
        if (this.$2c_0 === 1) {
            CUI.Utility.ensureCSSClassOnElement(this.$1z_0, 'ms-cui-oneCtxTab');
        }
        else if (this.$2c_0 === 2) {
            CUI.Utility.removeCSSClassFromElement(this.$1z_0, 'ms-cui-oneCtxTab');
        }
    },
    
    $Cg: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$1z_0)) {
            CUI.Utility.removeChildNodesSlow(this.$1z_0);
        }
        this.$2c_0 = 0;
    },
    
    dispose: function() {ULSpEN:;
        this.$1Y_0 = null;
        this.$D_0 = null;
        this.$1z_0 = null;
        this.$2c_0 = 0;
    }
}


CUI.DeclarativeTemplate = function(data) {ULSpEN:;
    this.$7z = Function.createDelegate(this, this.$CQ_1);
    CUI.DeclarativeTemplate.initializeBase(this);
    this.$12_1 = new CUI.DataNodeWrapper(data);
}
CUI.DeclarativeTemplate.prototype = {
    $12_1: null,
    
    createGroup: function($p0, $p1, $p2, $p3, $p4, $p5, $p6, $p7) {
        var $v_0 = new CUI.DeclarativeTemplateBuildContext();
        $v_0.ribbon = $p0;
        $v_0.controls = $p6;
        $v_0.parameters = $p7;
        var $v_1 = $p0.$CJ($p1, $p2, $p3, $p4, $p5);
        for (var $v_2 = 0; $v_2 < this.$12_1.get_children().length; $v_2++) {
            var $v_3 = this.$CM_1(this.$12_1.get_children()[$v_2], $v_1, $v_0);
            if (!CUI.ScriptUtility.isNullOrUndefined($v_3)) {
                $v_1.addChild($v_3);
            }
        }
        return $v_1;
    },
    
    $CM_1: function($p0, $p1, $p2) {
        var $v_0 = $p0.attrs.Title;
        if ($v_0 === 'Popup') {
            var $v_2 = $p0.attrs.LayoutTitle;
            $p1.set_popupLayoutTitle($v_2);
            return null;
        }
        var $v_1 = $p2.ribbon.$A5($p1.$6_0 + '-' + $v_0, $v_0);
        $v_1.$7k(this.$7z, $p0, $p2);
        return $v_1;
    },
    
    $CQ_1: function($p0, $p1, $p2) {
        var $v_0 = $p0;
        var $v_1 = $p2;
        this.$Cm($p1, $v_0, $v_1);
        $v_0.$4v(true);
        return $v_0;
    },
    
    $Cm: function($p0, $p1, $p2) {
        var $v_0 = $p0.children;
        var $v_1 = 0;
        for (var $v_2 = 0; $v_2 < $v_0.length; $v_2++) {
            var $v_3 = $v_0[$v_2].name;
            if ($v_3 === 'Section') {
                var $v_4 = this.$CN_1($v_0[$v_2], $p2, $p1, $v_1++);
                $p1.addChild($v_4);
            }
            else {
                $v_1 = this.$7R_1($v_0[$v_2], $p2, $p1, $v_1);
            }
        }
    },
    
    $CN_1: function($p0, $p1, $p2, $p3) {
        var $v_0;
        var $v_1 = $p0.attrs.Type;
        var $v_2 = $p0.attrs.Alignment;
        switch ($v_1) {
            case 'OneRow':
                $v_0 = 2;
                break;
            case 'TwoRow':
                $v_0 = 3;
                break;
            case 'ThreeRow':
                $v_0 = 4;
                break;
            case 'Divider':
                $v_0 = 1;
                break;
            default:
                throw Error.create('Invalid Section attribute \"Type\" found in XML: ' + $v_1);
        }
        var $v_3 = 1;
        if ($v_2 === 'Middle') {
            $v_3 = 2;
        }
        var $v_4 = $p1.ribbon.$26($p2.$6_0 + '-' + $p3, $v_0, $v_3);
        if ($v_0 !== 1) {
            this.$7S_1($v_4.getRow(1), ((($p0.children))[0]), $p1);
            if ($v_4.$G_2 === 3 || $v_4.$G_2 === 4) {
                this.$7S_1($v_4.getRow(2), ((($p0.children))[1]), $p1);
            }
            if ($v_4.$G_2 === 4) {
                this.$7S_1($v_4.getRow(3), ((($p0.children))[2]), $p1);
            }
        }
        return $v_4;
    },
    
    $7S_1: function($p0, $p1, $p2) {
        var $v_0 = $p1.children;
        for (var $v_1 = 0; $v_1 < $v_0.length; $v_1++) {
            var $v_2 = $v_0[$v_1].name;
            var $v_3 = null;
            if ($v_2 === 'ControlRef') {
                $v_3 = this.$A1_1($v_0[$v_1], $p2);
            }
            else if ($v_2 === 'OverflowArea') {
                this.$7R_1($v_0[$v_1], $p2, $p0, $v_1);
            }
            else {
                $v_3 = this.$CO_1($v_0[$v_1], $p2, $p0, $v_1);
            }
            if (!CUI.ScriptUtility.isNullOrUndefined($v_3)) {
                $p0.addChild($v_3);
            }
        }
    },
    
    $CO_1: function($p0, $p1, $p2, $p3) {
        var $v_0 = $p0.children;
        var $v_1 = $p1.ribbon.$A8($p2.$6_0 + '-' + $p3);
        for (var $v_2 = 0; $v_2 < $v_0.length; $v_2++) {
            var $v_3 = CUI.DataNodeWrapper.getNodeName($v_0[$v_2]);
            if ($v_3 === 'ControlRef') {
                var $v_4 = this.$A1_1($v_0[$v_2], $p1);
                if (!CUI.ScriptUtility.isNullOrUndefined($v_4)) {
                    $v_1.addChild($v_4);
                }
            }
            else {
                this.$7R_1($v_0[$v_2], $p1, $v_1, $v_2);
            }
        }
        if (!$v_1.$4_0.$P_0) {
            return null;
        }
        return $v_1;
    },
    
    $A1_1: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = $v_0['TemplateAlias'];
        var $v_2 = $v_0['DisplayMode'];
        var $v_3 = $p1.controls[$v_1];
        var $v_4 = null;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_3) && CUI.Control.isInstanceOfType($v_3)) {
            $v_4 = $v_3.createComponentForDisplayMode($v_2);
        }
        return $v_4;
    },
    
    $7R_1: function($p0, $p1, $p2, $p3) {
        var $v_0 = CUI.DataNodeWrapper.getNodeAttributes($p0);
        var $v_1 = $v_0['TemplateAlias'];
        var $v_2 = CUI.DataNodeWrapper.getNodeName($p0);
        var $v_3 = $p1.controls[$v_1];
        if (CUI.ScriptUtility.isNullOrUndefined($v_3)) {
            return $p3;
        }
        var $v_4 = false;
        var $v_5 = false;
        var $v_6 = 2;
        if ($v_2 === 'OverflowSection') {
            $v_4 = CUI.Utility.$v($v_0['DividerBefore']);
            $v_5 = CUI.Utility.$v($v_0['DividerAfter']);
            if ($v_4) {
                var $v_9 = $p1.ribbon.$26($p2.$6_0 + '-' + $p3++, 1, 1);
                $p2.addChild($v_9);
            }
            var $v_8 = $v_0['Type'];
            switch ($v_8) {
                case 'OneRow':
                    $v_6 = 2;
                    break;
                case 'TwoRow':
                    $v_6 = 3;
                    break;
                case 'ThreeRow':
                    $v_6 = 4;
                    break;
                default:
                    throw Error.create('Invalid Section attribute \"Type\" found in XML: ' + $v_8);
            }
        }
        var $v_7 = $v_0['DisplayMode'];
        if (Array.isInstanceOfType($v_3)) {
            var $v_A = $v_3;
            var $v_B = null;
            for (var $v_C = 0; $v_C < $v_A.length; $v_C++) {
                var $v_D = $v_A[$v_C];
                if ($v_2 === 'OverflowSection') {
                    if ($v_6 === 2) {
                        if (CUI.ScriptUtility.isNullOrUndefined($v_B)) {
                            $v_B = $p1.ribbon.$26($p2.$6_0 + '-' + $p3++, 2, 1);
                            $p2.addChild($v_B);
                        }
                        $v_B.getRow(1).addChild($v_D.createComponentForDisplayMode($v_7));
                    }
                    else if ($v_6 === 4) {
                        if (CUI.ScriptUtility.isNullOrUndefined($v_B)) {
                            $v_B = $p1.ribbon.$26($p2.$6_0 + '-' + $p3++, 4, 1);
                            $p2.addChild($v_B);
                        }
                        $v_B.getRow(($v_C % 3) + 1).addChild($v_D.createComponentForDisplayMode($v_7));
                        if ($v_C % 3 === 2) {
                            $v_B = null;
                        }
                    }
                    else {
                        if (CUI.ScriptUtility.isNullOrUndefined($v_B)) {
                            $v_B = $p1.ribbon.$26($p2.$6_0 + '-' + $p3++, 3, 1);
                            $p2.addChild($v_B);
                        }
                        $v_B.getRow(($v_C % 2) + 1).addChild($v_D.createComponentForDisplayMode($v_7));
                        if ($v_C % 2 === 1) {
                            $v_B = null;
                        }
                    }
                }
                else {
                    $p2.addChild($v_D.createComponentForDisplayMode($v_7));
                }
            }
        }
        else {
            var $v_E = $v_3;
            if ($v_2 === 'OverflowSection') {
                var $v_F;
                if ($v_6 === 2) {
                    $v_F = $p1.ribbon.$26($p2.$6_0 + '-' + $p3++, 2, 1);
                    $v_F.getRow(1).addChild($v_E.createComponentForDisplayMode($v_7));
                }
                else if ($v_6 === 4) {
                    $v_F = $p1.ribbon.$26($p2.$6_0 + '-' + $p3++, 4, 1);
                    $v_F.getRow(1).addChild($v_E.createComponentForDisplayMode($v_7));
                }
                else {
                    $v_F = $p1.ribbon.$26($p2.$6_0 + '-' + $p3++, 3, 1);
                    $v_F.getRow(1).addChild($v_E.createComponentForDisplayMode($v_7));
                }
                $p2.addChild($v_F);
            }
            else {
                $p2.addChild($v_E.createComponentForDisplayMode($v_7));
            }
        }
        if ($v_5) {
            var $v_G = $p1.ribbon.$26($p2.$6_0 + '-' + $p3++, 1, 1);
            $p2.addChild($v_G);
        }
        return $p3;
    }
}


CUI.Group = function(ribbon, id, title, description, command, properties) {ULSpEN:;
    CUI.Group.initializeBase(this, [ ribbon, id, title, description ]);
    this.$y_2 = command;
    this.$5_2 = properties;
}
CUI.Group.prototype = {
    $b_2: null,
    $D_2: null,
    $3b_2: null,
    $V_2: null,
    $5_2: null,
    
    $L: function() {ULSpEN:;
        this.ensureDOMElementAndEmpty();
        if (CUI.ScriptUtility.isNullOrUndefined(this.$D_2)) {
            this.$D_2 = CUI.Utility.$3('span');
            this.$D_2.className = 'ms-cui-groupTitle';
        }
        else {
            this.$D_2 = CUI.Utility.removeChildNodes(this.$D_2);
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$b_2)) {
            this.$b_2 = CUI.Utility.$3('span');
            this.$b_2.className = 'ms-cui-groupBody';
        }
        else {
            this.$b_2 = CUI.Utility.removeChildNodes(this.$b_2);
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$3b_2)) {
            this.$3b_2 = CUI.Utility.$3('span');
            this.$3b_2.className = 'ms-cui-groupSeparator';
        }
        var $v_0 = this.get_title();
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            CUI.UIUtility.setInnerText(this.$D_2, $v_0);
        }
        this.$D_2.title = this.get_title();
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$V_2) && CUI.GroupPopupLayout.isInstanceOfType(this.$V_2)) {
            this.$V_2.$m();
            this.get_$2().appendChild(this.$V_2.get_$2());
            this.get_$2().appendChild(this.$3b_2);
            this.$V_2.$2O();
        }
        else {
            var $v_1 = CUI.Utility.$3('span');
            $v_1.className = 'ms-cui-groupContainer';
            $v_1.appendChild(this.$b_2);
            $v_1.appendChild(this.$D_2);
            this.get_$2().appendChild($v_1);
            this.get_$2().appendChild(this.$3b_2);
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$V_2)) {
                this.$V_2.$m();
                this.$b_2.appendChild(this.$V_2.get_$2());
                this.$V_2.$2O();
            }
        }
        CUI.Group.callBaseMethod(this, '$L');
    },
    
    $3v: function() {ULSpEN:;
        CUI.Group.callBaseMethod(this, '$3v');
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$V_2) && !CUI.GroupPopupLayout.isInstanceOfType(this.$V_2)) {
            var $v_0 = this.get_$2().childNodes[0];
            this.$3b_2 = this.get_$2().childNodes[1];
            this.$b_2 = $v_0.childNodes[0];
            this.$D_2 = $v_0.childNodes[1];
        }
    },
    
    $36: function($p0) {
        this.$3v();
        this.$N();
        this.$g_0 = false;
        if ($p0 && !CUI.ScriptUtility.isNullOrUndefined(this.$V_2)) {
            this.$V_2.$36(true);
        }
    },
    
    $m: function() {ULSpEN:;
        var $v_0 = this.get_$2();
        CUI.Group.callBaseMethod(this, '$m');
    },
    
    get_cssClass: function() {ULSpEN:;
        return 'ms-cui-group';
    },
    
    get_domElementTagName: function() {ULSpEN:;
        return 'li';
    },
    
    unselectLayout: function() {ULSpEN:;
        this.selectLayout(null, null);
    },
    
    selectLayout: function($p0, $p1) {
        var $v_0 = null;
        if ($p0 !== 'Popup') {
            $v_0 = (CUI.ScriptUtility.isNullOrUndefined($p0)) ? null : this.getChildByTitle($p0);
        }
        else {
            if (!CUI.ScriptUtility.isNullOrUndefined($p1)) {
                this.set_popupLayoutTitle($p1);
            }
            this.$Cd_2();
            $v_0 = this.$4j_2;
        }
        if ($v_0 === this.$V_2 || CUI.ScriptUtility.isNullOrUndefined($v_0) && CUI.ScriptUtility.isNullOrUndefined(this.$V_2)) {
            return;
        }
        this.$V_2 = (!CUI.ScriptUtility.isNullOrUndefined($v_0)) ? $v_0 : null;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            $v_0.$7l(true);
            if ($p0 === 'Popup') {
                this.$5d_2.$7l(true);
            }
        }
        this.$w();
    },
    
    get_selectedLayout: function() {ULSpEN:;
        return this.$V_2;
    },
    
    ensureCorrectChildType: function($p0) {
        if (!CUI.Layout.isInstanceOfType($p0) && !CUI.GroupPopupLayout.isInstanceOfType($p0)) {
            throw Error.create('Only children of type Layout can be added to Groups');
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.getChildByTitle($p0.get_title()))) {
            throw Error.create('A Layout with title ' + $p0.get_title() + ' already exists in this Group.');
        }
    },
    
    get_$7b: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$V_2) || CUI.ScriptUtility.isNullOrUndefined(this.$V_2.get_$2())) {
            return false;
        }
        return this.get_$2().offsetHeight < this.$V_2.get_$2().offsetHeight || this.get_$2().offsetWidth < this.$V_2.get_$2().offsetWidth;
    },
    
    $y_2: null,
    
    get_command: function() {ULSpEN:;
        return this.$y_2;
    },
    
    $6l_2: null,
    
    get_popupLayoutTitle: function() {ULSpEN:;
        return this.$6l_2;
    },
    set_popupLayoutTitle: function($p0) {
        if ($p0 === 'Popup') {
            throw Error.create('PopupLayoutTitle cannot be set to \'Popup\'');
        }
        var $v_0 = (CUI.ScriptUtility.isNullOrUndefined($p0)) ? null : this.getChildByTitle($p0);
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            throw Error.create('This Group does not have a Layout with Title: ' + $p0);
        }
        if (this.$6l_2 === $p0) {
            return;
        }
        this.$6l_2 = $p0;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$4i_2)) {
            this.$4i_2.set_layoutTitle($p0);
        }
        return $p0;
    },
    
    $4j_2: null,
    $3n_2: null,
    $4i_2: null,
    $5d_2: null,
    $6m_2: null,
    
    $Cd_2: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$4j_2)) {
            return;
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_popupLayoutTitle())) {
            throw Error.create('No PopupLayoutTitle has been set.');
        }
        this.$4j_2 = this.get_ribbon().$CL(this.$6_0 + '-Popup', this);
        this.$5d_2 = this.get_ribbon().$A6(this.$6_0 + '-popupMenu', null, null, null);
        this.$6m_2 = this.get_ribbon().$A7(this.$6_0 + '-popupMenuSection', null, null, false, null, null);
        var $v_0 = ({});
        $v_0.LabelText = this.get_title();
        var $v_1 = this.get_ribbon().get_ribbonProperties();
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$5_2.Image32by32Popup)) {
            $v_0.Image32by32 = this.$5_2.Image32by32Popup;
            $v_0.Image32by32Class = this.$5_2.Image32by32PopupClass;
            $v_0.Image32by32Top = this.$5_2.Image32by32PopupTop;
            $v_0.Image32by32Left = this.$5_2.Image32by32PopupLeft;
        }
        else {
            $v_0.Image32by32 = $v_1.Image32by32GroupPopupDefault;
            $v_0.Image32by32Class = $v_1.Image32by32GroupPopupDefaultClass;
            $v_0.Image32by32Left = $v_1.Image32by32GroupPopupDefaultLeft;
            $v_0.Image32by32Top = $v_1.Image32by32GroupPopupDefaultTop;
        }
        $v_0.Command = this.$y_2;
        this.$3n_2 = new CUI.Controls.FlyoutAnchor(this.get_ribbon(), this.$6_0 + '-PopupAnchor', $v_0, this.$5d_2);
        this.$3n_2.$6U_2 = true;
        this.$3n_2.set_enabled(this.get_enabled());
        this.$4i_2 = this.get_ribbon().$CK(this.$6_0 + '-popupMenuItem', this);
        this.$4j_2.addChild(this.$3n_2.createComponentForDisplayMode('Large'));
        this.$5d_2.addChild(this.$6m_2);
        this.$6m_2.addChild(this.$4i_2);
        this.$4i_2.set_layoutTitle(this.get_popupLayoutTitle());
        this.addChild(this.$4j_2);
    },
    
    $2P: function() {ULSpEN:;
        this.set_enabled((CUI.ScriptUtility.isNullOrUndefined(this.$y_2)) ? true : this.get_ribbon().$4w(this.$y_2, null, null));
        if (!this.get_enabled() || CUI.ScriptUtility.isNullOrUndefined(this.$V_2)) {
            return;
        }
        this.$V_2.$2P();
    },
    
    onEnabledChanged: function($p0) {
        CUI.Group.callBaseMethod(this, 'onEnabledChanged', [ $p0 ]);
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$3n_2)) {
            this.$3n_2.set_enabled($p0);
        }
    },
    
    $50: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$V_2) && CUI.GroupPopupLayout.isInstanceOfType(this.$V_2)) {
            this.$V_2.get_$2().getElementsByTagName('A')[0].focus();
            return true;
        }
        return CUI.Group.callBaseMethod(this, '$50');
    }
}


CUI.GroupPopup = function(ribbon, id, group) {ULSpEN:;
    this.$8G = Function.createDelegate(this, this.$DD_1);
    CUI.GroupPopup.initializeBase(this, [ ribbon, id, '', '' ]);
    this.$4V_1 = group;
}
CUI.GroupPopup.prototype = {
    $4V_1: null,
    $D_1: null,
    $b_1: null,
    
    $L: function() {ULSpEN:;
        this.ensureDOMElementAndEmpty();
        if (CUI.ScriptUtility.isNullOrUndefined(this.$D_1)) {
            this.$D_1 = CUI.Utility.$3('div');
            this.$D_1.className = 'ms-cui-groupTitle';
        }
        else {
            this.$D_1 = CUI.Utility.removeChildNodes(this.$D_1);
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$b_1)) {
            this.$b_1 = CUI.Utility.$3('div');
            this.$b_1.className = 'ms-cui-groupBody';
        }
        else {
            this.$b_1 = CUI.Utility.removeChildNodes(this.$b_1);
        }
        CUI.UIUtility.setInnerText(this.$D_1, this.$4V_1.get_title());
        this.get_$2().appendChild(this.$b_1);
        this.get_$2().appendChild(this.$D_1);
        var $v_0 = this.$4V_1.getChildByTitle(this.$4a_1);
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            throw Error.create('Cannot find Layout with title: ' + this.$4a_1 + ' for this GroupPopup to use from the Group with id: ' + this.$4V_1.$6_0);
        }
        var $v_1 = $v_0.$4m(true);
        this.removeChildren();
        this.addChild($v_1);
        this.appendChildrenToElement(this.$b_1);
        CUI.GroupPopup.callBaseMethod(this, '$L');
    },
    
    $4a_1: null,
    
    get_layoutTitle: function() {ULSpEN:;
        return this.$4a_1;
    },
    set_layoutTitle: function($p0) {
        if (this.$4a_1 === $p0) {
            return;
        }
        this.$4a_1 = $p0;
        this.$w();
        return $p0;
    },
    
    get_cssClass: function() {ULSpEN:;
        return 'ms-cui-groupPopup';
    },
    
    $4D_1: null,
    
    $1g: function($p0) {
        if ($p0.$G_1 === 4) {
            var $v_0 = $p0.get_sourceControl();
            if (this.$4D_1) {
                return CUI.GroupPopup.callBaseMethod(this, '$1g', [ $p0 ]);
            }
            this.$4D_1 = $v_0;
            this.$EB_1();
        }
        else if ($p0.$G_1 === 10) {
            this.$D2_1();
            this.$4D_1 = null;
        }
        return CUI.GroupPopup.callBaseMethod(this, '$1g', [ $p0 ]);
    },
    
    $3X_1: null,
    $5V_1: false,
    
    $EB_1: function() {ULSpEN:;
        if (this.$5V_1) {
            return;
        }
        if (!this.$3X_1) {
            this.$3X_1 = CUI.Utility.$A3();
            $addHandler(this.$3X_1, 'click', this.$8G);
            this.get_$2().appendChild(this.$3X_1);
        }
        this.$3X_1.style.display = '';
        this.$5V_1 = true;
    },
    
    $D2_1: function() {ULSpEN:;
        if (!this.$5V_1) {
            return;
        }
        this.$3X_1.style.display = 'none';
        this.$5V_1 = false;
    },
    
    $DD_1: function($p0) {
        if (this.$4D_1) {
            this.$4D_1.$4o();
        }
    }
}


CUI.GroupPopupLayout = function(ribbon, id, group) {ULSpEN:;
    CUI.GroupPopupLayout.initializeBase(this, [ ribbon, id, 'Popup' ]);
    this.$4V_3 = group;
}
CUI.GroupPopupLayout.prototype = {
    $4V_3: null,
    
    $L: function() {ULSpEN:;
        CUI.GroupPopupLayout.callBaseMethod(this, '$L');
    },
    
    get_cssClass: function() {ULSpEN:;
        return null;
    },
    
    ensureCorrectChildType: function($p0) {
        if (!CUI.ControlComponent.isInstanceOfType($p0)) {
            throw Error.create('Only ControlComponents can be added to GroupPopupLayout.');
        }
        if (this.$4_0.$P_0 > 0) {
            throw Error.create('GroupPopupLayouts can only have one child');
        }
    }
}


CUI.Layout = function(ribbon, id, title) {ULSpEN:;
    CUI.Layout.initializeBase(this, [ ribbon, id, title, '' ]);
}
CUI.Layout.prototype = {
    
    $L: function() {ULSpEN:;
        if (this.get_needsDelayIniting()) {
            this.doDelayedInit();
        }
        this.ensureDOMElementAndEmpty();
        this.appendChildrenToElement(this.get_$2());
        CUI.Layout.callBaseMethod(this, '$L');
    },
    
    $3v: function() {ULSpEN:;
        if (this.get_needsDelayIniting()) {
            this.doDelayedInit();
        }
        this.set_$2($get(this.$K_0.$6_0 + '-' + this.get_title()));
    },
    
    ensureCorrectChildType: function($p0) {
        if (!CUI.Section.isInstanceOfType($p0)) {
            throw Error.create('Only children of Section can be added to a Layout');
        }
    },
    
    get_cssClass: function() {ULSpEN:;
        return 'ms-cui-layout';
    },
    
    $4m: function($p0) {
        if (this.get_needsDelayIniting()) {
            this.doDelayedInit();
        }
        var $v_0 = this.get_ribbon().$A5('clonedLayout-' + this.get_ribbon().$27(), this.get_title());
        if (!$p0) {
            return $v_0;
        }
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_1 = $$enum_1_0.get_current();
            var $v_2 = $v_1.$4m($p0);
            $v_0.addChild($v_2);
        }
        return $v_0;
    },
    
    get_visibleInDOM: function() {ULSpEN:;
        if (CUI.Group.isInstanceOfType(this.$K_0)) {
            var $v_0 = this.$K_0;
            return $v_0.$V_2 === this;
        }
        else if (CUI.GroupPopup.isInstanceOfType(this.$K_0)) {
            return true;
        }
        else {
            return false;
        }
    }
}


CUI.RibbonEventCommandProperties = function() {ULSpEN:;
    CUI.RibbonEventCommandProperties.initializeBase(this);
}
CUI.RibbonEventCommandProperties.prototype = {
    Minimized: false,
    Maximized: false
}


CUI.CommandContextSwitchCommandProperties = function() {
}
CUI.CommandContextSwitchCommandProperties.prototype = {
    OldContextId: null,
    OldContextCommand: null,
    NewContextId: null,
    NewContextCommand: null,
    ChangedByUser: false
}


CUI.Ribbon = function(id, properties) {ULSpEN:;
    this.$8Q = Function.createDelegate(this, this.$DJ);
    this.$8y = Function.createDelegate(this, this.$Db);
    this.$8R = Function.createDelegate(this, this.$DK);
    this.$98 = Function.createDelegate(this, this.$Dk_2);
    this.$6Y_2 = new Date(0);
    this.$73_2 = CUI.Utility.$38();
    this.$72_2 = CUI.Utility.$3y();
    CUI.Ribbon.initializeBase(this, [ id, properties ]);
    this.$11_2 = {};
    this.$9T_2 = properties.ShortcutKeyJumpToRibbon_Ctrl + properties.ShortcutKeyJumpToRibbon_Alt + properties.ShortcutKeyJumpToRibbon_Shift + properties.ShortcutKeyJumpToRibbon_AccessKey;
    this.$9S_2 = properties.ShortcutKeyJumpToFirstControl_Ctrl + properties.ShortcutKeyJumpToFirstControl_Alt + properties.ShortcutKeyJumpToFirstControl_Shift + properties.ShortcutKeyJumpToFirstControl_AccessKey;
    this.$2y_2 = this.$AX_2();
}
CUI.Ribbon.prototype = {
    $A_2: null,
    $30_2: null,
    $1k_2: null,
    $e_2: null,
    $f_2: null,
    $q_2: null,
    $BM_2: null,
    $p_2: null,
    $2t_2: null,
    $l_2: null,
    $2s_2: null,
    $9Y_2: null,
    $1l_2: null,
    $1m_2: null,
    $t_2: null,
    $u_2: null,
    $4h_2: false,
    $2u_2: null,
    $4Y_2: null,
    $9S_2: null,
    $9T_2: null,
    $4f_2: null,
    $74_2: false,
    $9a_2: null,
    $9b_2: null,
    $9Z_2: null,
    $9N_2: false,
    $6g_2: null,
    
    get_storedFocus: function() {ULSpEN:;
        return this.$2u_2;
    },
    set_storedFocus: function(value) {ULSpEN:;
        this.$2u_2 = value;
        return value;
    },
    
    $7s_2: function($p0) {
        if (CUI.ScriptUtility.isNullOrUndefined($p0)) {
            return false;
        }
        else if (!CUI.ScriptUtility.isNullOrUndefined($p0.id) && $p0.id === 'Ribbon') {
            return false;
        }
        else if ($p0.tagName === 'BODY') {
            return true;
        }
        else {
            return this.$7s_2($p0.parentNode);
        }
    },
    
    refresh: function() {ULSpEN:;
        this.$L();
        CUI.Ribbon.callBaseMethod(this, 'refresh');
        this.$45();
    },
    
    $L: function() {ULSpEN:;
        CUI.Ribbon.callBaseMethod(this, '$L');
        this.$m();
        this.$D0_2();
        var $v_0 = null;
        var $v_1 = null, $v_2 = null;
        var $v_3 = null;
        var $v_4 = null;
        CUI.Utility.removeChildNodesSlow(this.$q_2);
        var $$dict_1_0 = this.$11_2;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_B = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            var $v_C = $v_B.value;
            $v_C.$Cg();
        }
        var $v_5 = 0;
        var $v_6 = new CUI.List();
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_D = $$enum_1_0.get_current();
            if ($v_D.get_visible()) {
                $v_6.add($v_D);
                $v_5++;
            }
        }
        var $v_7 = 0;
        var $v_8 = $v_6.$P_0;
        var $v_9 = !(CUI.ScriptUtility.isNullOrEmptyString(this.get_ribbonProperties().ATTabPositionText) || CUI.ScriptUtility.isNullOrEmptyString(this.get_ribbonProperties().ATContextualTabText));
        var $$enum_1_0 = $v_6.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_E = $$enum_1_0.get_current();
            $v_E.$7G();
            if (CUI.ScriptUtility.isNullOrUndefined($v_1)) {
                $v_1 = $v_E;
                this.$4Y_2 = $v_1.$6_0;
            }
            $v_E.$Dy();
            if ($v_E.$1A_2) {
                if (!$v_3 || $v_E.$10_2 !== $v_3) {
                    if ($v_E.$10_2 !== $v_3) {
                        if (!CUI.ScriptUtility.isNullOrUndefined($v_2) && $v_2.$1A_2) {
                            CUI.Utility.ensureCSSClassOnElement($v_2.$D_2, 'ms-cui-ct-last');
                        }
                    }
                    $v_3 = $v_E.$10_2;
                    $v_4 = this.$11_2[$v_E.$10_2];
                    CUI.Utility.removeCSSClassFromElement($v_4.get_$2(), 'ms-cui-cg-s');
                    this.$7j(0);
                    this.$q_2.appendChild($v_4.get_$2());
                    CUI.Utility.ensureCSSClassOnElement($v_E.$D_2, 'ms-cui-ct-first');
                }
                $v_4.$BZ($v_E.$D_2);
            }
            else {
                if ($v_3) {
                    CUI.Utility.ensureCSSClassOnElement($v_2.$D_2, 'ms-cui-ct-last');
                    $v_3 = null;
                    $v_4 = null;
                }
                if ($v_9) {
                    $v_7++;
                    $v_E.$BB(this.get_ribbonProperties().ATTabPositionText, null, null, $v_7, $v_8);
                }
                this.$q_2.appendChild($v_E.$D_2);
            }
            if ($v_E === this.$A_2) {
                $v_0 = $v_E;
            }
            $v_2 = $v_E;
        }
        if ($v_3) {
            CUI.Utility.ensureCSSClassOnElement($v_2.$D_2, 'ms-cui-ct-last');
            $v_2 = null;
            $v_3 = null;
            $v_4 = null;
        }
        var $v_A = 1;
        if ($v_9) {
            for (var $v_F = 0; $v_F < $v_5; $v_F++) {
                var $v_G = $v_6.get_item($v_F);
                if ($v_G.$1A_2) {
                    if ($v_G.$10_2 !== $v_3) {
                        $v_3 = $v_G.$10_2;
                        $v_4 = this.$11_2[$v_G.$10_2];
                        $v_A = 1;
                    }
                    $v_G.$AB();
                    $v_G.$BB(this.get_ribbonProperties().ATTabPositionText, this.get_ribbonProperties().ATContextualTabText, $v_4.$1S_0, $v_A, $v_4.$2c_0);
                    $v_A++;
                }
            }
        }
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            if ($v_0.$1A_2) {
                var $v_H = this.$7L($v_0.$10_2);
                CUI.Utility.ensureCSSClassOnElement($v_H.get_$2(), 'ms-cui-cg-s');
                this.$7j($v_H.$3S_0);
            }
        }
        if (CUI.ScriptUtility.isNullOrUndefined($v_0) && !this.$21_2) {
            $v_0 = (!CUI.ScriptUtility.isNullOrUndefined(this.$6a_2)) ? this.$6a_2 : $v_1;
            this.$5u($v_0);
        }
        if (this.$21_2) {
            $v_0 = null;
        }
        this.$EH();
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            if ($v_0.get_$B5()) {
                CUI.Utility.disableElement(this.$l_2);
            }
            var $v_I = this.$l_2.className.indexOf('ms-cui-disabled') !== -1;
            this.$l_2.className = $v_0.$Cv() + (($v_I) ? ' ms-cui-disabled' : '');
        }
        this.$N();
        this.$g_0 = false;
        if (this.$6f_2 && !CUI.ScriptUtility.isNullOrUndefined(this.get_ribbonProperties().RootEventCommand)) {
            var $v_J = new CUI.RibbonEventCommandProperties();
            $v_J.RootId = this.$6_0;
            $v_J.RootType = 'Ribbon';
            $v_J.Minimized = this.get_minimized();
            $v_J.Maximized = !this.get_minimized();
            this.raiseCommandEvent(this.get_ribbonProperties().RootEventCommand, 11, $v_J);
            this.$6f_2 = false;
        }
    },
    
    $36: function($p0) {
        this.$3v();
        this.$N();
        this.$g_0 = false;
        var $v_0 = this.$4_0;
        if ($p0) {
            if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
                var $$enum_3_0 = $v_0.getEnumerator();
                while ($$enum_3_0.moveNext()) {
                    var $v_1 = $$enum_3_0.get_current();
                    if (!$v_1.get_visible()) {
                        continue;
                    }
                    if (!CUI.ScriptUtility.isNullOrUndefined(this.$A_2) && this.$A_2 === $v_1) {
                        this.$A_2.$36($p0);
                    }
                    else {
                        $v_1.$9s();
                        $v_1.$9t();
                    }
                }
            }
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$11_2)) {
            var $$dict_2_0 = this.$11_2;
            for (var $$key_2_1 in $$dict_2_0) {
                var $v_2 = { key: $$key_2_1, value: $$dict_2_0[$$key_2_1] };
                ($v_2.value).$Bd();
            }
        }
    },
    
    $3v: function() {ULSpEN:;
        CUI.Ribbon.callBaseMethod(this, '$3v');
        var $v_0 = this.get_$2().childNodes;
        this.$BM_2 = $get('cui-' + this.$6_0 + '-scrollCurtain');
        this.$2s_2 = $v_0[0];
        this.$1k_2 = $v_0[1];
        this.$e_2 = this.$1k_2.childNodes[0];
        this.$f_2 = this.$1k_2.childNodes[1];
        this.$p_2 = this.$f_2.childNodes[0];
        if ($v_0.length > 2) {
            this.$l_2 = $v_0[2];
        }
        this.$2t_2 = CUI.Utility.$5q(this.$e_2, 'ms-cui-qat-container');
        this.$q_2 = CUI.Utility.$5q(this.$f_2, 'ms-cui-tts');
        if (CUI.ScriptUtility.isNullOrUndefined(this.$q_2)) {
            this.$q_2 = CUI.Utility.$5q(this.$f_2, 'ms-cui-tts-scale-1');
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$q_2)) {
            this.$q_2 = CUI.Utility.$5q(this.$f_2, 'ms-cui-tts-scale-2');
        }
    },
    
    $N: function() {ULSpEN:;
        this.$4f_2 = this.$98;
        this.set_$52(true);
        this.$9a_2 = this.$8R;
        this.$9b_2 = this.$8y;
        this.$9Z_2 = this.$8Q;
        $addHandler(this.get_$2(), 'keydown', this.$9b_2);
        if (!this.$9N_2) {
            $addHandler(document, 'keydown', this.$9a_2);
            $addHandler(this.get_$2(), 'keydown', this.$9Z_2);
            this.$9N_2 = true;
        }
        CUI.Ribbon.callBaseMethod(this, '$N');
    },
    
    get_$52: function() {ULSpEN:;
        return this.$74_2;
    },
    set_$52: function($p0) {
        if ($p0 === this.$74_2) {
            return;
        }
        if ($p0) {
            $addHandler(window, 'resize', this.$4f_2);
        }
        else {
            try {
                $removeHandler(window, 'resize', this.$4f_2);
            }
            catch ($$e_2_0) {
            }
        }
        this.$74_2 = $p0;
        return $p0;
    },
    
    $DK: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined($p0) && !CUI.ScriptUtility.isNullOrUndefined($p0.rawEvent)) {
            var $v_0 = $p0.rawEvent.keyCode;
            var $v_1 = ($p0.ctrlKey) ? 't' : 'f';
            $v_1 += ($p0.altKey) ? 't' : 'f';
            $v_1 += ($p0.shiftKey) ? 't' : 'f';
            try {
                $v_1 += String.fromCharCode(_processKeyCodes($v_0));
            }
            catch ($$e_2_0) {
                return;
            }
            var $v_2 = $p0.target;
            if ($v_1 === this.$9S_2) {
                this.$9z_2();
                this.jumpToLastFocused($v_2);
            }
            else if ($v_1 === this.$9T_2) {
                this.$9z_2();
                this.jumpToRibbonTab($v_2);
            }
        }
    },
    
    $9z_2: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(document.selection) && document.selection.type === 'Control') {
            var $v_0 = document.selection.createRange();
            for (var $v_1 = $v_0.length; $v_1 > 0; $v_1--) {
                $v_0.remove($v_1 - 1);
            }
            $v_0.select();
        }
    },
    
    jumpToLastFocused: function(currentElement) {ULSpEN:;
        if (this.$1o_1) {
            this.$0_0.$4n();
        }
        if (this.$7s_2(currentElement)) {
            this.$2u_2 = currentElement;
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.get_$o())) {
            try {
                this.setFocus();
            }
            catch ($$e_2_0) {
            }
            return;
        }
        this.setFocusOnRibbon();
    },
    
    jumpToRibbonTab: function(currentElement) {ULSpEN:;
        if (this.$7s_2(currentElement)) {
            this.$2u_2 = currentElement;
        }
        if (this.$1o_1) {
            this.$0_0.$4n();
        }
        if (!CUI.ScriptUtility.isNullOrEmptyString(this.$4Y_2)) {
            var $v_0 = $get(this.$4Y_2 + '-title');
            if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
                $v_0.firstChild.focus();
            }
        }
    },
    
    setFocusOnTabTitle: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrEmptyString(this.$4Y_2)) {
            var $v_0 = $get(this.$4Y_2 + '-title');
            if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
                $v_0.firstChild.focus();
            }
        }
    },
    
    $DJ: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined($p0) && !CUI.ScriptUtility.isNullOrUndefined($p0.rawEvent)) {
            var $v_0 = $p0.rawEvent.keyCode;
            if ((($p0.ctrlKey || $p0.shiftKey) && ($v_0 === 39 && !this.$0_0._textDirection) || ($v_0 === 37 && this.$0_0._textDirection === 1))) {
                $p0.preventDefault();
                $p0.stopPropagation();
                this.$A_2.$Am(true);
            }
            else if ((($p0.ctrlKey || $p0.shiftKey) && ($v_0 === 37 && !this.$0_0._textDirection) || ($v_0 === 39 && this.$0_0._textDirection === 1))) {
                $p0.preventDefault();
                $p0.stopPropagation();
                this.$A_2.$Am(false);
            }
        }
    },
    
    setFocusOnRibbon: function() {ULSpEN:;
        if (this.$21_2) {
            this.setFocusOnTabTitle();
        }
        else {
            this.$A_2.$BD();
        }
    },
    
    setFocusOnCurrentTab: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$A_2)) {
            this.$A_2.$E5();
        }
        else {
            this.setFocusOnRibbon();
        }
    },
    
    setFocus: function() {ULSpEN:;
        if (this.$21_2 || !CUI.Ribbon.callBaseMethod(this, 'setFocus')) {
            this.setFocusOnTabTitle();
        }
        return true;
    },
    
    $Db: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined($p0) && !CUI.ScriptUtility.isNullOrUndefined($p0.rawEvent) && !this.$1o_1) {
            if ($p0.rawEvent.keyCode === 27 && !CUI.ScriptUtility.isNullOrUndefined(this.$2u_2)) {
                $p0.stopPropagation();
                $p0.preventDefault();
                try {
                    this.$2u_2.focus();
                }
                catch ($$e_3_0) {
                }
                this.$2u_2 = null;
            }
        }
    },
    
    $11_2: null,
    
    addContextualGroup: function(id, title, color, command) {ULSpEN:;
        var $v_0 = this.$11_2[id];
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            throw Error.create('A contextual group with id: ' + id + ' has already been added to this ribbon.');
        }
        $v_0 = new CUI.ContextualGroup(id, title, color, command);
        this.$11_2[id] = $v_0;
    },
    
    get_contextualGroupIds: function() {ULSpEN:;
        var $v_0 = [];
        var $$dict_1_0 = this.$11_2;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_1 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            Array.add($v_0, $v_1.key);
        }
        return $v_0;
    },
    
    removeContextualGroup: function(id) {ULSpEN:;
        var $v_0 = this.$11_2[id];
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            var $$enum_2_0 = this.$4_0.getEnumerator();
            while ($$enum_2_0.moveNext()) {
                var $v_1 = $$enum_2_0.get_current();
                if ($v_1.$1A_2 && $v_1.$10_2 === id) {
                    throw Error.create('You cannot remove a contextual group when there are Tabs that refer to it.');
                }
            }
            delete this.$11_2[id];
        }
    },
    
    showContextualGroup: function(id) {ULSpEN:;
        this.$7r_2(id, true);
    },
    
    hideContextualGroup: function(id) {ULSpEN:;
        this.$7r_2(id, false);
    },
    
    $7r_2: function($p0, $p1) {
        var $v_0 = this.$11_2[$p0];
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            throw Error.create('This ribbon does not contain a contextual group with id: ' + $p0);
        }
        var $v_1 = false;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_2 = $$enum_1_0.get_current();
            if ($v_2.$10_2 === $p0) {
                if ($v_2.get_visible() !== $p1) {
                    $v_1 = true;
                }
                $v_2.set_$64($p1);
            }
        }
        if ($v_1) {
            this.$w();
        }
    },
    
    $7L: function($p0) {
        return this.$11_2[$p0];
    },
    
    addChildAtIndex: function(child, index) {ULSpEN:;
        this.ensureCorrectChildType(child);
        var $v_0 = child;
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            throw Error.create('child must not be null or undefined.');
        }
        if ($v_0.$1A_2) {
            var $v_1 = this.$11_2[$v_0.$10_2];
            if (CUI.ScriptUtility.isNullOrUndefined($v_1)) {
                throw Error.create('A contextual tab with contextual group id: ' + $v_0.$10_2 + ' cannot be added because ' + ' the ribbon does not have a contextual group with this id.');
            }
        }
        CUI.Ribbon.callBaseMethod(this, 'addChildAtIndex', [ child, index ]);
    },
    
    ensureCorrectChildType: function(child) {ULSpEN:;
        if (!CUI.Tab.isInstanceOfType(child)) {
            throw Error.create('Only children of type Tab can be added to a Ribbon');
        }
    },
    
    get_cssClass: function() {ULSpEN:;
        return 'ms-cui-ribbon';
    },
    
    get_rootType: function() {ULSpEN:;
        return 'Ribbon';
    },
    
    $AC_2: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$p_2)) {
            this.$p_2 = CUI.Utility.$3('div');
            this.$p_2.id = 'jewelcontainer';
            this.$p_2.className = 'ms-cui-jewel-container';
            this.$p_2.style.display = 'none';
            this.$f_2.appendChild(this.$p_2);
        }
    },
    
    $Ce_2: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$2t_2)) {
            this.$2t_2 = CUI.Utility.$3('span');
            this.$2t_2.className = 'ms-cui-qat-container';
            this.$e_2.appendChild(this.$2t_2);
        }
    },
    
    $9w: function($p0, $p1, $p2) {
        var $v_0 = new CUI.QATBuildOptions();
        $v_0.attachToDOM = $p1;
        $v_0.trimmedIds = this.get_$2Q().$s_0.trimmedIds;
        var $v_1 = new CUI.QATBuilder($v_0, this.$2t_2, this.get_$2Q().$1R_0);
        $v_1.$12_0 = $p2;
        if (!$v_1.buildQAT($p0)) {
            throw Error.create('QAT could not be built');
        }
        this._qat = $v_1.get_QAT();
        this.$e_2.style.display = 'block';
    },
    
    $9v: function($p0, $p1, $p2) {
        this.$p_2.style.display = 'block';
        var $v_0 = new CUI.JewelBuildOptions();
        $v_0.attachToDOM = $p1;
        $v_0.trimmedIds = this.get_$2Q().$s_0.trimmedIds;
        var $v_1 = new CUI.JewelBuilder($v_0, this.$p_2, this.get_$2Q().$1R_0);
        $v_1.$12_0 = $p2;
        if (!$v_1.buildJewel($p0)) {
            throw Error.create('Jewel could not be built');
        }
        this._jewel = $v_1.get_jewel();
    },
    
    _qat: null,
    
    get_QAT: function() {ULSpEN:;
        return this._qat;
    },
    set_QAT: function(value) {ULSpEN:;
        this._qat = value;
        return value;
    },
    
    _jewel: null,
    
    get_jewel: function() {ULSpEN:;
        return this._jewel;
    },
    set_jewel: function(value) {ULSpEN:;
        this._jewel = value;
        return value;
    },
    
    $CP: function($p0, $p1, $p2, $p3, $p4) {
        return new CUI.Tab(this, $p0, $p1, $p2, $p3, false, null, $p4);
    },
    
    $CG: function($p0, $p1, $p2, $p3, $p4, $p5) {
        return new CUI.Tab(this, $p0, $p1, $p2, $p3, true, $p4, $p5);
    },
    
    $CJ: function($p0, $p1, $p2, $p3, $p4) {
        return new CUI.Group(this, $p0, $p2, $p3, $p4, $p1);
    },
    
    $CK: function($p0, $p1) {
        return new CUI.GroupPopup(this, $p0, $p1);
    },
    
    $CL: function($p0, $p1) {
        return new CUI.GroupPopupLayout(this, $p0, $p1);
    },
    
    $A5: function($p0, $p1) {
        return new CUI.Layout(this, $p0, $p1);
    },
    
    $26: function($p0, $p1, $p2) {
        return new CUI.Section(this, $p0, $p1, $p2);
    },
    
    $A8: function($p0) {
        return new CUI.Strip(this, $p0);
    },
    
    $6a_2: null,
    
    $EH: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$A_2)) {
            this.$A_2.$m();
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$A_2) && !this.$A_2.$1A_2) {
            this.$6a_2 = this.$A_2;
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$A_2) || !this.$A_2.$4_0.$P_0) {
            if (!CUI.ScriptUtility.isNullOrUndefined(this.get_$2()) && !CUI.ScriptUtility.isNullOrUndefined(this.$l_2) && this.get_$2().lastChild === this.$l_2) {
                this.get_$2().removeChild(this.$l_2);
            }
        }
        else if (!CUI.ScriptUtility.isNullOrUndefined(this.$l_2)) {
            this.get_$2().appendChild(this.$l_2);
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$A_2)) {
            return;
        }
        var $v_0 = this.$A_2.$g_0;
        this.$A_2.$2O();
        if (this.$A_2.$4_0.$P_0 > 0 && !CUI.ScriptUtility.isNullOrUndefined(this.$l_2)) {
            var $v_1 = false;
            if (this.$l_2.hasChildNodes()) {
                $v_1 = this.$l_2.firstChild === this.$A_2.get_$2();
                if (!$v_1) {
                    this.$l_2.removeChild(this.$l_2.firstChild);
                }
            }
            if (!$v_1) {
                this.$l_2.appendChild(this.$A_2.get_$2());
            }
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.get_ribbonProperties().TabSwitchCommand) && (this.$30_2 !== this.$A_2)) {
            var $v_2 = new CUI.CommandContextSwitchCommandProperties();
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$30_2) && this.$30_2 !== this.$A_2) {
                $v_2.OldContextId = this.$30_2.$6_0;
                $v_2.OldContextCommand = this.$30_2.$y_2;
            }
            else {
                $v_2.OldContextId = null;
                $v_2.OldContextCommand = null;
            }
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$A_2)) {
                $v_2.NewContextId = this.$A_2.$6_0;
                $v_2.NewContextCommand = this.$A_2.$y_2;
                $v_2.ChangedByUser = this.$A_2.$5g_2;
            }
            this.raiseCommandEvent(this.get_ribbonProperties().TabSwitchCommand, 2, $v_2);
            this.$EI_2(this.$A_2);
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$A_2)) {
            this.$A_2.$5g_2 = false;
            if (this.$A_2.$1E_2) {
                this.$A_2.$BD();
            }
        }
    },
    
    $5u: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined($p0)) {
            this.$w();
            $p0.$7q(true, false);
            if (!$p0.$1A_2) {
                this.$7j(0);
            }
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$A_2) && this.$A_2 !== $p0) {
                this.$A_2.$7q(false, false);
            }
            this.$A_2 = $p0;
            this.set_$41(false);
        }
        this.set_$o(null);
    },
    
    $EI_2: function($p0) {
        this.$30_2 = $p0;
    },
    
    selectTabById: function(tabId) {ULSpEN:;
        var $v_0 = this.getChild(tabId);
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            if ($v_0.get_selected() && $v_0.get_visible()) {
                return true;
            }
            if ($v_0.$1A_2 && !$v_0.get_visible()) {
                this.showContextualGroup($v_0.$10_2);
            }
            if ($v_0.get_visible()) {
                $v_0.set_selected(true);
                return true;
            }
        }
        return false;
    },
    
    selectTabByCommand: function(tabCommand) {ULSpEN:;
        if (this.get_selectedTabCommand() === tabCommand) {
            return true;
        }
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_0 = $$enum_1_0.get_current();
            if ($v_0.$y_2 === tabCommand) {
                return this.selectTabById($v_0.$6_0);
            }
        }
        return false;
    },
    
    $7j: function($p0) {
        var $v_0 = CUI.ContextualGroup.$5o($p0);
        if ($v_0 === '') {
            CUI.Utility.removeCSSClassFromElement(this.$f_2, this.$3T_2);
            this.$3T_2 = null;
        }
        else {
            if (!this.$3T_2) {
                CUI.Utility.removeCSSClassFromElement(this.$f_2, this.$3T_2);
            }
            this.$3T_2 = 'ms-cui-ct-topBar-' + $v_0;
            CUI.Utility.ensureCSSClassOnElement(this.$f_2, this.$3T_2);
        }
    },
    
    $3T_2: null,
    
    get_selectedTabCommand: function() {ULSpEN:;
        return (this.$A_2) ? this.$A_2.$y_2 : null;
    },
    
    get_selectedTabId: function() {ULSpEN:;
        return (this.$A_2) ? this.$A_2.$6_0 : null;
    },
    
    $AW_2: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$A_2)) {
            return 0;
        }
        return this.$l_2.offsetHeight - this.$A_2.get_$2().offsetHeight;
    },
    
    $5r_2: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$A_2)) {
            return 0;
        }
        return this.$l_2.offsetWidth - this.$A_2.$Cx();
    },
    
    $7P_2: function() {ULSpEN:;
        return this.get_$2().offsetWidth;
    },
    
    $AT_2: function() {ULSpEN:;
        return 100;
    },
    
    $Aa_2: function() {ULSpEN:;
        this.$9Y_2 = this.get_$2().style.display;
        this.get_$2().style.display = 'none';
        return;
    },
    
    $EA_2: function() {ULSpEN:;
        this.get_$2().style.display = this.$9Y_2;
        if (this.$7P_2() < this.$AT_2()) {
            this.get_$2().style.display = 'none';
            return;
        }
    },
    
    $AX_2: function() {ULSpEN:;
        return CUI.Utility.$38().toString() + CUI.Utility.$3y().toString();
    },
    
    $E0: function($p0) {
        var $v_0 = 20;
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            return false;
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$A_2) && !this.$A_2.$9e_2) {
            var $v_6 = null;
            if (this.$3u_1) {
                $v_6 = this.getDataCookieValue(this.$A_2.$6_0);
            }
            var $v_7 = this.$2y_2;
            if (!CUI.ScriptUtility.isNullOrUndefined($v_6) && $v_6.startsWith($v_7)) {
                var $v_8 = $v_6.split('|');
                if (!CUI.ScriptUtility.isNullOrUndefined($v_8) && $v_8.length === 4) {
                    var $v_9 = parseInt($v_8[1]);
                    var $v_A = parseInt($v_8[2]);
                    var $v_B = $v_8[3];
                    $v_0 = ($v_A > $v_0) ? $v_A : $v_0;
                    if (!isNaN($v_9) && $v_9 >= 0) {
                        if ($v_9 >= 0 && $v_9 < this.$A_2.get_scaling().$1q_0.length) {
                            this.$A_2.scaleIndex($v_9);
                            this.$A_2.$9e_2 = true;
                            this.$L();
                            if ($v_B === (this.get_$18()).get_ribbonBuildOptions().scalingHint) {
                                this.$A_2.$6Z_2 = this.$2y_2;
                                return true;
                            }
                        }
                    }
                }
            }
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$A_2)) {
            return false;
        }
        if (this.$A_2.$g_0) {
            this.$L();
        }
        if ($p0 && this.$7P_2() > 0) {
            if (!CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
                if (this.get_$2().style.display !== 'none' && this.$7P_2() < this.$AT_2()) {
                    this.$Aa_2();
                }
                else if (this.get_$2().style.display === 'none') {
                    this.$EA_2();
                }
            }
        }
        var $v_1 = 0;
        var $v_2 = false;
        while ((this.$5r_2() < 0 || this.$AW_2() < 0 || this.$A_2.get_$7b()) && $v_1 < 25) {
            if (!this.$A_2.scaleDown()) {
                $v_2 = true;
                break;
            }
            this.$L();
            $v_1++;
        }
        if ($v_2) {
        }
        var $v_3 = 0;
        var $v_4 = 0;
        if ($v_1 <= 0) {
            while (this.$5r_2() > $v_0 && $v_3 < 25) {
                if (!this.$A_2.scaleUp()) {
                    break;
                }
                this.$L();
                $v_3++;
                if (this.$5r_2() <= 0 || this.$AW_2() < 0 || this.$A_2.get_$7b()) {
                    this.$A_2.scaleDown();
                    this.$L();
                    $v_4++;
                    break;
                }
            }
        }
        if (this.$3u_1 && this.$A_2.$1L_2 >= -1) {
            this.$EE_2();
        }
        this.$A_2.$6Z_2 = this.$2y_2;
        this.$7g_2();
        var $v_5 = ($v_1 > 0 || $v_3 - $v_4 > 0);
        if ($v_5) {
            if (!CUI.ScriptUtility.isNullOrUndefined(this.get_ribbonProperties().ScaleCommand)) {
                this.raiseCommandEvent(this.get_ribbonProperties().ScaleCommand, 1, null);
            }
        }
        return $v_5;
    },
    
    $E9_2: function() {ULSpEN:;
        return ((this.$0_0._textDirection === 1) && CUI.Utility.$3B());
    },
    
    $E6_2: function() {ULSpEN:;
        this.$q_2.style.width = 'auto';
        var $v_0 = this.$9y_2(this.$q_2);
        this.$q_2.style.width = $v_0 + 'px';
        this.$q_2.setAttribute('_widthAdded', true);
    },
    
    $9y_2: function($p0) {
        var $v_0 = 0;
        var $v_1 = $p0.children;
        var $v_2 = $v_1.length;
        for (var $v_3 = 0; $v_3 < $v_2; $v_3++) {
            var $v_4 = $v_1[$v_3];
            if (!CUI.ScriptUtility.isNullOrUndefined($v_4) && $v_4.nodeName === 'LI' && $v_4.offsetWidth > 0) {
                var $v_5 = $v_4.childNodes[1];
                if (!CUI.ScriptUtility.isNullOrUndefined($v_5) && $v_5.nodeName === 'UL') {
                    $v_5.style.width = 'auto';
                    var $v_6 = this.$9y_2($v_5);
                    $v_5.style.width = $v_6 + 'px';
                    $v_0 = $v_0 + $v_6 + 4;
                }
                else {
                    $v_0 = $v_0 + $v_4.offsetWidth + 2;
                }
            }
        }
        return $v_0;
    },
    
    $7g_2: function() {ULSpEN:;
        if (this.$E9_2()) {
            this.$E6_2();
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(window._ribbonScaleHeader)) {
            window._ribbonScaleHeader(this.$1k_2, this.$0_0._textDirection === 1);
        }
    },
    
    $45: function() {ULSpEN:;
        if (this.$21_2) {
            this.$7g_2();
            return false;
        }
        var $v_0 = this.$E0(false);
        this.$6Y_2 = new Date();
        return $v_0;
    },
    
    $Dz: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$A_2)) {
            this.$A_2.$B7($p0);
        }
    },
    
    $BL_2: true,
    
    get_$D8: function() {ULSpEN:;
        return this.$6Y_2.getTime();
    },
    
    $EE_2: function() {ULSpEN:;
        this.storeDataCookie(this.$A_2.$6_0, CUI.Utility.$38().toString() + CUI.Utility.$3y().toString() + '|' + this.$A_2.$1L_2.toString() + '|' + this.$5r_2().toString() + '|' + (this.get_$18()).get_ribbonBuildOptions().scalingHint.toString());
    },
    
    $21_2: false,
    $BR_2: false,
    $6f_2: false,
    
    get_minimized: function() {ULSpEN:;
        return this.$21_2;
    },
    set_minimized: function(value) {ULSpEN:;
        if (this.$21_2 !== value) {
            this.set_$41(value);
            if (!value && this.get_$4x()) {
                this.pollForStateAndUpdate();
            }
        }
        return value;
    },
    
    $9W_2: false,
    
    get_$41: function() {ULSpEN:;
        return this.$21_2;
    },
    set_$41: function($p0) {
        if (this.$21_2 !== $p0 || !this.$9W_2) {
            this.$w();
            this.$BR_2 = !$p0;
            this.$6f_2 = true;
            this.$21_2 = $p0;
            this.$9W_2 = true;
            if ($p0 && !CUI.ScriptUtility.isNullOrUndefined(this.$A_2)) {
                this.$A_2.$7q(false, false);
                this.$A_2 = null;
            }
        }
        return $p0;
    },
    
    $2P: function() {ULSpEN:;
        this.set_$40(new Date());
        this.$3N_1 = false;
        var $v_0 = {};
        var $$dict_1_0 = this.$11_2;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_1 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            var $v_2 = $v_1.value;
            var $v_3 = false;
            if (!CUI.ScriptUtility.isNullOrUndefined($v_2.$y_0)) {
                $v_3 = this.get_rootUser().isRootCommandEnabled($v_2.$y_0, this);
            }
            if ($v_3) {
                $v_0[$v_1.key] = true;
            }
            this.$7r_2($v_1.key, $v_3);
        }
        if (this._qat) {
            this._qat.pollForStateAndUpdate();
        }
        if (this._jewel) {
            this._jewel.pollForStateAndUpdate();
        }
        if (this.$g_0) {
            this.$L();
            this.$7g_2();
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$A_2)) {
            this.$A_2.$2P();
        }
        if (this.$3N_1) {
            this.$45();
            this.$3N_1 = false;
        }
        this.ensureGlobalDisablingRemoved();
    },
    
    $1g: function($p0) {
        if ($p0.$G_1 !== 11) {
            $p0.get_commandInfo().RootLocation = ($p0.$G_1 === 2) ? 'UpperRibbon' : 'LowerRibbon';
            if ($p0.$G_1 === 2) {
                var $v_0 = $p0.$2z_1;
                $p0.get_commandInfo().TabId = $v_0.NewContextId;
            }
        }
        return CUI.Ribbon.callBaseMethod(this, '$1g', [ $p0 ]);
    },
    
    get_jewelElement: function() {ULSpEN:;
        return this.$p_2;
    },
    set_jewelElement: function(value) {ULSpEN:;
        this.$p_2 = value;
        return value;
    },
    
    $6T_2: false,
    $2y_2: null,
    
    $Dk_2: function($p0) {
        var $v_0 = this.$AX_2();
        if (this.$2y_2 === $v_0) {
            return;
        }
        this.$2y_2 = $v_0;
        if (!this.$6T_2 && this.$BL_2 && this.$EL_2()) {
            this.$Dx_2();
            this.$6T_2 = true;
            this._componentWidth = this._componentHeight = -1;
            this.$4n();
            this.$2f();
            var $v_1 = this.$45();
            if ($v_1) {
                this.pollForStateAndUpdate();
            }
            this.$6T_2 = false;
        }
    },
    
    $EL_2: function() {ULSpEN:;
        return (this.$73_2 !== CUI.Utility.$38()) || (this.$72_2 !== CUI.Utility.$3y());
    },
    
    $Dx_2: function() {ULSpEN:;
        this.$73_2 = CUI.Utility.$38();
        this.$72_2 = CUI.Utility.$3y();
    },
    
    get_ribbonProperties: function() {ULSpEN:;
        return this.$5_1;
    },
    
    get_$2Q: function() {ULSpEN:;
        return this.get_$18();
    },
    set_$2Q: function($p0) {
        this.set_$18($p0);
        return $p0;
    },
    
    get_domElementTagName: function() {ULSpEN:;
        return 'div';
    },
    
    $m: function() {ULSpEN:;
        CUI.Ribbon.callBaseMethod(this, '$m');
        this.get_$2().setAttribute('aria-describedby', 'ribboninstructions');
        this.get_$2().setAttribute('role', 'toolbar');
        this.$Ci_2();
        this.$Cj_2();
        this.$Ce_2();
        this.$AC_2();
        this.$Cf_2();
        this.$Cc_2();
        this.$AC_2();
    },
    
    $Cj_2: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$e_2)) {
            this.$e_2 = CUI.Utility.$3('div');
            this.$e_2.className = 'ms-cui-topBar1';
            this.$e_2.style.display = 'none';
            this.$1k_2.appendChild(this.$e_2);
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$f_2)) {
            this.$f_2 = CUI.Utility.$3('div');
            this.$f_2.className = 'ms-cui-topBar2';
            this.$1k_2.appendChild(this.$f_2);
        }
    },
    
    $Ci_2: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$2s_2)) {
            this.$2s_2 = CUI.Utility.$3('span');
            this.$2s_2.className = 'ms-cui-hidden';
            this.$2s_2.id = 'ribboninstruction';
            CUI.Utility.$2k(this.$2s_2, (this.$5_1).NavigationHelpText);
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$1k_2)) {
            this.$1k_2 = CUI.Utility.$3('div');
            this.$1k_2.className = 'ms-cui-ribbonTopBars';
            this.get_$2().appendChild(this.$2s_2);
            this.get_$2().appendChild(this.$1k_2);
        }
    },
    
    $Cf_2: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$l_2)) {
            this.$l_2 = CUI.Utility.$3('div');
            CUI.Utility.disableElement(this.$l_2);
        }
    },
    
    $Cc_2: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$t_2)) {
            this.$t_2 = $get(this.$2S_1 + '-' + 'QATRowCenter');
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$u_2)) {
            this.$u_2 = $get(this.$2S_1 + '-' + 'QATRowRight');
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$1l_2)) {
            this.$1l_2 = $get(this.$2S_1 + '-' + 'TabRowLeft');
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$1m_2)) {
            this.$1m_2 = $get(this.$2S_1 + '-' + 'TabRowRight');
        }
    },
    
    $D0_2: function() {ULSpEN:;
        if (!this.$4h_2 && !CUI.ScriptUtility.isNullOrUndefined(this.$t_2) && this.$t_2.parentNode !== this.$e_2) {
            if (this.$t_2.parentNode) {
                this.$t_2.parentNode.removeChild(this.$t_2);
            }
            this.$e_2.appendChild(this.$t_2);
            this.$t_2.style.display = 'inline-block';
            this.$e_2.style.display = 'block';
            CUI.Utility.$29(this.$t_2, true, false);
        }
        if (!this.$4h_2 && !CUI.ScriptUtility.isNullOrUndefined(this.$u_2) && this.$u_2.parentNode !== this.$e_2) {
            if (this.$u_2.parentNode) {
                this.$u_2.parentNode.removeChild(this.$u_2);
            }
            this.$e_2.appendChild(this.$u_2);
            this.$u_2.style.display = 'inline-block';
            this.$e_2.style.display = 'block';
            CUI.Utility.$29(this.$u_2, true, false);
        }
        if (!this.$4h_2 && !CUI.ScriptUtility.isNullOrUndefined(this.$1l_2) && this.$1l_2.parentNode !== this.$f_2) {
            if (this.$1l_2.parentNode) {
                this.$1l_2.parentNode.removeChild(this.$1l_2);
            }
            this.$f_2.appendChild(this.$1l_2);
            this.$1l_2.style.display = 'block';
            CUI.Utility.$29(this.$1l_2, true, false);
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$q_2)) {
            this.$q_2 = CUI.Utility.$3('ul');
            this.$q_2.setAttribute('role', 'tablist');
            this.$q_2.className = 'ms-cui-tts';
            this.$f_2.appendChild(this.$q_2);
        }
        if (!this.$4h_2 && !CUI.ScriptUtility.isNullOrUndefined(this.$1m_2) && this.$1m_2.parentNode !== this.$f_2) {
            if (this.$1m_2.parentNode) {
                this.$1m_2.parentNode.removeChild(this.$1m_2);
            }
            this.$f_2.appendChild(this.$1m_2);
            this.$1m_2.style.display = 'block';
            CUI.Utility.$29(this.$1m_2, true, false);
        }
        this.$4h_2 = true;
    },
    
    ensureGlobalDisablingRemoved: function() {ULSpEN:;
        CUI.Utility.enableElement(this.$q_2);
        this.$AD();
        if (this._jewel) {
            this._jewel.set_enabled(true);
        }
        if (this._qat) {
            this._qat.pollForStateAndUpdate();
        }
    },
    
    $AD: function() {ULSpEN:;
        CUI.Utility.enableElement(this.$l_2);
    },
    
    get_rootUser: function() {ULSpEN:;
        return CUI.Ribbon.callBaseMethod(this, 'get_rootUser');
    },
    set_rootUser: function(value) {ULSpEN:;
        CUI.Ribbon.callBaseMethod(this, 'set_rootUser', [ value ]);
        if (!CUI.ScriptUtility.isNullOrUndefined(this._qat)) {
            this._qat.set_rootUser(value);
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this._jewel)) {
            this._jewel.set_rootUser(value);
        }
        return value;
    },
    
    dispose: function() {ULSpEN:;
        this.set_$CU(true);
        var $v_0 = this.$0_0;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            var $v_1 = $v_0.$2d_1;
            if (!CUI.ScriptUtility.isNullOrUndefined($v_1)) {
                window.clearTimeout($v_1);
            }
            $v_0.$2f();
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$4f_2)) {
            this.set_$52(false);
            this.$4f_2 = null;
        }
        if (this.$6g_2) {
            $removeHandler(this.get_$2(), 'contextmenu', this.$6g_2);
            this.$6g_2 = null;
        }
        CUI.Ribbon.callBaseMethod(this, 'dispose');
        this.$30_2 = null;
        this.$A_2 = null;
        this.$1k_2 = null;
        this.$q_2 = null;
        this.$p_2 = null;
        this.$l_2 = null;
        this.$1l_2 = null;
        this.$1m_2 = null;
        this.$2t_2 = null;
        this.$t_2 = null;
        this.$u_2 = null;
        this.$e_2 = null;
        this.$f_2 = null;
        var $$dict_1_0 = this.$11_2;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_2 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            var $v_3 = $v_2.value;
            $v_3.dispose();
        }
        this.$11_2 = null;
    }
}


CUI.RibbonCommand = function() {
}
CUI.RibbonCommand.$AU_0 = function($p0) {
    var $v_0 = window._v_rg_spbutton;
    if ($v_0) {
        var $v_1 = $v_0[$p0];
        if ($v_1) {
            var $v_2 = $get($v_1);
            return $v_2;
        }
    }
    return null;
}
CUI.RibbonCommand.serverButton = function(srcId, menuItemId) {ULSpEN:;
    var $v_0 = CUI.RibbonCommand.$AU_0(srcId);
    if ($v_0) {
        var $v_1 = $v_0;
        if (CUI.BrowserUtility.$Ag()) {
            if ($v_0.tagName !== 'A') {
                CUI.NativeUtility.ffClick($v_0);
            }
            else {
                window.location.href = $v_1.href;
            }
        }
        else {
            $v_0.click();
        }
    }
}
CUI.RibbonCommand.serverQueryButton = function(srcId) {ULSpEN:;
    var $v_0 = CUI.RibbonCommand.$AU_0(srcId);
    return $v_0;
}
CUI.RibbonCommand.serverControlLabel = function(ribbonCommand) {ULSpEN:;
    var $v_0 = window._v_rg_spbutton;
    if ($v_0) {
        var $v_1 = ($v_0[ribbonCommand]);
        if ($v_1) {
            var $v_2 = $get($v_1);
            return ($v_2.value);
        }
    }
    return null;
}


CUI.RibbonBuildContext = function() {ULSpEN:;
    CUI.RibbonBuildContext.initializeBase(this);
}
CUI.RibbonBuildContext.prototype = {
    
    clone: function() {ULSpEN:;
        var $v_0 = new CUI.RibbonBuildContext();
        $v_0.initializedTab = this.initializedTab;
        $v_0.initialScalingIndex = this.initialScalingIndex;
        $v_0.initialTabId = this.initialTabId;
        $v_0.ribbon = this.ribbon;
        return $v_0;
    },
    
    initializedTab: null,
    initialTabId: null,
    initialScalingIndex: 0,
    ribbon: null
}


CUI.RibbonBuildOptions = function() {ULSpEN:;
    this.initialScalingIndex = -1;
    CUI.RibbonBuildOptions.initializeBase(this);
}
CUI.RibbonBuildOptions.prototype = {
    lazyTabInit: false,
    shallowTabs: false,
    showQATId: null,
    showJewelId: null,
    minimized: false,
    shownTabs: null,
    shownContextualGroups: null,
    initiallyVisibleContextualGroups: null,
    normalizedContextualGroups: null,
    trimEmptyGroups: false,
    initialTabSelectedByUser: false,
    launchedByKeyboard: false,
    scalingHint: '0'
}


CUI.RibbonBuilder = function(options, elmPlaceholder, rootBuildClient) {ULSpEN:;
    this.$8w = Function.createDelegate(this, this.$DZ_1);
    this.$81 = Function.createDelegate(this, this.$CS_1);
    this.$8v = Function.createDelegate(this, this.$Ax_1);
    CUI.RibbonBuilder.initializeBase(this, [ options, elmPlaceholder, rootBuildClient ]);
    if (CUI.ScriptUtility.isNullOrUndefined(elmPlaceholder)) {
        throw Error.create('Ribbon placeholder DOM element is null or undefined.');
    }
}
CUI.RibbonBuilder.prototype = {
    
    get_ribbon: function() {ULSpEN:;
        return this.$0_0;
    },
    set_ribbon: function(value) {ULSpEN:;
        this.$0_0 = value;
        return value;
    },
    
    get_ribbonBuildOptions: function() {ULSpEN:;
        return this.$s_0;
    },
    
    buildRibbonAndInitialTab: function(initialTabId) {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(initialTabId)) {
            throw Error.create('Initial tab for ribbon is null or undefined');
        }
        if (this.$2Y_0) {
            return false;
        }
        var $v_0 = new CUI.RibbonBuildContext();
        $v_0.initialTabId = initialTabId;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.get_ribbonBuildOptions().attachToDOM) && this.get_ribbonBuildOptions().attachToDOM) {
            $v_0.initialScalingIndex = this.get_ribbonBuildOptions().initialScalingIndex;
        }
        this.$2Y_0 = true;
        var $v_1 = new CUI.DataQuery();
        $v_1.id = $v_0.initialTabId;
        $v_1.queryType = 2;
        $v_1.handler = this.$8v;
        $v_1.data = $v_0;
        this.$12_0.runQuery($v_1);
        return true;
    },
    
    buildRibbonFromData: function(dataNode, initialTabId) {ULSpEN:;
        var $v_0 = new CUI.RibbonBuildContext();
        $v_0.initialTabId = initialTabId;
        var $v_1 = new CUI.DataQueryResult();
        $v_1.success = true;
        $v_1.queryData = dataNode;
        $v_1.contextData = $v_0;
        this.$Ax_1($v_1);
    },
    
    $Ax_1: function($p0) {
        var $v_0 = $p0.contextData;
        $p0.queryData = this.applyDataExtensions($p0.queryData);
        CUI.Utility.ensureCSSClassOnElement(this._elmPlaceholder, 'loaded');
        var $v_1 = CUI.DataNodeWrapper.getFirstChildNodeWithName($p0.queryData, 'Templates');
        if (!CUI.ScriptUtility.isNullOrUndefined($v_1)) {
            CUI.TemplateManager.get_instance().loadTemplates($v_1);
        }
        this.set_ribbon(this.$Bw_1($p0.queryData, $v_0));
        this.get_ribbon().set_$2Q(this);
        this.$1R_0.onComponentCreated(this.get_ribbon(), this.get_ribbon().$6_0);
        if (this.get_ribbonBuildOptions().minimized) {
            this.get_ribbon().set_$41(true);
        }
        else {
            this.get_ribbon().set_$41(false);
            var $v_3 = this.get_ribbon().getChild($v_0.initialTabId);
            if (!CUI.ScriptUtility.isNullOrUndefined($v_3)) {
                $v_3.$5g_2 = this.get_ribbonBuildOptions().initialTabSelectedByUser;
                this.get_ribbon().$5u($v_3);
            }
        }
        this.get_ribbon().$2S_1 = this.get_ribbonBuildOptions().clientID;
        var $v_2 = !this.get_ribbonBuildOptions().minimized && this.get_ribbonBuildOptions().attachToDOM;
        if ($v_2) {
            if (!(this.$s_0).minimized) {
                this.get_ribbon().$Dz($v_0.initialScalingIndex - 1);
            }
            this.get_ribbon().$36(true);
            if (!CUI.ScriptUtility.isNullOrEmptyString(this.get_ribbonBuildOptions().showQATId)) {
                this.get_ribbon().$9w(this.get_ribbonBuildOptions().showQATId, true, this.$12_0);
            }
            if (!CUI.ScriptUtility.isNullOrEmptyString(this.get_ribbonBuildOptions().showJewelId)) {
                this.get_ribbon().$9v(this.get_ribbonBuildOptions().showJewelId, true, this.$12_0);
            }
        }
        else {
            this.get_ribbon().$m();
            if (!CUI.ScriptUtility.isNullOrEmptyString(this.get_ribbonBuildOptions().showQATId)) {
                this.get_ribbon().$9w(this.get_ribbonBuildOptions().showQATId, false, this.$12_0);
            }
            if (!CUI.ScriptUtility.isNullOrEmptyString(this.get_ribbonBuildOptions().showJewelId)) {
                this.get_ribbon().$9v(this.get_ribbonBuildOptions().showJewelId, false, this.$12_0);
            }
            CUI.Utility.removeChildNodesSlow(this._elmPlaceholder);
            this._elmPlaceholder.appendChild(this.get_ribbon().get_$2());
        }
        this.get_ribbon().$45();
        this.$7a(this.get_ribbon());
        this.$1R_0.onComponentBuilt(this.get_ribbon(), this.get_ribbon().$6_0);
        if (this.get_ribbonBuildOptions().launchedByKeyboard) {
            this.get_ribbon().setFocusOnRibbon();
        }
        CUI.PMetrics.perfMark(7104);
    },
    
    $DZ_1: function($p0) {
        var $v_0 = $p0.contextData;
        if ($p0.success) {
            var $v_1 = CUI.DataNodeWrapper.getFirstChildNodeWithName($p0.queryData, 'Ribbon');
            var $v_2 = CUI.DataNodeWrapper.getFirstChildNodeWithName($v_1, 'Tabs');
            var $v_3 = null;
            if (CUI.ScriptUtility.isNullOrUndefined($v_2) || !CUI.DataNodeWrapper.getNodeChildren($v_2).length) {
                var $v_6 = CUI.DataNodeWrapper.getFirstChildNodeWithName($v_1, 'ContextualTabs');
                var $v_7 = CUI.DataNodeWrapper.getNodeChildren($v_6);
                for (var $v_8 = 0; $v_8 < $v_7.length; $v_8++) {
                    var $v_9 = $v_7[$v_8];
                    $v_3 = CUI.DataNodeWrapper.getNodeChildren($v_9);
                    if ($v_3.length > 0) {
                        break;
                    }
                }
            }
            else {
                $v_3 = CUI.DataNodeWrapper.getNodeChildren($v_2);
            }
            var $v_4 = CUI.DataNodeWrapper.getFirstChildNodeWithName($p0.queryData, 'Templates');
            $v_4 = this.applyDataExtensions($v_4);
            CUI.TemplateManager.get_instance().loadTemplates($v_4);
            var $v_5 = this.applyDataExtensions($v_3[0]);
            this.$7I_1($v_0.initializedTab, $v_5, $v_0);
            $v_0.initializedTab.get_ribbon().$5u($v_0.initializedTab);
            $v_0.initializedTab.$4v(true);
        }
        CUI.PMetrics.perfMark(7106);
    },
    
    $Bw_1: function($p0, $p1) {
        var $v_0 = CUI.DataNodeWrapper.getFirstChildNodeWithName($p0, 'Ribbon');
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            throw Error.create('No ribbon element was present in the data');
        }
        var $v_1 = new CUI.DataNodeWrapper($v_0);
        this.set_ribbon(new CUI.Ribbon($v_1.get_attributes()['Id'], $v_1.get_attributes()));
        this.get_ribbon().$3u_1 = true;
        var $v_2 = CUI.DataNodeWrapper.getNodeChildren(CUI.DataNodeWrapper.getFirstChildNodeWithName($v_1.$a_0, 'Tabs'));
        this.$9q_1($v_2, null, $p1);
        var $v_3 = CUI.DataNodeWrapper.getFirstChildNodeWithName($v_1.$a_0, 'ContextualTabs');
        if (!CUI.ScriptUtility.isNullOrUndefined($v_3)) {
            var $v_4 = CUI.DataNodeWrapper.getNodeChildren($v_3);
            var $v_5 = !CUI.ScriptUtility.isNullOrUndefined(this.get_ribbonBuildOptions().shownContextualGroups);
            for (var $v_6 = 0; $v_6 < $v_4.length; $v_6++) {
                if ($v_5) {
                    var $v_7 = CUI.DataNodeWrapper.getNodeAttributes($v_4[$v_6])['Id'];
                    if (!CUI.ScriptUtility.isNullOrUndefined($v_7)) {
                        if (CUI.ScriptUtility.isNullOrUndefined(this.get_ribbonBuildOptions().shownContextualGroups[$v_7])) {
                            continue;
                        }
                    }
                }
                this.$BW_1($v_4[$v_6], $p1);
            }
        }
        return this.get_ribbon();
    },
    
    $BW_1: function($p0, $p1) {
        var $v_0 = CUI.DataNodeWrapper.getNodeAttributes($p0);
        var $v_1 = 0;
        var $v_2 = $v_0['Id'];
        var $v_3 = !CUI.ScriptUtility.isNullOrUndefined(this.get_ribbonBuildOptions().normalizedContextualGroups) && !CUI.ScriptUtility.isNullOrUndefined(this.get_ribbonBuildOptions().normalizedContextualGroups[$v_2]) && this.get_ribbonBuildOptions().normalizedContextualGroups[$v_2];
        if (!$v_3) {
            switch ($v_0['Color']) {
                case 'DarkBlue':
                    $v_1 = 1;
                    break;
                case 'LightBlue':
                    $v_1 = 2;
                    break;
                case 'Magenta':
                    $v_1 = 6;
                    break;
                case 'Green':
                    $v_1 = 5;
                    break;
                case 'Orange':
                    $v_1 = 4;
                    break;
                case 'Purple':
                    $v_1 = 8;
                    break;
                case 'Teal':
                    $v_1 = 3;
                    break;
                case 'Yellow':
                    $v_1 = 7;
                    break;
                default:
                    $v_1 = 0;
                    break;
            }
            this.get_ribbon().addContextualGroup($v_2, $v_0['Title'], $v_1, $v_0['Command']);
        }
        var $v_4 = CUI.DataNodeWrapper.getNodeChildren($p0);
        if (!$v_3) {
            for (var $v_5 = 0; $v_5 < $v_4.length; $v_5++) {
                var $v_6 = CUI.DataNodeWrapper.getNodeAttribute($v_4[$v_5], 'Id');
                if ($v_6 === $p1.initialTabId) {
                    if (CUI.ScriptUtility.isNullOrUndefined(this.get_ribbonBuildOptions().initiallyVisibleContextualGroups)) {
                        this.get_ribbonBuildOptions().initiallyVisibleContextualGroups = {};
                    }
                    this.get_ribbonBuildOptions().initiallyVisibleContextualGroups[$v_2] = true;
                    break;
                }
            }
        }
        this.$9q_1($v_4, ($v_3) ? null : $v_0['Id'], $p1);
    },
    
    $9q_1: function($p0, $p1, $p2) {
        var $v_0 = !CUI.ScriptUtility.isNullOrUndefined(this.get_ribbonBuildOptions().shownTabs);
        for (var $v_1 = 0; $v_1 < $p0.length; $v_1++) {
            if ($v_0) {
                var $v_3 = CUI.DataNodeWrapper.getNodeAttributes($p0[$v_1])['Id'];
                if (!CUI.ScriptUtility.isNullOrUndefined($v_3)) {
                    if (CUI.ScriptUtility.isNullOrUndefined(this.get_ribbonBuildOptions().shownTabs[$v_3])) {
                        continue;
                    }
                }
            }
            var $v_2 = this.$C0_1($p0[$v_1], $p2, $p1);
            this.get_ribbon().addChild($v_2);
        }
    },
    
    $C0_1: function($p0, $p1, $p2) {
        var $v_0 = new CUI.DataNodeWrapper($p0);
        var $v_1;
        if (CUI.ScriptUtility.isNullOrUndefined($p2)) {
            $v_1 = this.get_ribbon().$CP($v_0.get_attributes()['Id'], $v_0.get_attributes()['Title'], $v_0.get_attributes()['Description'], $v_0.get_attributes()['Command'], $v_0.get_attributes()['CssClass']);
        }
        else {
            $v_1 = this.get_ribbon().$CG($v_0.get_attributes()['Id'], $v_0.get_attributes()['Title'], $v_0.get_attributes()['Description'], $v_0.get_attributes()['Command'], $p2, $v_0.get_attributes()['CssClass']);
            if (!CUI.ScriptUtility.isNullOrUndefined(this.get_ribbonBuildOptions().initiallyVisibleContextualGroups) && this.get_ribbonBuildOptions().initiallyVisibleContextualGroups[$p2]) {
                $v_1.set_$64(true);
            }
        }
        if (!$v_0.get_children().length) {
            $v_1.$7k(this.$81, $v_0.$a_0, $p1.clone());
        }
        else {
            this.$7I_1($v_1, $p0, $p1);
        }
        return $v_1;
    },
    
    $7I_1: function($p0, $p1, $p2) {
        var $v_0 = CUI.DataNodeWrapper.getFirstChildNodeWithName($p1, 'Groups');
        var $v_1 = CUI.DataNodeWrapper.getNodeChildren($v_0);
        var $v_2 = {};
        for (var $v_7 = 0; $v_7 < $v_1.length; $v_7++) {
            if (this.isNodeTrimmed($v_1[$v_7])) {
                continue;
            }
            var $v_8 = this.$Bn_1($v_1[$v_7], $p2);
            if (!CUI.ScriptUtility.isNullOrUndefined($v_8)) {
                $p0.addChild($v_8);
            }
            else {
                var $v_9 = CUI.DataNodeWrapper.getNodeAttribute($v_1[$v_7], 'Id');
                if (!CUI.ScriptUtility.isNullOrUndefined($v_9)) {
                    $v_2[$v_9] = $v_9;
                }
            }
        }
        var $v_3 = CUI.DataNodeWrapper.getFirstChildNodeWithName($p1, 'Scaling');
        var $v_4 = CUI.DataNodeWrapper.getNodeChildren($v_3);
        var $v_5 = null;
        var $v_6 = false;
        for (var $v_A = 0; $v_A < $v_4.length; $v_A++) {
            var $v_B = CUI.DataNodeWrapper.getNodeName($v_4[$v_A]);
            var $v_C = CUI.DataNodeWrapper.getNodeAttributes($v_4[$v_A]);
            var $v_D = $v_C['GroupId'];
            if ($v_B === 'MaxSize') {
                if (this.isIdTrimmed($v_D) || !CUI.ScriptUtility.isNullOrUndefined($v_2[$v_D])) {
                    continue;
                }
                $p0.get_scaling().setGroupMaxSize($v_D, $v_C['Size']);
            }
            else if ($v_B === 'Scale') {
                if (this.isIdTrimmed($v_D) || !CUI.ScriptUtility.isNullOrUndefined($v_2[$v_D])) {
                    continue;
                }
                $p0.get_scaling().addScalingStep(new CUI.ScalingStep($v_D, $v_C['Size'], $v_C['PopupSize'], $v_5, $v_6));
                $v_5 = null;
                $v_6 = false;
            }
            else if ($v_B === 'LowScaleWarning') {
                $v_5 = $v_C['Message'];
                $v_6 = true;
            }
            else {
                throw Error.create('Was expecting a node with name MaxSize or Scale.');
            }
        }
        $p0.scaleMax();
    },
    
    $CS_1: function($p0, $p1, $p2) {
        var $v_0 = $p2;
        var $v_1 = $p0;
        var $v_2 = new CUI.DataNodeWrapper($p1);
        $v_0.initializedTab = $p0;
        if (!$v_2.get_hasChildren()) {
            var $v_3 = new CUI.DataQuery();
            $v_3.id = $v_0.initializedTab.$6_0;
            $v_3.queryType = 4;
            $v_3.handler = this.$8w;
            $v_3.data = $v_0;
            this.$12_0.runQuery($v_3);
            return null;
        }
        this.$7I_1($v_1, $p1, $v_0);
        $v_1.$4v(true);
        this.get_ribbon().refresh();
        return $v_1;
    },
    
    $Bn_1: function($p0, $p1) {
        var $v_0 = new CUI.DataNodeWrapper($p0);
        var $v_1 = $v_0.get_attributes()['Template'];
        var $v_2 = CUI.TemplateManager.get_instance().getTemplate($v_1);
        if (CUI.ScriptUtility.isNullOrUndefined($v_2)) {
            throw Error.create('A template with name: ' + $v_1 + ' could not be loaded.');
        }
        var $v_3 = {};
        var $v_4 = null;
        for (var $v_8 = 0; $v_8 < $v_0.get_children().length; $v_8++) {
            if (($v_0.get_children()[$v_8].name) === 'Controls') {
                $v_4 = $v_0.get_children()[$v_8];
                break;
            }
        }
        if (CUI.ScriptUtility.isNullOrUndefined($v_4)) {
            throw Error.create('No Controls node found in this Group tag.');
        }
        var $v_5 = CUI.DataNodeWrapper.getNodeChildren($v_4);
        var $v_6 = true;
        for (var $v_9 = 0; $v_9 < $v_5.length; $v_9++) {
            if (this.isNodeTrimmed($v_5[$v_9])) {
                continue;
            }
            $v_6 = false;
            var $v_A = this.$1f($v_5[$v_9], $p1);
            var $v_B = $v_3[$v_A.get_templateAlias()];
            if (CUI.ScriptUtility.isNullOrUndefined($v_B)) {
                $v_3[$v_A.get_templateAlias()] = $v_A;
            }
            else if (Array.isInstanceOfType($v_B)) {
                Array.add($v_B, $v_A);
            }
            else {
                var $v_C = [];
                Array.add($v_C, $v_B);
                Array.add($v_C, $v_A);
                $v_3[$v_A.get_templateAlias()] = $v_C;
            }
        }
        if (this.get_ribbonBuildOptions().trimEmptyGroups && $v_6) {
            return null;
        }
        var $v_7 = $v_2.createGroup(this.get_ribbon(), $v_0.get_attributes()['Id'], $v_0.get_attributes(), $v_0.get_attributes()['Title'], $v_0.get_attributes()['Description'], $v_0.get_attributes()['Command'], $v_3, null);
        return $v_7;
    }
}


CUI.RibbonComponent = function(ribbon, id, title, description) {ULSpEN:;
    CUI.RibbonComponent.initializeBase(this, [ ribbon, id, title, description ]);
}
CUI.RibbonComponent.prototype = {
    
    get_ribbon: function() {ULSpEN:;
        return this.$0_0;
    }
}


CUI.Row = function(ribbon, id) {ULSpEN:;
    CUI.Row.initializeBase(this, [ ribbon, id, '', '' ]);
}
CUI.Row.prototype = {
    
    $L: function() {ULSpEN:;
        this.ensureDOMElementAndEmpty();
        CUI.Row.callBaseMethod(this, 'appendChildrenToElement', [ this.get_$2() ]);
        CUI.Row.callBaseMethod(this, '$L');
    },
    
    $3v: function() {ULSpEN:;
        this.set_$2($get(this.$K_0.$6_0 + '-' + this.$K_0.$4_0.indexOf(this)));
    },
    
    ensureCorrectChildType: function($p0) {
        if (!CUI.Strip.isInstanceOfType($p0) && !CUI.ControlComponent.isInstanceOfType($p0)) {
            throw Error.create('Only children of type Strip and ControlComponent can be added to Row Components.');
        }
    },
    
    get_domElementTagName: function() {ULSpEN:;
        return 'span';
    },
    
    get_cssClass: function() {ULSpEN:;
        var $v_0 = (this.$K_0).$G_2;
        if ($v_0 === 2) {
            return 'ms-cui-row-onerow';
        }
        else {
            return 'ms-cui-row';
        }
    }
}


CUI.ScalingStep = function(groupId, layoutName, popupSize, scaleWarningMessage, warnForScale) {ULSpEN:;
    if ((CUI.ScriptUtility.isNullOrUndefined(groupId) || CUI.ScriptUtility.isNullOrUndefined(layoutName))) {
        throw Error.create('groupId, layoutName and message cannot be undefined or null');
    }
    this.$2H_0 = groupId;
    this.$5Y_0 = layoutName;
    this.$6n_0 = popupSize;
    this.$9f_0 = scaleWarningMessage;
    this.$9m_0 = warnForScale;
}
CUI.ScalingStep.prototype = {
    $2H_0: null,
    $5Y_0: null,
    $6n_0: null,
    $9f_0: null,
    $9m_0: false,
    $1p_0: null,
    
    $BC: function($p0) {
        this.$1p_0 = $p0;
    },
    
    get_groupId: function() {ULSpEN:;
        return this.$2H_0;
    },
    
    get_layoutName: function() {ULSpEN:;
        return this.$5Y_0;
    },
    
    get_popupSize: function() {ULSpEN:;
        return this.$6n_0;
    },
    
    get_scaleWarningMessage: function() {ULSpEN:;
        return this.$9f_0;
    },
    
    get_hasScaleWarning: function() {ULSpEN:;
        return this.$9m_0;
    },
    
    get_previousLayoutName: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$1p_0)) {
            return null;
        }
        var $v_0 = this.$1p_0.getGroupMaxSize(this.$2H_0);
        var $v_1 = this.$1p_0.$1q_0;
        for (var $v_2 = 0; $v_2 < $v_1.length; $v_2++) {
            var $v_3 = $v_1[$v_2];
            if ($v_3 === this) {
                break;
            }
            if ($v_3.$2H_0 === this.$2H_0) {
                $v_0 = $v_3.$5Y_0;
            }
        }
        return $v_0;
    }
}


CUI.Scaling = function() {ULSpEN:;
    this.$4c_0 = {};
    this.$1q_0 = [];
}
CUI.Scaling.prototype = {
    $4c_0: null,
    $1q_0: null,
    
    setGroupMaxSize: function($p0, $p1) {
        this.$4c_0[$p0] = $p1;
        this.$g_0 = true;
    },
    
    removeGroupMaxSize: function($p0) {
        delete this.$4c_0[$p0];
        this.$g_0 = true;
    },
    
    getGroupMaxSize: function($p0) {
        return this.$4c_0[$p0];
    },
    
    addScalingStep: function($p0) {
        if (CUI.ScriptUtility.isNullOrUndefined($p0)) {
            throw Error.create('step must be definined and not null');
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$4c_0[$p0.$2H_0])) {
            throw Error.create('You must set the GroupMaxSize of Group: ' + $p0.$2H_0 + ' before you add ScalingSteps for it');
        }
        this.addScalingStepAtIndex($p0, this.$1q_0.length);
    },
    
    addScalingStepAtIndex: function($p0, $p1) {
        if (Array.contains(this.$1q_0, $p0)) {
            throw Error.create('This ScalingInfo already contains this ScaleStep');
        }
        Array.insert(this.$1q_0, $p1, $p0);
        $p0.$BC(this);
        this.$g_0 = true;
    },
    
    removeScalingStep: function($p0) {
        Array.remove(this.$1q_0, $p0);
        $p0.$BC(null);
        this.$g_0 = true;
    },
    
    get_steps: function() {ULSpEN:;
        return Array.clone(this.$1q_0);
    },
    
    get_stepsInternal: function() {ULSpEN:;
        return this.$1q_0;
    },
    
    $g_0: true
}


CUI.Section = function(ribbon, id, type, alignment) {ULSpEN:;
    CUI.Section.initializeBase(this, [ ribbon, id, '', '' ]);
    this.$G_2 = type;
    this.$1O_2 = alignment;
    switch (type) {
        case 4:
            this.$34(new CUI.Row(ribbon, id + '-0'), false);
            this.$34(new CUI.Row(ribbon, id + '-1'), false);
            this.$34(new CUI.Row(ribbon, id + '-2'), false);
            break;
        case 3:
            this.$34(new CUI.Row(ribbon, id + '-0'), false);
            this.$34(new CUI.Row(ribbon, id + '-1'), false);
            break;
        case 2:
            this.$34(new CUI.Row(ribbon, id + '-0'), false);
            break;
        case 1:
            break;
        default:
            throw Error.create('Invalid SectionType');
    }
}
CUI.Section.prototype = {
    $G_2: 0,
    $1O_2: 0,
    
    $L: function() {ULSpEN:;
        this.ensureDOMElementAndEmpty();
        this.appendChildrenToElement(this.get_$2());
        this.$m();
        if (this.$G_2 !== 1) {
            var $v_0 = this.$4_0;
            this.$75_2($v_0, 1);
            if (this.$G_2 === 3 || this.$G_2 === 4) {
                this.$75_2($v_0, 2);
            }
            if (this.$G_2 === 4) {
                this.$75_2($v_0, 3);
            }
        }
        this.$g_0 = false;
    },
    
    $3v: function() {ULSpEN:;
        this.set_$2($get(this.$K_0.$6_0 + '-' + this.$K_0.$4_0.indexOf(this).toString()));
    },
    
    $75_2: function($p0, $p1) {
        var $v_0 = $p0.get_item($p1 - 1);
        $v_0.$m();
        if (this.$G_2 === 3) {
            $v_0.get_$2().className = 'ms-cui-row-tworow';
        }
        this.get_$2().appendChild($v_0.get_$2());
        $v_0.$2O();
    },
    
    get_cssClass: function() {ULSpEN:;
        if (this.$1O_2 === 2) {
            return 'ms-cui-section-alignmiddle';
        }
        else {
            return 'ms-cui-section';
        }
    },
    
    get_type: function() {ULSpEN:;
        return this.$G_2;
    },
    
    get_alignment: function() {ULSpEN:;
        return this.$1O_2;
    },
    
    removeChild: function($p0) {
        throw Error.create('Cannot directly add and remove children from Section Components');
    },
    
    addChildAtIndex: function($p0, $p1) {
        throw Error.create('Cannot directly add and remove children from Section Components');
    },
    
    getRow: function($p0) {
        switch (this.$G_2) {
            case 4:
                if ($p0 < 1 || $p0 > 3) {
                    throw Error.create('This Section type only has Row numbers 1, 2 and 3.');
                }
                break;
            case 3:
                if ($p0 < 1 || $p0 > 2) {
                    throw Error.create('This Section type only has Row numbers 1 and 2');
                }
                break;
            case 2:
                if ($p0 !== 1) {
                    throw Error.create('This Section type only has Row number 1.');
                }
                break;
            default:
                throw Error.create('This Section type does not have any rows');
        }
        return this.$4_0.get_item($p0 - 1);
    },
    
    $m: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            return;
        }
        if (this.$G_2 === 1) {
            var $v_0 = CUI.Utility.$3('span');
            $v_0.className = 'ms-cui-section-divider';
            this.set_$2($v_0);
            return;
        }
        CUI.Section.callBaseMethod(this, '$m');
    },
    
    ensureCorrectChildType: function($p0) {
        var $v_0 = this.$4_0.$P_0;
        if ((this.$G_2 === 2 && $v_0 > 0) || (this.$G_2 === 3 && $v_0 > 1) || (this.$G_2 === 4 && $v_0 > 2)) {
            throw Error.create('No more children can be added to a Section of this type.');
        }
        if (this.$G_2 === 1) {
            throw Error.create('Cannot add child components to Divider Section types.');
        }
        if (!CUI.Row.isInstanceOfType($p0)) {
            throw Error.create('Only children of type Row can be added to Section Components.');
        }
    },
    
    $4m: function($p0) {
        var $v_0 = this.get_ribbon().$26('clonedSection-' + this.get_ribbon().$27(), this.$G_2, this.$1O_2);
        if (!$p0) {
            return $v_0;
        }
        var $v_1 = 0;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_2 = $$enum_1_0.get_current();
            var $$enum_3_0 = $v_2.$4_0.getEnumerator();
            while ($$enum_3_0.moveNext()) {
                var $v_3 = $$enum_3_0.get_current();
                var $v_4 = null;
                if (CUI.ControlComponent.isInstanceOfType($v_3)) {
                    var $v_5 = $v_3;
                    $v_4 = $v_5.$4m($p0);
                }
                else if (CUI.Strip.isInstanceOfType($v_3)) {
                    $v_4 = ($v_3).$4m($p0);
                }
                else {
                }
                $v_0.getRow($v_1 + 1).addChild($v_4);
            }
            $v_1++;
        }
        return $v_0;
    },
    
    get_domElementTagName: function() {ULSpEN:;
        return 'span';
    }
}


CUI.Strip = function(ribbon, id) {ULSpEN:;
    CUI.Strip.initializeBase(this, [ ribbon, id, '', '' ]);
}
CUI.Strip.prototype = {
    
    $L: function() {ULSpEN:;
        this.ensureDOMElementAndEmpty();
        this.appendChildrenToElement(this.get_$2());
        CUI.Strip.callBaseMethod(this, '$L');
    },
    
    $3v: function() {ULSpEN:;
        this.set_$2($get(this.$K_0.$6_0 + '-' + this.$K_0.$4_0.indexOf(this)));
    },
    
    ensureCorrectChildType: function($p0) {
        if (!CUI.ControlComponent.isInstanceOfType($p0)) {
            throw Error.create('Only children of type Control can be added to Strips.');
        }
    },
    
    get_cssClass: function() {ULSpEN:;
        return 'ms-cui-strip';
    },
    
    $4m: function($p0) {
        var $v_0 = this.get_ribbon().$A8('clonedStrip-' + this.get_ribbon().$27());
        if (!$p0) {
            return $v_0;
        }
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_1 = $$enum_1_0.get_current();
            $v_0.addChild($v_1.$4m($p0));
        }
        return $v_0;
    }
}


CUI.Tab = function(ribbon, id, title, description, command, contextual, contextualGroupId, cssClass) {ULSpEN:;
    this.$9C = Function.createDelegate(this, this.$BH_2);
    this.$93 = Function.createDelegate(this, this.$Dg_2);
    this.$91 = Function.createDelegate(this, this.$Az_2);
    this.$92 = Function.createDelegate(this, this.$Df_2);
    CUI.Tab.initializeBase(this, [ ribbon, id, title, description ]);
    this.$1L_2 = -1;
    this.$1p_2 = new CUI.Scaling();
    this.$1A_2 = contextual;
    this.$10_2 = contextualGroupId;
    this.$y_2 = command;
    this.$9G_2 = (CUI.ScriptUtility.isNullOrUndefined(cssClass)) ? '' : cssClass;
    if (contextual) {
        this.set_$64(false);
    }
}
CUI.Tab.prototype = {
    $5f_2: false,
    $D_2: null,
    $r_2: null,
    $3e_2: null,
    $2U_2: null,
    $1L_2: 0,
    $9G_2: null,
    $1A_2: false,
    $10_2: null,
    
    $L: function() {ULSpEN:;
        this.ensureDOMElementAndEmpty();
        this.$7G();
        this.appendChildrenToElement(this.get_$2());
        CUI.Tab.callBaseMethod(this, '$L');
    },
    
    $9s: function() {ULSpEN:;
        this.$D_2 = $get(this.$6_0 + '-title');
        this.$r_2 = this.$D_2.childNodes[0];
        this.$3e_2 = this.$r_2.childNodes[0];
        this.$2U_2 = this.$r_2.childNodes[1];
    },
    
    $9t: function() {ULSpEN:;
        $addHandler(this.$r_2, 'dblclick', this.$92);
        $addHandler(this.$r_2, 'click', this.$91);
        $addHandler(this.$r_2, 'keypress', this.$93);
    },
    
    $3v: function() {ULSpEN:;
        CUI.Tab.callBaseMethod(this, '$3v');
        this.$9s();
    },
    
    $N: function() {ULSpEN:;
        CUI.Tab.callBaseMethod(this, '$N');
        this.$9t();
    },
    
    $m: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            return;
        }
        CUI.Tab.callBaseMethod(this, '$m');
        this.get_$2().setAttribute('role', 'tabpanel');
        this.get_$2().setAttribute('aria-labelledby', this.$6_0 + '-title');
    },
    
    get_domElementTagName: function() {ULSpEN:;
        return 'ul';
    },
    
    $Ch: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$D_2)) {
            this.$D_2 = CUI.Utility.$3('li');
        }
    },
    
    $AB: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$2U_2)) {
            this.$2U_2 = CUI.Utility.$3('span');
        }
    },
    
    $7G: function() {ULSpEN:;
        var $v_0 = ' ';
        if (CUI.ScriptUtility.isNullOrUndefined(this.$r_2)) {
            this.$Ch();
            this.$r_2 = CUI.Utility.$3('a');
            CUI.Utility.$1s(this.$r_2);
            this.$r_2.className = 'ms-cui-tt-a';
            this.$3e_2 = CUI.Utility.$3('span');
            this.$3e_2.className = 'ms-cui-tt-span';
            this.$D_2.appendChild(this.$r_2);
            this.$r_2.appendChild(this.$3e_2);
            this.$N();
        }
        else {
            $v_0 += (this.$D_2.className.indexOf('ms-cui-ct-first') > -1) ? 'ms-cui-ct-first ' : '';
            $v_0 += (this.$D_2.className.indexOf('ms-cui-ct-last') > -1) ? 'ms-cui-ct-last' : '';
            $v_0 = $v_0.trimEnd();
        }
        this.$D_2.className = this.$AV_2() + $v_0;
        this.$D_2.id = this.$6_0 + '-title';
        this.$D_2.setAttribute('role', 'tab');
        this.$D_2.setAttribute('aria-selected', this.$5f_2);
        CUI.UIUtility.setInnerText(this.$3e_2, this.get_title());
        this.$D_2.title = this.get_title();
        if (!CUI.ScriptUtility.isNullOrEmptyString(this.get_description())) {
            this.$r_2.setAttribute('title', this.get_description());
        }
        else {
            this.$r_2.setAttribute('title', this.get_title());
        }
    },
    
    $BB: function($p0, $p1, $p2, $p3, $p4) {
        if (CUI.ScriptUtility.isNullOrUndefined(this.$2U_2)) {
            this.$AB();
        }
        if (this.$1A_2) {
            $p1 = String.format($p1, $p2, $p3, $p4);
        }
        else {
            $p1 = String.format($p0, $p3, $p4);
        }
        CUI.UIUtility.setInnerText(this.$2U_2, $p1);
        CUI.Utility.ensureCSSClassOnElement(this.$2U_2, 'ms-cui-hidden');
        this.$r_2.appendChild(this.$2U_2);
    },
    
    $Dy: function() {ULSpEN:;
        this.$D_2.className = this.$AV_2();
    },
    
    get_cssClass: function() {ULSpEN:;
        return this.$Ct_2();
    },
    
    get_selected: function() {ULSpEN:;
        return this.$5f_2;
    },
    set_selected: function($p0) {
        if (!this.get_visible()) {
            throw Error.create('Tabs must be visible and enabled in order to be selected.');
        }
        if ($p0) {
            if (this.get_needsDelayIniting()) {
                this.doDelayedInit();
                return;
            }
            this.get_ribbon().$5u(this);
            this.get_ribbon().set_$41(false);
            this.get_ribbon().$L();
            if (this.$6Z_2 !== this.get_ribbon().$2y_2) {
                this.get_ribbon().$45();
            }
            this.$B2();
            this.$1E_2 = false;
        }
        else {
            throw Error.create('Selected cannot be set to false explicitly.\nSelecting another Tab will do this implicitly.');
        }
        return $p0;
    },
    
    $Dv_2: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.get_ribbon().get_$2Q()) && !CUI.ScriptUtility.isNullOrUndefined(this.get_ribbon().get_$2Q().get_ribbonBuildOptions()) && !CUI.ScriptUtility.isNullOrEmptyString(this.get_ribbon().get_$2Q().get_ribbonBuildOptions().clientID)) {
            var $v_0 = $get(this.get_ribbon().get_$2Q().get_ribbonBuildOptions().clientID + '_activeTabId');
            if ($v_0) {
                $v_0.value = this.$6_0;
            }
        }
    },
    
    $7q: function($p0, $p1) {
        if ($p0) {
            this.$Dv_2();
        }
        this.$5f_2 = $p0;
        this.$w();
        if ($p1) {
            this.$7G();
        }
    },
    
    $4v: function($p0) {
        CUI.Tab.callBaseMethod(this, '$4v', [ $p0 ]);
        this.get_ribbon().$45();
        this.get_ribbon().pollForStateAndUpdate();
    },
    
    ensureCorrectChildType: function($p0) {
        if (!CUI.Group.isInstanceOfType($p0)) {
            throw Error.create('Only children of type Group can be added to Tab Components');
        }
    },
    
    $1p_2: null,
    
    get_scaling: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$1p_2)) {
            this.$1p_2 = new CUI.Scaling();
        }
        return this.$1p_2;
    },
    
    get_currentScalingIndex: function() {ULSpEN:;
        return this.$1L_2;
    },
    
    $6Z_2: null,
    
    scaleMax: function() {ULSpEN:;
        this.$7h();
        this.$w();
    },
    
    $7h: function() {ULSpEN:;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_0 = $$enum_1_0.get_current();
            var $v_1 = this.$1p_2.getGroupMaxSize($v_0.$6_0);
            if (!CUI.ScriptUtility.isNullOrUndefined($v_1)) {
                $v_0.selectLayout($v_1, null);
            }
        }
        this.$1L_2 = -1;
    },
    
    scaleIndex: function($p0) {
        this.$B7($p0);
        this.$w();
    },
    
    $B7: function($p0) {
        this.$7h();
        while ($p0 > this.$1L_2) {
            if (!this.$B6()) {
                break;
            }
        }
    },
    
    $E1: function() {ULSpEN:;
        if (this.$1L_2 === -2) {
            this.$7h();
            return true;
        }
        if (this.$1L_2 === -1) {
            return false;
        }
        var $v_0 = this.$1p_2.$1q_0;
        var $v_1 = $v_0[this.$1L_2];
        var $v_2 = this.getChild($v_1.$2H_0);
        $v_2.selectLayout($v_1.get_previousLayoutName(), null);
        this.$1L_2--;
        return true;
    },
    
    scaleUp: function() {ULSpEN:;
        var $v_0 = this.$E1();
        if ($v_0) {
            this.$w();
        }
        return $v_0;
    },
    
    $B6: function() {ULSpEN:;
        if (this.$1L_2 === -2) {
            this.scaleMax();
            return true;
        }
        var $v_0 = this.$1p_2.$1q_0;
        if ($v_0.length <= this.$1L_2 + 1) {
            return false;
        }
        this.$1L_2++;
        var $v_1 = $v_0[this.$1L_2];
        var $v_2 = this.getChild($v_1.$2H_0);
        $v_2.selectLayout($v_1.$5Y_0, $v_1.$6n_0);
        return true;
    },
    
    scaleDown: function() {ULSpEN:;
        var $v_0 = this.$B6();
        if ($v_0) {
            this.$w();
        }
        return $v_0;
    },
    
    $9e_2: false,
    
    $Cx: function() {ULSpEN:;
        var $v_0 = 0;
        var $v_1 = this.get_$2().childNodes;
        for (var $v_2 = 0; $v_2 < $v_1.length; $v_2++) {
            $v_0 += $v_1[$v_2].offsetWidth;
        }
        return $v_0;
    },
    
    get_contextual: function() {ULSpEN:;
        return this.$1A_2;
    },
    
    get_contextualGroupId: function() {ULSpEN:;
        return this.$10_2;
    },
    
    $5g_2: false,
    $1E_2: false,
    
    $Dg_2: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined($p0) && !CUI.ScriptUtility.isNullOrUndefined($p0.rawEvent)) {
            var $v_0 = $p0.rawEvent.keyCode;
            if ($v_0 === 13) {
                this.$1E_2 = true;
                $p0.stopPropagation();
                this.$Az_2($p0);
            }
        }
    },
    
    $Az_2: function($p0) {
        CUI.PMetrics.perfMark(7105);
        $p0.preventDefault();
        this.$6t_2 = true;
        if (this.get_selected()) {
            window.setTimeout(this.$9C, 500);
        }
        else {
            this.$BH_2();
        }
    },
    
    $6t_2: true,
    
    $BH_2: function() {ULSpEN:;
        if (!this.$6t_2) {
            return;
        }
        this.$5g_2 = true;
        this.get_ribbon().$AA();
        this.set_selected(true);
        this.get_ribbon().$2f();
        this.get_ribbon().set_$o(null);
        CUI.PMetrics.perfMark(7107);
    },
    
    $Am: function($p0) {
        var $v_0 = document.activeElement;
        var $v_1 = this.$AF_2($v_0);
        var $v_2 = this.$4_0.$P_0;
        var $v_3;
        var $v_4 = 0;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_6 = $$enum_1_0.get_current();
            if ($v_6.$6_0 === $v_1) {
                break;
            }
            $v_4++;
        }
        var $v_5;
        if ($p0) {
            $v_5 = ($v_4 + 1) % $v_2;
        }
        else {
            $v_5 = $v_4 - 1;
        }
        if ($v_5 < 0) {
            $v_5 = $v_2 + $v_5;
        }
        while ($v_5 !== $v_4) {
            $v_3 = this.$4_0.get_item($v_5);
            if ($v_3.$50()) {
                return;
            }
            if ($p0) {
                $v_5 = ($v_5 + 1) % $v_2;
            }
            else {
                $v_5 = $v_5 - 1;
            }
            if ($v_5 < 0) {
                $v_5 = $v_2 + $v_5;
            }
        }
    },
    
    $AF_2: function($p0) {
        if ($p0.nodeName === 'LI') {
            return $p0.id;
        }
        else {
            return this.$AF_2($p0.parentNode);
        }
    },
    
    $BD: function() {ULSpEN:;
        var $v_0 = false;
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_1 = $$enum_1_0.get_current();
            if ($v_1.$50()) {
                $v_0 = true;
                return;
            }
        }
        if (!$v_0) {
            this.$r_2.focus();
        }
    },
    
    $E5: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$r_2)) {
            this.$r_2.focus();
        }
    },
    
    $Df_2: function($p0) {
        this.$6t_2 = false;
        $p0.preventDefault();
        this.get_ribbon().set_$41(true);
        this.get_ribbon().$L();
    },
    
    get_$7b: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.get_$2()) && !CUI.ScriptUtility.isNullOrUndefined(this.get_$2().lastChild)) {
            var $v_0 = CUI.Utility.$AP(this.get_$2().lastChild);
            if (this.$0_0._textDirection !== 1 && CUI.Utility.$38() <= $v_0.width + $v_0.x) {
                return true;
            }
        }
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_1 = $$enum_1_0.get_current();
            if ($v_1.get_$7b()) {
                return true;
            }
        }
        return false;
    },
    
    $AV_2: function() {ULSpEN:;
        var $v_0 = 'ms-cui-tt ' + this.$9G_2;
        if (this.$5f_2) {
            $v_0 += ' ms-cui-tt-s';
        }
        return $v_0;
    },
    
    $Ct_2: function() {ULSpEN:;
        var $v_0 = 'ms-cui-tabBody';
        if (this.$1A_2) {
            $v_0 += ' ms-cui-tabBody-' + CUI.ContextualGroup.$5o(this.get_ribbon().$7L(this.$10_2).$3S_0);
        }
        return $v_0;
    },
    
    $Cv: function() {ULSpEN:;
        var $v_0 = 'ms-cui-tabContainer';
        if (this.$1A_2) {
            $v_0 += ' ms-cui-tabContainer-' + CUI.ContextualGroup.$5o(this.get_ribbon().$7L(this.$10_2).$3S_0);
        }
        return $v_0;
    },
    
    get_visible: function() {ULSpEN:;
        return CUI.Tab.callBaseMethod(this, 'get_visible');
    },
    set_visible: function($p0) {
        if (this.$1A_2) {
            throw Error.create('Visibility of Contextual Tabs cannot be set explicitly.');
        }
        CUI.Tab.callBaseMethod(this, 'set_visible', [ $p0 ]);
        return $p0;
    },
    
    $y_2: null,
    
    get_command: function() {ULSpEN:;
        return this.$y_2;
    },
    
    $1g: function($p0) {
        $p0.get_commandInfo().TabId = this.$6_0;
        return CUI.Tab.callBaseMethod(this, '$1g', [ $p0 ]);
    },
    
    $2P: function() {ULSpEN:;
        var $v_0 = (CUI.ScriptUtility.isNullOrUndefined(this.$y_2)) ? true : this.get_ribbon().$4w(this.$y_2, null, null);
        this.set_enabled($v_0);
        if ($v_0) {
            this.set_$40(new Date());
            CUI.Tab.callBaseMethod(this, '$2P');
        }
        this.get_ribbon().$AD();
    },
    
    dispose: function() {ULSpEN:;
        CUI.Tab.callBaseMethod(this, 'dispose');
        CUI.Utility.$7d(this.$D_2);
        this.$2U_2 = null;
        this.$D_2 = null;
        this.$r_2 = null;
        this.$3e_2 = null;
    }
}


CUI.Template = function() {
}


CUI.TemplateManager = function() {ULSpEN:;
    this.$3q_0 = {};
}
CUI.TemplateManager.get_instance = function() {ULSpEN:;
    if (CUI.ScriptUtility.isNullOrUndefined(CUI.TemplateManager.$5W_0)) {
        CUI.TemplateManager.$5W_0 = new CUI.TemplateManager();
    }
    return CUI.TemplateManager.$5W_0;
}
CUI.TemplateManager.prototype = {
    $3q_0: null,
    
    addTemplate: function($p0, $p1) {
        this.$3q_0[$p1] = $p0;
    },
    
    removeTemplate: function($p0) {
        this.$3q_0[$p0] = null;
    },
    
    getTemplate: function($p0) {
        return this.$3q_0[$p0];
    },
    
    loadTemplates: function($p0) {
        var $v_0 = new CUI.DataNodeWrapper($p0);
        var $v_1 = CUI.DataNodeWrapper.getFirstChildNodeWithName($p0, 'RibbonTemplates');
        var $v_2 = CUI.DataNodeWrapper.getNodeChildren($v_1);
        for (var $v_3 = 0; $v_3 < $v_2.length; $v_3++) {
            this.$D9_0($v_2[$v_3]);
        }
    },
    
    $D9_0: function($p0) {
        var $v_0 = new CUI.DataNodeWrapper($p0);
        var $v_1 = $v_0.get_attributes()['Id'];
        var $v_2 = $v_0.get_attributes()['Classname'];
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$3q_0[$v_1])) {
            return;
        }
        if (CUI.ScriptUtility.isNullOrUndefined($v_2)) {
            this.$3q_0[$v_1] = new CUI.DeclarativeTemplate($p0);
        }
        else {
        }
    }
}


CUI.RootUser = function() {
}


CUI.RootProperties = function() {
}
CUI.RootProperties.prototype = {
    RootEventCommand: null,
    ImageDownArrow: null,
    ImageDownArrowClass: null,
    ImageDownArrowTop: null,
    ImageDownArrowLeft: null,
    ImageSideArrow: null,
    ImageSideArrowClass: null,
    ImageSideArrowTop: null,
    ImageSideArrowLeft: null,
    ImageUpArrow: null,
    ImageUpArrowClass: null,
    ImageUpArrowTop: null,
    ImageUpArrowLeft: null,
    TextDirection: null,
    ToolTipFooterText: null,
    ToolTipFooterImage16by16: null,
    ToolTipFooterImage16by16Class: null,
    ToolTipFooterImage16by16Top: null,
    ToolTipFooterImage16by16Left: null,
    ToolTipDisabledCommandImage16by16: null,
    ToolTipDisabledCommandImage16by16Class: null,
    ToolTipDisabledCommandImage16by16Top: null,
    ToolTipDisabledCommandImage16by16Left: null,
    ToolTipDisabledCommandDescription: null,
    ToolTipDisabledCommandTitle: null,
    ToolTipDisabledCommandHelpKey: null,
    ToolTipHelpCommand: null,
    ToolTipSelectedItemTitlePrefix: null
}


CUI.RootEventCommandProperties = function() {
}
CUI.RootEventCommandProperties.prototype = {
    RootId: null,
    RootType: null
}


CUI.Root = function(id, properties) {ULSpEN:;
    this.$8f = Function.createDelegate(this, this.$DP_1);
    this.$8i = Function.createDelegate(this, this.$DS_1);
    this.$8j = Function.createDelegate(this, this.$DT_1);
    this.$8h = Function.createDelegate(this, this.$DR_1);
    this.$99 = Function.createDelegate(this, this.onWindowScroll);
    this.$59 = Function.createDelegate(this, this.$7Z_1);
    this.$8g = Function.createDelegate(this, this.$DQ_1);
    this.$2a_1 = -1;
    this.$3m_1 = -1;
    CUI.Root.initializeBase(this, [ null, id, null, null ]);
    this.initRootMember(this);
    this.$5_1 = properties;
    this.$k_1 = {};
    this.$9F_1 = {};
    this.$9E_1 = 0;
    this.$9k_1 = 0;
    if (!CUI.ScriptUtility.isNullOrUndefined(properties.TextDirection)) {
        this._textDirection = (properties.TextDirection.toLowerCase() === 'rtl') ? 1 : 0;
    }
    this.$6k_1 = this.$8g;
    this.$22_1 = this.$59;
    $addHandler(document, 'keydown', this.$6k_1);
    $addHandler(window, 'unload', this.$22_1);
}
CUI.Root.$1M = function($p0, $p1) {
    if (CUI.ScriptUtility.isNullOrUndefined($p0)) {
        return 0;
    }
    return $p0[$p1];
}
CUI.Root.prototype = {
    $k_1: null,
    $9F_1: null,
    $9E_1: 0,
    $9k_1: 0,
    $9d_1: false,
    $6X_1: null,
    $9U_1: null,
    _textDirection: 0,
    $2S_1: null,
    $9P_1: true,
    
    get_initializing: function() {ULSpEN:;
        return this.$9P_1;
    },
    
    get_$o: function() {ULSpEN:;
        return this.$6X_1;
    },
    set_$o: function($p0) {
        if (!this.$1o_1) {
            this.$6X_1 = $p0;
        }
        return $p0;
    },
    
    get_$3z: function() {ULSpEN:;
        return this.$9U_1;
    },
    set_$3z: function($p0) {
        if (!this.$1o_1) {
            this.$9U_1 = $p0;
            this.$6X_1 = $p0;
        }
        return $p0;
    },
    
    $AA: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.get_$o())) {
            this.get_$o().$C7();
        }
    },
    
    $Du: function($p0) {
        this.$9F_1[$p0.$6_0] = $p0;
    },
    
    $L: function() {ULSpEN:;
        CUI.Root.callBaseMethod(this, '$L');
        this.$9P_1 = false;
        if (!this.$9d_1) {
            $addHandler(window, 'scroll', this.$99);
            this.$9d_1 = true;
        }
    },
    
    $m: function() {ULSpEN:;
        CUI.Root.callBaseMethod(this, '$m');
        if (this._textDirection === 1) {
            CUI.Utility.ensureCSSClassOnElement(this.get_$2(), 'ms-cui-rtl');
        }
    },
    
    setFocus: function() {ULSpEN:;
        var $v_0 = this.get_$o();
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return false;
        }
        return $v_0.$7o();
    },
    
    restoreFocus: function() {ULSpEN:;
        var $v_0 = this.get_$3z();
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return false;
        }
        return $v_0.$7o();
    },
    
    $BK_1: false,
    
    refresh: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$24_1)) {
            this.$24_1.onRootRefreshed(this);
        }
    },
    
    attach: function() {ULSpEN:;
        this.$36(true);
    },
    
    $3N_1: false,
    
    get_needScaling: function() {ULSpEN:;
        return this.$3N_1;
    },
    set_needScaling: function(value) {ULSpEN:;
        this.$3N_1 = value;
        return value;
    },
    
    $24_1: null,
    
    get_rootUser: function() {ULSpEN:;
        return this.$24_1;
    },
    set_rootUser: function(value) {ULSpEN:;
        this.$24_1 = value;
        return value;
    },
    
    $3O_1: null,
    
    get_$18: function() {ULSpEN:;
        return this.$3O_1;
    },
    set_$18: function($p0) {
        this.$3O_1 = $p0;
        return $p0;
    },
    
    get_$4x: function() {ULSpEN:;
        return !CUI.ScriptUtility.isNullOrUndefined(this.$24_1);
    },
    
    $4w: function($p0, $p1, $p2) {
        return (this.$B1($p0, $p1, $p2, false) & 1) > 0;
    },
    
    $B1: function($p0, $p1, $p2, $p3) {
        var $v_0 = 0;
        var $v_1 = this.$24_1.isRootCommandEnabled($p0, this);
        if ($v_1) {
            $v_0 = 1;
        }
        if (CUI.ScriptUtility.isNullOrUndefined($p1) || (!$p3 && !$v_1)) {
            return $v_0;
        }
        if (this.$24_1.executeRootCommand($p1, $p2, null, this)) {
            $v_0 |= 2;
        }
        return $v_0;
    },
    
    pollForStateAndUpdate: function() {ULSpEN:;
        this.$2P();
    },
    
    $2P: function() {ULSpEN:;
        this.set_$40(new Date());
        CUI.Root.callBaseMethod(this, '$2P');
        this.ensureGlobalDisablingRemoved();
    },
    
    ensureGlobalDisablingRemoved: function() {ULSpEN:;
        CUI.Utility.enableElement(this.get_$2());
    },
    
    get_element: function() {ULSpEN:;
        return this.get_$2();
    },
    
    get_cssClass: function() {ULSpEN:;
        return 'ms-cui-disabled';
    },
    
    get_textDirection: function() {ULSpEN:;
        return this._textDirection;
    },
    
    $27: function() {ULSpEN:;
        return this.$9k_1++;
    },
    
    $A7: function($p0, $p1, $p2, $p3, $p4, $p5) {
        return new CUI.MenuSection(this, $p0, $p1, $p2, $p3, $p4, $p5);
    },
    
    $A6: function($p0, $p1, $p2, $p3) {
        return new CUI.Menu(this, $p0, $p1, $p2, $p3);
    },
    
    $CI: function($p0, $p1, $p2, $p3) {
        return new CUI.Gallery(this, $p0, $p1, $p2, $p3);
    },
    
    $CH: function($p0, $p1, $p2) {
        return new CUI.ControlComponent(this, $p0, $p1, $p2);
    },
    
    $3w: function($p0, $p1, $p2) {
        return new CUI.MenuItem(this, $p0, $p1, $p2);
    },
    
    $CF: function($p0, $p1, $p2, $p3) {
        return new CUI.CommandEventArgs($p0, $p1, $p2, $p3);
    },
    
    $Ck: function($p0) {
        if (CUI.ScriptUtility.isNullOrUndefined($p0.$6_1)) {
            return;
        }
        $p0.$6s_1 = this.$Cy();
        var $v_0 = $p0.get_commandInfo();
        $v_0.CommandId = $p0.$6_1;
        $v_0.RootId = this.$6_0;
        $v_0.RootType = this.get_rootType();
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$24_1)) {
            this.$24_1.executeRootCommand($p0.$6_1, $p0.$2z_1, $v_0, this);
        }
    },
    
    $1g: function($p0) {
        this.$Ck($p0);
        return true;
    },
    
    get_rootType: function() {ULSpEN:;
        return 'Root';
    },
    
    $Cy: function() {ULSpEN:;
        return this.$9E_1++;
    },
    
    $W_1: null,
    
    $BX: function($p0) {
        if (CUI.ScriptUtility.isNullOrUndefined(this.$W_1)) {
            this.$W_1 = [];
        }
        Array.add(this.$W_1, $p0);
    },
    
    $69_1: false,
    
    $2e: function($p0) {
        if (CUI.ScriptUtility.isNullOrUndefined(this.$W_1)) {
            return;
        }
        this.$69_1 = true;
        var $v_0 = Array.indexOf(this.$W_1, $p0);
        for (var $v_1 = this.$W_1.length - 1; $v_1 >= $v_0; $v_1--) {
            (this.$W_1[$v_1]).$4o();
            Array.removeAt(this.$W_1, $v_1);
        }
        this.$69_1 = false;
    },
    
    $4n: function() {ULSpEN:;
        if (this.$69_1 || CUI.ScriptUtility.isNullOrUndefined(this.$W_1)) {
            return;
        }
        for (var $v_0 = this.$W_1.length - 1; $v_0 >= 0; $v_0--) {
            (this.$W_1[$v_0]).$4o();
            Array.removeAt(this.$W_1, $v_0);
        }
    },
    
    $33_1: null,
    
    $2f: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$33_1)) {
            return;
        }
        this.$33_1.$X();
    },
    
    $2d_1: 0,
    $3s_1: null,
    
    get_$7t: function() {ULSpEN:;
        if ((Sys.Browser.agent === Sys.Browser.InternetExplorer) && (CUI.ScriptUtility.isNullOrUndefined(this.$3s_1))) {
            this.$3s_1 = CUI.Utility.$A4();
            this.$3s_1.className = 'ms-cui-tooltip-backFrame';
            this.$3s_1.style.visibility = 'hidden';
            document.body.appendChild(this.$3s_1);
        }
        return this.$3s_1;
    },
    
    $1o_1: false,
    $1D_1: null,
    $2K_1: null,
    $1B_1: null,
    
    $Be: function($p0, $p1) {
        if (CUI.ScriptUtility.isNullOrUndefined(this.$2K_1)) {
            this.$2K_1 = [];
        }
        Array.add(this.$2K_1, $p0);
        this.$1B_1 = $p0;
        if (this.$1o_1) {
            return false;
        }
        var $v_0 = this.get_$Al_1();
        $v_0.style.visibility = 'hidden';
        document.body.appendChild($v_0);
        $v_0.style.visibility = 'visible';
        this.$1o_1 = true;
        return true;
    },
    
    $CZ: function($p0) {
        if ($p0 !== this.$1B_1) {
            return;
        }
        if (!this.$1o_1) {
            throw Error.create('Cannot end modal mode because the Ribbon is not in Modal Mode');
        }
        Array.removeAt(this.$2K_1, this.$2K_1.length - 1);
        this.$1B_1 = null;
        if (this.$2K_1.length > 0) {
            this.$1B_1 = this.$2K_1[this.$2K_1.length - 1];
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$1B_1)) {
            this.$Cb_1();
        }
    },
    
    $Cb_1: function() {ULSpEN:;
        if (!this.$1o_1) {
            return;
        }
        if (!this.$2K_1.length) {
            document.body.removeChild(this.get_$Al_1());
            this.$1o_1 = false;
            if (Sys.Browser.agent === Sys.Browser.InternetExplorer) {
                $clearHandlers(this.$1D_1);
                this.$1D_1 = null;
            }
        }
    },
    
    get_$Al_1: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$1D_1)) {
            this.$1D_1 = CUI.Utility.$3('div');
            if (Sys.Browser.agent === Sys.Browser.InternetExplorer) {
                this.$1D_1.className = 'ms-cui-modalDiv-ie';
            }
            else {
                this.$1D_1.className = 'ms-cui-modalDiv-ff';
            }
            CUI.Utility.$29(this.$1D_1, true, false);
            $addHandler(this.$1D_1, 'click', this.$8h);
            $addHandler(this.$1D_1, 'mouseover', this.$8j);
            $addHandler(this.$1D_1, 'mouseout', this.$8i);
            $addHandler(this.$1D_1, 'contextmenu', this.$8f);
        }
        return this.$1D_1;
    },
    
    $6k_1: null,
    $22_1: null,
    
    $DP_1: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$1B_1)) {
            this.$1B_1.onModalContextMenu($p0);
        }
    },
    
    $DR_1: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$1B_1)) {
            this.$1B_1.onModalBodyClick($p0);
        }
    },
    
    $DT_1: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$1B_1)) {
            this.$1B_1.onModalBodyMouseOver($p0);
        }
    },
    
    $DS_1: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$1B_1)) {
            this.$1B_1.onModalBodyMouseOut($p0);
        }
    },
    
    $DQ_1: function($p0) {
        if (!this.$1o_1) {
            return;
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$1B_1)) {
            this.$1B_1.onModalKeyPress($p0);
        }
    },
    
    onWindowScroll: function(evt) {ULSpEN:;
        this.$4n();
        this.$2f();
    },
    
    $Cp: function() {ULSpEN:;
        this.$AA();
    },
    
    $7Z_1: function($p0) {
        this.dispose();
    },
    
    dispose: function() {ULSpEN:;
        this.$6J_1 = true;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.get_$2()) && this.$BK_1) {
            $removeHandler(this.get_$2(), 'contextmenu', CUI.Utility.get_returnFalseHandler());
        }
        try {
            $removeHandler(document, 'keydown', this.$6k_1);
        }
        catch ($$e_1_0) {
        }
        $removeHandler(window, 'unload', this.$22_1);
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$1D_1)) {
            $clearHandlers(this.$1D_1);
        }
        this.$1D_1 = null;
        this.$24_1 = null;
        this.$3O_1 = null;
        CUI.Root.callBaseMethod(this, 'dispose');
    },
    
    $6J_1: false,
    
    get_$CU: function() {ULSpEN:;
        return this.$6J_1;
    },
    set_$CU: function($p0) {
        this.$6J_1 = $p0;
        return $p0;
    },
    
    get_$EM: function() {ULSpEN:;
        if (this._componentWidth === -1 && !CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this._componentWidth = this.get_$2().offsetWidth;
        }
        return this._componentWidth;
    },
    
    get_$77: function() {ULSpEN:;
        if (this._componentHeight === -1 && !CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this._componentHeight = this.get_$2().offsetHeight;
        }
        return this._componentHeight;
    },
    
    get_$4p: function() {ULSpEN:;
        if (this._componentTopPosition === -1 && !CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this._componentTopPosition = CUI.UIUtility.calculateOffsetTop(this.get_$2());
        }
        return this._componentTopPosition;
    },
    
    get_$EN: function() {ULSpEN:;
        if (this._componentLeftPosition === -1 && !CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this._componentLeftPosition = CUI.UIUtility.calculateOffsetLeft(this.get_$2());
        }
        return this._componentLeftPosition;
    },
    
    $5G_1: '',
    
    get_cookieDataVersion: function() {ULSpEN:;
        return this.$5G_1;
    },
    set_cookieDataVersion: function(value) {ULSpEN:;
        this.$5G_1 = value;
        return value;
    },
    
    $3u_1: false,
    
    get_useDataCookie: function() {ULSpEN:;
        return this.$3u_1;
    },
    set_useDataCookie: function(value) {ULSpEN:;
        this.$3u_1 = value;
        return value;
    },
    
    storeDataCookie: function(name, value) {ULSpEN:;
        var $v_0 = new Date();
        $v_0.setTime($v_0.getTime() + 604800000);
        document.cookie = name + '=' + this.$5G_1 + value + '; expires=' + $v_0.toDateString() + '; path=/';
    },
    
    getDataCookieValue: function(name) {ULSpEN:;
        name = this.$5G_1 + name;
        var $v_0 = document.cookie.split(';');
        for (var $v_1 = 0; $v_1 < $v_0.length; $v_1++) {
            var $v_2 = $v_0[$v_1].trimStart();
            if ($v_2.startsWith(name)) {
                if ($v_2.startsWith(name + '=')) {
                    return $v_2.substring(name.length + 1, $v_2.length);
                }
            }
        }
        return null;
    },
    
    $5_1: null,
    $2v_1: false,
    
    $Dn: function($p0, $p1) {
        this.$BI_1($p0, $p1, false);
    },
    
    $Do: function($p0, $p1) {
        this.$BI_1($p0, $p1, true);
    },
    
    $BI_1: function($p0, $p1, $p2) {
        if (CUI.ScriptUtility.isNullOrUndefined($p0) || CUI.ScriptUtility.isNullOrUndefined($p1)) {
            return;
        }
        $p0.style.top = '0px';
        $p0.style.left = '0px';
        var $v_0 = this.$7K($p0, $p1);
        this.$7m($p0, $v_0, $p2);
    },
    
    $7m: function($p0, $p1, $p2) {
        var $v_0 = false;
        if (CUI.ScriptUtility.isNullOrUndefined($p0) || CUI.ScriptUtility.isNullOrUndefined($p1)) {
            return;
        }
        var $v_1;
        var $v_2;
        var $v_3 = CUI.Root.$1M($p1, 'launcherLeft');
        var $v_4 = CUI.Root.$1M($p1, 'launcherTop');
        var $v_5 = CUI.Root.$1M($p1, 'launcherWidth');
        var $v_6 = CUI.Root.$1M($p1, 'launcherHeight');
        var $v_7 = CUI.Root.$1M($p1, 'flyOutWidth');
        var $v_8 = CUI.Root.$1M($p1, 'flyOutHeight');
        var $v_9 = CUI.Root.$1M($p1, 'flyOutRealHeight');
        var $v_A = CUI.Root.$1M($p1, 'viewportWidth');
        var $v_B = CUI.Root.$1M($p1, 'viewportHeight');
        var $v_C = CUI.Root.$1M($p1, 'viewableLeft');
        var $v_D = CUI.Root.$1M($p1, 'viewableTop');
        var $v_E = !this.$0_0._textDirection;
        var $v_F = false, $v_G = false;
        var $v_H = $p0.getAttribute('mscui:scrollable');
        var $v_I = !CUI.ScriptUtility.isNullOrUndefined($v_H) && ($v_H) === 'true';
        if ($p2) {
            if ($v_E) {
                $v_1 = $v_3 + $v_5;
                $v_1 += 2;
            }
            else {
                $v_1 = $v_3 - $v_7;
            }
            $v_2 = $v_4;
        }
        else {
            if ($v_E) {
                $v_1 = $v_3;
            }
            else {
                $v_1 = $v_3 + $v_5 - $v_7;
            }
            $v_2 = $v_4 + $v_6;
            var $v_J = ($v_5 >= 2) ? $v_5 - 2 : $v_5;
            if ($v_J > $v_7) {
                $v_7 = $v_J;
            }
            $p0.style.minWidth = $v_J + 'px';
        }
        if (this.$2v_1) {
            $v_2 += $v_D;
            $v_1 += $v_C;
        }
        $p0.style.top = $v_2 + 'px';
        $p0.style.left = $v_1 + 'px';
        if ($v_7 <= $v_A) {
            if ($v_1 + $v_7 > $v_C + $v_A) {
                if ($p2 && $v_E && ($v_3 - $v_7) > $v_C) {
                    $v_1 = $v_3 - $v_7;
                }
                else {
                    $v_1 = $v_C + $v_A - $v_7 - 5;
                    $v_F = true;
                }
                $v_0 = true;
            }
            else if ($v_1 < $v_C) {
                if ($p2 && !$v_E && ($v_3 + $v_5 + $v_7) < ($v_C + $v_A)) {
                    $v_1 = $v_3 + $v_5;
                }
                else {
                    $v_1 = $v_C + 5;
                    $v_G = true;
                }
                $v_0 = true;
            }
            else {
                $v_0 = false;
            }
        }
        else {
            if ($v_E) {
                $v_1 = $v_C;
                $v_0 = true;
            }
            else {
                $v_1 = $v_C + $v_A - $v_7;
                $v_0 = true;
            }
        }
        if ($v_0) {
            $p0.style.left = $v_1 + 'px';
            $v_0 = false;
        }
        if ($v_2 + $v_9 > $v_D + $v_B) {
            var $v_K = $v_2;
            var $v_L = $v_D + $v_B - $v_2;
            $v_2 = $v_4 - $v_9;
            if (this.$2v_1) {
                $v_2 += $v_D;
            }
            var $v_M = $v_4;
            if (!this.$2v_1) {
                $v_M -= $v_D;
            }
            $v_0 = true;
            if ($v_M < $v_9) {
                var $v_N = $v_7 + 22;
                if ($v_M < $v_L) {
                    $v_2 = $v_K;
                    $p0.style.maxHeight = ($v_L - 5) + 'px';
                    if (!$v_I) {
                        $p0.style.overflowY = 'scroll';
                        $p0.style.width = $v_N + 'px';
                    }
                    if ($v_F && $v_E) {
                        $v_1 -= 27;
                        $p0.style.left = $v_1 + 'px';
                    }
                    else if ($v_G && !$v_E) {
                        $v_1 += 27;
                        $p0.style.left = $v_1 + 'px';
                    }
                    $v_0 = false;
                }
                else {
                    $p0.style.maxHeight = ($v_M - 5) + 'px';
                    if (!$v_I) {
                        $p0.style.overflowY = 'scroll';
                        $p0.style.width = $v_N + 'px';
                    }
                    if ($v_F && $v_E) {
                        $v_1 -= 27;
                        $p0.style.left = $v_1 + 'px';
                    }
                    else if ($v_G && !$v_E) {
                        $v_1 += 27;
                        $p0.style.left = $v_1 + 'px';
                    }
                }
                if (!$v_I) {
                    $p0.setAttribute('mscui:scrollable', 'true');
                }
            }
            else {
                if ($v_I) {
                    $p0.style.maxHeight = 'none';
                    $p0.style.overflowY = 'visible';
                    $p0.style.width = 'auto';
                    $p0.setAttribute('mscui:scrollable', 'false');
                }
            }
        }
        else {
            if ($v_I) {
                $p0.style.maxHeight = 'none';
                $p0.style.overflowY = 'visible';
                $p0.style.width = 'auto';
                $p0.setAttribute('mscui:scrollable', 'false');
            }
            $v_0 = false;
        }
        if ($v_0) {
            $p0.style.top = $v_2 + 'px';
            $v_0 = false;
        }
    },
    
    $7K: function($p0, $p1) {
        var $v_0 = {};
        if (CUI.ScriptUtility.isNullOrUndefined($p0) || CUI.ScriptUtility.isNullOrUndefined($p1)) {
            return $v_0;
        }
        $v_0['launcherWidth'] = $p1.offsetWidth;
        $v_0['launcherHeight'] = $p1.offsetHeight;
        var $v_1 = $p1.offsetTop, $v_2 = $p1.offsetLeft;
        if (!CUI.ScriptUtility.isNullOrUndefined($p1.offsetParent)) {
            var $v_3 = $p1.offsetParent;
            for (; !CUI.ScriptUtility.isNullOrUndefined($v_3); $v_3 = $v_3.offsetParent) {
                $v_1 += $v_3.offsetTop;
                $v_2 += $v_3.offsetLeft;
            }
        }
        else {
            $v_1 = $p1.offsetTop;
            $v_2 = $p1.offsetLeft;
        }
        if (!CUI.ScriptUtility.isNullOrUndefined($p1.parentNode)) {
            var $v_4 = 0;
            var $v_5 = 0;
            var $v_6 = $p1.parentNode;
            for (; !CUI.ScriptUtility.isNullOrUndefined($v_6); $v_6 = $v_6.parentNode) {
                if ($v_6.scrollTop > 0) {
                    $v_4 += $v_6.scrollTop;
                }
                if ($v_6.scrollLeft > 0) {
                    if (($v_6 === document.documentElement) && (CUI.Utility.$3B()) && (this.$0_0._textDirection === 1)) {
                        $v_5 += document.body.scrollLeft;
                    }
                    else {
                        $v_5 += $v_6.scrollLeft;
                    }
                }
            }
            if ($v_1 >= $v_4) {
                $v_1 -= $v_4;
            }
            if ($v_2 >= $v_5) {
                $v_2 -= $v_5;
            }
        }
        $v_0['launcherTop'] = $v_1;
        $v_0['launcherLeft'] = $v_2;
        if ($p0) {
            $v_0['flyOutWidth'] = $p0.offsetWidth;
            $v_0['flyOutHeight'] = $p0.offsetHeight;
            $v_0['flyOutRealHeight'] = $p0.scrollHeight;
            $v_0['viewportWidth'] = CUI.Utility.$38();
            $v_0['viewportHeight'] = CUI.Utility.$3y();
            if (CUI.ScriptUtility.isNullOrUndefined($v_0['viewportWidth'])) {
                $v_0['viewportWidth'] = document.documentElement.clientWidth;
                $v_0['viewportHeight'] = document.documentElement.clientHeight;
            }
            if (CUI.ScriptUtility.isNullOrUndefined($v_0['viewportWidth'])) {
                $v_0['viewportWidth'] = document.body.clientWidth;
                $v_0['viewportHeight'] = document.body.clientHeight;
            }
            $v_0['viewableTop'] = document.documentElement.scrollTop;
            $v_0['viewableLeft'] = document.documentElement.scrollLeft;
            if (CUI.ScriptUtility.isNullOrUndefined($v_0['viewableTop'])) {
                $v_0['viewableTop'] = window.pageYOffset;
                $v_0['viewableLeft'] = window.pageXOffset;
            }
            if (CUI.ScriptUtility.isNullOrUndefined($v_0['viewableTop'])) {
                $v_0['viewableTop'] = document.body.scrollTop;
                $v_0['viewableLeft'] = document.body.scrollLeft;
            }
            if ((CUI.Utility.$3B()) && (this.$0_0._textDirection === 1)) {
                $v_0['viewableLeft'] = document.body.scrollLeft;
            }
        }
        return $v_0;
    }
}


CUI.ButtonDock = function(root, id, properties) {ULSpEN:;
    CUI.ButtonDock.initializeBase(this, [ root, id, '', '' ]);
    this.$1O_1 = properties.Alignment;
}
CUI.ButtonDock.prototype = {
    $1O_1: null,
    
    $L: function() {ULSpEN:;
        this.ensureDOMElementAndEmpty();
        this.appendChildrenToElement(this.get_$2());
        CUI.ButtonDock.callBaseMethod(this, '$L');
    },
    
    appendChildrenToElement: function($p0) {
        var $$enum_1_0 = this.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_0 = $$enum_1_0.get_current();
            $v_0.$m();
            switch (this.$1O_1) {
                case 'Left':
                    CUI.Utility.ensureCSSClassOnElement($v_0.get_$2(), 'ms-cui-toolbar-button-left');
                    break;
                case 'Center':
                    CUI.Utility.ensureCSSClassOnElement($v_0.get_$2(), 'ms-cui-toolbar-button-center');
                    break;
                case 'Right':
                    CUI.Utility.ensureCSSClassOnElement($v_0.get_$2(), 'ms-cui-toolbar-button-right');
                    break;
                default:
                    throw Error.argumentOutOfRange(this.$1O_1);
            }
            $p0.appendChild($v_0.get_$2());
            $v_0.$2O();
        }
    },
    
    ensureCorrectChildType: function($p0) {
        if (!CUI.ControlComponent.isInstanceOfType($p0)) {
            throw Error.create('Only children of type ControlComponent can be added to a ButtonDock.');
        }
    },
    
    get_cssClass: function() {ULSpEN:;
        switch (this.$1O_1) {
            case 'Left':
                return 'ms-cui-toolbar-buttondock alignleft';
            case 'Center':
                return 'ms-cui-toolbar-buttondock aligncenter';
            case 'Right':
                return 'ms-cui-toolbar-buttondock alignright';
            default:
                throw Error.argumentOutOfRange(this.$1O_1);
        }
    },
    
    get_visibleInDOM: function() {ULSpEN:;
        return true;
    },
    
    get_alignment: function() {ULSpEN:;
        return this.$1O_1;
    }
}


CUI.Toolbar = function(id, properties, builder, hasJewel) {ULSpEN:;
    CUI.Toolbar.initializeBase(this, [ id, properties ]);
    this.$3O_2 = builder;
    this.$4W_2 = hasJewel;
}
CUI.Toolbar.prototype = {
    $4U_2: null,
    $e_2: null,
    $f_2: null,
    $p_2: null,
    $t_2: null,
    $u_2: null,
    $3O_2: null,
    $4W_2: false,
    _jewel: null,
    
    get_jewel: function() {ULSpEN:;
        return this._jewel;
    },
    set_jewel: function(value) {ULSpEN:;
        this._jewel = value;
        return value;
    },
    
    refresh: function() {ULSpEN:;
        this.$L();
        CUI.Toolbar.callBaseMethod(this, '$L');
    },
    
    $L: function() {ULSpEN:;
        var $v_0 = this.$5_1;
        var $v_1 = !CUI.ScriptUtility.isNullOrUndefined($v_0.Size) || ($v_0.Size === 'TwoRow');
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this.createToolbarStructure($v_1);
        }
        this.set_$2(CUI.Utility.removeChildNodes(this.get_$2()));
        if ($v_1) {
            this.get_$2().appendChild(this.$4U_2);
            this.appendChildrenToElement(this.$f_2);
        }
        else {
            if (this.$4W_2) {
                this.get_$2().appendChild(this.$p_2);
            }
            this.appendChildrenToElement(this.get_$2());
        }
        this.$g_0 = false;
    },
    
    createToolbarStructure: function(twoRow) {ULSpEN:;
        if (this.$4W_2) {
            this.$p_2 = CUI.Utility.$3('div');
            this.$p_2.id = 'jewelcontainer';
            this.$p_2.className = 'ms-cui-jewel-container';
            this.$p_2.style.display = 'none';
        }
        if (twoRow) {
            this.$e_2 = CUI.Utility.$3('div');
            this.$e_2.className = 'ms-cui-topBar1';
            this.$e_2.style.display = 'none';
            this.$f_2 = CUI.Utility.$3('div');
            this.$f_2.className = 'ms-cui-topBar2';
            if (this.$4W_2) {
                this.$f_2.appendChild(this.$p_2);
            }
            this.$4U_2 = CUI.Utility.$3('div');
            this.$4U_2.className = 'ms-cui-ribbonTopBars';
            this.$4U_2.appendChild(this.$e_2);
            this.$4U_2.appendChild(this.$f_2);
            this.$t_2 = $get(this.$2S_1 + '-' + 'QATRowCenter');
            this.$u_2 = $get(this.$2S_1 + '-' + 'QATRowRight');
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$t_2)) {
                this.$t_2.parentNode.removeChild(this.$t_2);
                this.$e_2.appendChild(this.$t_2);
                this.$t_2.style.display = 'inline-block';
                this.$e_2.style.display = 'block';
                CUI.Utility.$29(this.$t_2, true, false);
            }
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$u_2)) {
                this.$u_2.parentNode.removeChild(this.$u_2);
                this.$e_2.appendChild(this.$u_2);
                this.$u_2.style.display = 'inline-block';
                this.$e_2.style.display = 'block';
                CUI.Utility.$29(this.$u_2, true, false);
            }
        }
        this.$m();
    },
    
    $2P: function() {ULSpEN:;
        if (this._jewel) {
            this._jewel.pollForStateAndUpdate();
        }
        CUI.Toolbar.callBaseMethod(this, '$2P');
    },
    
    ensureGlobalDisablingRemoved: function() {ULSpEN:;
        CUI.Toolbar.callBaseMethod(this, 'ensureGlobalDisablingRemoved');
        if (this._jewel) {
            this._jewel.set_enabled(true);
        }
    },
    
    ensureCorrectChildType: function(child) {ULSpEN:;
        if (!CUI.ButtonDock.isInstanceOfType(child)) {
            throw Error.create('Only children of type ButtonDock can be added to a Toolbar');
        }
        var $v_0 = child;
        if ($v_0.$1O_1 === 'Center') {
            var $$enum_2_0 = this.$4_0.getEnumerator();
            while ($$enum_2_0.moveNext()) {
                var $v_1 = $$enum_2_0.get_current();
                if ($v_1.$1O_1 === 'Center') {
                    throw Error.create('Can\'t add a centered buttondock because one is already present.');
                }
            }
        }
    },
    
    get_cssClass: function() {ULSpEN:;
        return 'ms-cui-toolbar-toolbar ' + CUI.Toolbar.callBaseMethod(this, 'get_cssClass');
    },
    
    get_domElementTagName: function() {ULSpEN:;
        return 'div';
    },
    
    get_rootType: function() {ULSpEN:;
        return 'Toolbar';
    },
    
    get_$EF: function() {ULSpEN:;
        return this.get_$18();
    },
    set_$EF: function($p0) {
        this.set_$18($p0);
        return $p0;
    },
    
    $CE: function($p0, $p1) {
        var $v_0 = $p0.attrs;
        var $v_1 = new CUI.ButtonDock(this.$0_0, $v_0.Id, $v_0);
        return $v_1;
    },
    
    $Bc: function($p0) {
        if (!this.$4W_2) {
            return;
        }
        this.$p_2.style.display = 'block';
        var $v_0 = new CUI.DataNodeWrapper($p0);
        var $v_1 = new CUI.JewelBuildContext();
        $v_1.jewelId = $v_0.get_attributes()['Id'];
        var $v_2 = new CUI.JewelBuildOptions();
        $v_2.trimmedIds = this.$3O_2.$s_0.trimmedIds;
        var $v_3 = new CUI.JewelBuilder($v_2, this.$p_2, this.$3O_2.$1R_0);
        $v_3.$Bp($p0, $v_1);
        this._jewel = $v_3.get_jewel();
    },
    
    $m: function() {ULSpEN:;
        CUI.Toolbar.callBaseMethod(this, '$m');
        this.get_$2().setAttribute('role', 'toolbar');
    },
    
    setFocusOnJewel: function() {ULSpEN:;
        if (this._jewel) {
            this._jewel.$Cq();
        }
    }
}


CUI.ToolbarBuildContext = function() {ULSpEN:;
    CUI.ToolbarBuildContext.initializeBase(this);
}
CUI.ToolbarBuildContext.prototype = {
    toolbar: null
}


CUI.ToolbarBuildOptions = function() {ULSpEN:;
    CUI.ToolbarBuildOptions.initializeBase(this);
}


CUI.ToolbarBuilder = function(options, elmPlaceholder, rootBuildClient) {ULSpEN:;
    this.$8x = Function.createDelegate(this, this.$Da_1);
    CUI.ToolbarBuilder.initializeBase(this, [ options, elmPlaceholder, rootBuildClient ]);
    if (CUI.ScriptUtility.isNullOrUndefined(elmPlaceholder)) {
        throw Error.create('Toolbar placeholder DOM element is null or undefined.');
    }
}
CUI.ToolbarBuilder.prototype = {
    
    get_toolbar: function() {ULSpEN:;
        return this.$0_0;
    },
    set_toolbar: function(value) {ULSpEN:;
        this.$0_0 = value;
        return value;
    },
    
    buildToolbar: function() {ULSpEN:;
        var $v_0 = new CUI.ToolbarBuildContext();
        var $v_1 = new CUI.DataQuery();
        $v_1.id = 'toolbar';
        $v_1.queryType = 1;
        $v_1.handler = this.$8x;
        $v_1.data = $v_0;
        this.$12_0.runQuery($v_1);
    },
    
    $Da_1: function($p0) {
        var $v_0 = $p0.contextData;
        $p0.queryData = this.applyDataExtensions($p0.queryData);
        this.set_toolbar(this.$C4_1($p0.queryData, $v_0));
        this.get_toolbar().set_$EF(this);
        this.$1R_0.onComponentCreated(this.get_toolbar(), this.get_toolbar().$6_0);
        this.get_toolbar().$L();
        this._elmPlaceholder.appendChild(this.get_toolbar().get_$2());
        var $$enum_1_0 = this.get_toolbar().$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_1 = $$enum_1_0.get_current();
            if ($v_1.$1O_1 === 'Left') {
                var $v_2 = $get('jewelcontainer');
                if ($v_2) {
                    if (!this.get_toolbar()._textDirection) {
                        $v_1.get_$2().style.left = $v_2.offsetWidth + 'px';
                    }
                    else {
                        $v_1.get_$2().style.right = $v_2.offsetWidth + 'px';
                    }
                }
                break;
            }
        }
        CUI.Utility.ensureCSSClassOnElement(this._elmPlaceholder, 'loaded');
        this.$1R_0.onComponentBuilt(this.get_toolbar(), this.get_toolbar().$6_0);
    },
    
    $C4_1: function($p0, $p1) {
        var $v_0 = CUI.DataNodeWrapper.getFirstChildNodeWithName($p0, 'Toolbar');
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            throw Error.create('No toolbar element was present in the data');
        }
        var $v_1 = new CUI.DataNodeWrapper($v_0);
        var $v_2 = (null !== CUI.DataNodeWrapper.getFirstChildNodeWithName($p0, 'Jewel'));
        this.set_toolbar(new CUI.Toolbar($v_1.get_attributes()['Id'], $v_1.get_attributes(), this, $v_2));
        this.get_toolbar().$2S_1 = this.$s_0.clientID;
        this.get_toolbar().$3u_1 = true;
        this.get_toolbar().$L();
        if ($v_2) {
            this.get_toolbar().$Bc($p0);
        }
        var $v_3 = CUI.DataNodeWrapper.getNodeChildren(CUI.DataNodeWrapper.getFirstChildNodeWithName($v_1.$a_0, 'ButtonDocks'));
        for (var $v_4 = 0; $v_4 < $v_3.length; $v_4++) {
            var $v_5 = this.$Bg_1($v_3[$v_4], $p1);
            this.get_toolbar().addChild($v_5);
        }
        return this.get_toolbar();
    },
    
    $Bg_1: function($p0, $p1) {
        var $v_0 = new CUI.DataNodeWrapper($p0);
        var $v_1 = this.get_toolbar().$CE($p0, $p1);
        var $v_2 = CUI.DataNodeWrapper.getFirstChildNodeWithName($p0, 'Controls');
        var $v_3 = CUI.DataNodeWrapper.getNodeChildren($v_2);
        for (var $v_4 = 0; $v_4 < $v_3.length; $v_4++) {
            if (this.isNodeTrimmed($v_3[$v_4])) {
                continue;
            }
            var $v_5 = this.$C3_1($v_3[$v_4], $p1);
            $v_1.addChild($v_5);
        }
        return $v_1;
    },
    
    $C3_1: function($p0, $p1) {
        var $v_0 = null;
        var $v_1 = new CUI.DataNodeWrapper($p0);
        var $v_2 = $v_1.get_name();
        var $v_3 = $v_1.get_attributes()['DisplayMode'];
        switch ($v_2) {
            case 'Button':
                $v_0 = this.$1f($p0, $p1);
                return $v_0.createComponentForDisplayMode((CUI.ScriptUtility.isNullOrEmptyString($v_3)) ? 'Small' : $v_3);
            case 'CheckBox':
                $v_0 = this.$1f($p0, $p1);
                return $v_0.createComponentForDisplayMode((CUI.ScriptUtility.isNullOrEmptyString($v_3)) ? 'Small' : $v_3);
            case 'ComboBox':
                $v_0 = this.$1f($p0, $p1);
                return $v_0.createComponentForDisplayMode('Medium');
            case 'FlyoutAnchor':
                $v_0 = this.$1f($p0, $p1);
                return $v_0.createComponentForDisplayMode((CUI.ScriptUtility.isNullOrEmptyString($v_3)) ? 'Medium' : $v_3);
            case 'Label':
                $v_0 = this.$1f($p0, $p1);
                return $v_0.createComponentForDisplayMode((CUI.ScriptUtility.isNullOrEmptyString($v_3)) ? 'Small' : $v_3);
            case 'Separator':
                $v_0 = this.$1f($p0, $p1);
                return $v_0.createComponentForDisplayMode('Small');
            case 'TextBox':
                $v_0 = this.$1f($p0, $p1);
                return $v_0.createComponentForDisplayMode((CUI.ScriptUtility.isNullOrEmptyString($v_3)) ? 'Medium' : $v_3);
            case 'ToggleButton':
                $v_0 = this.$1f($p0, $p1);
                return $v_0.createComponentForDisplayMode((CUI.ScriptUtility.isNullOrEmptyString($v_3)) ? 'Small' : $v_3);
            default:
                throw Error.create('Invalid control type.');
        }
    }
}


CUI.ToolTip = function(root, id, title, description, properties) {ULSpEN:;
    this.$1H = Function.createDelegate(this, this.$DB);
    CUI.ToolTip.initializeBase(this, [ root, id, title, description ]);
    this.$5_1 = properties;
    if (!CUI.ScriptUtility.isNullOrEmptyString(properties.ToolTipShortcutKey)) {
        if (!this.$0_0._textDirection) {
            this.$1S_0 = String.format('{0} ({1})', this.get_title(), this.$5_1.ToolTipShortcutKey);
        }
        else {
            this.$1S_0 = String.format('({1}) {0}', this.get_title(), this.$5_1.ToolTipShortcutKey);
        }
    }
}
CUI.ToolTip.prototype = {
    $b_1: null,
    $Q_1: null,
    $D_1: null,
    $1W_1: null,
    $5M_1: null,
    $4J_1: null,
    $5T_1: null,
    $2p_1: null,
    $6K_1: null,
    $5O_1: null,
    $2V_1: null,
    $4K_1: null,
    $2C_1: null,
    $6L_1: null,
    $4L_1: null,
    $4M_1: null,
    $6u_1: null,
    $6v_1: null,
    $9h_1: null,
    $9i_1: null,
    $9j_1: null,
    $5_1: null,
    $1C_1: null,
    
    $L: function() {ULSpEN:;
        if (this.get_needsDelayIniting()) {
            this.doDelayedInit();
        }
        this.ensureDOMElementAndEmpty();
        this.get_$2().setAttribute('role', 'tooltip');
        this.get_$2().setAttribute('aria-hidden', 'true');
        if (CUI.ScriptUtility.isNullOrUndefined(this.$b_1)) {
            this.$b_1 = CUI.Utility.$3('div');
            this.$b_1.className = 'ms-cui-tooltip-body';
        }
        else {
            this.$b_1 = CUI.Utility.removeChildNodes(this.$b_1);
        }
        this.get_$2().appendChild(this.$b_1);
        if (CUI.ScriptUtility.isNullOrUndefined(this.$Q_1)) {
            this.$Q_1 = CUI.Utility.$3('div');
            this.$Q_1.className = 'ms-cui-tooltip-glow';
            this.$b_1.appendChild(this.$Q_1);
        }
        else {
            this.$Q_1 = CUI.Utility.removeChildNodes(this.$Q_1);
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$D_1)) {
            this.$D_1 = CUI.Utility.$3('h1');
            if (this.$1S_0.length > 100) {
                CUI.UIUtility.setInnerText(this.$D_1, this.$1S_0.substr(0, 100));
            }
            else {
                CUI.UIUtility.setInnerText(this.$D_1, this.get_title());
            }
            this.$Q_1.appendChild(this.$D_1);
        }
        if ((CUI.ScriptUtility.isNullOrUndefined(this.$5M_1)) && (!CUI.ScriptUtility.isNullOrEmptyString(this.$5_1.ToolTipImage32by32))) {
            this.$5M_1 = CUI.Utility.$3('img');
            this.$4J_1 = CUI.Utility.$j(2, 4, this.$5_1.ToolTipImage32by32, this.$5_1.ToolTipImage32by32Class, this.$5M_1, true, false, this.$5_1.ToolTipImage32by32Top, this.$5_1.ToolTipImage32by32Left);
            this.$4J_1.className = this.$4J_1.className + ' ms-cui-tooltip-bitmap ';
            this.$Q_1.appendChild(this.$4J_1);
        }
        var $v_0 = this.$5_1.ToolTipSelectedItemTitle;
        var $v_1 = this.get_description();
        if ((CUI.ScriptUtility.isNullOrUndefined(this.$1W_1)) && ((!CUI.ScriptUtility.isNullOrEmptyString($v_1)) || (!CUI.ScriptUtility.isNullOrEmptyString($v_0)))) {
            this.$1W_1 = CUI.Utility.$3('div');
            this.$1W_1.className = 'ms-cui-tooltip-description';
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$5_1.ToolTipImage32by32)) {
                this.$1W_1.style.width = '80%';
            }
            this.$Q_1.appendChild(this.$1W_1);
            var $v_2 = this.$0_0.$5_1.ToolTipSelectedItemTitlePrefix;
            if (!CUI.ScriptUtility.isNullOrEmptyString($v_0) && (!CUI.ScriptUtility.isNullOrEmptyString($v_2))) {
                var $v_3 = String.format($v_2, $v_0);
                this.$5T_1 = CUI.Utility.$3('p');
                CUI.Utility.$2k(this.$5T_1, $v_3);
                this.$1W_1.appendChild(this.$5T_1);
                this.$9j_1 = CUI.Utility.$3('br');
                this.$1W_1.appendChild(this.$9j_1);
            }
            if (!CUI.ScriptUtility.isNullOrEmptyString($v_1)) {
                if ($v_1.length > 512) {
                    this.$1W_1.innerHTML = this.$1W_1.innerHTML + CUI.Utility.$Ad($v_1.substr(0, 512), true);
                }
                else {
                    this.$1W_1.innerHTML = this.$1W_1.innerHTML + CUI.Utility.$Ad($v_1, true);
                }
            }
        }
        if ((CUI.ScriptUtility.isNullOrUndefined(this.$2p_1)) && (!CUI.ScriptUtility.isNullOrUndefined(this.$1C_1)) && (!CUI.ScriptUtility.isNullOrEmptyString(this.$1C_1.Title))) {
            this.$6u_1 = CUI.Utility.$3('div');
            this.$6u_1.className = 'ms-cui-tooltip-clear';
            this.$Q_1.appendChild(this.$6u_1);
            this.$9h_1 = CUI.Utility.$3('hr');
            this.$Q_1.appendChild(this.$9h_1);
            this.$2V_1 = CUI.Utility.$3('div');
            this.$2V_1.className = 'ms-cui-tooltip-footer';
            this.$Q_1.appendChild(this.$2V_1);
            this.$4K_1 = CUI.Utility.$3('div');
            CUI.Utility.$2k(this.$4K_1, this.$1C_1.Title);
            this.$6K_1 = CUI.Utility.$3('img');
            this.$5O_1 = CUI.Utility.$j(2, 3, this.$1C_1.Icon, this.$1C_1.IconClass, this.$6K_1, true, false, this.$1C_1.IconTop, this.$1C_1.IconLeft);
            this.$5O_1.style.verticalAlign = 'top';
            if (!this.$0_0._textDirection) {
                this.$2V_1.appendChild(this.$5O_1);
                this.$2V_1.appendChild(this.$4K_1);
            }
            else {
                this.$2V_1.appendChild(this.$4K_1);
                this.$2V_1.appendChild(this.$5O_1);
            }
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$1C_1.Description)) {
                this.$2p_1 = CUI.Utility.$3('div');
                this.$2p_1.className = 'ms-cui-tooltip-description';
                this.$2p_1.style.width = '90%';
                CUI.Utility.$2k(this.$2p_1, this.$1C_1.Description);
                this.$Q_1.appendChild(this.$2p_1);
            }
        }
        if ((CUI.ScriptUtility.isNullOrUndefined(this.$2C_1)) && (!CUI.ScriptUtility.isNullOrUndefined(this.$0_0.$5_1.ToolTipFooterImage16by16)) && (!CUI.ScriptUtility.isNullOrUndefined(this.$0_0.$5_1.ToolTipFooterText)) && (((!CUI.ScriptUtility.isNullOrUndefined(this.$1C_1)) && (!CUI.ScriptUtility.isNullOrEmptyString(this.$1C_1.HelpKeyWord))) || (!CUI.ScriptUtility.isNullOrEmptyString(this.$5_1.ToolTipHelpKeyWord)))) {
            this.$6v_1 = CUI.Utility.$3('div');
            this.$6v_1.className = 'ms-cui-tooltip-clear';
            this.$Q_1.appendChild(this.$6v_1);
            this.$9i_1 = CUI.Utility.$3('hr');
            this.$Q_1.appendChild(this.$9i_1);
            this.$2C_1 = CUI.Utility.$3('div');
            this.$2C_1.className = 'ms-cui-tooltip-footer';
            this.$Q_1.appendChild(this.$2C_1);
            this.$4M_1 = CUI.Utility.$3('div');
            CUI.Utility.$2k(this.$4M_1, this.$0_0.$5_1.ToolTipFooterText);
            this.$6L_1 = CUI.Utility.$3('img');
            this.$4L_1 = CUI.Utility.$j(2, 3, this.$0_0.$5_1.ToolTipFooterImage16by16, this.$0_0.$5_1.ToolTipFooterImage16by16Class, this.$6L_1, true, false, this.$0_0.$5_1.ToolTipFooterImage16by16Top, this.$0_0.$5_1.ToolTipFooterImage16by16Left);
            this.$4L_1.style.verticalAlign = 'top';
            if (!this.$0_0._textDirection) {
                this.$2C_1.appendChild(this.$4L_1);
                this.$2C_1.appendChild(this.$4M_1);
            }
            else {
                this.$2C_1.appendChild(this.$4M_1);
                this.$2C_1.appendChild(this.$4L_1);
            }
        }
        this.appendChildrenToElement(this.$b_1);
        CUI.ToolTip.callBaseMethod(this, '$L');
    },
    
    $CT: function() {ULSpEN:;
        this.$L();
        this.get_$2().style.visibility = 'hidden';
        this.get_$2().style.position = 'absolute';
        this.get_$2().style.top = '0px';
        this.get_$2().style.left = '0px';
        document.body.appendChild(this.get_$2());
        this.$Dp();
        if (Sys.Browser.agent === Sys.Browser.InternetExplorer) {
            CUI.Utility.$B3(this.$0_0.get_$7t(), this.get_$2());
            this.$0_0.get_$7t().style.visibility = 'visible';
        }
        this.get_$2().style.visibility = 'visible';
        this.set_visible(true);
        this.get_$2().setAttribute('aria-hidden', 'false');
        return true;
    },
    
    $Aa: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.get_$2())) {
            this.get_$2().style.visibility = 'hidden';
            this.get_$2().setAttribute('aria-hidden', 'true');
        }
        if (Sys.Browser.agent === Sys.Browser.InternetExplorer) {
            this.$0_0.get_$7t().style.visibility = 'hidden';
        }
        this.set_visible(false);
    },
    
    get_cssClass: function() {ULSpEN:;
        return 'ms-cui-tooltip';
    },
    
    get_innerDiv: function() {ULSpEN:;
        return this.$Q_1;
    },
    set_innerDiv: function($p0) {
        this.$Q_1 = $p0;
        return $p0;
    },
    
    $Dp: function() {ULSpEN:;
        var $v_0 = this.get_$2();
        var $v_1 = this.$K_0.get_$2();
        if (CUI.ScriptUtility.isNullOrUndefined($v_0) || CUI.ScriptUtility.isNullOrUndefined($v_1)) {
            return;
        }
        $v_0.style.top = '0px';
        $v_0.style.left = '0px';
        var $v_2 = this.$0_0.$7K($v_0, $v_1);
        var $v_3 = CUI.Root.$1M($v_2, 'flyOutWidth');
        if ((this.$K_0.get_$4p() > this.$0_0.get_$4p()) && ((this.$K_0.get_$4p() + this.$K_0.get_$77()) < (this.$0_0.get_$4p() + this.$0_0.get_$77()))) {
            $v_2['launcherTop'] = this.$0_0.get_$4p();
            $v_2['launcherHeight'] = this.$0_0.get_$77();
        }
        else {
            var $v_4 = CUI.Root.$1M($v_2, 'launcherLeft');
            var $v_5 = CUI.Root.$1M($v_2, 'launcherTop');
            $v_4 += 30;
            $v_5 += 10;
            $v_2['launcherLeft'] = $v_4;
            $v_2['launcherTop'] = $v_5;
        }
        this.$0_0.$7m($v_0, $v_2, false);
        $v_0.style.minWidth = $v_3 + 'px';
    },
    
    $DB: function($p0) {
        if (this.$0_0) {
            this.$0_0.$2f();
        }
    },
    
    $Ar: function($p0) {
        if ($p0) {
            if ($p0.rawEvent) {
                var $v_0 = 113;
                var $v_1 = 123;
                if ((($p0.rawEvent.keyCode === $v_0) || ($p0.rawEvent.keyCode === $v_1))) {
                    var $v_2 = null;
                    if (!CUI.ScriptUtility.isNullOrUndefined(this.$5_1.ToolTipHelpKeyWord)) {
                        $v_2 = this.$5_1.ToolTipHelpKeyWord;
                    }
                    if ((!CUI.ScriptUtility.isNullOrUndefined(this.$1C_1)) && (!CUI.ScriptUtility.isNullOrEmptyString(this.$1C_1.HelpKeyWord))) {
                        $v_2 = this.$1C_1.HelpKeyWord;
                    }
                    if (!CUI.ScriptUtility.isNullOrUndefined($v_2)) {
                        var $v_3 = {};
                        $v_3['HelpKeyword'] = $v_2;
                        if (!CUI.ScriptUtility.isNullOrUndefined(this.$0_0.$5_1.ToolTipHelpCommand)) {
                            this.raiseCommandEvent(this.$0_0.$5_1.ToolTipHelpCommand, 1, $v_3);
                        }
                    }
                    $p0.preventDefault();
                    $p0.stopPropagation();
                    $p0.rawEvent.cancelBubble = true;
                    $p0.rawEvent.returnValue = false;
                }
                else {
                    this.$0_0.$2f();
                }
            }
        }
    },
    
    dispose: function() {ULSpEN:;
        CUI.ToolTip.callBaseMethod(this, 'dispose');
        this.$b_1 = null;
        this.$1W_1 = null;
        this.$5M_1 = null;
        this.$4J_1 = null;
        this.$2p_1 = null;
        this.$6K_1 = null;
        this.$2V_1 = null;
        this.$4K_1 = null;
        this.$2C_1 = null;
        this.$6L_1 = null;
        this.$4L_1 = null;
        this.$4M_1 = null;
        this.$Q_1 = null;
        this.$D_1 = null;
        this.$5T_1 = null;
    }
}


CUI.Unit = function(name, abbreviations, min, max, decimaldigits, step) {ULSpEN:;
    this.$5Z_0 = name;
    this.$5C_0 = abbreviations;
    this.$4d_0 = min;
    this.$4b_0 = max;
    this.$6F_0 = decimaldigits;
    this.$6x_0 = step;
}
CUI.Unit.prototype = {
    $5Z_0: null,
    $5C_0: null,
    $4d_0: 0,
    $4b_0: 0,
    $6F_0: 0,
    $6x_0: 0,
    
    $78: function($p0) {
        if (!$p0) {
            return false;
        }
        for (var $v_0 = 0; $v_0 < this.$5C_0.length; $v_0++) {
            if (this.$5C_0[$v_0].toLowerCase() === $p0.toLowerCase()) {
                return true;
            }
        }
        return false;
    },
    
    $EK: function($p0) {
        if (typeof($p0) !== 'number') {
            return CUI.Unit.$7V;
        }
        if ($p0 < this.$4d_0) {
            return 2;
        }
        if ($p0 > this.$4b_0) {
            return 3;
        }
        var $v_0 = $p0.toString();
        var $v_1 = $v_0.indexOf('.');
        if ($v_1 > -1) {
            var $v_2 = $v_0.substr($v_1 + 1);
            if ($v_2.length > this.$6F_0) {
                return 1;
            }
        }
        return 0;
    },
    
    get_$5m: function() {ULSpEN:;
        return this.$5C_0[0];
    }
}


CUI.Utility = function() {
}
CUI.Utility.removeChildNodes = function($p0) {
    if (CUI.ScriptUtility.isNullOrUndefined($p0)) {
        return null;
    }
    var $v_0 = $p0.parentNode;
    if ($v_0) {
        var $v_1 = $p0.cloneNode(false);
        $v_0.replaceChild($v_1, $p0);
        return $v_1;
    }
    else {
        var $v_2 = $p0.firstChild;
        var $v_3;
        while ($v_2) {
            $v_3 = $v_2.nextSibling;
            $p0.removeChild($v_2);
            $v_2 = $v_3;
        }
        return $p0;
    }
}
CUI.Utility.removeChildNodesSlow = function($p0) {
    while ($p0.hasChildNodes()) {
        $p0.removeChild($p0.firstChild);
    }
}
CUI.Utility.ensureCSSClassOnElement = function($p0, $p1) {
    if (CUI.ScriptUtility.isNullOrUndefined($p0)) {
        return;
    }
    var $v_0 = $p0.className;
    if (!CUI.ScriptUtility.isNullOrUndefined($v_0) && $v_0.indexOf($p1) !== -1) {
        return;
    }
    var $v_1 = ($v_0.trim() + ' ' + $p1);
    $v_1 = $v_1.trim();
    $p0.className = $v_1;
}
CUI.Utility.isDescendantOf = function($p0, $p1) {
    while (!CUI.ScriptUtility.isNullOrUndefined($p1)) {
        try {
            if ($p1.nodeName.toLowerCase() === 'body') {
                break;
            }
        }
        catch ($$e_2_0) {
            if ($p1 === $p0) {
                return true;
            }
            break;
        }
        if ($p1 === $p0) {
            return true;
        }
        $p1 = $p1.parentNode;
    }
    return false;
}
CUI.Utility.removeCSSClassFromElement = function($p0, $p1) {
    if (CUI.ScriptUtility.isNullOrUndefined($p0) || CUI.ScriptUtility.isNullOrUndefined($p1) || CUI.ScriptUtility.isNullOrUndefined($p0.className)) {
        return;
    }
    var $v_0 = $p0.className;
    if ($v_0 !== $v_0.replace($p1, '')) {
        $p0.className = $v_0.replace($p1, '');
    }
}
CUI.Utility.setEnabledOnElement = function($p0, $p1) {
    if ($p1) {
        CUI.Utility.enableElement($p0);
    }
    else {
        CUI.Utility.disableElement($p0);
    }
}
CUI.Utility.enableElement = function($p0) {
    if (CUI.ScriptUtility.isNullOrUndefined($p0)) {
        return;
    }
    CUI.Utility.removeCSSClassFromElement($p0, 'ms-cui-disabled');
}
CUI.Utility.disableElement = function($p0) {
    if (CUI.ScriptUtility.isNullOrUndefined($p0)) {
        return;
    }
    CUI.Utility.ensureCSSClassOnElement($p0, 'ms-cui-disabled');
}
CUI.Utility.setDisabledAttribute = function($p0, $p1) {
    if (CUI.ScriptUtility.isNullOrUndefined($p0)) {
        return;
    }
    $p0.disabled = $p1;
}
CUI.Utility.$1s = function($p0) {
    $p0.setAttribute('href', 'javascript:;');
    $p0.setAttribute('onclick', 'return false;');
}
CUI.Utility.$4q = function() {ULSpEN:;
    var $v_0 = CUI.Utility.$3('a');
    $v_0.href = 'javascript:;';
    $v_0.setAttribute('onclick', 'return false;');
    return $v_0;
}
CUI.Utility.$AP = function($p0) {
    var $v_0 = $p0;
    var $v_1 = 0;
    var $v_2 = 0;
    var $v_3 = $p0.offsetWidth;
    var $v_4 = $p0.offsetHeight;
    while (!CUI.ScriptUtility.isNullOrUndefined($v_0) && !CUI.ScriptUtility.isNullOrUndefined($v_0.nodeName) && $v_0.nodeName.toLowerCase() !== 'body') {
        var $v_5 = $v_0.clientLeft;
        if (CUI.ScriptUtility.isNullOrUndefined($v_5)) {
            $v_5 = 0;
        }
        var $v_6 = $v_0.clientTop;
        if (CUI.ScriptUtility.isNullOrUndefined($v_6)) {
            $v_6 = 0;
        }
        $v_1 += $v_0.offsetLeft + $v_5;
        $v_2 += $v_0.offsetTop + $v_6;
        $v_0 = $v_0.offsetParent;
    }
    return new Sys.UI.Bounds($v_1, $v_2, $v_3, $v_4);
}
CUI.Utility.$2k = function($p0, $p1) {
    CUI.UIUtility.setInnerText($p0, $p1);
}
CUI.Utility.$Ad = function($p0, $p1) {
    var $v_0 = new Sys.StringBuilder();
    if (CUI.ScriptUtility.isNullOrEmptyString($p0) || 0 === $p0.length) {
        return null;
    }
    var $v_1 = false;
    var $v_2 = 0;
    var $v_3 = 0;
    var $v_4 = 0;
    var $v_5 = $p0.length;
    while ($v_4 < $v_5) {
        var $v_6;
        var $v_7 = $p0.charCodeAt($v_4);
        if ($v_7 < 63) {
            $v_6 = CUI.Utility.$Ac_0[$v_7];
        }
        else if ($v_7 >= 160 && $v_7 <= 255) {
            $v_6 = -2;
        }
        else {
            $v_6 = 0;
        }
        if ($v_6) {
            if ($v_3 > 0) {
                $v_0.append($p0.substring($v_2, $v_2 + $v_3));
                $v_3 = 0;
            }
            $v_2 = $v_4 + 1;
            if ($v_6 === -2) {
                $v_0.append('&#');
                $v_0.append($v_7.toString());
                $v_0.append(';');
            }
            else if ($v_6 === 8) {
                var $v_8 = $p0.charAt($v_4 + 1);
                if (($v_8 === ' ') || $v_1) {
                    $v_0.append(CUI.Utility.$19_0[$v_6]);
                }
                else {
                    $v_0.append(' ');
                }
            }
            else {
                if ($v_6 === 2 && $p1) {
                    if ($v_4 + 5 < $v_5 && $p0.charAt($v_4 + 1) === 'n' && $p0.charAt($v_4 + 2) === 'b' && $p0.charAt($v_4 + 3) === 's' && $p0.charAt($v_4 + 4) === 'p' && $p0.charAt($v_4 + 5) === ';') {
                        $v_0.append(CUI.Utility.$19_0[8]);
                        $v_4 += 6;
                        $v_2 += 5;
                        continue;
                    }
                    if ($v_4 + 5 < $v_5 && $p0.charAt($v_4 + 1) === '#' && $p0.charAt($v_4 + 2) === '1' && $p0.charAt($v_4 + 3) === '6' && $p0.charAt($v_4 + 4) === '0' && $p0.charAt($v_4 + 5) === ';') {
                        $v_0.append(CUI.Utility.$19_0[8]);
                        $v_4 += 6;
                        $v_2 += 5;
                        continue;
                    }
                }
                else if ($v_6 === 4 && $p1) {
                    var $v_9, $v_A, $v_B;
                    $v_9 = $p0.charAt($v_4 + 1);
                    if ('b' === $v_9 || 'B' === $v_9) {
                        $v_A = $p0.charAt($v_4 + 2);
                        if ('>' === $v_A) {
                            $v_0.append(CUI.Utility.$19_0[9]);
                            $v_4 += 3;
                            $v_2 += 2;
                            continue;
                        }
                        else if ('r' === $v_A || 'R' === $v_A) {
                            $v_B = $p0.charAt($v_4 + 3);
                            if ('>' === $v_B) {
                                $v_0.append(CUI.Utility.$19_0[7]);
                                $v_4 += 4;
                                $v_2 += 3;
                                continue;
                            }
                            if ('/' === $v_B) {
                                var $v_C = $p0.charAt($v_4 + 4);
                                if ($v_C === '>') {
                                    $v_0.append(CUI.Utility.$19_0[7]);
                                    $v_4 += 5;
                                    $v_2 += 4;
                                    continue;
                                }
                            }
                            if (' ' === $v_B) {
                                var $v_D = $p0.charAt($v_4 + 4);
                                var $v_E = $p0.charAt($v_4 + 5);
                                if ($v_D === '/' && $v_E === '>') {
                                    $v_0.append(CUI.Utility.$19_0[7]);
                                    $v_4 += 6;
                                    $v_2 += 5;
                                    continue;
                                }
                            }
                        }
                    }
                    else if ('i' === $v_9 || 'I' === $v_9) {
                        $v_A = $p0.charAt($v_4 + 2);
                        if ('>' === $v_A) {
                            $v_0.append(CUI.Utility.$19_0[10]);
                            $v_4 += 3;
                            $v_2 += 2;
                            continue;
                        }
                    }
                    else if ('p' === $v_9 || 'P' === $v_9) {
                        $v_A = $p0.charAt($v_4 + 2);
                        if ('>' === $v_A) {
                            $v_0.append(CUI.Utility.$19_0[11]);
                            $v_4 += 3;
                            $v_2 += 2;
                            continue;
                        }
                    }
                    else if ('u' === $v_9 || 'U' === $v_9) {
                        $v_A = $p0.charAt($v_4 + 2);
                        if ('>' === $v_A) {
                            $v_0.append(CUI.Utility.$19_0[12]);
                            $v_4 += 3;
                            $v_2 += 2;
                            continue;
                        }
                    }
                    else if ('/' === $v_9) {
                        $v_B = $p0.charAt($v_4 + 3);
                        if ('>' === $v_B) {
                            $v_A = $p0.charAt($v_4 + 2);
                            if ('b' === $v_A || 'B' === $v_A) {
                                $v_0.append(CUI.Utility.$19_0[13]);
                                $v_4 += 4;
                                $v_2 += 3;
                                continue;
                            }
                            else if ('i' === $v_A || 'I' === $v_A) {
                                $v_0.append(CUI.Utility.$19_0[14]);
                                $v_4 += 4;
                                $v_2 += 3;
                                continue;
                            }
                            else if ('p' === $v_A || 'P' === $v_A) {
                                $v_0.append(CUI.Utility.$19_0[15]);
                                $v_4 += 4;
                                $v_2 += 3;
                                continue;
                            }
                            else if ('u' === $v_A || 'U' === $v_A) {
                                $v_0.append(CUI.Utility.$19_0[16]);
                                $v_4 += 4;
                                $v_2 += 3;
                                continue;
                            }
                        }
                    }
                }
                else if ($v_6 === 7) {
                    $v_1 = true;
                }
                else {
                    $v_1 = false;
                }
                $v_0.append(CUI.Utility.$19_0[$v_6]);
            }
        }
        else {
            $v_1 = false;
            $v_3++;
        }
        $v_4++;
    }
    if ($v_2 < $v_5) {
        $v_0.append($p0.substring($v_2, $v_5));
    }
    return $v_0.toString();
}
CUI.Utility.$29 = function($p0, $p1, $p2) {
    if (CUI.ScriptUtility.isNullOrUndefined($p0) || ($p0.nodeName === '#text')) {
        return;
    }
    if ($p1) {
        $p0.setAttribute('unselectable', 'on');
    }
    else {
        $p0.setAttribute('unselectable', 'off');
    }
    if ($p2) {
        var $v_0 = $p0.firstChild;
        while ($v_0) {
            CUI.Utility.$29($v_0, $p1, true);
            $v_0 = $v_0.nextSibling;
        }
    }
}
CUI.Utility.$j = function($p0, $p1, $p2, $p3, $p4, $p5, $p6, $p7, $p8) {
    var $v_0 = null;
    if ($p0 === 1) {
        $v_0 = CUI.Utility.$3('div');
    }
    else if ($p0 === 3) {
        $v_0 = ($p6) ? CUI.Utility.$CC() : CUI.Utility.$3('a');
    }
    else {
        $v_0 = ($p6) ? CUI.Utility.$CD() : CUI.Utility.$3('span');
    }
    var $v_1 = '';
    var $v_2 = {};
    $v_1 = CUI.Utility.$Ae[$p1];
    var $v_3 = !CUI.ScriptUtility.isNullOrUndefined($p7);
    var $v_4 = !CUI.ScriptUtility.isNullOrUndefined($p8);
    var $v_5 = !CUI.ScriptUtility.isNullOrUndefined($p3);
    if ($p5) {
        $v_1 += ' ms-cui-img-cont-float';
    }
    else {
        $v_1 += ' ms-cui-img-container';
    }
    if ($v_5) {
        $p4.className = $p3;
    }
    $v_0.className += ' ' + $v_1;
    if (!CUI.ScriptUtility.isNullOrEmptyString($p2)) {
        $v_0.appendChild($p4);
        $p4.src = $p2;
        if ($v_3) {
            $p4.style.top = $p7 + 'px';
        }
        if ($v_4) {
            $p4.style.left = $p8 + 'px';
        }
    }
    return $v_0;
}
CUI.Utility.$1h = function($p0, $p1, $p2, $p3, $p4, $p5, $p6) {
    $p0.style.display = 'inline-block';
    if (!CUI.ScriptUtility.isNullOrUndefined($p2)) {
        $p0.className = $p2;
    }
    if (!CUI.ScriptUtility.isNullOrEmptyString($p6)) {
        $p0.style.height = $p6 + 'px';
    }
    if (!CUI.ScriptUtility.isNullOrEmptyString($p5)) {
        $p0.style.width = $p5 + 'px';
    }
    if (!CUI.ScriptUtility.isNullOrEmptyString($p1)) {
        $p0.style.backgroundImage = 'url(' + $p1 + ')';
    }
    var $v_0 = '0px', $v_1 = '0px';
    var $v_2 = false;
    if (!CUI.ScriptUtility.isNullOrEmptyString($p4)) {
        $v_0 = $p4 + 'px';
        $v_2 = true;
    }
    if (!CUI.ScriptUtility.isNullOrEmptyString($p3)) {
        $v_1 = $p3 + 'px';
        $v_2 = true;
    }
    if ($v_2) {
        $p0.style.backgroundPosition = $v_0 + ' ' + $v_1;
    }
}
CUI.Utility.$A4 = function() {ULSpEN:;
    var $v_0 = CUI.Utility.$3('iframe');
    $v_0.style.position = 'absolute';
    $v_0.style.visibility = 'hidden';
    return $v_0;
}
CUI.Utility.$A3 = function() {ULSpEN:;
    var $v_0 = CUI.Utility.$3('span');
    if (Sys.Browser.agent === Sys.Browser.InternetExplorer) {
        $v_0.className = 'ms-cui-glass-ie';
    }
    else {
        $v_0.className = 'ms-cui-glass-ff';
    }
    return $v_0;
}
CUI.Utility.$B3 = function($p0, $p1) {
    $p0.style.position = 'absolute';
    $p0.style.visibility = 'hidden';
    $p0.style.left = $p1.style.left;
    $p0.style.top = $p1.style.top;
    var $v_0 = $p1.offsetWidth;
    var $v_1 = $p1.offsetHeight;
    $p0.style.width = $v_0.toString() + 'px';
    $p0.style.height = $v_1.toString() + 'px';
    $p0.style.visibility = 'visible';
}
CUI.Utility.$1i = function($p0, $p1) {
    if ((CUI.ScriptUtility.isNullOrUndefined($p1)) || (CUI.ScriptUtility.isNullOrUndefined($p0)) || (CUI.ScriptUtility.isNullOrUndefined($p0.ToolTipTitle))) {
        return;
    }
    $p1.setAttribute('aria-describedby', $p0.Id + '_ToolTip');
}
CUI.Utility.$AH = function($p0, $p1) {
    var $v_0;
    var $v_1 = '<br />';
    var $v_2 = $p0.lastIndexOf('\u200b\u200b');
    var $v_3 = $p0.lastIndexOf(' ');
    if ($v_2 !== -1) {
        $v_0 = CUI.Utility.$3A($p0.substr(0, $v_2)) + $v_1;
        if ($v_2 < $p0.length) {
            $v_0 += CUI.Utility.$3A($p0.substr($v_2 + 2));
        }
    }
    else if ($v_3 !== -1) {
        $v_0 = CUI.Utility.$3A($p0.substr(0, $v_3)) + $v_1;
        if ($v_3 < $p0.length) {
            $v_0 += CUI.Utility.$3A($p0.substr($v_3 + 1));
        }
        if ($p1) {
            $v_0 += ' ';
        }
    }
    else if ($v_3 === -1 && $p1) {
        $v_0 = CUI.Utility.$3A($p0) + $v_1;
    }
    else {
        $v_0 = CUI.Utility.$3A($p0);
    }
    return $v_0;
}
CUI.Utility.$3A = function($p0) {
    if (CUI.ScriptUtility.isNullOrEmptyString($p0)) {
        return '';
    }
    var $v_0 = new Sys.StringBuilder();
    var $v_1 = $p0.length;
    for (var $v_2 = 0; $v_2 < $v_1; $v_2++) {
        var $v_3 = $p0.charAt($v_2);
        switch ($v_3) {
            case '<':
                $v_0.append('&lt;');
                break;
            case '>':
                $v_0.append('&gt;');
                break;
            case '&':
                $v_0.append('&amp;');
                break;
            case '\"':
                $v_0.append('&quot;');
                break;
            case '\'':
                $v_0.append('&#39;');
                break;
            default:
                $v_0.append($v_3);
                break;
        }
    }
    return $v_0.toString();
}
CUI.Utility.$7d = function($p0) {
    if (CUI.ScriptUtility.isNullOrUndefined($p0)) {
        return;
    }
    $clearHandlers($p0);
    if (!CUI.ScriptUtility.isNullOrUndefined($p0.childNodes)) {
        for (var $v_0 = 0; $v_0 < $p0.childNodes.length; $v_0++) {
            CUI.Utility.$7d($p0.childNodes[$v_0]);
        }
    }
}
CUI.Utility.$CD = function() {ULSpEN:;
    var $v_0 = CUI.Utility.$3('span');
    $v_0.className = 'ms-cui-block';
    return $v_0;
}
CUI.Utility.$CC = function() {ULSpEN:;
    var $v_0 = CUI.Utility.$3('a');
    $v_0.className = 'ms-cui-block';
    return $v_0;
}
CUI.Utility.$v = function($p0) {
    if (CUI.ScriptUtility.isNullOrUndefined($p0)) {
        return false;
    }
    return $p0 === 'True' || $p0 === 'true';
}
CUI.Utility.$38 = function() {ULSpEN:;
    var $v_0 = window.innerWidth;
    if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
        $v_0 = document.documentElement.clientWidth;
    }
    if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
        $v_0 = document.body.clientWidth;
    }
    return $v_0;
}
CUI.Utility.$3y = function() {ULSpEN:;
    var $v_0 = window.innerHeight;
    if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
        $v_0 = document.documentElement.clientHeight;
    }
    if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
        $v_0 = document.body.clientHeight;
    }
    return $v_0;
}
CUI.Utility.$5q = function($p0, $p1) {
    var $v_0 = CUI.Utility.$Cu($p0, $p1, true);
    return ($v_0 && $v_0.length > 0) ? $v_0[0] : null;
}
CUI.Utility.$Cu = function($p0, $p1, $p2) {
    if (!CUI.ScriptUtility.isNullOrUndefined($p0.getElementsByClassName)) {
        var $v_0 = $p0.getElementsByClassName($p1);
        if ($p2) {
            if (CUI.ScriptUtility.isNullOrUndefined($v_0) || $v_0.length <= 1) {
                return $v_0;
            }
            var $v_1 = [];
            $v_1[0] = $v_0[0];
            return $v_1;
        }
        return $v_0;
    }
    if (!CUI.ScriptUtility.isNullOrUndefined($p0.querySelectorAll)) {
        if ($p2) {
            var $v_2 = $p0.querySelector('.' + $p1);
            var $v_3 = [];
            if (!CUI.ScriptUtility.isNullOrUndefined($v_2)) {
                $v_3[0] = $v_2;
            }
            return $v_3;
        }
        return $p0.querySelectorAll('.' + $p1);
    }
    else {
        return CUI.Utility.$AM_0($p0, $p1, $p2);
    }
}
CUI.Utility.$AM_0 = function($p0, $p1, $p2) {
    var $v_0 = [];
    var $v_1 = 0;
    var $v_2;
    for (var $v_3 = 0; $v_3 < $p0.childNodes.length; $v_3++) {
        $v_2 = $p0.childNodes[$v_3];
        if (!CUI.ScriptUtility.isNullOrUndefined($v_2.className) && $v_2.className.indexOf($p1) >= 0) {
            $v_0[$v_1++] = $v_2;
            if ($p2) {
                break;
            }
        }
        $v_0 = $v_0.concat(CUI.Utility.$AM_0($v_2, $p1, $p2));
        if ($v_0.length > 0 && $p2) {
            break;
        }
    }
    return $v_0;
}
CUI.Utility.$7i = function($p0) {
    if (!CUI.ScriptUtility.isNullOrUndefined($p0.select)) {
        $p0.select();
    }
    else if (Sys.Browser.agent === Sys.Browser.InternetExplorer) {
        var $v_0 = $p0.createTextRange();
        $v_0.moveStart('character', 0);
        $v_0.moveEnd('character', $p0.value.length);
        $v_0.select();
    }
    else {
        $p0.setSelectionRange(0, $p0.value.length);
    }
}
CUI.Utility.$3B = function() {ULSpEN:;
    if (!CUI.Utility.$6V_0) {
        if (Sys.Browser.agent === Sys.Browser.InternetExplorer && !window.document.documentMode) {
            CUI.Utility.$6W_0 = true;
        }
        CUI.Utility.$6V_0 = true;
    }
    return CUI.Utility.$6W_0;
}
CUI.Utility.$7N = function($p0, $p1) {
    return CUI.Utility.$Cw($p0, [ $p1 ]);
}
CUI.Utility.$Cw = function($p0, $p1) {
    var $v_0 = $p1.length;
    if (!$p0) {
        return null;
    }
    for (var $v_2 = 0; $v_2 < $v_0; $v_2++) {
        if ($p0.tagName.toLowerCase() === $p1[$v_2].toLowerCase()) {
            return $p0;
        }
    }
    var $v_1 = $p0.parentNode;
    while ($v_1) {
        for (var $v_3 = 0; $v_3 < $v_0; $v_3++) {
            if ($v_1.tagName.toLowerCase() === $p1[$v_3].toLowerCase()) {
                return $v_1;
            }
        }
        $v_1 = $v_1.parentNode;
    }
    return null;
}
CUI.Utility.$3 = function($p0) {
    var $v_0 = document.createElement($p0);
    $v_0.setAttribute('unselectable', 'on');
    return $v_0;
}
CUI.Utility.$2h = function($p0) {
    var $v_0 = document.createElement('label');
    $v_0.setAttribute('unselectable', 'on');
    $v_0.className = 'ms-cui-hidden';
    CUI.UIUtility.setInnerText($v_0, $p0);
    return $v_0;
}
CUI.Utility.$7A = function($p0) {
    return document.createElement($p0);
}
CUI.Utility.$7p = function($p0, $p1) {
    if (CUI.ScriptUtility.isNullOrUndefined($p1)) {
        return;
    }
    $p0.style.imeMode = (CUI.Utility.$v($p1)) ? 'auto' : 'disabled';
}
CUI.Utility.get_returnFalseHandler = function() {ULSpEN:;
    if (CUI.ScriptUtility.isNullOrUndefined(CUI.Utility.$5e_0)) {
        CUI.Utility.$5e_0 = CUI.NativeUtility.returnFalse;
    }
    return CUI.Utility.$5e_0;
}


CUI.ScriptUtility = function() {
}
CUI.ScriptUtility.isNullOrEmptyString = function($p0) {
    var $v_0 = null;
    return $p0 === $v_0 || typeof($p0) === 'undefined' || !$p0.length;
}
CUI.ScriptUtility.isNullOrUndefined = function($p0) {
    var $v_0 = null;
    return $p0 === $v_0 || typeof($p0) === 'undefined';
}
CUI.ScriptUtility.isUndefined = function($p0) {
    return typeof($p0) === 'undefined';
}


CUI.UIUtility = function() {
}
CUI.UIUtility.generateRandomElementId = function() {ULSpEN:;
    var $v_0 = null;
    var $v_1 = null;
    do {
        var $v_2 = Math.random();
        $v_2 = $v_2 * 100000;
        $v_2 = Math.round($v_2);
        $v_0 = 'rnd' + $v_2.toString();
        $v_1 = $get($v_0);
    } while ($v_1);
    return $v_0;
}
CUI.UIUtility.cancelEvent = function($p0) {
    if ($p0) {
        $p0.preventDefault();
        $p0.stopPropagation();
    }
}
CUI.UIUtility.insertBefore = function($p0, $p1) {
    var $v_0 = $p1.parentNode;
    $v_0.insertBefore($p0, $p1);
}
CUI.UIUtility.insertAfter = function($p0, $p1) {
    var $v_0 = $p1.parentNode;
    if ($v_0.lastChild === $p1) {
        $v_0.appendChild($p0);
    }
    else {
        $v_0.insertBefore($p0, $p1.nextSibling);
    }
}
CUI.UIUtility.removeNode = function($p0) {
    if ($p0.parentNode) {
        $p0.parentNode.removeChild($p0);
    }
}
CUI.UIUtility.calculateOffsetLeft = function($p0) {
    var $v_0 = 0;
    while ($p0) {
        $v_0 += $p0.offsetLeft;
        $p0 = $p0.offsetParent;
    }
    return $v_0;
}
CUI.UIUtility.calculateOffsetTop = function($p0) {
    var $v_0 = 0;
    while ($p0) {
        $v_0 += $p0.offsetTop;
        $p0 = $p0.offsetParent;
    }
    return $v_0;
}
CUI.UIUtility.setInnerText = function($p0, $p1) {
    CUI.NativeUtility.setInnerText($p0, $p1);
}
CUI.UIUtility.isTextNode = function($p0) {
    return $p0.nodeType === 3 || $p0.nodeType === 4;
}
CUI.UIUtility.isNodeOfType = function($p0, $p1) {
    for (var $v_0 = 0; $v_0 < $p1.length; $v_0++) {
        if ($p0.tagName === $p1[$v_0]) {
            return true;
        }
    }
    return false;
}


CUI.ListNode = function(o, prev, next) {ULSpEN:;
    this.next = next;
    this.previous = prev;
    this.data = o;
}
CUI.ListNode.prototype = {
    next: null,
    previous: null,
    data: null
}


CUI.List = function() {
}
CUI.List.prototype = {
    $1n_0: null,
    $32_0: null,
    $P_0: 0,
    
    add: function($p0) {
        if (!this.$1n_0) {
            this.$1n_0 = this.$32_0 = new CUI.ListNode($p0, null, null);
        }
        else {
            this.$32_0 = this.$32_0.next = new CUI.ListNode($p0, this.$32_0, null);
        }
        this.$P_0++;
    },
    
    insert: function($p0, $p1) {
        if ($p0 > this.$P_0 || 0 > $p0) {
            throw Error.argumentOutOfRange('pos');
        }
        if ($p0 === this.$P_0) {
            this.add($p1);
            return;
        }
        var $v_0 = this.$1n_0;
        while (0 !== $p0--) {
            $v_0 = $v_0.next;
        }
        var $v_1 = new CUI.ListNode($p1, $v_0.previous, $v_0);
        if (!$v_0.previous) {
            this.$1n_0 = $v_1;
        }
        else {
            $v_0.previous.next = $v_1;
        }
        if (!$v_0.next) {
            this.$32_0 = $v_1;
        }
        else {
            $v_0.next.previous = $v_1;
        }
    },
    
    remove: function($p0) {
        var $v_0 = this.$1n_0;
        while ($v_0) {
            if ($v_0.data === $p0) {
                break;
            }
            $v_0 = $v_0.next;
        }
        if (!$v_0) {
            return false;
        }
        if (!$v_0.previous) {
            this.$1n_0 = $v_0.next;
        }
        else {
            $v_0.previous.next = $v_0.next;
        }
        if (!$v_0.next) {
            this.$32_0 = $v_0.previous;
        }
        else {
            $v_0.next.previous = $v_0.previous;
        }
        return true;
    },
    
    clear: function() {ULSpEN:;
        var $v_0 = this.$1n_0, $v_1;
        this.$1n_0 = null;
        this.$32_0 = null;
        while ($v_0) {
            $v_1 = $v_0.next;
            $v_0.previous = null;
            $v_0.next = null;
            $v_0 = $v_1;
        }
    },
    
    indexOf: function($p0) {
        var $v_0 = this.$1n_0;
        var $v_1 = 0;
        while ($v_0) {
            if ($v_0.data === $p0) {
                break;
            }
            $v_0 = $v_0.next;
            $v_1++;
        }
        if (!$v_0) {
            return -1;
        }
        return $v_1;
    },
    
    get_item: function($p0) {
        var $v_0 = this.$9r_0($p0);
        return $v_0.data;
    },
    
    get_count: function() {ULSpEN:;
        return this.$P_0;
    },
    
    getEnumerator: function() {ULSpEN:;
        return new CUI.ListEnumerator(this.$1n_0);
    },
    
    getEnumeratorAtPos: function($p0) {
        var $v_0 = this.$9r_0($p0);
        return new CUI.ListEnumerator($v_0);
    },
    
    $9r_0: function($p0) {
        var $v_0 = this.$1n_0;
        var $v_1 = 0;
        while ($v_1 !== $p0) {
            if (!$v_0) {
                throw Error.argumentOutOfRange('pos');
            }
            $v_0 = $v_0.next;
            $v_1++;
        }
        return $v_0;
    }
}


CUI.ListEnumerator = function(first) {ULSpEN:;
    this.$3g_0 = first;
}
CUI.ListEnumerator.prototype = {
    $3g_0: null,
    $a_0: null,
    
    get_current: function() {ULSpEN:;
        if (!this.$a_0) {
            throw Error.argumentOutOfRange();
        }
        return this.$a_0.data;
    },
    
    moveNext: function() {ULSpEN:;
        if (!this.$a_0) {
            this.$a_0 = this.$3g_0;
            return this.$3g_0;
        }
        if (!this.$a_0.next) {
            return false;
        }
        this.$a_0 = this.$a_0.next;
        return true;
    },
    
    movePrevious: function() {ULSpEN:;
        if (!this.$a_0) {
            this.$a_0 = this.$3g_0;
            return this.$3g_0;
        }
        if (!this.$a_0.previous) {
            return false;
        }
        this.$a_0 = this.$a_0.previous;
        return true;
    },
    
    reset: function() {ULSpEN:;
        this.$a_0 = this.$3g_0;
    }
}


CUI.JsonXmlElement = function(name, attrs) {ULSpEN:;
    this.name = name;
    if (!attrs) {
        attrs = {};
    }
    this.attrs = attrs;
}
CUI.JsonXmlElement.prototype = {
    
    get_name: function() {ULSpEN:;
        return this.name;
    },
    
    get_attributes: function() {ULSpEN:;
        return this.attrs;
    },
    
    appendChild: function(name, attrs) {ULSpEN:;
        var $v_0 = new CUI.JsonXmlElement(name, attrs);
        return this.appendChildNode($v_0);
    },
    
    appendChildNode: function(node) {ULSpEN:;
        var $v_0 = this.children;
        if (!$v_0) {
            $v_0 = [];
            this.children = $v_0;
        }
        Array.add($v_0, node);
        return node;
    },
    
    get_childNodes: function() {ULSpEN:;
        return this.children;
    }
}


Type.registerNamespace('CUI.Controls');

CUI.Controls.ColorStyle = function() {}
CUI.Controls.$create_ColorStyle = function() {ULSpEN:;
    return new CUI.Controls.ColorStyle();
}


CUI.Controls.ColorPickerResult = function() {}
CUI.Controls.$create_ColorPickerResult = function() {ULSpEN:;
    return new CUI.Controls.ColorPickerResult();
}


CUI.Controls.ContextMenuControlProperties = function() {ULSpEN:;
    CUI.Controls.ContextMenuControlProperties.initializeBase(this);
}


CUI.Controls.ContextMenuControl = function(root, id, properties, menu) {ULSpEN:;
    CUI.Controls.ContextMenuControl.initializeBase(this, [ root, id, properties, menu ]);
    this.addDisplayMode('Menu');
}
CUI.Controls.ContextMenuControl.prototype = {
    $Ak_3: null,
    
    createDOMElementForDisplayMode: function($p0) {
        switch ($p0) {
            case 'Menu':
                this.$Ak_3 = CUI.Utility.$3('span');
                return this.$Ak_3;
            default:
                this.ensureValidDisplayMode($p0);
                return null;
        }
    },
    
    onEnabledChanged: function($p0) {
    },
    
    onMenuButtonClick: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        this.$Ah($p0, null);
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_3().CommandMenuOpen, 4, null);
    },
    
    onLaunchedMenuClosed: function() {ULSpEN:;
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_3().CommandMenuClose, 10, null);
    },
    
    get_$1_3: function() {ULSpEN:;
        return this.$5_0;
    }
}


CUI.Controls.Button = function(root, id, properties) {ULSpEN:;
    this.$85 = Function.createDelegate(this, this.handleTabBlur);
    this.$86 = Function.createDelegate(this, this.handleTabFocus);
    this.$83 = Function.createDelegate(this, this.handleMouseBlur);
    this.$84 = Function.createDelegate(this, this.handleMouseFocus);
    this.$1H = Function.createDelegate(this, this.onClick);
    CUI.Controls.Button.initializeBase(this, [ root, id, properties ]);
    this.addDisplayMode('Small');
    this.addDisplayMode('Medium');
    this.addDisplayMode('Large');
    this.addDisplayMode('Menu');
    this.addDisplayMode('Menu16');
    this.addDisplayMode('Menu32');
}
CUI.Controls.Button.prototype = {
    $F_1: null,
    $8_1: null,
    $9_1: null,
    $T_1: null,
    $Z_1: null,
    $2J_1: null,
    $16_1: null,
    $6M_1: null,
    $6N_1: null,
    $6O_1: null,
    $1u_1: null,
    $1X_1: null,
    
    createComponentForDisplayModeInternal: function($p0) {
        var $v_0;
        if ($p0.startsWith('Menu')) {
            $v_0 = this.$0_0.$3w(this.$6_0 + '-' + $p0 + this.$0_0.$27(), $p0, this);
            this.$2J_1 = this.get_$1_1().MenuItemId;
            this.$16_1 = this.get_$1_1().CommandValueId;
            if (CUI.ScriptUtility.isNullOrEmptyString(this.$16_1)) {
                this.$16_1 = this.$2J_1;
            }
        }
        else {
            $v_0 = CUI.Controls.Button.callBaseMethod(this, 'createComponentForDisplayModeInternal', [ $p0 ]);
        }
        return $v_0;
    },
    
    createDOMElementForDisplayMode: function($p0) {
        return this.$2g_1($p0, true);
    },
    
    $2g_1: function($p0, $p1) {
        var $v_0 = (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_1().Alt)) ? this.getLabel() : this.get_$1_1().Alt;
        switch ($p0) {
            case 'Large':
                this.$F_1 = CUI.Control.createStandardControlDOMElement(this, this.$0_0, 'Large', this.get_$1_1(), false, false);
                if ($p1) {
                    this.$O('Large');
                }
                return this.$F_1;
            case 'Medium':
                this.$8_1 = CUI.Control.createStandardControlDOMElement(this, this.$0_0, 'Medium', this.get_$1_1(), false, false);
                if ($p1) {
                    this.$O('Medium');
                }
                return this.$8_1;
            case 'Small':
                this.$9_1 = CUI.Control.createStandardControlDOMElement(this, this.$0_0, 'Small', this.get_$1_1(), false, false);
                if ($p1) {
                    this.$O('Small');
                }
                return this.$9_1;
            case 'Menu':
            case 'Menu16':
                this.$T_1 = CUI.Control.createStandardControlDOMElement(this, this.$0_0, 'Menu16', this.get_$1_1(), true, false);
                if ($p1) {
                    this.$O('Menu16');
                }
                return this.$T_1;
            case 'Menu32':
                this.$Z_1 = CUI.Control.createStandardControlDOMElement(this, this.$0_0, 'Menu32', this.get_$1_1(), true, false);
                if ($p1) {
                    this.$O('Menu32');
                }
                return this.$Z_1;
            default:
                this.ensureValidDisplayMode($p0);
                return null;
        }
    },
    
    $35: function($p0) {
        var $v_0 = $get(this.$6_0 + '-' + $p0);
        this.storeElementForDisplayMode($v_0, $p0);
        switch ($p0) {
            case 'Large':
                this.$F_1 = $v_0;
                break;
            case 'Medium':
                this.$8_1 = $v_0;
                break;
            case 'Small':
                this.$9_1 = $v_0;
                break;
        }
    },
    
    $O: function($p0) {
        switch ($p0) {
            case 'Large':
                this.$N_1(this.$F_1, true);
                break;
            case 'Medium':
                this.$N_1(this.$8_1, true);
                break;
            case 'Small':
                this.$N_1(this.$9_1, true);
                break;
            case 'Menu32':
                this.$N_1(this.$Z_1, false);
                break;
            case 'Menu16':
                this.$N_1(this.$T_1, false);
                break;
            case 'Menu':
                this.$N_1(this.$T_1, false);
                break;
        }
    },
    
    $N_1: function($p0, $p1) {
        $addHandler($p0, 'click', this.$1H);
        if ($p1) {
            $addHandler($p0, 'dblclick', this.$3J);
        }
        $addHandler($p0, 'mouseover', this.$84);
        $addHandler($p0, 'mouseout', this.$83);
        $addHandler($p0, 'focus', this.$86);
        $addHandler($p0, 'blur', this.$85);
    },
    
    onEnabledChanged: function($p0) {
        CUI.Utility.setEnabledOnElement(this.$F_1, $p0);
        CUI.Utility.setEnabledOnElement(this.$8_1, $p0);
        CUI.Utility.setEnabledOnElement(this.$9_1, $p0);
        CUI.Utility.setEnabledOnElement(this.$T_1, $p0);
        CUI.Utility.setEnabledOnElement(this.$Z_1, $p0);
        if (!$p0) {
            this.$1U_1();
        }
    },
    
    get_$15: function() {ULSpEN:;
        return 'Button';
    },
    
    getTextValue: function() {ULSpEN:;
        return this.getLabel();
    },
    
    getLabel: function() {ULSpEN:;
        return this.get_$1_1().LabelText;
    },
    
    receiveFocus: function() {ULSpEN:;
        this.onBeginFocus();
        var $v_0 = this.get_displayedComponent();
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return;
        }
        ($v_0).set_$1G(true);
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$T_1)) {
            this.$T_1.focus();
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$Z_1)) {
            this.$Z_1.focus();
        }
    },
    
    getDropDownDOMElementForDisplayMode: function($p0) {
        var $v_0;
        switch ($p0) {
            case 'Large':
                $v_0 = this.$6M_1;
                break;
            case 'Medium':
                $v_0 = this.$6N_1;
                break;
            case 'Small':
                $v_0 = this.$6O_1;
                break;
            case 'Menu':
                $v_0 = this.$1u_1;
                break;
            case 'Text':
                $v_0 = this.$1X_1;
                break;
            default:
                $v_0 = CUI.Utility.$3('span');
                break;
        }
        if ($v_0) {
            return $v_0;
        }
        return this.$A2_1($p0);
    },
    
    $A2_1: function($p0) {
        var $v_0;
        switch ($p0) {
            case 'Large':
                $v_0 = this.$2g_1($p0, false).cloneNode(true);
                this.$F_1 = null;
                $v_0.style.height = 'auto';
                $v_0.childNodes[1].style.height = 'auto';
                this.$6M_1 = $v_0;
                break;
            case 'Medium':
                $v_0 = this.$2g_1($p0, false).cloneNode(true);
                this.$8_1 = null;
                this.$6N_1 = $v_0;
                break;
            case 'Small':
                $v_0 = this.$2g_1($p0, false).cloneNode(true);
                this.$9_1 = null;
                this.$6O_1 = $v_0;
                break;
            case 'Menu':
                this.$1u_1 = this.$2g_1('Menu', false).cloneNode(true);
                this.$T_1 = null;
                return this.$1u_1;
            case 'Text':
                var $v_1 = CUI.Utility.$3('a');
                CUI.Utility.$1s($v_1);
                this.$1X_1 = CUI.Utility.$3('span');
                this.$1X_1.className = 'ms-cui-textmenuitem';
                CUI.UIUtility.setInnerText($v_1, this.get_$1_1().LabelText);
                this.$1X_1.appendChild($v_1);
                return this.$1X_1;
            default:
                this.ensureValidDisplayMode($p0);
                return null;
        }
        return $v_0;
    },
    
    deselect: function() {
    },
    
    getMenuItemId: function() {ULSpEN:;
        return this.$2J_1;
    },
    
    getCommandValueId: function() {ULSpEN:;
        return this.$16_1;
    },
    
    $7o: function() {ULSpEN:;
        if (!this.get_enabled()) {
            return false;
        }
        this.get_displayedComponent().get_$2().focus();
        return true;
    },
    
    focusOnDisplayedComponent: function() {ULSpEN:;
        this.receiveFocus();
    },
    
    onClick: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined(CUI.PMetrics)) {
            CUI.PMetrics.perfMark(7700);
        }
        $p0.preventDefault();
        $p0.stopPropagation();
        this.$X();
        if (!this.get_enabled()) {
            return;
        }
        this.$0_0.set_$3z(this);
        var $v_0 = 1;
        var $v_1 = this.get_stateProperties();
        var $v_2 = this.get_$1_1().CommandType;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_2) && $v_2 === 'OptionSelection') {
            $v_0 = 3;
        }
        $v_1['CommandValueId'] = this.$16_1;
        $v_1['MenuItemId'] = this.$2J_1;
        $v_1['SourceControlId'] = this.$6_0;
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_1().Command, $v_0, $v_1);
        if (!CUI.ScriptUtility.isNullOrUndefined(CUI.PMetrics)) {
            CUI.PMetrics.perfMark(7701);
        }
    },
    
    handleMouseFocus: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled()) {
            return;
        }
        var $v_0 = this.get_displayedComponent();
        if (CUI.MenuItem.isInstanceOfType($v_0)) {
            ($v_0).set_$1G(true);
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_1().CommandPreview)) {
            return;
        }
        var $v_1 = this.get_stateProperties();
        $v_1['CommandValueId'] = this.$16_1;
        $v_1['MenuItemId'] = this.$2J_1;
        var $v_2 = 5;
        var $v_3 = this.get_$1_1().CommandType;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_3) && $v_3 === 'OptionSelection') {
            $v_2 = 7;
        }
        $v_0.raiseCommandEvent(this.get_$1_1().CommandPreview, $v_2, $v_1);
    },
    
    handleMouseBlur: function($p0) {
        this.$1U_1();
        this.onEndFocus();
        if (!this.get_enabled()) {
            return;
        }
        var $v_0 = this.get_displayedComponent();
        if (CUI.MenuItem.isInstanceOfType($v_0)) {
            ($v_0).set_$1G(false);
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_1().CommandRevert)) {
            return;
        }
        var $v_1 = 6;
        var $v_2 = this.get_stateProperties();
        $v_2['CommandValueId'] = this.$16_1;
        $v_2['MenuItemId'] = this.$2J_1;
        var $v_3 = this.get_$1_1().CommandType;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_3) && $v_3 === 'OptionSelection') {
            $v_1 = 8;
        }
        $v_0.raiseCommandEvent(this.get_$1_1().CommandRevert, $v_1, $v_2);
    },
    
    handleTabFocus: function($p0) {
        this.onBeginFocus();
        var $v_0 = this.get_displayedComponent();
        if (CUI.MenuItem.isInstanceOfType($v_0)) {
            ($v_0).set_$1G(true);
            this.$39_1(this.get_enabled());
        }
        else if (this.get_enabled()) {
            this.$0_0.set_$o(this);
        }
    },
    
    handleTabBlur: function($p0) {
        this.$1U_1();
        this.onEndFocus();
        if (!this.get_enabled()) {
            return;
        }
        var $v_0 = this.get_displayedComponent();
        if (CUI.MenuItem.isInstanceOfType($v_0)) {
            ($v_0).set_$1G(false);
        }
    },
    
    onMenuClosed: function() {ULSpEN:;
        this.$1U_1();
        this.$X();
    },
    
    $1U_1: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$F_1)) {
            CUI.Utility.removeCSSClassFromElement(this.$F_1, 'ms-cui-ctl-hoveredOver');
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$8_1)) {
            CUI.Utility.removeCSSClassFromElement(this.$8_1, 'ms-cui-ctl-hoveredOver');
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$9_1)) {
            CUI.Utility.removeCSSClassFromElement(this.$9_1, 'ms-cui-ctl-hoveredOver');
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$T_1)) {
            CUI.Utility.removeCSSClassFromElement(this.$T_1, 'ms-cui-ctl-hoveredOver');
            CUI.Utility.removeCSSClassFromElement(this.$T_1, 'ms-cui-ctl-disabledHoveredOver');
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$Z_1)) {
            CUI.Utility.removeCSSClassFromElement(this.$Z_1, 'ms-cui-ctl-hoveredOver');
            CUI.Utility.removeCSSClassFromElement(this.$Z_1, 'ms-cui-ctl-disabledHoveredOver');
        }
    },
    
    $39_1: function($p0) {
        var $v_0 = 'ms-cui-ctl-hoveredOver';
        if (!$p0) {
            $v_0 = 'ms-cui-ctl-disabledHoveredOver';
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$T_1)) {
                CUI.Utility.ensureCSSClassOnElement(this.$T_1, $v_0);
            }
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$Z_1)) {
                CUI.Utility.ensureCSSClassOnElement(this.$Z_1, $v_0);
            }
        }
        else {
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$F_1)) {
                CUI.Utility.ensureCSSClassOnElement(this.$F_1, $v_0);
            }
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$8_1)) {
                CUI.Utility.ensureCSSClassOnElement(this.$8_1, $v_0);
            }
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$9_1)) {
                CUI.Utility.ensureCSSClassOnElement(this.$9_1, $v_0);
            }
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$T_1)) {
                CUI.Utility.ensureCSSClassOnElement(this.$T_1, $v_0);
            }
            if (!CUI.ScriptUtility.isNullOrUndefined(this.$Z_1)) {
                CUI.Utility.ensureCSSClassOnElement(this.$Z_1, $v_0);
            }
        }
    },
    
    dispose: function() {ULSpEN:;
        CUI.Controls.Button.callBaseMethod(this, 'dispose');
        this.$F_1 = null;
        this.$8_1 = null;
        this.$9_1 = null;
        this.$T_1 = null;
        this.$Z_1 = null;
        this.$6M_1 = null;
        this.$6N_1 = null;
        this.$6O_1 = null;
        this.$1u_1 = null;
        this.$1X_1 = null;
    },
    
    get_$1_1: function() {ULSpEN:;
        return this.$5_0;
    }
}


CUI.Controls.CheckBoxCommandProperties = function() {
}


CUI.Controls.CheckBox = function(root, id, properties) {ULSpEN:;
    this.$8V = Function.createDelegate(this, this.$As_2);
    this.$67 = Function.createDelegate(this, this.$DI_2);
    this.$49 = Function.createDelegate(this, this.$5w_2);
    this.$4A = Function.createDelegate(this, this.$5x_2);
    this.$3I = Function.createDelegate(this, this.$4u_2);
    this.$48 = Function.createDelegate(this, this.$42_2);
    this.$1H = Function.createDelegate(this, this.onClick);
    CUI.Controls.CheckBox.initializeBase(this, [ root, id, properties ]);
}
CUI.Controls.CheckBox.prototype = {
    $9_2: null,
    $17_2: null,
    $8_2: null,
    $13_2: null,
    $2F_2: null,
    
    createDOMElementForDisplayMode: function($p0) {
        var $v_0 = (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_2().Alt)) ? this.get_$1_2().LabelText : this.get_$1_2().Alt;
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            $v_0 = '';
        }
        switch ($p0) {
            case 'Small':
                this.$9_2 = CUI.Utility.$3('span');
                this.$9_2.className = 'ms-cui-cbx';
                this.$9_2.setAttribute('mscui:controltype', this.get_$15());
                this.$17_2 = CUI.Utility.$3('input');
                this.$17_2.type = 'checkbox';
                this.$17_2.className = 'ms-cui-cbx-input';
                this.$17_2.id = this._id + '-Small-checkbox';
                if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_2().ToolTipTitle)) {
                    this.$17_2.title = $v_0;
                }
                this.$17_2.setAttribute('role', this.get_$1e());
                CUI.Utility.$1i(this.get_$1_2(), this.$17_2);
                this.$N_2(this.$17_2, null);
                this.$9_2.appendChild(this.$17_2);
                return this.$9_2;
            case 'Medium':
                this.$8_2 = CUI.Utility.$3('span');
                this.$8_2.className = 'ms-cui-cbx';
                this.$8_2.setAttribute('mscui:controltype', this.get_$15());
                this.$13_2 = CUI.Utility.$3('input');
                this.$13_2.type = 'checkbox';
                this.$13_2.className = 'ms-cui-cbx-input';
                this.$13_2.id = this._id + '-Medium-checkbox';
                if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_2().ToolTipTitle)) {
                    this.$13_2.title = $v_0;
                }
                this.$13_2.setAttribute('role', this.get_$1e());
                CUI.Utility.$1i(this.get_$1_2(), this.$13_2);
                var $v_1 = false;
                if (!CUI.ScriptUtility.isNullOrUndefined(this.get_$1_2().LabelText)) {
                    this.$2F_2 = CUI.Utility.$3('label');
                    if (CUI.Utility.$3B()) {
                        this.$2F_2.setAttribute('htmlFor', this._id + '-Medium-checkbox');
                    }
                    else {
                        this.$2F_2.setAttribute('for', this._id + '-Medium-checkbox');
                    }
                    CUI.Utility.$2k(this.$2F_2, this.get_$1_2().LabelText);
                    $v_1 = true;
                }
                this.$N_2(this.$13_2, this.$2F_2);
                this.$8_2.appendChild(this.$13_2);
                if ($v_1) {
                    this.$8_2.appendChild(this.$2F_2);
                }
                return this.$8_2;
            default:
                this.ensureValidDisplayMode($p0);
                return null;
        }
    },
    
    $35: function($p0) {
        var $v_0 = $get(this.$6_0 + '-' + $p0);
        this.storeElementForDisplayMode($v_0, $p0);
        switch ($p0) {
            case 'Medium':
                this.$8_2 = $v_0;
                this.$13_2 = $v_0.firstChild;
                this.$2F_2 = $v_0.childNodes[1];
                break;
            case 'Small':
                this.$9_2 = $v_0;
                this.$17_2 = $v_0.firstChild;
                break;
        }
    },
    
    $O: function($p0) {
        switch ($p0) {
            case 'Medium':
                this.$N_2(this.$13_2, this.$2F_2);
                break;
            case 'Small':
                this.$N_2(this.$17_2, null);
                break;
        }
    },
    
    $N_2: function($p0, $p1) {
        $addHandler($p0, 'click', this.$1H);
        $addHandler($p0, 'focus', this.$48);
        $addHandler($p0, 'blur', this.$3I);
        $addHandler($p0, 'mouseover', this.$4A);
        $addHandler($p0, 'mouseout', this.$49);
        $addHandler($p0, 'keydown', this.$67);
        if (!CUI.ScriptUtility.isNullOrUndefined($p1)) {
            $addHandler($p1, 'click', this.$8V);
            $addHandler($p1, 'keydown', this.$67);
            $addHandler($p1, 'mouseover', this.$4A);
            $addHandler($p1, 'mouseout', this.$49);
        }
    },
    
    onEnabledChanged: function($p0) {
        if ($p0) {
            CUI.Utility.enableElement(this.$9_2);
            CUI.Utility.enableElement(this.$8_2);
        }
        else {
            CUI.Utility.disableElement(this.$9_2);
            CUI.Utility.disableElement(this.$8_2);
        }
        CUI.Utility.setDisabledAttribute(this.$17_2, !$p0);
        CUI.Utility.setDisabledAttribute(this.$13_2, !$p0);
    },
    
    get_$15: function() {ULSpEN:;
        return 'CheckBox';
    },
    
    get_$1e: function() {ULSpEN:;
        return 'checkbox';
    },
    
    onClick: function($p0) {
        this.$X();
        if (!this.get_enabled()) {
            return;
        }
        var $v_0 = 9;
        var $v_1 = this.get_displayedComponent();
        switch ($v_1.get_displayMode()) {
            case 'Small':
                this.get_stateProperties()['On'] = this.$17_2.checked;
                break;
            case 'Medium':
                this.get_stateProperties()['On'] = this.$13_2.checked;
                break;
            default:
                this.ensureValidDisplayMode($v_1.get_displayMode());
                return;
        }
        $v_1.raiseCommandEvent(this.get_$1_2().Command, $v_0, this.get_stateProperties());
        if (this.$0_0.get_$4x()) {
            this.$4y();
        }
        else {
            this.setState(this.get_stateProperties()['On']);
        }
    },
    
    $42_2: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled()) {
            return;
        }
        this.$0_0.set_$o(this);
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_2().CommandPreview)) {
            return;
        }
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_2().CommandPreview, 5, this.get_stateProperties());
    },
    
    $DI_2: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined($p0)) {
            if ($p0.keyCode === 13) {
                this.$As_2($p0);
            }
        }
    },
    
    $5x_2: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled()) {
            return;
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_2().CommandPreview)) {
            return;
        }
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_2().CommandPreview, 5, this.get_stateProperties());
    },
    
    $4u_2: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled()) {
            return;
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_2().CommandRevert)) {
            return;
        }
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_2().CommandRevert, 6, this.get_stateProperties());
    },
    
    $5w_2: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled()) {
            return;
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_2().CommandRevert)) {
            return;
        }
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_2().CommandRevert, 6, this.get_stateProperties());
    },
    
    $As_2: function($p0) {
        $p0.preventDefault();
        this.$X();
        if (!this.get_enabled()) {
            return;
        }
        this.$0_0.set_$o(this);
        this.setState(!this.$13_2.checked);
        this.onClick($p0);
    },
    
    setState: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$17_2)) {
            this.$17_2.checked = $p0;
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$13_2)) {
            this.$13_2.checked = $p0;
        }
    },
    
    $4y: function() {ULSpEN:;
        this.pollForStateAndUpdateInternal(this.get_$1_2().Command, this.get_$1_2().QueryCommand, this.get_stateProperties(), true);
        this.setState(this.get_stateProperties()['On']);
    },
    
    addDisplayModes: function() {ULSpEN:;
        this.addDisplayMode('Small');
        this.addDisplayMode('Medium');
    },
    
    $7o: function() {ULSpEN:;
        if (!this.get_enabled()) {
            return false;
        }
        var $v_0 = this.get_displayedComponent().get_$2();
        $v_0.firstChild.focus();
        return true;
    },
    
    dispose: function() {ULSpEN:;
        CUI.Controls.CheckBox.callBaseMethod(this, 'dispose');
        this.$8_2 = null;
        this.$13_2 = null;
        this.$2F_2 = null;
        this.$9_2 = null;
        this.$17_2 = null;
    },
    
    get_$1_2: function() {ULSpEN:;
        return this.$5_0;
    }
}


CUI.Controls.ColorPickerCommandProperties = function() {
}


CUI.Controls.ColorPicker = function(root, id, properties, colors) {ULSpEN:;
    this.$53 = Function.createDelegate(this, this.$An_1);
    this.$8A = Function.createDelegate(this, this.$DA_1);
    this.$55 = Function.createDelegate(this, this.$Ap_1);
    this.$54 = Function.createDelegate(this, this.$Ao_1);
    CUI.Controls.ColorPicker.initializeBase(this, [ root, id, properties ]);
    this.addDisplayMode('Menu');
    this.$9D_1 = colors;
}
CUI.Controls.ColorPicker.prototype = {
    $9D_1: null,
    
    createComponentForDisplayModeInternal: function($p0) {
        if (this.$k_0.length > 0) {
            throw Error.create('Only one ControlComponent can be created for each ColorPicker Control');
        }
        var $v_0;
        $v_0 = this.$0_0.$3w(this.$6_0 + '-' + $p0 + this.$0_0.$27(), $p0, this);
        return $v_0;
    },
    
    get_$15: function() {ULSpEN:;
        return 'ColorPicker';
    },
    
    $2T_1: null,
    
    $BV_1: function($p0, $p1) {
        var $v_0 = null;
        var $v_1 = $p0.ownerDocument;
        var $v_2 = 0;
        var $v_3 = $p1.length / 10;
        for (var $v_4 = 0; $v_4 < $p1.length; $v_4++) {
            if (!($v_4 % 10)) {
                $v_0 = $v_1.createElement('tr');
                $p0.appendChild($v_0);
                $v_2++;
            }
            var $v_5 = $v_1.createElement('td');
            $v_5.className = 'ms-cui-colorpicker-cell';
            $v_5.setAttribute('arrayPosition', $v_4);
            if ($v_2 === 1) {
                $v_5.style.padding = '2px';
                $v_5.style.height = '16px';
            }
            $v_0.appendChild($v_5);
            var $v_6 = $v_1.createElement('a');
            $v_6.href = 'javascript:';
            var $v_7 = $p1[$v_4].Title;
            $v_6.title = $v_7;
            $v_6.className = 'ms-cui-colorpicker-cell-a';
            $addHandler($v_6, 'focus', this.$54);
            var $v_8 = $v_1.createElement('div');
            var $v_9 = $p1[$v_4].DisplayColor;
            $v_8.style.backgroundColor = $v_9;
            $v_8.className = 'ms-cui-colorpicker-celldiv';
            var $v_A = 13;
            if ($v_2 === 1 || $v_2 === 2) {
                $v_8.style.borderTopWidth = '1px';
                $v_A--;
            }
            if ($v_2 === 1 || $v_2 === $v_3) {
                $v_8.style.borderBottomWidth = '1px';
                $v_A--;
            }
            if ($v_A !== 13) {
                $v_8.style.height = $v_A + 'px';
            }
            var $v_B = $v_1.createElement('div');
            $v_B.className = 'ms-cui-colorpicker-cellinternaldiv';
            $addHandler($v_6, 'mouseover', this.$55);
            $addHandler($v_6, 'mouseout', this.$8A);
            $addHandler($v_6, 'click', this.$53);
            $v_5.appendChild($v_6);
            $v_6.appendChild($v_8);
            $v_8.appendChild($v_B);
            $v_5.colorPickerCssClass = $p1[$v_4];
            Array.add(this.$2T_1, $v_5);
        }
    },
    
    createDOMElementForDisplayMode: function($p0) {
        switch ($p0) {
            case 'Menu':
                var $v_0 = this.$0_0.get_element().ownerDocument;
                var $v_1 = $v_0.createElement('table');
                if (this.$0_0._textDirection === 1) {
                    $v_1.dir = 'rtl';
                }
                else {
                    $v_1.dir = 'ltr';
                }
                $v_1.className = 'ms-cui-smenu-inner';
                $v_1.setAttribute('cellSpacing', '0');
                $v_1.setAttribute('cellPadding', '0');
                $v_1.setAttribute('mscui:controltype', this.get_$15());
                this.$2T_1 = [];
                var $v_2 = $v_0.createElement('tbody');
                this.$BV_1($v_2, this.$9D_1);
                $v_1.appendChild($v_2);
                return $v_1;
            default:
                this.ensureValidDisplayMode($p0);
                break;
        }
        return null;
    },
    
    onEnabledChanged: function($p0) {
    },
    
    $An_1: function($p0) {
        $p0.preventDefault();
        if (!this.get_enabled()) {
            return;
        }
        var $v_0 = $p0.target;
        var $v_1 = CUI.Utility.$7N($v_0, 'td');
        var $v_2 = this.$AO_1($v_1);
        this.$76_1();
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_1().Command, 1, $v_2);
    },
    
    $AO_1: function($p0) {
        var $v_0 = $p0.colorPickerCssClass;
        var $v_1 = new CUI.Controls.ColorPickerResult();
        $v_1.Color = $v_0.Color;
        $v_1.Style = $v_0.Style;
        return $v_1;
    },
    
    $Ap_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        var $v_0 = CUI.Utility.$7N($p0.target, 'td');
        this.$7Q_1($v_0);
    },
    
    $Ao_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        var $v_0 = CUI.Utility.$7N($p0.target, 'td');
        this.$7Q_1($v_0);
    },
    
    $DA_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        this.$5z_1();
        CUI.Controls.ColorPicker.$7_1 = -10;
    },
    
    $3C_1: false,
    $7c_1: null,
    
    $7Q_1: function($p0) {
        var $v_0 = parseInt($p0.getAttribute('arrayPosition'));
        if (CUI.Controls.ColorPicker.$7_1 === $v_0) {
            return;
        }
        CUI.Controls.ColorPicker.$7_1 = $v_0;
        this.$B8_1($p0);
        this.$Ba_1($p0);
    },
    
    $Ba_1: function($p0) {
        this.$5z_1();
        Sys.UI.DomElement.addCssClass($p0, 'ms-cui-colorpicker-hoveredOver');
        this.$7T_1 = $p0;
        if ($p0.firstChild) {
            $p0.firstChild.focus();
        }
    },
    
    $7T_1: null,
    
    $5z_1: function() {ULSpEN:;
        if (this.$7T_1) {
            this.$7T_1.className = 'ms-cui-colorpicker-cell';
        }
    },
    
    receiveFocus: function() {ULSpEN:;
        this.$7n_1(0);
    },
    
    $7n_1: function($p0) {
        if (this.$2T_1 && this.$2T_1.length > $p0) {
            var $v_0 = this.$2T_1[$p0];
            this.$7Q_1($v_0);
        }
    },
    
    $76_1: function() {ULSpEN:;
        this.$3C_1 = false;
        this.$7c_1 = null;
    },
    
    $7E_1: function() {ULSpEN:;
        if (this.$3C_1 && !CUI.ScriptUtility.isNullOrEmptyString(this.get_$1_1().CommandRevert)) {
            this.get_displayedComponent().raiseCommandEvent(this.get_$1_1().CommandRevert, 6, this.$7c_1);
        }
    },
    
    $B8_1: function($p0) {
        if (!CUI.ScriptUtility.isNullOrEmptyString(this.get_$1_1().CommandPreview)) {
            this.$3C_1 = true;
            var $v_0 = this.$AO_1($p0);
            this.$7c_1 = $v_0;
            this.get_displayedComponent().raiseCommandEvent(this.get_$1_1().CommandPreview, 5, $v_0);
        }
    },
    
    get_$1_1: function() {ULSpEN:;
        return this.$5_0;
    },
    
    onMenuClosed: function() {ULSpEN:;
        this.$7E_1();
    },
    
    $2j: function() {ULSpEN:;
        var $v_0 = 1;
        var $v_1 = window.event;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_1) && $v_1.keyCode === 38) {
            $v_0 = 10;
        }
        if (CUI.Controls.ColorPicker.$7_1 < 0) {
            CUI.Controls.ColorPicker.$7_1 += this.$2T_1.length + $v_0;
        }
        if (CUI.Controls.ColorPicker.$7_1 >= $v_0) {
            this.$7n_1(CUI.Controls.ColorPicker.$7_1 - $v_0);
            return true;
        }
        this.$5z_1();
        CUI.Controls.ColorPicker.$7_1 -= $v_0;
        return false;
    },
    
    $2i: function() {ULSpEN:;
        var $v_0 = 1;
        var $v_1 = window.event;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_1) && $v_1.keyCode === 40) {
            $v_0 = 10;
        }
        if (CUI.Controls.ColorPicker.$7_1 + $v_0 < 0) {
            CUI.Controls.ColorPicker.$7_1 = -1;
            $v_0 = 1;
        }
        if (CUI.Controls.ColorPicker.$7_1 + $v_0 < this.$2T_1.length) {
            this.$7n_1(CUI.Controls.ColorPicker.$7_1 + $v_0);
            return true;
        }
        this.$5z_1();
        CUI.Controls.ColorPicker.$7_1 -= this.$2T_1.length;
        return false;
    }
}


CUI.Controls.ComboBoxCommandProperties = function() {
}


CUI.Controls.ComboBox = function(root, id, properties, menu) {ULSpEN:;
    this.$82 = Function.createDelegate(this, this.executeAutoComplete);
    this.$8N = Function.createDelegate(this, this.onInputKeyDown);
    this.$8L = Function.createDelegate(this, this.onInputBlur);
    this.$8M = Function.createDelegate(this, this.onInputFocus);
    this.$5E_3 = 100;
    this.$3l_3 = -1;
    CUI.Controls.ComboBox.initializeBase(this, [ root, id, properties, menu ]);
    if (CUI.ScriptUtility.isNullOrUndefined(this.get_cbProperties().AllowFreeForm)) {
        this.$68_3 = false;
    }
    else {
        this.$68_3 = this.get_cbProperties().AllowFreeForm.toLowerCase() === 'true';
    }
    if (CUI.ScriptUtility.isNullOrEmptyString(this.get_cbProperties().AutoComplete)) {
        this.get_cbProperties().AutoComplete = 'true';
    }
    if (!CUI.ScriptUtility.isNullOrEmptyString(this.get_cbProperties().AutoCompleteDelay)) {
        try {
            this.$5E_3 = parseInt(this.get_cbProperties().AutoCompleteDelay);
        }
        catch ($$e_2_0) {
            this.$5E_3 = 100;
        }
    }
}
CUI.Controls.ComboBox.prototype = {
    $8_3: null,
    $J_3: null,
    $I_3: null,
    $1x_3: null,
    $1y_3: null,
    $68_3: false,
    
    createDOMElementForDisplayMode: function($p0) {
        switch ($p0) {
            case 'Medium':
                var $v_0 = (CUI.ScriptUtility.isNullOrUndefined(this.get_cbProperties().Alt)) ? '' : this.get_cbProperties().Alt;
                var $v_1 = (CUI.ScriptUtility.isNullOrUndefined(this.get_cbProperties().AltArrow)) ? $v_0 : this.get_cbProperties().AltArrow;
                this.$8_3 = CUI.Utility.$3('span');
                this.$8_3.className = 'ms-cui-cb';
                this.$8_3.setAttribute('mscui:controltype', this.get_$15());
                this.$J_3 = CUI.Utility.$7A('input');
                this.$J_3.setAttribute('name', this.get_cbProperties().Command);
                this.$J_3.type = 'text';
                this.$J_3.style.width = this.get_cbProperties().Width;
                this.$J_3.className = 'ms-cui-cb-input';
                this.$J_3.setAttribute('autocomplete', 'off');
                this.$J_3.id = this.get_cbProperties().Id;
                if (CUI.ScriptUtility.isNullOrUndefined(this.get_properties().ToolTipTitle)) {
                    this.$J_3.title = $v_0;
                }
                CUI.Utility.$7p(this.$J_3, (this.get_properties()).ImeEnabled);
                var $v_2 = this.get_stateProperties()[CUI.Controls.ComboBoxCommandProperties.SelectedItemId];
                if (CUI.ScriptUtility.isNullOrUndefined($v_2)) {
                    $v_2 = this.get_cbProperties().InitialItem;
                }
                if (!CUI.ScriptUtility.isNullOrUndefined($v_2)) {
                    this.$2R($v_2);
                }
                CUI.Utility.$1i(this.get_properties(), this.$J_3);
                this.$I_3 = CUI.Utility.$3('a');
                CUI.Utility.ensureCSSClassOnElement(this.$I_3, 'ms-cui-dd-arrow-button');
                CUI.Utility.$1s(this.$I_3);
                this.$I_3.tabIndex = -1;
                this.$I_3.setAttribute('aria-haspopup', true);
                this.$1x_3 = CUI.Utility.$3('img');
                this.$1y_3 = CUI.Utility.$j(2, 1, this.$0_0.$5_1.ImageDownArrow, this.$0_0.$5_1.ImageDownArrowClass, this.$1x_3, true, false, this.$0_0.$5_1.ImageDownArrowTop, this.$0_0.$5_1.ImageDownArrowLeft);
                if (CUI.ScriptUtility.isNullOrUndefined(this.get_properties().ToolTipTitle)) {
                    this.$1x_3.alt = $v_1;
                    this.$I_3.title = $v_1;
                }
                this.$O('Medium');
                this.$8_3.appendChild(this.$J_3);
                this.$8_3.appendChild(this.$I_3);
                this.$I_3.appendChild(this.$1y_3);
                return this.$8_3;
            default:
                this.ensureValidDisplayMode($p0);
                return null;
        }
    },
    
    $35: function($p0) {
        var $v_0 = $get(this.$6_0 + '-' + $p0);
        this.storeElementForDisplayMode($v_0, $p0);
        this.get_stateProperties()[CUI.Controls.DropDownCommandProperties.SelectedItemId] = null;
        switch ($p0) {
            case 'Medium':
                this.$8_3 = $v_0;
                this.$J_3 = $v_0.childNodes[0];
                this.$I_3 = $v_0.childNodes[1];
                this.$1y_3 = this.$I_3.childNodes[0];
                this.$1x_3 = this.$1y_3.childNodes[0];
                CUI.Utility.$29(this.$J_3, false, false);
                break;
        }
    },
    
    $O: function($p0) {
        switch ($p0) {
            case 'Medium':
                this.$N_3();
                break;
        }
    },
    
    $N_3: function() {ULSpEN:;
        $addHandler(this.$J_3, 'focus', this.$8M);
        $addHandler(this.$J_3, 'blur', this.$8L);
        $addHandler(this.$J_3, 'keydown', this.$8N);
        $addHandler(this.$J_3, 'mouseup', CUI.Utility.get_returnFalseHandler());
        $addHandler(this.$I_3, 'mouseover', this.$2l);
        $addHandler(this.$I_3, 'mouseout', this.$1j);
        $addHandler(this.$I_3, 'click', this.$3F);
        $addHandler(this.$I_3, 'focus', this.$2l);
        $addHandler(this.$I_3, 'blur', this.$1j);
        $addHandler(this.$I_3, 'keypress', this.$3G);
    },
    
    onEnabledChanged: function($p0) {
        if ($p0) {
            CUI.Utility.enableElement(this.$J_3);
            CUI.Utility.enableElement(this.$8_3);
        }
        else {
            CUI.Utility.disableElement(this.$J_3);
            CUI.Utility.disableElement(this.$8_3);
        }
        CUI.Controls.ComboBox.callBaseMethod(this, 'onEnabledChanged', [ $p0 ]);
    },
    
    get_$15: function() {ULSpEN:;
        return 'ComboBox';
    },
    
    get_$1e: function() {ULSpEN:;
        return 'combobox';
    },
    
    $3j_3: null,
    
    get_menuItems: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$3j_3)) {
            this.$3j_3 = {};
        }
        return this.$3j_3;
    },
    set_menuItems: function($p0) {
        this.$3j_3 = $p0;
        return $p0;
    },
    
    getFirstMenuItemThatBeginsWith: function($p0) {
        var $$dict_1_0 = this.$3j_3;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_0 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            if ($v_0.key.toLowerCase().startsWith($p0.toLowerCase())) {
                return $v_0;
            }
        }
        return null;
    },
    
    $5c_3: null,
    
    onInputKeyDown: function($p0) {
        this.clearPendingAutoComplete();
        var $v_0 = this.$J_3.value;
        this.$X();
        if ($p0 && $p0.rawEvent) {
            if ($p0.rawEvent.keyCode === 40 && $p0.altKey) {
                this.launchMenuInternal();
                return;
            }
        }
        if (CUI.ScriptUtility.isNullOrEmptyString($v_0)) {
            return;
        }
        if ($p0 && $p0.rawEvent) {
            var $v_1 = $p0.rawEvent.keyCode;
            switch ($v_1) {
                case 13:
                    this.clearPendingAutoComplete();
                    $p0.preventDefault();
                    this.validateAndSave();
                    return;
                case 27:
                    this.clearPendingAutoComplete();
                    if (!this.$i_1) {
                        this.resetToPreviousValue();
                    }
                    return;
                case 38:
                    break;
                case 40:
                    if ($p0.altKey) {
                        this.launchMenuInternal();
                        return;
                    }
                    else {
                    }
                    break;
                case 8:
                case 127:
                case 46:
                    this.clearPendingAutoComplete();
                    this.$5c_3 = null;
                    return;
                case 36:
                case 35:
                case 33:
                case 34:
                case 37:
                case 39:
                case 16:
                case 18:
                case 17:
                case 20:
                    return;
            }
        }
        if (CUI.Utility.$v(this.get_cbProperties().AutoComplete)) {
            this.clearPendingAutoComplete();
            this.$3l_3 = window.setTimeout(this.$82, this.$5E_3);
        }
    },
    
    executeAutoComplete: function() {ULSpEN:;
        this.$3l_3 = -1;
        var $v_0 = this.$J_3.value;
        var $v_1 = this.getFirstMenuItemThatBeginsWith($v_0);
        if (!$v_1) {
            this.$5c_3 = null;
            return;
        }
        this.$J_3.value = $v_1.key;
        if (Sys.Browser.agent === Sys.Browser.InternetExplorer) {
            var $v_2 = this.$J_3.createTextRange();
            $v_2.moveStart('character', $v_0.length);
            $v_2.moveEnd('character', this.$J_3.value.length);
            $v_2.select();
        }
        else {
            this.$J_3.setSelectionRange($v_0.length, this.$J_3.value.length);
        }
        this.$5c_3 = $v_1.value;
    },
    
    clearPendingAutoComplete: function() {ULSpEN:;
        if (this.$3l_3 !== -1) {
            window.clearTimeout(this.$3l_3);
        }
        this.$3l_3 = -1;
    },
    
    $7o: function() {ULSpEN:;
        if (!this.get_enabled()) {
            return false;
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$J_3)) {
            this.$J_3.focus();
            return true;
        }
        return false;
    },
    
    onInputFocus: function($p0) {
        this.$0_0.set_$o(this);
        this.onArrowButtonFocus($p0);
        if (CUI.Utility.$v(this.get_cbProperties().PopulateDynamically)) {
            this.pollForDynamicMenu(false);
        }
        CUI.Utility.$7i(this.$J_3);
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$B_1)) {
            this.$B_1.$L();
        }
    },
    
    onInputBlur: function($p0) {
        this.clearPendingAutoComplete();
        this.onArrowButtonBlur($p0);
    },
    
    get_$5s_3: function() {ULSpEN:;
        return this.get_stateProperties()[CUI.Controls.ComboBoxCommandProperties.IsFreeForm];
    },
    set_$5s_3: function($p0) {
        this.get_stateProperties()[CUI.Controls.ComboBoxCommandProperties.IsFreeForm] = $p0;
        return $p0;
    },
    
    validateAndSave: function() {ULSpEN:;
        if (!this.$2R(this.$5c_3)) {
            var $v_0 = this.get_displayedComponent();
            if (!CUI.Utility.$v(this.get_cbProperties().AutoComplete)) {
                var $v_1 = this.$3j_3[this.$J_3.value];
                if (!CUI.ScriptUtility.isNullOrEmptyString($v_1) && this.$2R($v_1)) {
                    this.set_$5s_3(false);
                    $v_0.raiseCommandEvent(this.get_cbProperties().Command, 3, { IsFreeForm: false, CommandValueId: this._selectedControl.getCommandValueId() });
                    return;
                }
            }
            if (this.$68_3) {
                this.set_$5s_3(true);
                this.get_stateProperties()[CUI.Controls.ComboBoxCommandProperties.Value] = this.$J_3.value;
                $v_0.raiseCommandEvent(this.get_cbProperties().Command, 3, { IsFreeForm: true, Value: this.$J_3.value });
            }
            else {
                this.resetToPreviousValue();
                return;
            }
        }
        else {
            this.set_$5s_3(false);
            this.get_displayedComponent().raiseCommandEvent(this.get_cbProperties().Command, 3, { IsFreeForm: false, CommandValueId: this._selectedControl.getCommandValueId() });
        }
    },
    
    resetToPreviousValue: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this._selectedControl)) {
            this.$J_3.value = (this._selectedControl).getTextValue();
        }
        else {
            this.$J_3.value = '';
        }
    },
    
    selectMenuItem: function($p0) {
        if (this._selectedControl === $p0) {
            return;
        }
        this._selectedControl = $p0;
        this.get_stateProperties()[CUI.Controls.ComboBoxCommandProperties.SelectedItemId] = $p0.getMenuItemId();
        var $v_0 = $p0;
        this.$J_3.value = $v_0.getTextValue();
    },
    
    $4y: function() {ULSpEN:;
        var $v_0 = this.get_stateProperties()[CUI.Controls.ComboBoxCommandProperties.SelectedItemId];
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            this.get_stateProperties()[CUI.Controls.ComboBoxCommandProperties.SelectedItemId] = this.get_cbProperties().InitialItem;
        }
        var $v_1 = this.pollForStateAndUpdateInternal(this.get_cbProperties().Command, this.get_cbProperties().QueryCommand, this.get_stateProperties(), false);
        var $v_2 = this.get_stateProperties()[CUI.Controls.ComboBoxCommandProperties.SelectedItemId];
        if ($v_1) {
            if (this.get_$5s_3()) {
                this.$J_3.value = this.get_stateProperties()[CUI.Controls.ComboBoxCommandProperties.Value];
                this.get_stateProperties()[CUI.Controls.ComboBoxCommandProperties.SelectedItemId] = null;
            }
            else {
                if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
                    if ($v_0 !== $v_2 || !this._itemEverSelected) {
                        if (!this.$2R($v_2)) {
                            throw Error.create('The menu item id requested via polling does not exist');
                        }
                    }
                }
                else {
                    if (!CUI.ScriptUtility.isNullOrUndefined(this.get_stateProperties()[CUI.Controls.ComboBoxCommandProperties.Value])) {
                        this.$J_3.value = this.get_stateProperties()[CUI.Controls.ComboBoxCommandProperties.Value];
                    }
                }
            }
        }
    },
    
    onDynamicMenuPopulated: function() {ULSpEN:;
        var $v_0 = null;
        var $v_1 = null;
        var $v_2 = null;
        var $v_3 = null;
        var $v_4 = null;
        var $v_5 = null;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$B_1)) {
            return;
        }
        var $$enum_1_0 = this.$B_1.$4_0.getEnumerator();
        while ($$enum_1_0.moveNext()) {
            var $v_6 = $$enum_1_0.get_current();
            var $$enum_3_0 = $v_6.$4_0.getEnumerator();
            while ($$enum_3_0.moveNext()) {
                var $v_7 = $$enum_3_0.get_current();
                if (CUI.MenuItem.isInstanceOfType($v_7)) {
                    $v_0 = $v_7;
                    $v_1 = $v_0.$M_1;
                    if (CUI.ISelectableControl.isInstanceOfType($v_1)) {
                        $v_2 = $v_1;
                        $v_4 = $v_2.getMenuItemId();
                    }
                    if (CUI.IMenuItem.isInstanceOfType($v_1)) {
                        $v_3 = $v_1;
                        $v_5 = $v_3.getTextValue();
                    }
                    if (!(CUI.ScriptUtility.isNullOrUndefined($v_4) || CUI.ScriptUtility.isNullOrUndefined($v_5))) {
                        this.get_menuItems()[$v_5] = $v_4;
                        $v_5 = null;
                        $v_4 = null;
                    }
                }
            }
        }
    },
    
    launchMenuInternal: function() {ULSpEN:;
        if (this.launchMenu(this.$J_3, this.$3M)) {
            this.sendMenuCreationCommandEvent();
        }
    },
    
    dispose: function() {ULSpEN:;
        CUI.Controls.ComboBox.callBaseMethod(this, 'dispose');
        this.$8_3 = null;
        this.$1x_3 = null;
        this.$1y_3 = null;
        this.$I_3 = null;
        this.$J_3 = null;
    },
    
    get_cbProperties: function() {ULSpEN:;
        return this.$5_0;
    }
}


CUI.Controls.DropDownCommandProperties = function() {
}


CUI.Controls.DropDown = function(root, id, properties, menu) {ULSpEN:;
    this.$47 = Function.createDelegate(this, this.onArrowButtonKeyboardFocus);
    this.$3M = Function.createDelegate(this, this.sendMenuCreationCommandEvent);
    this.$3G = Function.createDelegate(this, this.onArrowButtonKeyPress);
    this.$3F = Function.createDelegate(this, this.onArrowButtonClick);
    this.$1j = Function.createDelegate(this, this.onArrowButtonBlur);
    this.$2l = Function.createDelegate(this, this.onArrowButtonFocus);
    CUI.Controls.DropDown.initializeBase(this, [ root, id, properties, menu ]);
    this.addDisplayModes();
    this.get_stateProperties()[CUI.Controls.DropDownCommandProperties.SelectedItemId] = null;
    this.get_stateProperties()[CUI.Controls.DropDownCommandProperties.Value] = null;
}
CUI.Controls.DropDown.prototype = {
    $8_2: null,
    $Y_2: null,
    $I_2: null,
    $1x_2: null,
    $1y_2: null,
    
    $7o: function() {ULSpEN:;
        if (!this.get_enabled()) {
            return false;
        }
        this.$I_2.focus();
        return true;
    },
    
    createDOMElementForDisplayMode: function($p0) {
        var $v_0 = (CUI.ScriptUtility.isNullOrUndefined(this.get_properties().Alt)) ? '' : this.get_properties().Alt;
        var $v_1 = (CUI.ScriptUtility.isNullOrUndefined(this.get_properties().AltArrow)) ? $v_0 : this.get_properties().AltArrow;
        var $v_2 = true;
        if (CUI.ScriptUtility.isNullOrEmptyString($v_1) && !CUI.ScriptUtility.isNullOrUndefined(this.get_properties().ToolTipTitle)) {
            $v_1 = this.get_properties().ToolTipTitle;
        }
        var $v_3 = null;
        switch ($p0) {
            case 'Text':
            case 'Medium':
                this.$8_2 = CUI.Utility.$3('span');
                this.$8_2.className = 'ms-cui-dd';
                this.$8_2.setAttribute('mscui:controltype', this.get_$15());
                this.$Y_2 = CUI.Utility.$3('span');
                this.$Y_2.className = 'ms-cui-dd-text';
                this.$Y_2.style.width = this.get_properties().Width;
                var $v_4 = this.get_stateProperties()[CUI.Controls.DropDownCommandProperties.SelectedItemId];
                if (CUI.ScriptUtility.isNullOrUndefined($v_4)) {
                    $v_4 = this.get_properties().InitialItem;
                }
                if (!CUI.ScriptUtility.isNullOrUndefined($v_4)) {
                    this.$2R($v_4);
                }
                this.$I_2 = CUI.Utility.$3('a');
                this.$I_2.setAttribute('role', this.get_$1e());
                this.$I_2.setAttribute('aria-haspopup', true);
                CUI.Utility.ensureCSSClassOnElement(this.$I_2, 'ms-cui-dd-arrow-button');
                CUI.Utility.$1i(this.get_properties(), this.$I_2);
                CUI.Utility.$1s(this.$I_2);
                this.$I_2.id = this.$6_0;
                this.$1x_2 = CUI.Utility.$3('img');
                this.$1y_2 = CUI.Utility.$j(2, 1, this.$0_0.$5_1.ImageDownArrow, this.$0_0.$5_1.ImageDownArrowClass, this.$1x_2, true, false, this.$0_0.$5_1.ImageDownArrowTop, this.$0_0.$5_1.ImageDownArrowLeft);
                if (CUI.ScriptUtility.isNullOrUndefined(this.get_properties().ToolTipTitle)) {
                    this.$I_2.setAttribute('title', $v_1);
                    this.$Y_2.title = $v_0;
                    this.$1x_2.alt = $v_1;
                    $v_2 = false;
                }
                this.$O('Medium');
                this.$8_2.appendChild(this.$Y_2);
                this.$8_2.appendChild(this.$I_2);
                this.$I_2.appendChild(this.$1y_2);
                if ($v_2) {
                    $v_3 = CUI.Utility.$2h($v_1);
                    this.$I_2.appendChild($v_3);
                }
                return this.$8_2;
            default:
                this.ensureValidDisplayMode($p0);
                return null;
        }
    },
    
    $35: function($p0) {
        var $v_0 = $get(this.$6_0 + '-' + $p0);
        this.storeElementForDisplayMode($v_0, $p0);
        switch ($p0) {
            case 'Text':
            case 'Medium':
                this.$8_2 = $v_0;
                this.$Y_2 = $v_0.childNodes[0];
                this.$I_2 = $v_0.childNodes[1];
                this.$1y_2 = this.$I_2.childNodes[0];
                this.$1x_2 = this.$1y_2.childNodes[0];
                break;
        }
    },
    
    $O: function($p0) {
        switch ($p0) {
            case 'Text':
            case 'Medium':
                this.$N_2();
                break;
        }
    },
    
    $N_2: function() {ULSpEN:;
        $addHandler(this.$8_2, 'click', this.$3F);
        $addHandler(this.$8_2, 'keypress', this.$3G);
        $addHandler(this.$I_2, 'mouseover', this.$2l);
        $addHandler(this.$I_2, 'mouseout', this.$1j);
        $addHandler(this.$I_2, 'focus', this.$47);
        $addHandler(this.$I_2, 'blur', this.$1j);
    },
    
    onEnabledChanged: function($p0) {
        if ($p0) {
            CUI.Utility.enableElement(this.$8_2);
        }
        else {
            CUI.Utility.disableElement(this.$8_2);
        }
    },
    
    get_$15: function() {ULSpEN:;
        return 'DropDown';
    },
    
    $1g: function($p0) {
        if ($p0.$G_1 === 3) {
            var $v_0 = $p0.$31_1;
            if (!(CUI.ISelectableControl.isInstanceOfType($v_0.$M_1))) {
                return CUI.Controls.DropDown.callBaseMethod(this, '$1g', [ $p0 ]);
            }
            var $v_1 = $v_0.$M_1;
            if (!CUI.ScriptUtility.isNullOrUndefined(this._selectedControl)) {
                this._selectedControl.deselect();
            }
            this.selectMenuItem($v_1);
        }
        if ($p0.$G_1 === 3 || $p0.$G_1 === 7 || $p0.$G_1 === 8) {
            var $v_2;
            switch ($p0.$G_1) {
                case 3:
                    $v_2 = this.get_properties().Command;
                    break;
                case 7:
                    $v_2 = this.get_properties().CommandPreview;
                    break;
                case 8:
                    $v_2 = this.get_properties().CommandRevert;
                    break;
                default:
                    $v_2 = this.get_properties().Command;
                    break;
            }
            this.get_displayedComponent().raiseCommandEvent($v_2, $p0.$G_1, $p0.$2z_1);
            CUI.Controls.DropDown.callBaseMethod(this, '$1g', [ $p0 ]);
            return false;
        }
        return CUI.Controls.DropDown.callBaseMethod(this, '$1g', [ $p0 ]);
    },
    
    selectMenuItem: function($p0) {
        if (this._selectedControl === $p0) {
            return;
        }
        this._selectedControl = $p0;
        this.get_stateProperties()[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $p0.getMenuItemId();
        var $v_0;
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_properties().SelectedItemDisplayMode)) {
            $v_0 = 'Text';
        }
        else {
            $v_0 = this.get_properties().SelectedItemDisplayMode;
        }
        var $v_1;
        if ($v_0 === 'Text') {
            var $v_2 = $p0.getTextValue();
            $v_1 = CUI.Utility.$3('a');
            CUI.UIUtility.setInnerText($v_1, $v_2);
        }
        else {
            $v_1 = this._selectedControl.getDropDownDOMElementForDisplayMode($v_0);
        }
        if (this.$Y_2.hasChildNodes()) {
            var $v_3 = this.$Y_2.firstChild;
            this.$Y_2.replaceChild($v_1, $v_3);
        }
        else {
            this.$Y_2.appendChild($v_1);
        }
    },
    
    _itemEverSelected: false,
    
    $2R: function($p0) {
        if (CUI.ScriptUtility.isNullOrUndefined($p0) || CUI.ScriptUtility.isNullOrUndefined(this.$B_1)) {
            return false;
        }
        var $v_0 = this.$B_1.$AR($p0);
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return false;
        }
        this.selectMenuItem($v_0);
        this._itemEverSelected = true;
        return true;
    },
    
    addDisplayModes: function() {ULSpEN:;
        this.addDisplayMode('Medium');
        this.addDisplayMode('Text');
    },
    
    onArrowButtonClick: function($p0) {
        var $v_0 = this.get_enabled();
        if ($v_0) {
            CUI.PMetrics.perfMark(7192);
        }
        this.$X();
        $p0.preventDefault();
        if (!$v_0) {
            return;
        }
        this.$0_0.set_$o(this);
        this.launchMenuInternal($p0);
        CUI.PMetrics.perfMark(7193);
    },
    
    launchMenuInternal: function($p0) {
        if (this.launchMenu(this.$I_2, this.$3M)) {
            this.sendMenuCreationCommandEvent();
        }
    },
    
    sendMenuCreationCommandEvent: function() {ULSpEN:;
        this.get_displayedComponent().raiseCommandEvent(this.get_properties().CommandMenuOpen, 4, null);
    },
    
    onBeginFocus: function() {ULSpEN:;
        var $v_0 = this.get_stateProperties()[CUI.Controls.DropDownCommandProperties.Value];
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            var $v_1 = this.get_stateProperties()[CUI.Controls.DropDownCommandProperties.SelectedItemId];
            if (CUI.ScriptUtility.isNullOrUndefined($v_1)) {
                $v_1 = this.get_properties().InitialItem;
            }
            if ((!CUI.ScriptUtility.isNullOrUndefined($v_1)) && (!CUI.ScriptUtility.isNullOrUndefined(this.$B_1))) {
                var $v_2 = this.$B_1.$AR($v_1);
                if (!CUI.ScriptUtility.isNullOrUndefined($v_2)) {
                    $v_0 = $v_2.getTextValue();
                }
            }
        }
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            this.get_properties().ToolTipSelectedItemTitle = $v_0;
        }
        CUI.Controls.DropDown.callBaseMethod(this, 'onBeginFocus');
    },
    
    onArrowButtonKeyboardFocus: function($p0) {
        this.$0_0.set_$o(this);
        this.onArrowButtonFocus($p0);
    },
    
    onArrowButtonFocus: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled()) {
            return;
        }
        this.highlight();
    },
    
    onArrowButtonBlur: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled() || this.$i_1) {
            return;
        }
        this.removeHighlight();
    },
    
    onArrowButtonKeyPress: function($p0) {
        this.$X();
        if (!this.get_enabled()) {
            return;
        }
        var $v_0 = $p0.rawEvent.keyCode;
        if ($v_0 === 13 || $v_0 === 32 || $v_0 === 40) {
            this.$1E_1 = true;
            this.launchMenuInternal($p0);
        }
    },
    
    highlight: function() {ULSpEN:;
        CUI.Utility.ensureCSSClassOnElement(this.$I_2, 'ms-cui-ctl-light-hoveredOver');
    },
    
    removeHighlight: function() {ULSpEN:;
        CUI.Utility.removeCSSClassFromElement(this.$I_2, 'ms-cui-ctl-light-hoveredOver');
    },
    
    onLaunchedMenuClosed: function() {ULSpEN:;
        this.$X();
        this.removeHighlight();
        this.get_displayedComponent().raiseCommandEvent(this.get_properties().CommandMenuClose, 10, null);
        CUI.Controls.DropDown.callBaseMethod(this, 'onLaunchedMenuClosed');
    },
    
    $4y: function() {ULSpEN:;
        var $v_0 = this.get_stateProperties()[CUI.Controls.DropDownCommandProperties.SelectedItemId];
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            this.get_stateProperties()[CUI.Controls.DropDownCommandProperties.SelectedItemId] = this.get_properties().InitialItem;
        }
        this.pollForStateAndUpdateInternal(this.get_properties().Command, this.get_properties().QueryCommand, this.get_stateProperties(), false);
        var $v_1 = this.get_stateProperties()[CUI.Controls.DropDownCommandProperties.SelectedItemId];
        if (!CUI.ScriptUtility.isNullOrUndefined($v_1)) {
            if ($v_0 !== $v_1 || !this._itemEverSelected) {
                if (!this.$2R($v_1)) {
                    throw Error.create('The menu item id requested via polling does not exist');
                }
            }
        }
        else {
            if (!CUI.ScriptUtility.isNullOrUndefined(this.get_stateProperties()[CUI.Controls.DropDownCommandProperties.Value])) {
                var $v_2 = this.get_stateProperties()[CUI.Controls.DropDownCommandProperties.Value];
                this.$Y_2.innerHTML = '<a>' + CUI.Utility.$3A($v_2) + '</a>';
            }
        }
    },
    
    dispose: function() {ULSpEN:;
        CUI.Controls.DropDown.callBaseMethod(this, 'dispose');
        this.$8_2 = null;
        this.$1x_2 = null;
        this.$1y_2 = null;
        this.$I_2 = null;
        this.$Y_2 = null;
    },
    
    get_properties: function() {ULSpEN:;
        return this.$5_0;
    }
}


CUI.Controls.FlyoutAnchor = function(root, id, properties, menu) {ULSpEN:;
    this.$8d = Function.createDelegate(this, this.$DN_2);
    this.$8c = Function.createDelegate(this, this.$DM_2);
    this.$8e = Function.createDelegate(this, this.$DO_2);
    this.$7x = Function.createDelegate(this, this.$2e_2);
    this.$49 = Function.createDelegate(this, this.$5w_2);
    this.$4A = Function.createDelegate(this, this.$5x_2);
    this.$48 = Function.createDelegate(this, this.$42_2);
    this.$8n = Function.createDelegate(this, this.$DX_2);
    this.$8m = Function.createDelegate(this, this.$DW_2);
    this.$90 = Function.createDelegate(this, this.$De_2);
    this.$8T = Function.createDelegate(this, this.$Ar_2);
    this.$3I = Function.createDelegate(this, this.$4u_2);
    this.$1H = Function.createDelegate(this, this.onClick);
    CUI.Controls.FlyoutAnchor.initializeBase(this, [ root, id, properties, menu ]);
    this.addDisplayMode('Menu');
    this.addDisplayMode('Menu16');
    this.addDisplayMode('Menu32');
    this.addDisplayMode('Small');
    this.addDisplayMode('Medium');
    this.addDisplayMode('Large');
    this.addDisplayMode('Thin');
}
CUI.Controls.FlyoutAnchor.prototype = {
    $5R_2: null,
    $5S_2: null,
    $3a_2: null,
    $4P_2: null,
    $6P_2: null,
    $4Q_2: null,
    $6Q_2: null,
    $h_2: null,
    $T_2: null,
    $Z_2: null,
    $F_2: null,
    $9H_2: null,
    $1v_2: null,
    $8_2: null,
    $9J_2: null,
    $2E_2: null,
    $9_2: null,
    $9L_2: null,
    $2G_2: null,
    $1b_2: null,
    $3d_2: null,
    $4T_2: null,
    
    createDOMElementForDisplayMode: function($p0) {
        var $v_0 = (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_2().Alt)) ? this.get_$1_2().LabelText : this.get_$1_2().Alt;
        switch ($p0) {
            case 'Menu':
                this.$h_2 = this.createMenuDOMElement('Menu', 'ms-cui-textmenuitem ms-cui-fa-menuitem ms-cui-ctl-menu', $v_0, null, null, null, null);
                this.$O($p0);
                this.$h_2.setAttribute('aria-haspopup', true);
                return this.$h_2;
            case 'Menu16':
                this.$T_2 = this.createMenuDOMElement('Menu16', 'ms-cui-fa-menuitem ms-cui-ctl-menu', $v_0, this.get_$1_2().Image16by16, this.get_$1_2().Image16by16Class, this.get_$1_2().Image16by16Top, this.get_$1_2().Image16by16Left);
                this.$O($p0);
                this.$T_2.setAttribute('aria-haspopup', true);
                return this.$T_2;
            case 'Menu32':
                this.$Z_2 = this.createMenuDOMElement('Menu32', 'ms-cui-fa-menuitem ms-cui-ctl-menu', $v_0, this.get_$1_2().Image32by32, this.get_$1_2().Image32by32Class, this.get_$1_2().Image32by32Top, this.get_$1_2().Image32by32Left);
                this.$Z_2.setAttribute('aria-haspopup', true);
                this.$O($p0);
                return this.$Z_2;
            case 'Large':
                this.$F_2 = CUI.Control.createStandardControlDOMElement(this, this.$0_0, 'Large', this.get_$1_2(), false, true);
                this.$F_2.setAttribute('aria-haspopup', true);
                if (this.$6U_2) {
                    CUI.Utility.ensureCSSClassOnElement(this.$F_2, 'ms-cui-ctl-large-groupPopup');
                }
                this.$O('Large');
                return this.$F_2;
            case 'Medium':
                this.$8_2 = CUI.Control.createStandardControlDOMElement(this, this.$0_0, 'Medium', this.get_$1_2(), false, true);
                this.$O('Medium');
                this.$8_2.setAttribute('aria-haspopup', true);
                return this.$8_2;
            case 'Small':
                this.$9_2 = CUI.Control.createStandardControlDOMElement(this, this.$0_0, 'Small', this.get_$1_2(), false, true);
                this.$O('Small');
                this.$9_2.setAttribute('aria-haspopup', true);
                return this.$9_2;
            case 'Thin':
                this.$1b_2 = CUI.Utility.$4q();
                this.$1b_2.className = 'ms-cui-ctl-thin';
                this.$3d_2 = CUI.Utility.$3('img');
                this.$3d_2.alt = '';
                if (CUI.ScriptUtility.isNullOrEmptyString(this.get_$1_2().ToolTipTitle)) {
                    this.$1b_2.title = $v_0;
                    this.$3d_2.alt = $v_0;
                }
                var $v_1 = this.$0_0;
                this.$4T_2 = CUI.Utility.$j(2, 1, $v_1.$5_1.ImageDownArrow, $v_1.$5_1.ImageDownArrowClass, this.$3d_2, true, false, $v_1.$5_1.ImageDownArrowTop, $v_1.$5_1.ImageDownArrowLeft);
                this.$1b_2.appendChild(this.$4T_2);
                this.$O('Thin');
                this.$1b_2.setAttribute('aria-haspopup', true);
                return this.$1b_2;
            default:
                this.ensureValidDisplayMode($p0);
                break;
        }
        return null;
    },
    
    $35: function($p0) {
        var $v_0 = $get(this.$6_0 + '-' + $p0);
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            this.storeElementForDisplayMode($v_0, $p0);
        }
        switch ($p0) {
            case 'Large':
                if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
                    this.$F_2 = $v_0;
                }
                this.$9H_2 = this.$F_2.childNodes[0].childNodes[0];
                this.$1v_2 = this.$F_2.lastChild.lastChild.childNodes[0];
                break;
            case 'Medium':
                if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
                    this.$8_2 = $v_0;
                }
                this.$9J_2 = this.$8_2.childNodes[0].childNodes[0];
                this.$2E_2 = this.$8_2.lastChild.lastChild.childNodes[0];
                break;
            case 'Small':
                if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
                    this.$9_2 = $v_0;
                }
                this.$9L_2 = this.$9_2.childNodes[0].childNodes[0];
                this.$2G_2 = this.$9_2.lastChild.lastChild.childNodes[0];
                break;
            case 'Thin':
                this.$1b_2 = $v_0;
                this.$4T_2 = $v_0.firstChild;
                this.$3d_2 = this.$4T_2.firstChild;
                break;
        }
    },
    
    get_$15: function() {ULSpEN:;
        return 'FlyoutAnchor';
    },
    
    createMenuDOMElement: function($p0, $p1, $p2, $p3, $p4, $p5, $p6) {
        var $v_0 = CUI.Utility.$4q();
        $v_0.setAttribute('role', this.get_$1e());
        $v_0.className = $p1;
        $v_0.title = $p2;
        $v_0.setAttribute('mscui:controltype', this.get_$15());
        CUI.Utility.$1i(this.get_$1_2(), $v_0);
        var $v_1 = null;
        switch ($p0) {
            case 'Menu16':
                if (CUI.ScriptUtility.isNullOrUndefined(this.$4P_2)) {
                    this.$4P_2 = CUI.Utility.$3('img');
                    this.$6P_2 = CUI.Utility.$j(2, 3, $p3, $p4, this.$4P_2, true, true, $p5, $p6);
                    this.$4P_2.alt = $p2;
                    $v_1 = this.$6P_2;
                }
                break;
            case 'Menu32':
                if (CUI.ScriptUtility.isNullOrUndefined(this.$4Q_2)) {
                    this.$4Q_2 = CUI.Utility.$3('img');
                    this.$6Q_2 = CUI.Utility.$j(2, 4, $p3, $p4, this.$4Q_2, true, true, $p5, $p6);
                    this.$4Q_2.alt = $p2;
                    $v_1 = this.$6Q_2;
                }
                break;
        }
        this.createMenuLabelDOMElementIfNeeded($p0);
        if (CUI.ScriptUtility.isNullOrUndefined(this.$5R_2)) {
            this.$5R_2 = CUI.Utility.$3('img');
            this.$5S_2 = CUI.Utility.$j(2, 2, this.$0_0.$5_1.ImageSideArrow, this.$0_0.$5_1.ImageSideArrowClass, this.$5R_2, false, true, this.$0_0.$5_1.ImageSideArrowTop, this.$0_0.$5_1.ImageSideArrowLeft);
            CUI.Utility.ensureCSSClassOnElement(this.$5S_2, 'ms-cui-fa-menu-arrow');
        }
        if ($v_1) {
            var $v_2 = CUI.Utility.$3('span');
            $v_2.className = 'ms-cui-ctl-iconContainer';
            $v_2.appendChild($v_1);
            $v_0.appendChild($v_2);
        }
        $v_0.appendChild(this.$3a_2);
        $v_0.appendChild(this.$5S_2);
        return $v_0;
    },
    
    createMenuLabelDOMElementIfNeeded: function($p0) {
        if (CUI.ScriptUtility.isNullOrUndefined(this.$3a_2)) {
            this.$3a_2 = CUI.Utility.$3('span');
            this.$3a_2.className = 'ms-cui-ctl-mediumlabel';
            CUI.UIUtility.setInnerText(this.$3a_2, this.get_$1_2().LabelText);
        }
    },
    
    $O: function($p0) {
        var $v_0 = this.getDisplayedDOMElement($p0);
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return;
        }
        var $v_1 = { click: this.$1H, blur: this.$3I, keypress: this.$8T, focus: this.$90 };
        var $v_2;
        if (Sys.Browser.agent === Sys.Browser.InternetExplorer) {
            if ($p0.startsWith('Menu')) {
                $v_2 = { mouseenter: this.$8m, mouseleave: this.$8n };
            }
            else {
                $v_2 = { mouseenter: this.$48, mouseleave: this.$3I };
            }
        }
        else {
            if ($p0.startsWith('Menu')) {
                $v_2 = { mouseover: this.$4A, mouseout: this.$49 };
            }
            else {
                $v_2 = { mouseover: this.$48, mouseout: this.$3I };
            }
        }
        $addHandlers($v_0, $v_1);
        $addHandlers($v_0, $v_2);
    },
    
    onEnabledChanged: function($p0) {
        CUI.Utility.setEnabledOnElement(this.$h_2, $p0);
        CUI.Utility.setEnabledOnElement(this.$T_2, $p0);
        CUI.Utility.setEnabledOnElement(this.$Z_2, $p0);
        CUI.Utility.setEnabledOnElement(this.$F_2, $p0);
        CUI.Utility.setEnabledOnElement(this.$8_2, $p0);
        CUI.Utility.setEnabledOnElement(this.$9_2, $p0);
        CUI.Utility.setEnabledOnElement(this.$1b_2, $p0);
    },
    
    positionMenu: function($p0, $p1) {
        if (this.get_displayedComponent().get_displayMode().startsWith('Menu')) {
            this.$0_0.$Do($p0, $p1);
        }
        else {
            CUI.Controls.FlyoutAnchor.callBaseMethod(this, 'positionMenu', [ $p0, $p1 ]);
        }
    },
    
    createComponentForDisplayModeInternal: function($p0) {
        var $v_0;
        if ($p0.startsWith('Menu')) {
            $v_0 = this.$0_0.$3w(this.$6_0 + '-' + $p0 + this.$0_0.$27(), $p0, this);
        }
        else {
            $v_0 = CUI.Controls.FlyoutAnchor.callBaseMethod(this, 'createComponentForDisplayModeInternal', [ $p0 ]);
        }
        return $v_0;
    },
    
    getDisplayedDOMElement: function($p0) {
        switch ($p0) {
            case 'Menu':
                return this.$h_2;
            case 'Menu16':
                return this.$T_2;
            case 'Menu32':
                return this.$Z_2;
            case 'Large':
                return this.$F_2;
            case 'Medium':
                return this.$8_2;
            case 'Small':
                return this.$9_2;
            case 'Thin':
                return this.$1b_2;
            default:
                this.ensureValidDisplayMode($p0);
                return null;
        }
    },
    
    onClick: function($p0) {
        var $v_0 = this.get_enabled();
        if ($v_0 && !this.$i_1) {
            CUI.PMetrics.perfMark(7190);
        }
        this.$X();
        $p0.preventDefault();
        if (!$v_0 || this.$i_1) {
            return;
        }
        this.$0_0.set_$3z(this);
        var $v_1 = this.get_displayedComponent();
        var $v_2 = $v_1.get_$2();
        this.$5t_2($v_2);
        if (!CUI.ScriptUtility.isNullOrUndefined(this.get_$1_2().Command)) {
            $v_1.raiseCommandEvent(this.get_$1_2().Command, 4, null);
        }
        CUI.PMetrics.perfMark(7191);
    },
    
    $42_2: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled()) {
            return;
        }
    },
    
    $DW_2: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled() || this.$i_1) {
            return;
        }
        var $v_0 = this.get_displayedComponent();
        var $v_1 = $v_0.get_$2();
        this.$5t_2($v_1);
        var $v_2 = this.get_$1_2().Command;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_2)) {
            $v_0.raiseCommandEvent($v_2, 4, null);
        }
    },
    
    $5x_2: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled() || this.$i_1) {
            return;
        }
        var $v_0 = $p0.target;
        var $v_1 = $p0.rawEvent.relatedTarget;
        if (!($v_0 === this.$h_2 || $v_0 === this.$T_2 || $v_0 === this.$Z_2)) {
            return;
        }
        while ($v_1 !== $v_0) {
            try {
                if ($v_1.nodeName.toLowerCase() === 'body') {
                    break;
                }
            }
            catch ($$e_2_0) {
                break;
            }
            $v_1 = $v_1.parentNode;
        }
        if ($v_1 === $v_0) {
            return;
        }
        var $v_2 = this.get_displayedComponent();
        var $v_3 = $v_2.get_$2();
        this.$5t_2($v_3);
        var $v_4 = this.get_$1_2().Command;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_4)) {
            $v_2.raiseCommandEvent($v_4, 4, null);
        }
    },
    
    $DO_2: function($p0) {
        var $v_0 = Array.indexOf(this.$0_0.$W_1, this);
        var $v_1 = this.$0_0.$2a_1;
        if ($v_1 !== -1 && $v_0 >= this.$0_0.$3m_1) {
            window.clearTimeout($v_1);
            this.$0_0.$2a_1 = -1;
            this.$0_0.$3m_1 = -1;
        }
    },
    
    $De_2: function($p0) {
        this.onBeginFocus();
        if (this.get_displayedComponent().get_displayMode().startsWith('Menu')) {
            this.$39_2(this.get_enabled());
        }
        if (this.get_enabled()) {
            this.$0_0.set_$o(this);
        }
    },
    
    $4u_2: function($p0) {
        this.onEndFocus();
        if (this.$i_1) {
            return;
        }
        this.$1U_2();
    },
    
    $DX_2: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled()) {
            return;
        }
        if (this.$i_1) {
            var $v_0 = Array.indexOf(this.$0_0.$W_1, this);
            for (var $v_1 = $v_0; $v_1 < this.$0_0.$W_1.length; $v_1++) {
                if (CUI.Utility.isDescendantOf((this.$0_0.$W_1[$v_1]).$B_1.get_$2(), $p0.rawEvent.toElement)) {
                    return;
                }
            }
            this.$62_2();
        }
    },
    
    $DM_2: function($p0) {
        this.onEndFocus();
        if (CUI.Utility.isDescendantOf(this.get_displayedComponent().get_$2(), $p0.rawEvent.toElement)) {
            return;
        }
        if (this.$i_1) {
            var $v_0 = Array.indexOf(this.$0_0.$W_1, this);
            for (var $v_1 = $v_0; $v_1 < this.$0_0.$W_1.length; $v_1++) {
                if (CUI.Utility.isDescendantOf((this.$0_0.$W_1[$v_1]).$B_1.get_$2(), $p0.rawEvent.toElement)) {
                    return;
                }
            }
            this.$62_2();
        }
    },
    
    $5w_2: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled() || CUI.Utility.isDescendantOf(this.get_displayedComponent().get_$2(), $p0.rawEvent.relatedTarget)) {
            return;
        }
        if (this.$i_1) {
            var $v_0 = Array.indexOf(this.$0_0.$W_1, this);
            for (var $v_1 = $v_0; $v_1 < this.$0_0.$W_1.length; $v_1++) {
                if (CUI.Utility.isDescendantOf((this.$0_0.$W_1[$v_1]).$B_1.get_$2(), $p0.rawEvent.relatedTarget)) {
                    return;
                }
            }
            this.$62_2();
        }
    },
    
    $DN_2: function($p0) {
        this.onEndFocus();
        if (CUI.Utility.isDescendantOf(this.get_displayedComponent().get_$2(), $p0.rawEvent.relatedTarget)) {
            return;
        }
        if (this.$i_1) {
            var $v_0 = Array.indexOf(this.$0_0.$W_1, this);
            for (var $v_1 = $v_0; $v_1 < this.$0_0.$W_1.length; $v_1++) {
                if (CUI.Utility.isDescendantOf((this.$0_0.$W_1[$v_1]).$B_1.get_$2(), $p0.rawEvent.relatedTarget)) {
                    return;
                }
            }
            this.$62_2();
        }
        this.$1U_2();
    },
    
    $Ar_2: function($p0) {
        this.$X();
        if (!this.get_enabled()) {
            return;
        }
        var $v_0 = $p0.rawEvent.keyCode;
        if (this.$i_1) {
            if ((!this.$0_0._textDirection && $v_0 === 39) || (this.$0_0._textDirection === 1 && $v_0 === 37)) {
                this.$B_1.$1r();
            }
        }
        else {
            if ($v_0 === 13 || $v_0 === 32 || (((!this.$0_0._textDirection && $v_0 === 39) || (this.$0_0._textDirection === 1 && $v_0 === 37)) && (!$p0.ctrlKey || !$p0.shiftKey))) {
                this.$1E_1 = true;
                var $v_1 = this.get_displayedComponent();
                var $v_2 = $v_1.get_$2();
                var $v_3 = this.get_$1_2().Command;
                if (!CUI.ScriptUtility.isNullOrUndefined($v_3)) {
                    $v_1.raiseCommandEvent($v_3, 4, null);
                }
                this.$5t_2($v_2);
            }
        }
    },
    
    $6S_2: false,
    
    onModalKeyPress: function($p0) {
        if ($p0) {
            if ($p0.rawEvent) {
                if ((((!this.$0_0._textDirection && $p0.rawEvent.keyCode === 37) || (this.$0_0._textDirection === 1 && $p0.rawEvent.keyCode === 39)) && this.get_displayedComponent().get_displayMode().startsWith('Menu')) || $p0.rawEvent.keyCode === 27) {
                    this.$0_0.$2e(this);
                    return;
                }
            }
        }
        if (this.$6U_2) {
            if (this.$6S_2) {
                return;
            }
            if (this.$B_1.$50()) {
                this.$6S_2 = true;
            }
            $p0.preventDefault();
        }
        else {
            CUI.Controls.FlyoutAnchor.callBaseMethod(this, 'onModalKeyPress', [ $p0 ]);
        }
    },
    
    onModalBodyClick: function($p0) {
        this.$0_0.$4n();
    },
    
    onLaunchedMenuClosed: function() {ULSpEN:;
        var $v_0 = this.$0_0.$2a_1;
        if ($v_0 !== -1) {
            window.clearTimeout($v_0);
        }
        this.$0_0.$2a_1 = -1;
        this.$0_0.$3m_1 = -1;
        this.$1U_2();
        this.$X();
        var $v_1 = this.get_displayedComponent();
        if ($v_1.get_displayMode().startsWith('Menu')) {
            var $v_2 = $v_1.$K_0.$K_0;
            $v_2.set_$B0(null);
        }
        $v_1.raiseCommandEvent(this.get_$1_2().CommandMenuClose, 10, null);
        CUI.Controls.FlyoutAnchor.callBaseMethod(this, 'onLaunchedMenuClosed');
    },
    
    $62_2: function() {ULSpEN:;
        var $v_0 = this.$0_0.$2a_1;
        if ($v_0 !== -1) {
            window.clearTimeout($v_0);
        }
        if (null === this.$6A_2) {
            this.$6A_2 = this.$7x;
        }
        this.$0_0.$3m_1 = Array.indexOf(this.$0_0.$W_1, this);
        this.$0_0.$2a_1 = window.setTimeout(this.$6A_2, 500);
    },
    
    $6A_2: null,
    
    $2e_2: function() {ULSpEN:;
        this.$0_0.$2e(this);
        this.$0_0.$2a_1 = -1;
        this.$0_0.$3m_1 = -1;
    },
    
    $6j_2: null,
    $6h_2: null,
    $6i_2: null,
    
    $5t_2: function($p0) {
        this.$X();
        this.$39_2(true);
        this.$0_0.$2v_1 = false;
        this.$6S_2 = false;
        var $v_0 = this.get_displayedComponent();
        var $v_1 = $v_0.get_displayMode().startsWith('Menu');
        if ($v_1) {
            var $v_2 = $v_0.$K_0.$K_0;
            $v_2.set_$B0(this);
        }
        this.launchMenu($p0);
        if (!$v_1) {
            return;
        }
        if (null === this.$6j_2) {
            this.$6j_2 = this.$8e;
        }
        $addHandler(this.$B_1.get_$2(), 'mouseover', this.$6j_2);
        if (Sys.Browser.agent === Sys.Browser.InternetExplorer) {
            if (null === this.$6h_2) {
                this.$6h_2 = this.$8c;
            }
            $addHandler(this.$B_1.get_$2(), 'mouseleave', this.$6h_2);
        }
        else {
            if (null === this.$6i_2) {
                this.$6i_2 = this.$8d;
            }
            $addHandler(this.$B_1.get_$2(), 'mouseout', this.$6i_2);
        }
    },
    
    $1U_2: function() {ULSpEN:;
        var $v_0 = 'ms-cui-ctl-disabledHoveredOver';
        var $v_1 = 'ms-cui-ctl-hoveredOver';
        CUI.Utility.removeCSSClassFromElement(this.$h_2, $v_1);
        CUI.Utility.removeCSSClassFromElement(this.$T_2, $v_1);
        CUI.Utility.removeCSSClassFromElement(this.$Z_2, $v_1);
        CUI.Utility.removeCSSClassFromElement(this.$F_2, $v_1);
        CUI.Utility.removeCSSClassFromElement(this.$8_2, $v_1);
        CUI.Utility.removeCSSClassFromElement(this.$9_2, $v_1);
        CUI.Utility.removeCSSClassFromElement(this.$1b_2, $v_1);
        CUI.Utility.removeCSSClassFromElement(this.$h_2, $v_0);
        CUI.Utility.removeCSSClassFromElement(this.$T_2, $v_0);
        CUI.Utility.removeCSSClassFromElement(this.$Z_2, $v_0);
    },
    
    $39_2: function($p0) {
        var $v_0 = 'ms-cui-ctl-hoveredOver';
        if (!$p0) {
            $v_0 = 'ms-cui-ctl-disabledHoveredOver';
            CUI.Utility.ensureCSSClassOnElement(this.$h_2, $v_0);
            CUI.Utility.ensureCSSClassOnElement(this.$T_2, $v_0);
            CUI.Utility.ensureCSSClassOnElement(this.$Z_2, $v_0);
        }
        else {
            CUI.Utility.ensureCSSClassOnElement(this.$h_2, $v_0);
            CUI.Utility.ensureCSSClassOnElement(this.$T_2, $v_0);
            CUI.Utility.ensureCSSClassOnElement(this.$Z_2, $v_0);
            CUI.Utility.ensureCSSClassOnElement(this.$F_2, $v_0);
            CUI.Utility.ensureCSSClassOnElement(this.$8_2, $v_0);
            CUI.Utility.ensureCSSClassOnElement(this.$9_2, $v_0);
            CUI.Utility.ensureCSSClassOnElement(this.$1b_2, $v_0);
        }
    },
    
    $6U_2: false,
    
    getTextValue: function() {ULSpEN:;
        return this.get_$1_2().LabelText;
    },
    
    $7o: function() {ULSpEN:;
        if (!this.get_enabled()) {
            return false;
        }
        this.receiveFocus();
        return true;
    },
    
    receiveFocus: function() {ULSpEN:;
        var $v_0 = this.get_displayedComponent().get_$2();
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            $v_0.focus();
        }
    },
    
    onMenuClosed: function() {ULSpEN:;
        this.$1U_2();
    },
    
    dispose: function() {ULSpEN:;
        CUI.Controls.FlyoutAnchor.callBaseMethod(this, 'dispose');
        this.$1b_2 = null;
        this.$3d_2 = null;
        this.$4T_2 = null;
        this.$F_2 = null;
        this.$1v_2 = null;
        this.$9H_2 = null;
        this.$8_2 = null;
        this.$2E_2 = null;
        this.$9J_2 = null;
        this.$h_2 = null;
        this.$T_2 = null;
        this.$Z_2 = null;
        this.$5R_2 = null;
        this.$5S_2 = null;
        this.$4P_2 = null;
        this.$6P_2 = null;
        this.$4Q_2 = null;
        this.$6Q_2 = null;
        this.$3a_2 = null;
        this.$9_2 = null;
        this.$2G_2 = null;
        this.$9L_2 = null;
    },
    
    get_$1_2: function() {ULSpEN:;
        return this.$5_0;
    }
}


CUI.Controls.GalleryButtonCommandProperties = function() {
}


CUI.Controls.GalleryButton = function(root, id, properties, dims) {ULSpEN:;
    this.$3H = Function.createDelegate(this, this.onBlur);
    this.$3K = Function.createDelegate(this, this.onFocus);
    this.$1H = Function.createDelegate(this, this.onClick);
    CUI.Controls.GalleryButton.initializeBase(this, [ root, id, properties ]);
    this.addDisplayMode('Large');
    this.addDisplayMode('Menu');
    this.$4E_1 = dims;
}
CUI.Controls.GalleryButton.prototype = {
    $E_1: null,
    $H_1: null,
    $4H_1: null,
    $4I_1: null,
    $4E_1: 0,
    
    createComponentForDisplayModeInternal: function($p0) {
        var $v_0;
        if ($p0 === 'Menu') {
            $v_0 = this.$0_0.$3w(this.$6_0 + '-' + $p0 + this.$0_0.$27(), $p0, this);
            if (CUI.ScriptUtility.isNullOrUndefined(this.get_properties().CommandValueId)) {
                this.get_properties().CommandValueId = this.get_properties().MenuItemId;
            }
        }
        else {
            $v_0 = CUI.Controls.GalleryButton.callBaseMethod(this, 'createComponentForDisplayModeInternal', [ $p0 ]);
        }
        return $v_0;
    },
    
    createDOMElementForDisplayMode: function($p0) {
        switch ($p0) {
            case 'Large':
            case 'Menu':
                var $v_0 = (CUI.ScriptUtility.isNullOrUndefined(this.get_properties().Alt)) ? '' : this.get_properties().Alt;
                this.$E_1 = CUI.Utility.$3('span');
                this.$E_1.setAttribute('mscui:controltype', this.get_$15());
                this.$E_1.className = 'ms-cui-gallerybutton ms-cui-gallerybutton-' + CUI.Utility.$AJ[this.$4E_1];
                this.$H_1 = CUI.Utility.$3('a');
                this.$H_1.title = $v_0;
                this.$H_1.className = 'ms-cui-gallerybutton-a';
                this.$H_1.setAttribute('role', this.get_$1e());
                CUI.Utility.$1s(this.$H_1);
                CUI.Utility.$1i(this.get_properties(), this.$H_1);
                this.$E_1.appendChild(this.$H_1);
                if (!CUI.ScriptUtility.isNullOrUndefined(this.get_properties().InnerHTML)) {
                    this.$H_1.innerHTML = this.get_properties().InnerHTML;
                    CUI.Utility.$29(this.$H_1, true, true);
                }
                else {
                    if (CUI.ScriptUtility.isNullOrUndefined(this.get_properties().Image)) {
                        throw Error.create('InnerHTML or Image must be defined for this GalleryButton');
                    }
                    var $v_1 = 4;
                    switch (this.$4E_1) {
                        case 1:
                            $v_1 = 3;
                            break;
                        case 2:
                            $v_1 = 4;
                            break;
                        case 3:
                            $v_1 = 5;
                            break;
                        case 4:
                            $v_1 = 6;
                            break;
                        case 5:
                            $v_1 = 7;
                            break;
                        case 6:
                            $v_1 = 8;
                            break;
                        case 7:
                            $v_1 = 9;
                            break;
                    }
                    this.$4H_1 = CUI.Utility.$3('img');
                    this.$4I_1 = CUI.Utility.$j(2, $v_1, this.get_properties().Image, this.get_properties().ImageClass, this.$4H_1, true, false, this.get_properties().ImageTop, this.get_properties().ImageLeft);
                    this.$4H_1.alt = $v_0;
                    this.$H_1.appendChild(this.$4I_1);
                }
                this.$O($p0);
                return this.$E_1;
            default:
                this.ensureValidDisplayMode($p0);
                return null;
        }
    },
    
    $35: function($p0) {
        var $v_0 = $get(this.$6_0 + '-' + $p0);
        this.storeElementForDisplayMode($v_0, $p0);
        switch ($p0) {
            case 'Large':
            case 'Menu':
                this.$E_1 = $v_0;
                this.$H_1 = this.$E_1.childNodes[0];
                this.$4I_1 = this.$H_1.childNodes[0];
                this.$4H_1 = this.$4I_1.childNodes[0];
                break;
        }
    },
    
    $O: function($p0) {
        switch ($p0) {
            case 'Large':
            case 'Menu':
                this.$N_1();
                break;
        }
    },
    
    $N_1: function() {ULSpEN:;
        $addHandler(this.$H_1, 'click', this.$1H);
        $addHandler(this.$H_1, 'focus', this.$3K);
        $addHandler(this.$H_1, 'mouseover', this.$3K);
        $addHandler(this.$H_1, 'blur', this.$3H);
        $addHandler(this.$H_1, 'mouseout', this.$3H);
    },
    
    get_$15: function() {ULSpEN:;
        return 'GalleryButton';
    },
    
    onEnabledChanged: function($p0) {
        if ($p0) {
            CUI.Utility.enableElement(this.$H_1);
        }
        else {
            CUI.Utility.disableElement(this.$H_1);
        }
    },
    
    onClick: function($p0) {
        this.$X();
        $p0.preventDefault();
        if (!this.get_enabled()) {
            return;
        }
        this.toggle();
        var $v_0 = 1;
        var $v_1 = this.get_properties().CommandType;
        var $v_2 = this.get_stateProperties();
        $v_2[CUI.Controls.GalleryButtonCommandProperties.CommandValueId] = this.get_properties().CommandValueId;
        $v_2['MenuItemId'] = this.get_properties().MenuItemId;
        $v_2['SourceControlId'] = this.get_properties().Id;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_1) && $v_1 === 'OptionSelection') {
            $v_0 = 3;
        }
        this.get_displayedComponent().raiseCommandEvent(this.get_properties().Command, $v_0, $v_2);
        if (this.$0_0.get_$4x()) {
            this.$4y();
        }
        else {
            this.$51_1(this.get_stateProperties()[CUI.Controls.GalleryButtonCommandProperties.On]);
        }
    },
    
    onFocus: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled()) {
            return;
        }
        this.$0_0.set_$o(this);
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_properties().CommandPreview)) {
            return;
        }
        var $v_0 = 5;
        var $v_1 = this.get_properties().CommandType;
        this.get_stateProperties()[CUI.Controls.GalleryButtonCommandProperties.CommandValueId] = this.get_properties().CommandValueId;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_1) && $v_1 === 'OptionSelection') {
            $v_0 = 7;
        }
        this.get_displayedComponent().raiseCommandEvent(this.get_properties().CommandPreview, $v_0, this.get_stateProperties());
    },
    
    onBlur: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled()) {
            return;
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_properties().CommandRevert)) {
            return;
        }
        var $v_0 = 6;
        var $v_1 = this.get_properties().CommandType;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_1) && $v_1 === 'OptionSelection') {
            $v_0 = 8;
            this.get_stateProperties()[CUI.Controls.GalleryButtonCommandProperties.CommandValueId] = this.get_properties().CommandValueId;
        }
        this.get_displayedComponent().raiseCommandEvent(this.get_properties().CommandRevert, $v_0, this.get_stateProperties());
    },
    
    getDropDownDOMElementForDisplayMode: function($p0) {
        return CUI.Utility.$3('span');
    },
    
    deselect: function() {ULSpEN:;
        this.set_selected(false);
    },
    
    getMenuItemId: function() {ULSpEN:;
        return this.get_properties().MenuItemId;
    },
    
    getCommandValueId: function() {ULSpEN:;
        return this.get_properties().CommandValueId;
    },
    
    focusOnDisplayedComponent: function() {ULSpEN:;
        this.receiveFocus();
    },
    
    getTextValue: function() {ULSpEN:;
        return this.get_properties().Alt;
    },
    
    receiveFocus: function() {ULSpEN:;
        this.$H_1.focus();
    },
    
    onMenuClosed: function() {ULSpEN:;
        CUI.Controls.GalleryButton.callBaseMethod(this, 'onMenuClosed');
    },
    
    $39_1: function() {ULSpEN:;
        CUI.Utility.ensureCSSClassOnElement(this.$E_1, 'ms-cui-gallerybutton-highlighted');
    },
    
    $1U_1: function() {ULSpEN:;
        CUI.Utility.removeCSSClassFromElement(this.$E_1, 'ms-cui-gallerybutton-highlighted');
    },
    
    toggle: function() {ULSpEN:;
        var $v_0 = !this.get_stateProperties()[CUI.Controls.GalleryButtonCommandProperties.On];
        this.get_stateProperties()[CUI.Controls.GalleryButtonCommandProperties.On] = $v_0;
        this.$51_1($v_0);
    },
    
    $51_1: function($p0) {
        if ($p0) {
            this.$39_1();
        }
        else {
            this.$1U_1();
        }
    },
    
    $4y: function() {ULSpEN:;
        var $v_0 = this.get_stateProperties();
        $v_0[CUI.Controls.GalleryButtonCommandProperties.CommandValueId] = this.get_properties().CommandValueId;
        $v_0['MenuItemId'] = this.get_properties().MenuItemId;
        $v_0['SourceControlId'] = this.get_properties().Id;
        var $v_1 = this.pollForStateAndUpdateInternal(this.get_properties().Command, this.get_properties().QueryCommand, $v_0, false);
        if ($v_1) {
            this.$51_1(this.get_stateProperties()[CUI.Controls.GalleryButtonCommandProperties.On]);
        }
    },
    
    get_selected: function() {ULSpEN:;
        return this.get_stateProperties()[CUI.Controls.GalleryButtonCommandProperties.On];
    },
    set_selected: function($p0) {
        this.get_stateProperties()[CUI.Controls.GalleryButtonCommandProperties.On] = $p0;
        if ($p0) {
            this.$39_1();
        }
        else {
            this.$1U_1();
        }
        return $p0;
    },
    
    get_elementDimensions: function() {ULSpEN:;
        return this.$4E_1;
    },
    set_elementDimensions: function($p0) {
        this.$4E_1 = $p0;
        return $p0;
    },
    
    dispose: function() {ULSpEN:;
        CUI.Controls.GalleryButton.callBaseMethod(this, 'dispose');
        this.$E_1 = null;
        this.$H_1 = null;
        this.$4H_1 = null;
        this.$4I_1 = null;
    },
    
    get_properties: function() {ULSpEN:;
        return this.$5_0;
    }
}


CUI.Controls.InsertTableCommandProperties = function() {
}


CUI.Controls.InsertTable = function(root, id, properties) {ULSpEN:;
    this.$53 = Function.createDelegate(this, this.$An_1);
    this.$55 = Function.createDelegate(this, this.$Ap_1);
    this.$54 = Function.createDelegate(this, this.$Ao_1);
    this.$8E = Function.createDelegate(this, this.$DC_1);
    this.$1c_1 = -1;
    this.$43_1 = -1;
    this.$44_1 = -1;
    CUI.Controls.InsertTable.initializeBase(this, [ root, id, properties ]);
    this.addDisplayMode('Menu');
}
CUI.Controls.InsertTable.prototype = {
    $2I_1: null,
    $4g_1: null,
    
    createComponentForDisplayModeInternal: function($p0) {
        if (this.$k_0.length > 0) {
            throw Error.create('Only one ControlComponent can be created for each InsertTable Control');
        }
        var $v_0;
        $v_0 = this.$0_0.$3w(this.$6_0 + '-' + $p0 + this.$0_0.$27(), $p0, this);
        return $v_0;
    },
    
    $E_1: null,
    $2o_1: null,
    
    createDOMElementForDisplayMode: function($p0) {
        switch ($p0) {
            case 'Menu':
                this.$E_1 = CUI.Utility.$3('table');
                this.$E_1.setAttribute('mscui:controltype', this.get_$15());
                this.$2o_1 = CUI.Utility.$3('tbody');
                this.$2o_1.className = 'ms-cui-it';
                this.$E_1.setAttribute('cellspacing', '0');
                this.$E_1.setAttribute('cellpadding', '0');
                this.$2o_1.setAttribute('cellspacing', '0');
                this.$2o_1.setAttribute('cellpadding', '0');
                $addHandler(this.$E_1, 'mouseout', this.$8E);
                this.$Ca_1();
                var $v_0;
                var $v_1;
                var $v_2;
                var $v_3;
                var $v_4;
                var $v_5 = 0;
                for (var $v_6 = 0; $v_6 < 10; $v_6++) {
                    $v_0 = CUI.Utility.$3('tr');
                    this.$2o_1.appendChild($v_0);
                    for (var $v_7 = 0; $v_7 < 10; $v_7++) {
                        $v_1 = CUI.Utility.$3('td');
                        $v_1.style.padding = '0px';
                        $v_0.appendChild($v_1);
                        $v_2 = CUI.Utility.$3('a');
                        CUI.Utility.$1s($v_2);
                        CUI.Utility.$1i(this.get_$1_1(), $v_2);
                        $addHandler($v_2, 'focus', this.$54);
                        $v_3 = CUI.Utility.$3('div');
                        $v_3.className = 'ms-cui-it-inactiveCell';
                        $v_4 = CUI.Utility.$3('div');
                        $v_4.id = this.$6_0 + '-' + $v_5;
                        $v_4.className = 'ms-cui-it-inactiveCellOuter';
                        $addHandler($v_1, 'mouseover', this.$55);
                        $addHandler($v_1, 'click', this.$53);
                        $v_1.appendChild($v_4);
                        $v_4.appendChild($v_3);
                        $v_3.appendChild($v_2);
                        this.$2I_1[$v_5] = $v_3;
                        this.$4g_1[$v_5] = $v_4;
                        $v_5++;
                    }
                }
                this.$E_1.appendChild(this.$2o_1);
                return this.$E_1;
            default:
                this.ensureValidDisplayMode($p0);
                break;
        }
        return null;
    },
    
    onEnabledChanged: function($p0) {
    },
    
    get_$15: function() {ULSpEN:;
        return 'InsertTable';
    },
    
    $An_1: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined(CUI.PMetrics)) {
            CUI.PMetrics.perfMark(7702);
        }
        $p0.preventDefault();
        if (!this.get_enabled()) {
            return;
        }
        var $v_0 = this.$7O_1($p0.target);
        var $v_1 = this.$7M_1($v_0);
        var $v_2 = this.$4s_1($v_1);
        var $v_3 = this.$4t_1($v_1);
        this.$76_1();
        this.get_commandProperties()['Rows'] = $v_3 + 1;
        this.get_commandProperties()['Columns'] = $v_2 + 1;
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_1().Command, 1, this.get_commandProperties());
        if (!CUI.ScriptUtility.isNullOrUndefined(CUI.PMetrics)) {
            CUI.PMetrics.perfMark(7703);
        }
    },
    
    $7O_1: function($p0) {
        while ($p0.hasChildNodes()) {
            $p0 = $p0.childNodes[0];
        }
        return $p0.parentNode.parentNode;
    },
    
    $BG_1: function($p0) {
        var $v_0 = $p0.childNodes[0].childNodes[0];
        var $v_1 = this.$7M_1($p0);
        $v_0.title = this.$AL_1(this.$4t_1($v_1) + 1, this.$4s_1($v_1) + 1);
    },
    
    $AL_1: function($p0, $p1) {
        var $v_0 = this.get_$1_1().Alt;
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            $v_0 = this.get_$1_1().MenuSectionTitle;
        }
        $v_0 = String.format($v_0, $p1.toString(), $p0.toString());
        return $v_0;
    },
    
    $Ap_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        var $v_0 = this.$7O_1($p0.target);
        this.$BG_1($v_0);
        this.$AY_1($v_0);
    },
    
    $Ao_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        var $v_0 = this.$7O_1($p0.target);
        this.$BG_1($v_0);
        this.$AY_1($v_0);
    },
    
    $DC_1: function($p0) {
        var $v_0 = CUI.Utility.$AP(this.$E_1);
        if ($p0.clientX <= $v_0.x || $p0.clientX >= $v_0.x + $v_0.width || $p0.clientY <= $v_0.y || $p0.clientY >= $v_0.y + $v_0.height) {
            this.$60_1();
        }
    },
    
    $60_1: function() {ULSpEN:;
        this.$EG_1();
        this.$7E_1();
        this.$43_1 = -1;
        this.$44_1 = -1;
        this.$3C_1 = false;
    },
    
    $7M_1: function($p0) {
        return parseInt($p0.id.substr(this.$6_0.length + 1));
    },
    
    $3C_1: false,
    
    $AY_1: function($p0) {
        var $v_0 = this.$7M_1($p0);
        if (this.$1c_1 === $v_0) {
            return;
        }
        this.$Cz_1($v_0);
    },
    
    $Cz_1: function($p0) {
        this.$Bb_1($p0);
        this.$1c_1 = $p0;
        this.$7E_1();
        this.$B8_1($p0);
    },
    
    $4t_1: function($p0) {
        return Math.floor($p0 / 10);
    },
    
    $4s_1: function($p0) {
        return $p0 % 10;
    },
    
    $Bb_1: function($p0) {
        var $v_0 = this.$4s_1($p0);
        var $v_1 = this.$4t_1($p0);
        var $v_2 = -1;
        var $v_3 = -1;
        if (this.$1c_1 !== -1) {
            $v_2 = this.$4t_1(this.$1c_1);
            $v_3 = this.$4s_1(this.$1c_1);
        }
        while ($v_2 !== $v_1 || $v_3 !== $v_0) {
            if ($v_2 < $v_1) {
                this.$BE_1(++$v_2, $v_3, true);
            }
            else if ($v_2 > $v_1) {
                this.$BE_1($v_2, $v_3, false);
                $v_2--;
            }
            else if ($v_3 < $v_0) {
                this.$BA_1(++$v_3, $v_2, true);
            }
            else if ($v_3 > $v_0) {
                this.$BA_1($v_3, $v_2, false);
                $v_3--;
            }
        }
        this.get_$Ab_1().$BF(this.$AL_1($v_1 + 1, $v_0 + 1));
    },
    
    $BE_1: function($p0, $p1, $p2) {
        for (var $v_0 = 0; $v_0 <= $p1; $v_0++) {
            this.$B9_1($p0, $v_0, $p2);
        }
    },
    
    $BA_1: function($p0, $p1, $p2) {
        for (var $v_0 = 0; $v_0 <= $p1; $v_0++) {
            this.$B9_1($v_0, $p0, $p2);
        }
    },
    
    $B9_1: function($p0, $p1, $p2) {
        var $v_0 = $p0 * 10 + $p1;
        var $v_1 = this.$2I_1[$v_0];
        var $v_2 = this.$4g_1[$v_0];
        if ($p2) {
            $v_1.className = 'ms-cui-it-activeCell';
            $v_2.className = 'ms-cui-it-activeCellOuter';
        }
        else {
            $v_1.className = 'ms-cui-it-inactiveCell';
            $v_2.className = 'ms-cui-it-inactiveCellOuter';
        }
    },
    
    $EG_1: function() {ULSpEN:;
        for (var $v_1 = 0; $v_1 < 100; $v_1++) {
            this.$2I_1[$v_1].className = 'ms-cui-it-inactiveCell';
            this.$4g_1[$v_1].className = 'ms-cui-it-inactiveCellOuter';
        }
        this.$1c_1 = -1;
        var $v_0 = this.get_$1_1().MenuSectionInitialTitle;
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            $v_0 = '';
        }
        this.get_$Ab_1().$BF($v_0);
    },
    
    $Ca_1: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$2I_1)) {
            this.$2I_1 = new Array(100);
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.$4g_1)) {
            this.$4g_1 = new Array(100);
        }
    },
    
    receiveFocus: function() {ULSpEN:;
        var $v_0 = this.$2I_1[0];
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return;
        }
        $v_0.firstChild.focus();
    },
    
    $76_1: function() {ULSpEN:;
        this.$43_1 = -1;
        this.$44_1 = -1;
        this.$3C_1 = false;
    },
    
    $7E_1: function() {ULSpEN:;
        if (this.$3C_1) {
            var $v_0 = this.get_$1_1().CommandRevert;
            if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
                this.get_commandProperties()['Rows'] = this.$44_1 + 1;
                this.get_commandProperties()['Columns'] = this.$43_1 + 1;
                this.get_displayedComponent().raiseCommandEvent($v_0, 6, this.get_commandProperties());
            }
            this.$76_1();
        }
    },
    
    $B8_1: function($p0) {
        this.$43_1 = this.$4s_1($p0);
        this.$44_1 = this.$4t_1($p0);
        this.$3C_1 = true;
        var $v_0 = this.get_$1_1().CommandPreview;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            this.get_commandProperties()['Rows'] = this.$44_1 + 1;
            this.get_commandProperties()['Columns'] = this.$43_1 + 1;
            this.get_displayedComponent().raiseCommandEvent($v_0, 5, this.get_commandProperties());
        }
    },
    
    get_$Ab_1: function() {ULSpEN:;
        var $v_0 = this.get_displayedComponent().$K_0;
        if (!CUI.MenuSection.isInstanceOfType($v_0)) {
            throw Error.create('InsertTable must live inside of a MenuSection.');
        }
        return $v_0;
    },
    
    onMenuClosed: function() {ULSpEN:;
        this.$60_1();
    },
    
    $2i: function() {ULSpEN:;
        if (this.$1c_1 === 99) {
            this.$60_1();
            return false;
        }
        this.$2I_1[this.$1c_1 + 1].firstChild.focus();
        return true;
    },
    
    $2j: function() {ULSpEN:;
        if (!this.$1c_1) {
            this.$60_1();
            return false;
        }
        else if (this.$1c_1 === -1) {
            this.$2I_1[99].firstChild.focus();
        }
        else {
            this.$2I_1[this.$1c_1 - 1].firstChild.focus();
        }
        return true;
    },
    
    dispose: function() {ULSpEN:;
        CUI.Controls.InsertTable.callBaseMethod(this, 'dispose');
        this.$E_1 = null;
        this.$2o_1 = null;
    },
    
    get_$1_1: function() {ULSpEN:;
        return this.$5_0;
    }
}


CUI.Controls.LabelCommandProperties = function() {
}


CUI.Controls.Label = function(root, id, properties) {ULSpEN:;
    CUI.Controls.Label.initializeBase(this, [ root, id, properties ]);
    this.addDisplayMode('Medium');
    this.addDisplayMode('Small');
}
CUI.Controls.Label.prototype = {
    $E_1: null,
    $5K_1: null,
    $2B_1: null,
    $9_1: null,
    $4S_1: null,
    $5i_1: '',
    
    createDOMElementForDisplayMode: function($p0) {
        var $v_0 = this.get_$1_1().ForId;
        var $v_1 = this.get_$1_1().LabelText;
        switch ($p0) {
            case 'Medium':
                if ($v_0) {
                    this.$E_1 = CUI.Utility.$3('label');
                    if (CUI.Utility.$3B()) {
                        this.$E_1.setAttribute('htmlFor', $v_0);
                    }
                    else {
                        this.$E_1.setAttribute('for', $v_0);
                    }
                }
                else {
                    this.$E_1 = CUI.Utility.$3('span');
                }
                this.$E_1.setAttribute('mscui:controltype', this.get_$15());
                this.$E_1.className = 'ms-cui-ctl-small ms-cui-fslb';
                if (!CUI.ScriptUtility.isNullOrEmptyString(this.get_$1_1().Image16by16)) {
                    this.$5K_1 = CUI.Utility.$3('img');
                    var $v_4 = CUI.Utility.$j(2, 3, this.get_$1_1().Image16by16, this.get_$1_1().Image16by16Class, this.$5K_1, true, false, this.get_$1_1().Image16by16Top, this.get_$1_1().Image16by16Left);
                    var $v_5 = CUI.Utility.$3('span');
                    $v_5.className = 'ms-cui-ctl-iconContainer';
                    $v_5.appendChild($v_4);
                    this.$E_1.appendChild($v_5);
                }
                this.$2B_1 = CUI.Utility.$3('span');
                this.$2B_1.className = 'ms-cui-ctl-mediumlabel';
                if (!CUI.ScriptUtility.isNullOrUndefined($v_1)) {
                    CUI.UIUtility.setInnerText(this.$2B_1, $v_1);
                }
                this.$E_1.appendChild(this.$2B_1);
                return this.$E_1;
            case 'Small':
                if ($v_0) {
                    this.$9_1 = CUI.Utility.$3('label');
                    if (CUI.Utility.$3B()) {
                        this.$9_1.setAttribute('htmlFor', $v_0);
                    }
                    else {
                        this.$9_1.setAttribute('for', $v_0);
                    }
                }
                else {
                    this.$9_1 = CUI.Utility.$3('span');
                }
                this.$9_1.setAttribute('mscui:controltype', this.get_$15());
                this.$9_1.className = 'ms-cui-ctl-small ms-cui-fslb';
                if (CUI.ScriptUtility.isNullOrEmptyString(this.get_$1_1().Image16by16)) {
                    throw Error.argumentNull('Image16by16', 'Small display mode must have an icon set');
                }
                this.$4S_1 = CUI.Utility.$3('img');
                var $v_2 = CUI.Utility.$j(2, 3, this.get_$1_1().Image16by16, this.get_$1_1().Image16by16Class, this.$4S_1, true, false, this.get_$1_1().Image16by16Top, this.get_$1_1().Image16by16Left);
                if (!CUI.ScriptUtility.isNullOrUndefined($v_1)) {
                    this.$4S_1.alt = $v_1;
                }
                var $v_3 = CUI.Utility.$3('span');
                $v_3.className = 'ms-cui-ctl-iconContainer';
                $v_3.appendChild($v_2);
                this.$9_1.appendChild($v_3);
                return this.$9_1;
            default:
                this.ensureValidDisplayMode($p0);
                break;
        }
        return null;
    },
    
    $35: function($p0) {
        var $v_0 = $get(this.$6_0 + '-' + $p0);
        this.storeElementForDisplayMode($v_0, $p0);
        switch ($p0) {
            case 'Medium':
                this.$E_1 = $v_0;
                if (!CUI.ScriptUtility.isNullOrEmptyString(this.get_$1_1().Image16by16)) {
                    this.$5K_1 = this.$E_1.firstChild.firstChild.firstChild;
                    this.$2B_1 = this.$E_1.childNodes[1];
                }
                else {
                    this.$2B_1 = this.$E_1.firstChild;
                }
                break;
            case 'Small':
                this.$9_1 = $v_0;
                this.$4S_1 = this.$9_1.firstChild.firstChild.firstChild;
                break;
        }
    },
    
    onEnabledChanged: function($p0) {
        CUI.Utility.setEnabledOnElement(this.$E_1, $p0);
        CUI.Utility.setEnabledOnElement(this.$9_1, $p0);
    },
    
    get_$15: function() {ULSpEN:;
        return 'Label';
    },
    
    $4y: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_1().Command)) {
            return;
        }
        var $v_0 = this.pollForStateAndUpdateInternal(this.get_$1_1().Command, this.get_$1_1().QueryCommand, this.get_stateProperties(), false);
        if ($v_0 && !CUI.ScriptUtility.isNullOrUndefined(this.get_$1_1().QueryCommand)) {
            var $v_1 = this.$5i_1;
            if (!CUI.ScriptUtility.isNullOrEmptyString(this.get_stateProperties()[CUI.Controls.LabelCommandProperties.Value])) {
                CUI.UIUtility.setInnerText(this.$2B_1, this.get_stateProperties()[CUI.Controls.LabelCommandProperties.Value]);
                this.$5i_1 = this.get_stateProperties()[CUI.Controls.LabelCommandProperties.Value];
            }
            else {
                CUI.UIUtility.setInnerText(this.$2B_1, this.get_$1_1().LabelText);
                this.$5i_1 = this.get_$1_1().LabelText;
            }
            if (this.$5i_1 !== $v_1) {
                this.$0_0.$3N_1 = true;
            }
        }
    },
    
    dispose: function() {ULSpEN:;
        CUI.Controls.Label.callBaseMethod(this, 'dispose');
        this.$E_1 = null;
        this.$5K_1 = null;
        this.$2B_1 = null;
        this.$9_1 = null;
        this.$4S_1 = null;
    },
    
    get_$1_1: function() {ULSpEN:;
        return this.$5_0;
    }
}


CUI.Controls.MRUSplitButton = function(root, id, properties, menu) {ULSpEN:;
    this.$3J = Function.createDelegate(this, this.onDblClick);
    this.$8z = Function.createDelegate(this, this.$Ay_3);
    this.$5A = Function.createDelegate(this, this.$Dc_3);
    this.$5B = Function.createDelegate(this, this.$Dd_3);
    CUI.Controls.MRUSplitButton.initializeBase(this, [ root, id, properties, menu ]);
}
CUI.Controls.MRUSplitButton.prototype = {
    $F_3: null,
    $1I_3: null,
    $R_3: null,
    $1v_3: null,
    $8_3: null,
    $Y_3: null,
    $S_3: null,
    $2E_3: null,
    $9_3: null,
    $1P_3: null,
    $U_3: null,
    $2G_3: null,
    $1V_3: false,
    $3P_3: false,
    
    $7o: function() {ULSpEN:;
        if (!this.get_enabled()) {
            return false;
        }
        if (this.$1V_3) {
            this.get_displayedComponent().get_$2().firstChild.firstChild.focus();
            return true;
        }
        return false;
    },
    
    createDOMElementForDisplayMode: function($p0) {
        var $v_0 = true;
        var $v_1 = (CUI.ScriptUtility.isNullOrEmptyString(this.get_properties().Alt)) ? '' : this.get_properties().Alt;
        var $v_2 = ($p0 === 'Medium' && !CUI.ScriptUtility.isNullOrUndefined(this.get_properties().Width)) ? this.get_properties().Width : 'auto';
        var $v_3 = null;
        var $v_4 = this.get_stateProperties()[CUI.Controls.DropDownCommandProperties.SelectedItemId];
        if (CUI.ScriptUtility.isNullOrUndefined($v_4)) {
            $v_4 = this.get_properties().InitialItem;
        }
        this.$3P_3 = true;
        switch ($p0) {
            case 'Large':
                this.$F_3 = CUI.Utility.$3('span');
                this.$F_3.setAttribute('mscui:controltype', this.get_$15());
                CUI.Utility.ensureCSSClassOnElement(this.$F_3, 'ms-cui-ctl-large');
                this.$1I_3 = CUI.Utility.$3('span');
                this.$1I_3.className = 'ms-cui-mrusb-selecteditem';
                if (!this.$2R($v_4)) {
                    if (!CUI.Utility.$v(this.get_properties().PopulateDynamically)) {
                        throw Error.create('No menu item with id \'' + this.get_properties().InitialItem + '\' exists in this control\'s menu');
                    }
                    else {
                        this.$1I_3.style.width = '32px';
                        this.$1I_3.style.height = '32px';
                    }
                }
                this.$R_3 = CUI.Utility.$3('a');
                this.$R_3.className = 'ms-cui-ctl-a2';
                this.$R_3.style.display = 'block';
                this.$R_3.setAttribute('role', this.get_$1e());
                this.$R_3.setAttribute('aria-haspopup', true);
                CUI.Utility.$1s(this.$R_3);
                CUI.Utility.$1i(this.get_properties(), this.$R_3);
                this.$1v_3 = CUI.Utility.$3('img');
                var $v_5 = CUI.Utility.$j(2, 1, this.$0_0.$5_1.ImageDownArrow, this.$0_0.$5_1.ImageDownArrowClass, this.$1v_3, true, false, this.$0_0.$5_1.ImageDownArrowTop, this.$0_0.$5_1.ImageDownArrowLeft);
                if (CUI.ScriptUtility.isNullOrEmptyString(this.get_properties().ToolTipTitle)) {
                    $v_0 = false;
                    this.$R_3.title = $v_1;
                    this.$1v_3.alt = $v_1;
                }
                this.$O($p0);
                this.$R_3.appendChild($v_5);
                if ($v_0) {
                    $v_3 = CUI.Utility.$2h($v_1);
                    this.$R_3.appendChild($v_3);
                }
                this.$F_3.appendChild(this.$1I_3);
                this.$F_3.appendChild(this.$R_3);
                this.$3P_3 = false;
                return this.$F_3;
            case 'Medium':
                this.$8_3 = CUI.Utility.$3('span');
                this.$8_3.setAttribute('mscui:controltype', this.get_$15());
                this.$8_3.className = 'ms-cui-ctl-medium ms-cui-ctl';
                this.$Y_3 = CUI.Utility.$3('span');
                this.$Y_3.className = 'ms-cui-mrusb-selecteditem';
                this.$Y_3.style.width = $v_2;
                if (!this.$2R($v_4)) {
                    throw Error.create('No menu item with id \'' + this.get_properties().InitialItem + '\' exists in this control\'s menu');
                }
                this.$S_3 = CUI.Utility.$3('a');
                CUI.Utility.$1s(this.$S_3);
                CUI.Utility.$1i(this.get_properties(), this.$S_3);
                this.$S_3.className = 'ms-cui-ctl';
                this.$S_3.setAttribute('role', this.get_$1e());
                this.$S_3.setAttribute('aria-haspopup', true);
                this.$2E_3 = CUI.Utility.$3('img');
                if (CUI.ScriptUtility.isNullOrEmptyString(this.get_properties().ToolTipTitle)) {
                    $v_0 = false;
                    this.$S_3.title = $v_1;
                    this.$2E_3.alt = $v_1;
                }
                var $v_6 = CUI.Utility.$j(2, 1, this.$0_0.$5_1.ImageDownArrow, this.$0_0.$5_1.ImageDownArrowClass, this.$2E_3, true, false, this.$0_0.$5_1.ImageDownArrowTop, this.$0_0.$5_1.ImageDownArrowLeft);
                this.$O($p0);
                this.$S_3.appendChild($v_6);
                if ($v_0) {
                    $v_3 = CUI.Utility.$2h($v_1);
                    this.$S_3.appendChild($v_3);
                }
                this.$8_3.appendChild(this.$Y_3);
                this.$8_3.appendChild(this.$S_3);
                this.$3P_3 = false;
                return this.$8_3;
            case 'Small':
                this.$9_3 = CUI.Utility.$3('span');
                this.$9_3.setAttribute('mscui:controltype', this.get_$15());
                this.$9_3.className = 'ms-cui-ctl-medium ms-cui-ctl';
                this.$1P_3 = CUI.Utility.$3('span');
                this.$1P_3.className = 'ms-cui-mrusb-selecteditem';
                this.$1P_3.style.width = $v_2;
                if (!this.$2R($v_4)) {
                    throw Error.create('No menu item with id \'' + this.get_properties().InitialItem + '\' exists in this control\'s menu');
                }
                this.$U_3 = CUI.Utility.$3('a');
                CUI.Utility.$1s(this.$U_3);
                CUI.Utility.$1i(this.get_properties(), this.$U_3);
                this.$U_3.setAttribute('role', this.get_$1e());
                this.$U_3.setAttribute('aria-haspopup', true);
                this.$U_3.className = 'ms-cui-ctl ms-cui-mrusb-arwbtn';
                this.$2G_3 = CUI.Utility.$3('img');
                if (CUI.ScriptUtility.isNullOrEmptyString(this.get_properties().ToolTipTitle)) {
                    this.$U_3.title = $v_1;
                    this.$2G_3.alt = $v_1;
                    $v_0 = false;
                }
                var $v_7 = CUI.Utility.$j(2, 1, this.$0_0.$5_1.ImageDownArrow, this.$0_0.$5_1.ImageDownArrowClass, this.$2G_3, true, false, this.$0_0.$5_1.ImageDownArrowTop, this.$0_0.$5_1.ImageDownArrowLeft);
                this.$O($p0);
                this.$U_3.appendChild($v_7);
                if ($v_0) {
                    $v_3 = CUI.Utility.$2h($v_1);
                    this.$U_3.appendChild($v_3);
                }
                this.$9_3.appendChild(this.$1P_3);
                this.$9_3.appendChild(this.$U_3);
                this.$3P_3 = false;
                return this.$9_3;
            default:
                this.$3P_3 = false;
                this.ensureValidDisplayMode($p0);
                return null;
        }
    },
    
    $35: function($p0) {
        var $v_0 = $get(this.$6_0 + '-' + $p0);
        this.storeElementForDisplayMode($v_0, $p0);
        switch ($p0) {
            case 'Large':
                this.$F_3 = $v_0;
                this.$1I_3 = this.$F_3.childNodes[0];
                this.$R_3 = this.$F_3.childNodes[1];
                this.$1v_3 = this.$R_3.childNodes[0].childNodes[0];
                break;
            case 'Medium':
                this.$8_3 = $v_0;
                this.$Y_3 = this.$8_3.childNodes[0];
                this.$S_3 = this.$8_3.childNodes[1];
                this.$2E_3 = this.$S_3.childNodes[0].childNodes[0];
                break;
            case 'Small':
                this.$9_3 = $v_0;
                this.$1P_3 = this.$9_3.childNodes[0];
                this.$U_3 = this.$9_3.childNodes[1];
                this.$2G_3 = this.$U_3.childNodes[0].childNodes[0];
                break;
        }
    },
    
    $O: function($p0) {
        this.$N_3($p0);
    },
    
    $N_3: function($p0) {
        switch ($p0) {
            case 'Large':
                $addHandler(this.$R_3, 'click', this.$3F);
                $addHandler(this.$1I_3, 'mouseover', this.$5B);
                $addHandler(this.$1I_3, 'mouseout', this.$5A);
                $addHandler(this.$R_3, 'mouseover', this.$2l);
                $addHandler(this.$R_3, 'mouseout', this.$1j);
                $addHandler(this.$R_3, 'focus', this.$47);
                $addHandler(this.$R_3, 'blur', this.$1j);
                $addHandler(this.$R_3, 'keypress', this.$3G);
                break;
            case 'Medium':
                $addHandler(this.$S_3, 'click', this.$3F);
                $addHandler(this.$Y_3, 'mouseover', this.$5B);
                $addHandler(this.$Y_3, 'mouseout', this.$5A);
                $addHandler(this.$S_3, 'mouseover', this.$2l);
                $addHandler(this.$S_3, 'mouseout', this.$1j);
                $addHandler(this.$S_3, 'focus', this.$47);
                $addHandler(this.$S_3, 'blur', this.$1j);
                $addHandler(this.$S_3, 'keypress', this.$3G);
                break;
            case 'Small':
                $addHandler(this.$U_3, 'click', this.$3F);
                $addHandler(this.$1P_3, 'mouseover', this.$5B);
                $addHandler(this.$1P_3, 'mouseout', this.$5A);
                $addHandler(this.$U_3, 'mouseover', this.$2l);
                $addHandler(this.$U_3, 'mouseout', this.$1j);
                $addHandler(this.$U_3, 'focus', this.$47);
                $addHandler(this.$U_3, 'blur', this.$1j);
                $addHandler(this.$U_3, 'keypress', this.$3G);
                break;
        }
    },
    
    get_$15: function() {ULSpEN:;
        return 'MRUSplitButton';
    },
    
    selectMenuItem: function($p0) {
        if (this._selectedControl === $p0 && !this.$3P_3) {
            return;
        }
        var $v_0 = (!CUI.ScriptUtility.isNullOrUndefined(this.get_displayedComponent())) ? this.get_displayedComponent().get_title() : this.$6D_0;
        var $v_1;
        switch ($v_0) {
            case 'Large':
                $v_1 = this.$1I_3;
                break;
            case 'Medium':
                $v_1 = this.$Y_3;
                break;
            case 'Small':
                $v_1 = this.$1P_3;
                break;
            default:
                throw Error.create('Invalid display mode on split button while selecting a menu item');
        }
        this._selectedControl = $p0;
        this.get_stateProperties()[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $p0.getMenuItemId();
        var $v_2 = $p0;
        if (CUI.MenuItem.isInstanceOfType($v_2.get_displayedComponent())) {
            this.$B_1.$3p_1 = $v_2.get_displayedComponent();
        }
        var $v_3 = this._selectedControl.getDropDownDOMElementForDisplayMode($v_0);
        if ($v_3.childNodes.length > 1) {
            var $v_4 = $v_3.childNodes[1];
            if ($v_4.childNodes.length > 1) {
                if ($v_4.childNodes[1].tagName.toLowerCase() === 'br') {
                    var $v_5 = CUI.Utility.$3('span');
                    CUI.Utility.$2k($v_5, ' ');
                    $v_4.replaceChild($v_5, $v_4.childNodes[1]);
                }
            }
        }
        $v_3.id = this.$6_0 + '-SelectedItem';
        if ($v_1.hasChildNodes()) {
            var $v_6 = $v_1.firstChild;
            $v_1.replaceChild($v_3, $v_6);
            $clearHandlers($v_6);
        }
        else {
            $v_1.appendChild($v_3);
        }
        $addHandler($v_3, 'click', this.$8z);
        $addHandler($v_3, 'dblclick', this.$3J);
    },
    
    addDisplayModes: function() {ULSpEN:;
        this.addDisplayMode('Large');
        this.addDisplayMode('Medium');
        this.addDisplayMode('Small');
    },
    
    launchMenuInternal: function($p0) {
        var $v_0 = false;
        this.$0_0.$2v_1 = false;
        switch (this.get_displayedComponent().get_title()) {
            case 'Large':
                $v_0 = this.launchMenu(this.$R_3, this.$3M);
                break;
            case 'Medium':
                $v_0 = this.launchMenu(this.$S_3, this.$3M);
                break;
            case 'Small':
                $v_0 = this.launchMenu(this.$U_3, this.$3M);
                break;
        }
        if ($v_0) {
            this.sendMenuCreationCommandEvent();
        }
    },
    
    onEnabledChanged: function($p0) {
        CUI.Controls.MRUSplitButton.callBaseMethod(this, 'onEnabledChanged', [ $p0 ]);
        var $v_0 = 'ms-cui-disabled';
        this.$1V_3 = $p0;
        if ($p0) {
            CUI.Utility.removeCSSClassFromElement(this.$F_3, $v_0);
            CUI.Utility.enableElement(this.$R_3);
            CUI.Utility.removeCSSClassFromElement(this.$8_3, $v_0);
            CUI.Utility.enableElement(this.$S_3);
            CUI.Utility.removeCSSClassFromElement(this.$9_3, $v_0);
            CUI.Utility.enableElement(this.$U_3);
        }
        else {
            CUI.Utility.ensureCSSClassOnElement(this.$F_3, $v_0);
            CUI.Utility.disableElement(this.$R_3);
            CUI.Utility.ensureCSSClassOnElement(this.$8_3, $v_0);
            CUI.Utility.disableElement(this.$S_3);
            CUI.Utility.ensureCSSClassOnElement(this.$9_3, $v_0);
            CUI.Utility.disableElement(this.$U_3);
        }
        CUI.Utility.setEnabledOnElement(this.$R_3, $p0);
        CUI.Utility.setEnabledOnElement(this.$S_3, $p0);
        CUI.Utility.setEnabledOnElement(this.$U_3, $p0);
    },
    
    onDblClick: function($p0) {
        this.$X();
        $p0.preventDefault();
        if (!this.get_enabled()) {
            return;
        }
        this.$Ay_3($p0);
    },
    
    $Ay_3: function($p0) {
        CUI.PMetrics.perfMark(7735);
        this.$X();
        $p0.preventDefault();
        if (!this.get_enabled()) {
            return;
        }
        var $v_0 = 3;
        this.get_displayedComponent().raiseCommandEvent(this.get_properties().Command, $v_0, { CommandValueId: this._selectedControl.getCommandValueId() });
    },
    
    $Dd_3: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled()) {
            return;
        }
        switch (this.get_displayedComponent().get_title()) {
            case 'Large':
                CUI.Utility.ensureCSSClassOnElement(this.$1I_3, 'ms-cui-ctl-light-hoveredOver');
                CUI.Utility.ensureCSSClassOnElement(this.$R_3, 'ms-cui-ctl-split-hover');
                break;
            case 'Medium':
                CUI.Utility.ensureCSSClassOnElement(this.$Y_3, 'ms-cui-ctl-light-hoveredOver');
                CUI.Utility.ensureCSSClassOnElement(this.$S_3, 'ms-cui-ctl-split-hover');
                break;
            case 'Small':
                CUI.Utility.ensureCSSClassOnElement(this.$1P_3, 'ms-cui-ctl-light-hoveredOver');
                CUI.Utility.ensureCSSClassOnElement(this.$U_3, 'ms-cui-ctl-split-hover');
                break;
        }
        if (CUI.ScriptUtility.isNullOrEmptyString(this.get_properties().CommandPreview)) {
            return;
        }
        this.get_displayedComponent().raiseCommandEvent(this.get_properties().CommandPreview, 5, { CommandValueId: this._selectedControl.getCommandValueId() });
    },
    
    $Dc_3: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled()) {
            return;
        }
        switch (this.get_displayedComponent().get_title()) {
            case 'Large':
                CUI.Utility.removeCSSClassFromElement(this.$1I_3, 'ms-cui-ctl-light-hoveredOver');
                CUI.Utility.removeCSSClassFromElement(this.$R_3, 'ms-cui-ctl-split-hover');
                break;
            case 'Medium':
                CUI.Utility.removeCSSClassFromElement(this.$Y_3, 'ms-cui-ctl-light-hoveredOver');
                CUI.Utility.removeCSSClassFromElement(this.$S_3, 'ms-cui-ctl-split-hover');
                break;
            case 'Small':
                CUI.Utility.removeCSSClassFromElement(this.$1P_3, 'ms-cui-ctl-light-hoveredOver');
                CUI.Utility.removeCSSClassFromElement(this.$U_3, 'ms-cui-ctl-split-hover');
                break;
        }
        if (CUI.ScriptUtility.isNullOrEmptyString(this.get_properties().CommandRevert)) {
            return;
        }
        this.get_displayedComponent().raiseCommandEvent(this.get_properties().CommandRevert, 6, { CommandValueId: this._selectedControl.getCommandValueId() });
    },
    
    highlight: function() {ULSpEN:;
        switch (this.get_displayedComponent().get_title()) {
            case 'Large':
                CUI.Utility.ensureCSSClassOnElement(this.$1I_3, 'ms-cui-ctl-split-hover');
                CUI.Utility.ensureCSSClassOnElement(this.$R_3, 'ms-cui-ctl-light-hoveredOver');
                break;
            case 'Medium':
                CUI.Utility.ensureCSSClassOnElement(this.$Y_3, 'ms-cui-ctl-split-hover');
                CUI.Utility.ensureCSSClassOnElement(this.$S_3, 'ms-cui-ctl-light-hoveredOver');
                break;
            case 'Small':
                CUI.Utility.ensureCSSClassOnElement(this.$1P_3, 'ms-cui-ctl-split-hover');
                CUI.Utility.ensureCSSClassOnElement(this.$U_3, 'ms-cui-ctl-light-hoveredOver');
                break;
        }
    },
    
    removeHighlight: function() {ULSpEN:;
        switch (this.get_displayedComponent().get_title()) {
            case 'Large':
                CUI.Utility.removeCSSClassFromElement(this.$1I_3, 'ms-cui-ctl-split-hover');
                CUI.Utility.removeCSSClassFromElement(this.$R_3, 'ms-cui-ctl-light-hoveredOver');
                break;
            case 'Medium':
                CUI.Utility.removeCSSClassFromElement(this.$Y_3, 'ms-cui-ctl-split-hover');
                CUI.Utility.removeCSSClassFromElement(this.$S_3, 'ms-cui-ctl-light-hoveredOver');
                break;
            case 'Small':
                CUI.Utility.removeCSSClassFromElement(this.$1P_3, 'ms-cui-ctl-split-hover');
                CUI.Utility.removeCSSClassFromElement(this.$U_3, 'ms-cui-ctl-light-hoveredOver');
                break;
        }
    },
    
    dispose: function() {ULSpEN:;
        CUI.Controls.MRUSplitButton.callBaseMethod(this, 'dispose');
        this.$F_3 = null;
        this.$1v_3 = null;
        this.$R_3 = null;
        this.$1I_3 = null;
        this.$8_3 = null;
        this.$2E_3 = null;
        this.$S_3 = null;
        this.$Y_3 = null;
        this.$9_3 = null;
        this.$2G_3 = null;
        this.$U_3 = null;
        this.$1P_3 = null;
    }
}


CUI.Controls.Separator = function(root, id, properties) {ULSpEN:;
    CUI.Controls.Separator.initializeBase(this, [ root, id, properties ]);
    this.addDisplayMode('Small');
}
CUI.Controls.Separator.prototype = {
    $5P_1: null,
    $5Q_1: null,
    $9_1: null,
    
    createDOMElementForDisplayMode: function($p0) {
        switch ($p0) {
            case 'Small':
                this.$5P_1 = CUI.Utility.$3('img');
                this.$5P_1.style.cursor = 'default';
                this.$5Q_1 = CUI.Utility.$j(2, 11, this.get_$1_1().Image, this.get_$1_1().ImageClass, this.$5P_1, true, false, this.get_$1_1().ImageTop, this.get_$1_1().ImageLeft);
                this.$9_1 = CUI.Utility.$3('span');
                this.$9_1.className = 'ms-cui-ctl ms-cui-ctl-small ms-cui-separator';
                this.$9_1.appendChild(this.$5Q_1);
                return this.$9_1;
            default:
                this.ensureValidDisplayMode($p0);
                break;
        }
        return null;
    },
    
    $35: function($p0) {
        var $v_0 = $get(this.$6_0 + '-' + $p0);
        this.storeElementForDisplayMode($v_0, $p0);
        switch ($p0) {
            case 'Small':
                this.$5Q_1 = $v_0;
                break;
        }
    },
    
    onEnabledChanged: function($p0) {
    },
    
    get_$15: function() {ULSpEN:;
        return 'Separator';
    },
    
    $4y: function() {
    },
    
    dispose: function() {ULSpEN:;
        CUI.Controls.Separator.callBaseMethod(this, 'dispose');
        this.$5P_1 = null;
        this.$5Q_1 = null;
        this.$9_1 = null;
    },
    
    get_$1_1: function() {ULSpEN:;
        return this.$5_0;
    }
}


CUI.Controls.SpinnerCommandProperties = function() {
}


CUI.Controls.Spinner = function(root, id, properties, validUnits) {ULSpEN:;
    this.$7u = Function.createDelegate(this, this.$BT_1);
    this.$7v = Function.createDelegate(this, this.$BU_1);
    this.$9A = Function.createDelegate(this, this.$EC_1);
    this.$9B = Function.createDelegate(this, this.$ED_1);
    this.$8q = Function.createDelegate(this, this.$At_1);
    this.$8k = Function.createDelegate(this, this.$DU_1);
    this.$96 = Function.createDelegate(this, this.$Di_1);
    this.$8J = Function.createDelegate(this, this.$DE_1);
    this.$8r = Function.createDelegate(this, this.$Au_1);
    this.$8l = Function.createDelegate(this, this.$DV_1);
    this.$97 = Function.createDelegate(this, this.$Dj_1);
    this.$8K = Function.createDelegate(this, this.$DF_1);
    this.$8U = Function.createDelegate(this, this.$DL_1);
    this.$8P = Function.createDelegate(this, this.$DH_1);
    this.$56 = Function.createDelegate(this, this.$Aq_1);
    this.$95 = Function.createDelegate(this, this.$5y_1);
    this.$8I = Function.createDelegate(this, this.$5v_1);
    this.$8C = Function.createDelegate(this, this.$7Y_1);
    this.$2m = Function.createDelegate(this, this.$4u_1);
    this.$3L = Function.createDelegate(this, this.$42_1);
    CUI.Controls.Spinner.initializeBase(this, [ root, id, properties ]);
    this.addDisplayMode('Medium');
    this.$4B_1 = 0;
    this.$3k_1 = 1;
    this.$2N_1 = validUnits;
    this.$1d_1 = parseFloat(this.get_$1_1().DefaultValue);
    this.get_stateProperties()['Value'] = this.$1d_1;
    this.$n_1 = this.$AG_1(this.get_$1_1().DefaultUnit);
    if (CUI.ScriptUtility.isNullOrUndefined(this.$n_1)) {
        throw Error.create('The default unit is not in the list of valid units');
    }
    this.get_stateProperties()['Unit'] = this.$n_1.$5Z_0;
}
CUI.Controls.Spinner.createUnit = function($p0, $p1, $p2, $p3, $p4, $p5) {
    return new CUI.Unit($p0, $p1, $p2, $p3, $p4, $p5);
}
CUI.Controls.Spinner.$Co_1 = function($p0, $p1) {
    var $v_0 = Math.pow(10, $p1.$6F_0);
    return Math.round($p0 * $v_0) / $v_0;
}
CUI.Controls.Spinner.prototype = {
    $E_1: null,
    $C_1: null,
    $2A_1: null,
    $d_1: null,
    $c_1: null,
    $4k_1: null,
    $3t_1: null,
    $4G_1: null,
    $3V_1: null,
    $n_1: null,
    $2N_1: null,
    $1d_1: 0,
    $9l_1: false,
    $4B_1: 0,
    $5D_1: 0,
    $9X_1: 0,
    $3k_1: 0,
    $2Z_1: 0,
    $3r_1: 0,
    $5F_1: null,
    $3R_1: false,
    
    createDOMElementForDisplayMode: function($p0) {
        switch ($p0) {
            case 'Medium':
                this.$E_1 = CUI.Utility.$3('span');
                this.$E_1.className = 'ms-cui-spn';
                this.$E_1.setAttribute('mscui:controltype', this.get_$15());
                this.$C_1 = CUI.Utility.$7A('input');
                this.$C_1.className = 'ms-cui-spn-txtbx';
                this.$C_1.id = this.$6_0;
                this.$C_1.setAttribute('role', 'textbox');
                CUI.Utility.$1i(this.get_$1_1(), this.$C_1);
                CUI.Utility.$7p(this.$C_1, (this.get_$1_1()).ImeEnabled);
                this.$2A_1 = CUI.Utility.$3('span');
                this.$2A_1.className = 'ms-cui-spn-arwbx';
                this.$d_1 = CUI.Utility.$3('a');
                this.$d_1.className = 'ms-cui-spn-btnup';
                this.$d_1.setAttribute('role', 'spinbutton');
                this.$c_1 = CUI.Utility.$3('a');
                this.$c_1.className = 'ms-cui-spn-btndown';
                this.$c_1.setAttribute('role', 'spinbutton');
                this.$4k_1 = CUI.Utility.$3('img');
                this.$4k_1.alt = '';
                this.$3t_1 = CUI.Utility.$j(2, 1, this.$0_0.$5_1.ImageUpArrow, this.$0_0.$5_1.ImageUpArrowClass, this.$4k_1, true, false, this.$0_0.$5_1.ImageUpArrowTop, this.$0_0.$5_1.ImageUpArrowLeft);
                CUI.Utility.ensureCSSClassOnElement(this.$3t_1, 'ms-cui-spn-imgcnt');
                if (!CUI.ScriptUtility.isNullOrUndefined(this.get_$1_1().AltUpArrow)) {
                    this.$d_1.title = this.get_$1_1().AltUpArrow;
                }
                this.$4G_1 = CUI.Utility.$3('img');
                this.$4G_1.alt = '';
                this.$3V_1 = CUI.Utility.$j(2, 1, this.$0_0.$5_1.ImageDownArrow, this.$0_0.$5_1.ImageDownArrowClass, this.$4G_1, true, false, this.$0_0.$5_1.ImageDownArrowTop, this.$0_0.$5_1.ImageDownArrowLeft);
                CUI.Utility.ensureCSSClassOnElement(this.$3V_1, 'ms-cui-spn-imgcnt');
                if (!CUI.ScriptUtility.isNullOrUndefined(this.get_$1_1().AltDownArrow)) {
                    this.$c_1.title = this.get_$1_1().AltDownArrow;
                }
                this.$O($p0);
                this.$E_1.appendChild(this.$C_1);
                this.$E_1.appendChild(this.$2A_1);
                this.$2A_1.appendChild(this.$d_1);
                this.$2A_1.appendChild(this.$c_1);
                this.$d_1.appendChild(this.$3t_1);
                this.$c_1.appendChild(this.$3V_1);
                return this.$E_1;
            default:
                this.ensureValidDisplayMode($p0);
                return null;
        }
    },
    
    $E2_1: function() {ULSpEN:;
        this.$E8_1(parseFloat(this.get_$1_1().DefaultValue));
        this.$5D_1 = parseInt(this.get_$1_1().AccelerationInterval);
        this.$9X_1 = parseInt(this.get_$1_1().MultiplierInterval);
        this.$5F_1 = this.get_$1_1().Command;
    },
    
    $35: function($p0) {
        var $v_0 = $get(this.$6_0 + '-' + $p0);
        this.storeElementForDisplayMode($v_0, $p0);
        switch ($p0) {
            case 'Medium':
                this.$E_1 = $v_0;
                this.$C_1 = this.$E_1.childNodes[0];
                this.$2A_1 = this.$E_1.childNodes[1];
                this.$d_1 = this.$2A_1.childNodes[0];
                this.$c_1 = this.$2A_1.childNodes[1];
                this.$3t_1 = this.$d_1.childNodes[0];
                this.$3V_1 = this.$c_1.childNodes[0];
                this.$4k_1 = this.$3t_1.childNodes[0];
                this.$4G_1 = this.$3V_1.childNodes[0];
                break;
        }
    },
    
    $O: function($p0) {
        switch ($p0) {
            case 'Medium':
                this.$N_1();
                this.$E2_1();
                break;
        }
    },
    
    $N_1: function() {ULSpEN:;
        $addHandler(this.$C_1, 'focus', this.$3L);
        $addHandler(this.$C_1, 'blur', this.$2m);
        $addHandler(this.$C_1, 'change', this.$8C);
        $addHandler(this.$C_1, 'mouseover', this.$8I);
        $addHandler(this.$C_1, 'mouseout', this.$95);
        $addHandler(this.$C_1, 'keypress', this.$56);
        $addHandler(this.$C_1, 'keydown', this.$8P);
        $addHandler(this.$C_1, 'keyup', this.$8U);
        $addHandler(this.$d_1, 'mouseover', this.$8K);
        $addHandler(this.$d_1, 'mouseout', this.$97);
        $addHandler(this.$d_1, 'mousedown', this.$8l);
        $addHandler(this.$d_1, 'mouseup', this.$8r);
        $addHandler(this.$c_1, 'mouseover', this.$8J);
        $addHandler(this.$c_1, 'mouseout', this.$96);
        $addHandler(this.$c_1, 'mousedown', this.$8k);
        $addHandler(this.$c_1, 'mouseup', this.$8q);
    },
    
    get_$15: function() {ULSpEN:;
        return 'Spinner';
    },
    
    onEnabledChanged: function($p0) {
        CUI.Utility.setEnabledOnElement(this.$C_1, $p0);
    },
    
    $7o: function() {ULSpEN:;
        if (!this.get_enabled()) {
            return false;
        }
        this.$C_1.focus();
        return true;
    },
    
    $42_1: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled()) {
            return;
        }
        this.$0_0.set_$o(this);
        this.$Aj_1($p0);
        CUI.Utility.$7i(this.$C_1);
    },
    
    $4u_1: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled()) {
            return;
        }
        if (this.$2x_1) {
            this.$46_1();
        }
        this.$Aj_1($p0);
    },
    
    $3i_1: false,
    
    $Aj_1: function($p0) {
        this.$3i_1 = !this.$3i_1;
        if (this.$3i_1) {
            this.$5v_1($p0);
        }
        else {
            this.$5y_1($p0);
        }
    },
    
    $7Y_1: function($p0) {
        this.$X();
        if (!this.get_enabled()) {
            return;
        }
        if (!this.$EJ_1()) {
            this.$4z_1();
            return;
        }
        var $v_0 = 1;
        this.get_stateProperties()['ChangeType'] = 'manual';
        this.get_stateProperties()['ChangedByMouse'] = false;
        this.get_displayedComponent().raiseCommandEvent(this.$5F_1, $v_0, this.get_stateProperties());
    },
    
    $C7: function() {ULSpEN:;
        this.$7Y_1(null);
    },
    
    $5v_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        CUI.Utility.ensureCSSClassOnElement(this.$C_1, 'ms-cui-spn-txtbx-hover');
        CUI.Utility.ensureCSSClassOnElement(this.$d_1, 'ms-cui-spn-btnup-ctl-hover');
        CUI.Utility.ensureCSSClassOnElement(this.$c_1, 'ms-cui-spn-btndown-ctl-hover');
    },
    
    $5y_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        if (!this.$3i_1) {
            CUI.Utility.removeCSSClassFromElement(this.$C_1, 'ms-cui-spn-txtbx-hover');
            CUI.Utility.removeCSSClassFromElement(this.$d_1, 'ms-cui-spn-btnup-ctl-hover');
            CUI.Utility.removeCSSClassFromElement(this.$c_1, 'ms-cui-spn-btndown-ctl-hover');
            CUI.Utility.removeCSSClassFromElement(this.$d_1, 'ms-cui-spn-btnup-down');
            CUI.Utility.removeCSSClassFromElement(this.$c_1, 'ms-cui-spn-btndown-down');
        }
    },
    
    $DF_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        this.$5v_1($p0);
        CUI.Utility.removeCSSClassFromElement(this.$d_1, 'ms-cui-spn-btnup-ctl-hover');
        CUI.Utility.ensureCSSClassOnElement(this.$d_1, 'ms-cui-spn-btnup-hover');
    },
    
    $Dj_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        if (!this.$2x_1) {
            this.$Au_1($p0);
        }
        this.$5y_1($p0);
        if (this.$3i_1) {
            CUI.Utility.ensureCSSClassOnElement(this.$d_1, 'ms-cui-spn-btnup-ctl-hover');
        }
        CUI.Utility.removeCSSClassFromElement(this.$d_1, 'ms-cui-spn-btnup-hover');
    },
    
    $DV_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        this.$3R_1 = true;
        if ($p0.button) {
            this.$46_1();
            return;
        }
        this.$63_1(1);
        CUI.Utility.ensureCSSClassOnElement(this.$d_1, 'ms-cui-spn-btnup-down');
    },
    
    $Au_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        this.$46_1();
        this.$0_0.set_$o(this);
        CUI.Utility.removeCSSClassFromElement(this.$d_1, 'ms-cui-spn-btnup-down');
    },
    
    $Af_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        if (!this.$3E_1(this.$n_1, this.$1d_1 + $p0 * this.$n_1.$6x_0)) {
            if (this.$1d_1 < this.$n_1.$4b_0) {
                this.$3E_1(this.$n_1, this.$n_1.$4b_0);
            }
            else {
                this.$4z_1();
                return;
            }
        }
        var $v_0 = 9;
        this.get_stateProperties()['ChangeType'] = 'increase';
        this.get_stateProperties()['ChangedByMouse'] = this.$3R_1;
        this.get_displayedComponent().raiseCommandEvent(this.$5F_1, $v_0, this.get_stateProperties());
    },
    
    $DE_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        this.$5v_1($p0);
        CUI.Utility.removeCSSClassFromElement(this.$c_1, 'ms-cui-spn-btndown-ctl-hover');
        CUI.Utility.ensureCSSClassOnElement(this.$c_1, 'ms-cui-spn-btndown-hover');
    },
    
    $Di_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        if (!this.$2x_1) {
            this.$At_1($p0);
        }
        this.$5y_1($p0);
        if (this.$3i_1) {
            CUI.Utility.ensureCSSClassOnElement(this.$c_1, 'ms-cui-spn-btndown-ctl-hover');
        }
        CUI.Utility.removeCSSClassFromElement(this.$c_1, 'ms-cui-spn-btndown-hover');
    },
    
    $DU_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        this.$3R_1 = true;
        if ($p0.button) {
            this.$46_1();
            return;
        }
        this.$63_1(CUI.Controls.Spinner.$7C_1);
        CUI.Utility.ensureCSSClassOnElement(this.$c_1, 'ms-cui-spn-btndown-down');
    },
    
    $At_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        this.$46_1();
        this.$0_0.set_$o(this);
        CUI.Utility.removeCSSClassFromElement(this.$c_1, 'ms-cui-spn-btndown-down');
    },
    
    $A9_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        if (!this.$3E_1(this.$n_1, this.$1d_1 - $p0 * this.$n_1.$6x_0)) {
            if (this.$1d_1 > this.$n_1.$4d_0) {
                this.$3E_1(this.$n_1, this.$n_1.$4d_0);
            }
            else {
                this.$4z_1();
                return;
            }
        }
        var $v_0 = 9;
        this.get_stateProperties()['ChangeType'] = 'decrease';
        this.get_stateProperties()['ChangedByMouse'] = this.$3R_1;
        this.get_displayedComponent().raiseCommandEvent(this.$5F_1, $v_0, this.get_stateProperties());
    },
    
    $Aq_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        this.$3R_1 = false;
        var $v_0 = $p0.rawEvent.keyCode;
        if ($v_0 === 27) {
            this.$4z_1();
        }
        else if ($v_0 === 13) {
            this.$7Y_1($p0);
            $p0.preventDefault();
        }
        else {
            return;
        }
    },
    
    $2x_1: false,
    
    $DH_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        if (this.$2x_1) {
            return;
        }
        this.$3R_1 = false;
        var $v_0 = $p0.rawEvent.keyCode;
        if ($v_0 === 38) {
            this.$63_1(1);
            CUI.Utility.ensureCSSClassOnElement(this.$d_1, 'ms-cui-spn-btnup-down');
        }
        else if ($v_0 === 40) {
            this.$63_1(CUI.Controls.Spinner.$7C_1);
            CUI.Utility.ensureCSSClassOnElement(this.$c_1, 'ms-cui-spn-btndown-down');
        }
        else {
            return;
        }
        this.$2x_1 = true;
    },
    
    $DL_1: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        if (!this.$2x_1) {
            return;
        }
        this.$46_1();
        CUI.Utility.removeCSSClassFromElement(this.$d_1, 'ms-cui-spn-btnup-down');
        CUI.Utility.removeCSSClassFromElement(this.$c_1, 'ms-cui-spn-btndown-down');
        this.$2x_1 = false;
    },
    
    $BU_1: function() {ULSpEN:;
        this.$4B_1++;
        this.$Af_1(this.$AK_1());
    },
    
    $BT_1: function() {ULSpEN:;
        this.$4B_1++;
        this.$A9_1(this.$AK_1());
    },
    
    $63_1: function($p0) {
        if (this.$2Z_1 > -1 || this.$3r_1 > -1) {
            return;
        }
        if ($p0 === 1) {
            this.$Af_1(1);
        }
        else {
            this.$A9_1(1);
        }
        if ($p0 === 1) {
            this.$3r_1 = window.setTimeout(this.$9B, 500);
        }
        else {
            this.$3r_1 = window.setTimeout(this.$9A, 500);
        }
    },
    
    $46_1: function() {ULSpEN:;
        if (this.$3r_1 > -1) {
            window.clearTimeout(this.$3r_1);
            this.$3r_1 = -1;
        }
        if (this.$2Z_1 > -1) {
            window.clearInterval(this.$2Z_1);
            this.$2Z_1 = -1;
            this.$3k_1 = 1;
            this.$4B_1 = 0;
        }
    },
    
    $ED_1: function() {ULSpEN:;
        if (this.$2Z_1 !== -1) {
            return;
        }
        this.$2Z_1 = window.setInterval(this.$7v, this.$5D_1);
    },
    
    $EC_1: function() {ULSpEN:;
        if (this.$2Z_1 !== -1) {
            return;
        }
        this.$2Z_1 = window.setInterval(this.$7u, this.$5D_1);
    },
    
    $AK_1: function() {ULSpEN:;
        var $v_0 = this.$4B_1 * this.$5D_1;
        if ($v_0 >= this.$3k_1 * this.$9X_1 && this.$3k_1 <= 3) {
            this.$3k_1++;
        }
        return this.$3k_1;
    },
    
    $E8_1: function($p0) {
        this.$1d_1 = $p0;
        this.$C_1.value = this.$7J_1($p0, this.$n_1.get_$5m());
        this.get_stateProperties()['Value'] = this.$1d_1;
    },
    
    get_value: function() {ULSpEN:;
        return this.$1d_1;
    },
    set_value: function($p0) {
        if (!this.$3E_1(this.$n_1, $p0)) {
            throw Error.create('Invalid value');
        }
        return $p0;
    },
    
    get_unitString: function() {ULSpEN:;
        return this.$n_1.get_$5m();
    },
    set_unitString: function($p0) {
        if (!this.$BJ_1(this.$1d_1.toString() + $p0)) {
            this.$4z_1();
            throw Error.create('Invalid unit');
        }
        return $p0;
    },
    
    $9R_1: false,
    $9Q_1: false,
    
    get_$7W_1: function() {ULSpEN:;
        if (!this.$9R_1) {
            var $v_0 = 1.1;
            var $v_1 = $v_0.toLocaleString().substring(1, 2);
            this.$9Q_1 = $v_1 === ',';
            this.$9R_1 = true;
        }
        return this.$9Q_1;
    },
    
    $EJ_1: function() {ULSpEN:;
        var $v_0 = this.$C_1.value;
        return this.$BJ_1($v_0);
    },
    
    $BJ_1: function($p0) {
        var $v_0 = '(\\-)?[0-9]*[\\.,]?[0-9]+';
        var $v_1 = new RegExp($v_0);
        $p0 = $p0.trim();
        if ($p0.search($v_1)) {
            return false;
        }
        var $v_2 = $p0.replace($v_1, '');
        var $v_3 = $p0.replace($v_2, '');
        var $v_4 = $v_2.trim();
        var $v_5;
        var $v_6;
        var $v_7 = false;
        if (this.get_$7W_1()) {
            $v_3 = $v_3.replace('.', '');
            if ($v_3.indexOf(',') > -1) {
                $v_7 = true;
                $v_3 = $v_3.replace(',', '.');
            }
        }
        else {
            $v_3 = $v_3.replace(',', '');
        }
        $v_6 = parseFloat($v_3);
        if (!CUI.ScriptUtility.isNullOrEmptyString($v_4)) {
            if (this.$n_1.$78($v_4)) {
                $v_5 = this.$n_1;
            }
            else {
                $v_5 = this.$Cn_1($v_4);
            }
        }
        else {
            $v_5 = this.$n_1;
        }
        return this.$3E_1($v_5, $v_6, $v_7);
    },
    
    $3E_1: function($p0, $p1, $p2) {
        if (arguments.length < 3) {
            $p2 = this.get_$7W_1();
        }
        if (!$p0) {
            return false;
        }
        var $v_0 = $p0.$EK($p1);
        if ($v_0 === CUI.Unit.$7V) {
            return false;
        }
        else if ($v_0 === 1) {
            $p1 = CUI.Controls.Spinner.$Co_1($p1, $p0);
        }
        else if ($v_0 === 2) {
            $p1 = $p0.$4d_0;
        }
        else if ($v_0 === 3) {
            $p1 = $p0.$4b_0;
        }
        this.$C_1.value = this.$7J_1($p1, $p0.get_$5m(), $p2);
        this.$n_1 = $p0;
        this.$1d_1 = $p1;
        this.$9l_1 = $p2;
        this.get_stateProperties()['Unit'] = $p0.$5Z_0;
        this.get_stateProperties()['Value'] = $p1;
        return true;
    },
    
    $4z_1: function() {ULSpEN:;
        this.$C_1.value = this.$7J_1(this.$1d_1, this.$n_1.get_$5m(), this.$9l_1);
    },
    
    $7J_1: function($p0, $p1, $p2) {
        if (arguments.length < 3) {
            $p2 = this.get_$7W_1();
        }
        var $v_0 = $p0.toString();
        if ($p2) {
            $v_0 = $v_0.replace('.', ',');
        }
        return $v_0 + ' ' + $p1;
    },
    
    $Cn_1: function($p0) {
        for (var $v_0 = 0; $v_0 < this.$2N_1.length; $v_0++) {
            if (this.$2N_1[$v_0].$78($p0)) {
                return this.$2N_1[$v_0];
            }
        }
        return null;
    },
    
    $AG_1: function($p0) {
        for (var $v_0 = 0; $v_0 < this.$2N_1.length; $v_0++) {
            if (this.$2N_1[$v_0].$5Z_0 === $p0) {
                return this.$2N_1[$v_0];
            }
            if (this.$2N_1[$v_0].$78($p0)) {
                return this.$2N_1[$v_0];
            }
        }
        return null;
    },
    
    $4y: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$E_1)) {
            return;
        }
        var $v_0 = this.pollForStateAndUpdateInternal(this.get_$1_1().Command, this.get_$1_1().QueryCommand, this.get_stateProperties(), true);
        var $v_1 = this.$AG_1(this.get_stateProperties()['Unit']);
        if (!this.$3E_1($v_1, this.get_stateProperties()['Value'])) {
            throw Error.create('Invalid valid and/or unit returned when polling');
        }
    },
    
    dispose: function() {ULSpEN:;
        CUI.Controls.Spinner.callBaseMethod(this, 'dispose');
        this.$4G_1 = null;
        this.$3V_1 = null;
        this.$4k_1 = null;
        this.$3t_1 = null;
        this.$E_1 = null;
        this.$2A_1 = null;
        this.$c_1 = null;
        this.$C_1 = null;
        this.$d_1 = null;
    },
    
    get_$1_1: function() {ULSpEN:;
        return this.$5_0;
    }
}


CUI.Controls.SplitButton = function(root, id, properties, menu) {ULSpEN:;
    this.$8b = Function.createDelegate(this, this.onMenuButtonKeyPress);
    this.$8W = Function.createDelegate(this, this.onMenuButtonABlur);
    this.$8a = Function.createDelegate(this, this.onMenuButtonKeyboardFocus);
    this.$8X = Function.createDelegate(this, this.onMenuButtonBlur);
    this.$8Z = Function.createDelegate(this, this.onMenuButtonFocus);
    this.$8Y = Function.createDelegate(this, this.onMenuButtonClick);
    this.$89 = Function.createDelegate(this, this.onButtonKeyboardFocus);
    this.$66 = Function.createDelegate(this, this.onButtonBlur);
    this.$88 = Function.createDelegate(this, this.onButtonFocus);
    this.$8o = Function.createDelegate(this, this.onMouseOut);
    this.$8p = Function.createDelegate(this, this.onMouseOver);
    this.$3J = Function.createDelegate(this, this.onDblClick);
    this.$87 = Function.createDelegate(this, this.onButtonClick);
    CUI.Controls.SplitButton.initializeBase(this, [ root, id, properties, menu ]);
    this.addDisplayMode('Large');
    this.addDisplayMode('Medium');
    this.addDisplayMode('Small');
}
CUI.Controls.SplitButton.prototype = {
    $F_2: null,
    $9I_2: null,
    $4N_2: null,
    $3Y_2: null,
    $1v_2: null,
    $8_2: null,
    $9K_2: null,
    $4O_2: null,
    $3Z_2: null,
    $2E_2: null,
    $9_2: null,
    $9M_2: null,
    $4R_2: null,
    $3c_2: null,
    $2G_2: null,
    
    createDOMElementForDisplayMode: function($p0) {
        var $v_0 = (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_2().Alt)) ? this.get_$1_2().LabelText : this.get_$1_2().Alt;
        var $v_1 = (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_2().MenuAlt)) ? $v_0 : this.get_$1_2().MenuAlt;
        this.$7B_2 = $p0;
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            $v_0 = '';
        }
        if (CUI.ScriptUtility.isNullOrUndefined($v_1)) {
            $v_1 = '';
        }
        switch ($p0) {
            case 'Large':
                this.$F_2 = CUI.Control.createTwoAnchorControlDOMElementCore(this, this.$0_0, 'Large', this.get_$1_2().Id, this.get_$1_2().Image32by32, this.get_$1_2().Image32by32Class, this.get_$1_2().Image32by32Top, this.get_$1_2().Image32by32Left, this.get_$1_2().Image16by16, this.get_$1_2().Image16by16Class, this.get_$1_2().Image16by16Top, this.get_$1_2().Image16by16Left, this.get_$1_2().LabelText, this.get_$1_2().Alt, this.get_$1_2().ToolTipTitle, true);
                this.$35('Large');
                this.$O($p0);
                return this.$F_2;
            case 'Medium':
                this.$8_2 = CUI.Control.createTwoAnchorControlDOMElementCore(this, this.$0_0, 'Medium', this.get_$1_2().Id, this.get_$1_2().Image32by32, this.get_$1_2().Image32by32Class, this.get_$1_2().Image32by32Top, this.get_$1_2().Image32by32Left, this.get_$1_2().Image16by16, this.get_$1_2().Image16by16Class, this.get_$1_2().Image16by16Top, this.get_$1_2().Image16by16Left, this.get_$1_2().LabelText, this.get_$1_2().Alt, this.get_$1_2().ToolTipTitle, true);
                this.$35('Medium');
                this.$O($p0);
                return this.$8_2;
            case 'Small':
                this.$9_2 = CUI.Control.createTwoAnchorControlDOMElementCore(this, this.$0_0, 'Small', this.get_$1_2().Id, this.get_$1_2().Image32by32, this.get_$1_2().Image32by32Class, this.get_$1_2().Image32by32Top, this.get_$1_2().Image32by32Left, this.get_$1_2().Image16by16, this.get_$1_2().Image16by16Class, this.get_$1_2().Image16by16Top, this.get_$1_2().Image16by16Left, this.get_$1_2().LabelText, this.get_$1_2().Alt, this.get_$1_2().ToolTipTitle, true);
                this.$35('Small');
                this.$O($p0);
                return this.$9_2;
            default:
                this.ensureValidDisplayMode($p0);
                return null;
        }
    },
    
    $7B_2: null,
    
    $35: function($p0) {
        var $v_0 = $get(this.$6_0 + '-' + $p0);
        this.storeElementForDisplayMode($v_0, $p0);
        this.$7B_2 = $p0;
        switch ($p0) {
            case 'Large':
                if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
                    this.$F_2 = $v_0;
                }
                this.$4N_2 = this.$F_2.childNodes[0];
                this.$9I_2 = this.$4N_2.childNodes[0].childNodes[0];
                this.$3Y_2 = this.$F_2.childNodes[1];
                var $v_1 = this.$3Y_2.childNodes[0];
                this.$1v_2 = null;
                for (var $v_2 = 0; $v_2 < $v_1.childNodes.length; $v_2++) {
                    var $v_3 = $v_1.childNodes[$v_2].tagName;
                    if (!CUI.ScriptUtility.isNullOrUndefined($v_3) && $v_3.toLowerCase() === 'span') {
                        this.$1v_2 = $v_1.childNodes[$v_2].childNodes[0];
                        break;
                    }
                }
                break;
            case 'Medium':
                if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
                    this.$8_2 = $v_0;
                }
                this.$4O_2 = this.$8_2.childNodes[0];
                this.$9K_2 = this.$4O_2.childNodes[0].childNodes[0];
                this.$3Z_2 = this.$8_2.childNodes[1];
                this.$2E_2 = this.$3Z_2.childNodes[0].childNodes[0].childNodes[0];
                break;
            case 'Small':
                if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
                    this.$9_2 = $v_0;
                }
                this.$4R_2 = this.$9_2.childNodes[0];
                this.$9M_2 = this.$4R_2.childNodes[0].childNodes[0];
                this.$3c_2 = this.$9_2.childNodes[1];
                this.$2G_2 = this.$3c_2.childNodes[0].childNodes[0].childNodes[0];
                break;
        }
    },
    
    $O: function($p0) {
        this.$N_2($p0);
    },
    
    $N_2: function($p0) {
        var $v_0 = null;
        var $v_1 = null;
        switch ($p0) {
            case 'Large':
                $v_0 = this.$4N_2;
                $v_1 = this.$3Y_2;
                break;
            case 'Medium':
                $v_0 = this.$4O_2;
                $v_1 = this.$3Z_2;
                break;
            case 'Small':
                $v_0 = this.$4R_2;
                $v_1 = this.$3c_2;
                break;
        }
        $addHandler($v_0, 'click', this.$87);
        $addHandler($v_0, 'dblclick', this.$3J);
        $addHandler($v_0, 'mouseover', this.$8p);
        $addHandler($v_0, 'mouseout', this.$8o);
        $addHandler($v_0, 'mouseover', this.$88);
        $addHandler($v_0, 'mouseout', this.$66);
        $addHandler($v_0, 'focus', this.$89);
        $addHandler($v_0, 'blur', this.$66);
        $addHandler($v_1, 'click', this.$8Y);
        $addHandler($v_1, 'mouseover', this.$8Z);
        $addHandler($v_1, 'mouseout', this.$8X);
        $addHandler($v_1, 'focus', this.$8a);
        $addHandler($v_1, 'blur', this.$8W);
        $addHandler($v_1, 'keypress', this.$8b);
    },
    
    $4r_2: false,
    
    $7o: function() {ULSpEN:;
        if (!this.get_enabled()) {
            return false;
        }
        var $v_0 = this.get_displayedComponent().get_$2();
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            if (this.$4r_2 || !this.$1V_2) {
                $v_0 = $v_0.childNodes[1];
            }
            else {
                $v_0 = $v_0.childNodes[0];
            }
            $v_0.focus();
            return true;
        }
        return false;
    },
    
    onEnabledChanged: function($p0) {
        this.onEnabledChangedForControl($p0);
        this.onEnabledChangedForButton($p0);
        this.onEnabledChangedForMenu($p0);
    },
    
    get_$15: function() {ULSpEN:;
        return 'SplitButton';
    },
    
    onEnabledChangedForControl: function($p0) {
        var $v_0 = 'ms-cui-disabled';
        if ($p0) {
            CUI.Utility.removeCSSClassFromElement(this.$F_2, $v_0);
            CUI.Utility.removeCSSClassFromElement(this.$8_2, $v_0);
            CUI.Utility.removeCSSClassFromElement(this.$9_2, $v_0);
        }
        else {
            CUI.Utility.ensureCSSClassOnElement(this.$F_2, $v_0);
            CUI.Utility.ensureCSSClassOnElement(this.$8_2, $v_0);
            CUI.Utility.ensureCSSClassOnElement(this.$9_2, $v_0);
        }
    },
    
    $20_2: true,
    
    onEnabledChangedForMenu: function($p0) {
        CUI.Utility.setEnabledOnElement(this.$3Y_2, $p0);
        CUI.Utility.setEnabledOnElement(this.$3Z_2, $p0);
        CUI.Utility.setEnabledOnElement(this.$3c_2, $p0);
        this.$7f_2();
        this.$20_2 = $p0;
    },
    
    $E7_2: function($p0) {
        CUI.Utility.setEnabledOnElement(this.$3Y_2, $p0);
        CUI.Utility.setEnabledOnElement(this.$3Z_2, $p0);
        CUI.Utility.setEnabledOnElement(this.$3c_2, $p0);
    },
    
    $1V_2: false,
    
    onEnabledChangedForButton: function($p0) {
        CUI.Utility.setEnabledOnElement(this.$4N_2, $p0);
        CUI.Utility.setEnabledOnElement(this.$4O_2, $p0);
        CUI.Utility.setEnabledOnElement(this.$4R_2, $p0);
        this.$7e_2();
        this.$1V_2 = $p0;
    },
    
    onButtonClick: function($p0) {
        $p0.preventDefault();
        this.$X();
        if (!this.get_enabled() || !this.$1V_2) {
            return;
        }
        this.$0_0.set_$3z(this);
        this.$4r_2 = false;
        var $v_0 = this.get_stateProperties();
        $v_0['CommandValueId'] = this.get_$1_2().CommandValueId;
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_2().Command, 1, $v_0);
    },
    
    onDblClick: function($p0) {
        $p0.preventDefault();
        this.$X();
        if (!this.get_enabled()) {
            return;
        }
        this.onButtonClick($p0);
    },
    
    onMouseOver: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled() || !this.$1V_2) {
            return;
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_2().CommandPreview)) {
            return;
        }
        var $v_0 = this.get_stateProperties();
        $v_0['CommandValueId'] = this.get_$1_2().CommandValueId;
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_2().CommandPreview, 5, $v_0);
    },
    
    onButtonKeyboardFocus: function($p0) {
        this.$0_0.set_$o(this);
        this.$4r_2 = false;
        this.onButtonFocus($p0);
    },
    
    onButtonFocus: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled() || !this.$1V_2) {
            return;
        }
        this.$D3_2();
    },
    
    onMouseOut: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled()) {
            return;
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_2().CommandRevert)) {
            return;
        }
        var $v_0 = this.get_stateProperties();
        $v_0['CommandValueId'] = this.get_$1_2().CommandValueId;
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_2().CommandRevert, 6, $v_0);
    },
    
    onButtonBlur: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled() || !this.$1V_2) {
            return;
        }
        this.$7e_2();
    },
    
    onMenuButtonClick: function($p0) {
        $p0.preventDefault();
        this.$X();
        if (!this.get_enabled() || !this.$20_2) {
            return;
        }
        this.$0_0.$2v_1 = false;
        this.$0_0.set_$3z(this);
        this.$4r_2 = true;
        var $v_0 = $p0.target;
        this.launchMenu($v_0);
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_2().CommandMenuOpen, 4, null);
    },
    
    onMenuButtonKeyboardFocus: function($p0) {
        this.onMenuButtonFocus($p0);
        this.$4r_2 = true;
        this.$0_0.set_$o(this);
    },
    
    onMenuButtonFocus: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled() || !this.$20_2) {
            return;
        }
        this.$D4_2();
    },
    
    onMenuButtonBlur: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled() || this.$i_1 || !this.$20_2) {
            return;
        }
        this.$7f_2();
    },
    
    onMenuButtonABlur: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled() || !this.$20_2) {
            return;
        }
        this.onMenuButtonBlur($p0);
    },
    
    onMenuButtonKeyPress: function($p0) {
        this.$X();
        if (!this.get_enabled() || !this.$20_2) {
            return;
        }
        if ($p0.rawEvent.keyCode === 13) {
            this.$1E_1 = true;
        }
    },
    
    onLaunchedMenuClosed: function() {ULSpEN:;
        this.$X();
        this.$1U_2();
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_2().CommandMenuClose, 10, null);
        CUI.Controls.SplitButton.callBaseMethod(this, 'onLaunchedMenuClosed');
    },
    
    $1U_2: function() {ULSpEN:;
        this.$7e_2();
        this.$7f_2();
    },
    
    $7e_2: function() {ULSpEN:;
        var $v_0 = this.$5p();
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return;
        }
        CUI.Utility.removeCSSClassFromElement($v_0.childNodes[1], 'ms-cui-ctl-split-hover');
        CUI.Utility.removeCSSClassFromElement($v_0.childNodes[0], 'ms-cui-ctl-light-hoveredOver');
    },
    
    $D3_2: function() {ULSpEN:;
        var $v_0 = this.$5p();
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return;
        }
        CUI.Utility.ensureCSSClassOnElement($v_0.childNodes[1], 'ms-cui-ctl-split-hover');
        CUI.Utility.ensureCSSClassOnElement($v_0.childNodes[0], 'ms-cui-ctl-light-hoveredOver');
    },
    
    $7f_2: function() {ULSpEN:;
        var $v_0 = this.$5p();
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return;
        }
        CUI.Utility.removeCSSClassFromElement($v_0.childNodes[0], 'ms-cui-ctl-split-hover');
        CUI.Utility.removeCSSClassFromElement($v_0.childNodes[1], 'ms-cui-ctl-light-hoveredOver');
    },
    
    $D4_2: function() {ULSpEN:;
        var $v_0 = this.$5p();
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return;
        }
        CUI.Utility.ensureCSSClassOnElement($v_0.childNodes[0], 'ms-cui-ctl-split-hover');
        CUI.Utility.ensureCSSClassOnElement($v_0.childNodes[1], 'ms-cui-ctl-light-hoveredOver');
    },
    
    $4y: function() {ULSpEN:;
        var $v_0 = this.$0_0.$4w(this.get_$1_2().Command, null, null);
        var $v_1 = true;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.get_$1_2().CommandMenuOpen)) {
            $v_1 = this.$0_0.$4w(this.get_$1_2().CommandMenuOpen, null, null);
        }
        else {
            $v_1 = $v_0;
        }
        if ($v_1 !== this.$20_2 || $v_0 !== this.$1V_2) {
            this.$1Q_0 = $v_1 || $v_0;
            var $v_2 = this.$20_2 && this.$1V_2;
            var $v_3 = $v_1 && $v_0;
            if ($v_2 !== $v_3) {
                this.onEnabledChangedForControl($v_3);
            }
            this.$E7_2(this.$1Q_0);
            if ($v_0 !== this.$1V_2) {
                this.onEnabledChangedForButton($v_0);
            }
            if ($v_1 !== this.$20_2) {
                this.onEnabledChangedForMenu($v_1);
            }
            this.$20_2 = $v_1;
            this.$1V_2 = $v_0;
        }
    },
    
    dispose: function() {ULSpEN:;
        CUI.Controls.SplitButton.callBaseMethod(this, 'dispose');
        this.$F_2 = null;
        this.$9I_2 = null;
        this.$4N_2 = null;
        this.$3Y_2 = null;
        this.$1v_2 = null;
        this.$8_2 = null;
        this.$9K_2 = null;
        this.$4O_2 = null;
        this.$3Z_2 = null;
        this.$2E_2 = null;
        this.$9_2 = null;
        this.$9M_2 = null;
        this.$4R_2 = null;
        this.$3c_2 = null;
        this.$2G_2 = null;
    },
    
    get_$1_2: function() {ULSpEN:;
        return this.$5_0;
    }
}


CUI.Controls.TextBoxCommandProperties = function() {
}


CUI.Controls.TextBox = function(root, id, properties) {ULSpEN:;
    this.$56 = Function.createDelegate(this, this.$Aq_1);
    this.$57 = Function.createDelegate(this, this.$5w_1);
    this.$58 = Function.createDelegate(this, this.$5x_1);
    this.$2m = Function.createDelegate(this, this.$4u_1);
    this.$3L = Function.createDelegate(this, this.$42_1);
    this.$8B = Function.createDelegate(this, this.$7X_1);
    CUI.Controls.TextBox.initializeBase(this, [ root, id, properties ]);
    this.addDisplayMode('Medium');
}
CUI.Controls.TextBox.prototype = {
    $C_1: null,
    
    get_value: function() {ULSpEN:;
        this.$7F_1();
        return this.$C_1.value;
    },
    set_value: function($p0) {
        this.$7F_1();
        if ($p0) {
            this.$C_1.value = $p0;
        }
        else {
            this.$C_1.value = '';
        }
        return $p0;
    },
    
    $7F_1: function() {ULSpEN:;
        if (!this.$C_1) {
            this.$C_1 = CUI.Utility.$7A('input');
            this.$C_1.type = 'text';
            CUI.Utility.$7p(this.$C_1, (this.get_$1_1()).ImeEnabled);
        }
    },
    
    createDOMElementForDisplayMode: function($p0) {
        switch ($p0) {
            case 'Medium':
                this.$7F_1();
                this.$C_1.id = this.$6_0;
                this.$C_1.setAttribute('mscui:controltype', this.get_$15());
                this.$C_1.setAttribute('role', this.get_$1e());
                CUI.Utility.$1i(this.get_$1_1(), this.$C_1);
                this.$C_1.className = 'ms-cui-tb';
                if (!CUI.ScriptUtility.isNullOrEmptyString(this.get_$1_1().MaxLength)) {
                    var $v_0 = parseInt(this.get_$1_1().MaxLength);
                    if ($v_0 !== Number.NaN) {
                        this.$C_1.setAttribute('maxlength', $v_0);
                    }
                }
                if (CUI.Utility.$v(this.get_$1_1().ShowAsLabel)) {
                    CUI.Utility.ensureCSSClassOnElement(this.$C_1, 'ms-cui-tb-labelmode');
                    this.$C_1.disabled = true;
                }
                if (!CUI.ScriptUtility.isNullOrUndefined(this.get_$1_1().Width)) {
                    this.$C_1.style.width = this.get_$1_1().Width;
                }
                this.$N_1();
                return this.$C_1;
            default:
                this.ensureValidDisplayMode($p0);
                return null;
        }
    },
    
    $35: function($p0) {
        var $v_0 = $get(this.$6_0);
        this.storeElementForDisplayMode($v_0, $p0);
        switch ($p0) {
            case 'Medium':
                this.$C_1 = $v_0;
                break;
        }
    },
    
    $O: function($p0) {
        this.$N_1();
    },
    
    $N_1: function() {ULSpEN:;
        $addHandler(this.$C_1, 'change', this.$8B);
        $addHandler(this.$C_1, 'focus', this.$3L);
        $addHandler(this.$C_1, 'blur', this.$2m);
        $addHandler(this.$C_1, 'mouseup', CUI.Utility.get_returnFalseHandler());
        $addHandler(this.$C_1, 'mouseover', this.$58);
        $addHandler(this.$C_1, 'mouseout', this.$57);
        $addHandler(this.$C_1, 'keypress', this.$56);
    },
    
    onEnabledChanged: function($p0) {
        if ($p0) {
            CUI.Utility.enableElement(this.$C_1);
        }
        else {
            CUI.Utility.disableElement(this.$C_1);
        }
    },
    
    get_$15: function() {ULSpEN:;
        return 'TextBox';
    },
    
    get_$1e: function() {ULSpEN:;
        return 'textbox';
    },
    
    $7X_1: function($p0) {
        this.$X();
        if (!this.get_enabled()) {
            return;
        }
        this.get_stateProperties()['Value'] = this.get_value();
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_1().Command, 1, this.get_stateProperties());
        if (this.$0_0.get_$4x()) {
            this.$4y();
        }
        else {
            this.$51_1(null);
        }
    },
    
    $C7: function() {ULSpEN:;
        this.$7X_1(null);
    },
    
    $51_1: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$C_1)) {
            if (!CUI.ScriptUtility.isNullOrUndefined($p0)) {
                this.set_value($p0);
            }
        }
    },
    
    $7o: function() {ULSpEN:;
        if (!this.get_enabled()) {
            return false;
        }
        this.$C_1.focus();
        return true;
    },
    
    $42_1: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled()) {
            return;
        }
        CUI.Utility.$7i(this.$C_1);
        this.$0_0.set_$o(this);
    },
    
    $4u_1: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled()) {
            return;
        }
    },
    
    $5x_1: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled()) {
            return;
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_1().CommandPreview)) {
            return;
        }
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_1().CommandPreview, 5, this.get_stateProperties());
    },
    
    $5w_1: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled()) {
            return;
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_1().CommandRevert)) {
            return;
        }
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_1().CommandRevert, 6, this.get_stateProperties());
    },
    
    $Aq_1: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined($p0) && !CUI.ScriptUtility.isNullOrUndefined($p0.rawEvent)) {
            if ($p0.rawEvent.keyCode === 13) {
                this.$7X_1($p0);
                $p0.preventDefault();
            }
        }
    },
    
    $4y: function() {ULSpEN:;
        var $v_0 = this.pollForStateAndUpdateInternal(this.get_$1_1().Command, this.get_$1_1().QueryCommand, this.get_stateProperties(), false);
        if ($v_0) {
            this.$51_1(this.get_stateProperties()['Value']);
        }
    },
    
    dispose: function() {ULSpEN:;
        CUI.Controls.TextBox.callBaseMethod(this, 'dispose');
        this.$C_1 = null;
    },
    
    get_$1_1: function() {ULSpEN:;
        return this.$5_0;
    }
}


CUI.Controls.ToggleButtonCommandProperties = function() {
}


CUI.Controls.ToggleButton = function(root, id, properties) {ULSpEN:;
    this.$8O = Function.createDelegate(this, this.$DG_1);
    this.$57 = Function.createDelegate(this, this.$5w_1);
    this.$58 = Function.createDelegate(this, this.$5x_1);
    this.$1H = Function.createDelegate(this, this.onClick);
    this.$2m = Function.createDelegate(this, this.$4u_1);
    this.$3L = Function.createDelegate(this, this.$42_1);
    CUI.Controls.ToggleButton.initializeBase(this, [ root, id, properties ]);
    this._id = id;
    this.addDisplayModes();
    this.get_stateProperties()['On'] = false;
}
CUI.Controls.ToggleButton.prototype = {
    _id: null,
    $F_1: null,
    $2J_1: null,
    $16_1: null,
    $9_1: null,
    $8_1: null,
    $h_1: null,
    $1a_1: null,
    $1w_1: null,
    $1u_1: null,
    $1X_1: null,
    
    get_on: function() {ULSpEN:;
        return this.get_stateProperties()['On'];
    },
    set_on: function($p0) {
        this.get_stateProperties()['On'] = $p0;
        this.setState($p0);
        return $p0;
    },
    
    createComponentForDisplayModeInternal: function($p0) {
        var $v_0;
        if ($p0.startsWith('Menu')) {
            $v_0 = this.$0_0.$3w(this.$6_0 + '-' + $p0 + this.$0_0.$27(), $p0, this);
            this.$2J_1 = this.get_$1_1().MenuItemId;
            this.$16_1 = this.get_$1_1().CommandValueId;
            if (CUI.ScriptUtility.isNullOrEmptyString(this.$16_1)) {
                this.$16_1 = this.$2J_1;
            }
        }
        else {
            $v_0 = CUI.Controls.ToggleButton.callBaseMethod(this, 'createComponentForDisplayModeInternal', [ $p0 ]);
        }
        return $v_0;
    },
    
    createDOMElementForDisplayMode: function($p0) {
        return this.$2g_1($p0, true);
    },
    
    $2g_1: function($p0, $p1) {
        switch ($p0) {
            case 'Large':
                this.$F_1 = CUI.Control.createStandardControlDOMElement(this, this.$0_0, 'Large', this.get_$1_1(), false, false);
                this.$35('Large');
                if ($p1) {
                    this.$O('Large');
                }
                return this.$F_1;
            case 'Medium':
                this.$8_1 = CUI.Control.createStandardControlDOMElement(this, this.$0_0, 'Medium', this.get_$1_1(), false, false);
                this.$35('Medium');
                if ($p1) {
                    this.$O('Medium');
                }
                return this.$8_1;
            case 'Small':
                this.$9_1 = CUI.Control.createStandardControlDOMElement(this, this.$0_0, 'Small', this.get_$1_1(), false, false);
                this.$35('Small');
                if ($p1) {
                    this.$O('Small');
                }
                return this.$9_1;
            case 'Menu':
                this.$h_1 = CUI.Control.createStandardControlDOMElement(this, this.$0_0, 'Menu', this.get_$1_1(), true, false);
                if ($p1) {
                    this.$O('Menu');
                }
                return this.$h_1;
            case 'Menu16':
                this.$1a_1 = CUI.Control.createStandardControlDOMElement(this, this.$0_0, 'Menu16', this.get_$1_1(), true, false);
                if ($p1) {
                    this.$O('Menu16');
                }
                return this.$1a_1;
            case 'Menu32':
                this.$1w_1 = CUI.Control.createStandardControlDOMElement(this, this.$0_0, 'Menu32', this.get_$1_1(), true, false);
                if ($p1) {
                    this.$O('Menu32');
                }
                return this.$1w_1;
            default:
                this.ensureValidDisplayMode($p0);
                return null;
        }
    },
    
    $7B_1: null,
    
    $35: function($p0) {
        this.$7B_1 = $p0;
        var $v_0 = $get(this.$6_0 + '-' + $p0);
        this.storeElementForDisplayMode($v_0, $p0);
        switch ($p0) {
            case 'Large':
                if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
                    this.$F_1 = $v_0;
                }
                break;
            case 'Medium':
                if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
                    this.$8_1 = $v_0;
                }
                break;
            case 'Small':
                if (!CUI.ScriptUtility.isNullOrUndefined($v_0)) {
                    this.$9_1 = $v_0;
                }
                break;
        }
    },
    
    $O: function($p0) {
        switch ($p0) {
            case 'Large':
                this.$N_1(this.$F_1, true);
                break;
            case 'Medium':
                this.$N_1(this.$8_1, true);
                break;
            case 'Small':
                this.$N_1(this.$9_1, true);
                break;
            case 'Menu32':
                this.$N_1(this.$1w_1, false);
                break;
            case 'Menu16':
                this.$N_1(this.$1a_1, false);
                break;
            case 'Menu':
                this.$N_1(this.$h_1, false);
                break;
        }
    },
    
    $N_1: function($p0, $p1) {
        if ($p1) {
            $addHandler($p0, 'mouseover', this.$3L);
            $addHandler($p0, 'mouseout', this.$2m);
        }
        $addHandler($p0, 'click', this.$1H);
        $addHandler($p0, 'mouseover', this.$58);
        $addHandler($p0, 'mouseout', this.$57);
        $addHandler($p0, 'focus', this.$8O);
        $addHandler($p0, 'blur', this.$2m);
    },
    
    $7o: function() {ULSpEN:;
        if (!this.get_enabled()) {
            return false;
        }
        var $v_0 = this.get_displayedComponent().get_$2();
        $v_0.focus();
        return true;
    },
    
    onEnabledChanged: function($p0) {
        CUI.Utility.setEnabledOnElement(this.$9_1, $p0);
        CUI.Utility.setEnabledOnElement(this.$8_1, $p0);
        CUI.Utility.setEnabledOnElement(this.$F_1, $p0);
        CUI.Utility.setEnabledOnElement(this.$h_1, $p0);
        CUI.Utility.setEnabledOnElement(this.$1a_1, $p0);
        CUI.Utility.setEnabledOnElement(this.$1w_1, $p0);
        if (this.get_on()) {
            if ($p0) {
                this.setState(true);
            }
            else {
                this.setState(false);
            }
        }
    },
    
    get_$15: function() {ULSpEN:;
        return 'ToggleButton';
    },
    
    onStateChanged: function() {ULSpEN:;
        this.setState(this.get_stateProperties()['On']);
    },
    
    getDropDownDOMElementForDisplayMode: function($p0) {
        var $v_0;
        switch ($p0) {
            case 'Menu16':
                $v_0 = this.$1u_1;
                break;
            case 'Text':
                $v_0 = this.$1X_1;
                break;
            default:
                $v_0 = CUI.Utility.$3('span');
                break;
        }
        if ($v_0) {
            return $v_0;
        }
        return this.$A2_1($p0);
    },
    
    $A2_1: function($p0) {
        switch ($p0) {
            case 'Menu':
                this.$1u_1 = this.$2g_1('Menu', false).cloneNode(true);
                return this.$1u_1;
            case 'Menu16':
                this.$1u_1 = this.$2g_1('Menu16', false).cloneNode(true);
                return this.$1u_1;
            case 'Text':
                var $v_0 = CUI.Utility.$3('a');
                CUI.Utility.$1s($v_0);
                this.$1X_1 = CUI.Utility.$3('span');
                this.$1X_1.className = 'ms-cui-textmenuitem';
                CUI.UIUtility.setInnerText($v_0, this.get_$1_1().LabelText);
                this.$1X_1.appendChild($v_0);
                return this.$1X_1;
            default:
                return CUI.Utility.$3('span');
        }
    },
    
    deselect: function() {
    },
    
    getMenuItemId: function() {ULSpEN:;
        return this.$2J_1;
    },
    
    getCommandValueId: function() {ULSpEN:;
        return this.$16_1;
    },
    
    focusOnDisplayedComponent: function() {ULSpEN:;
        this.receiveFocus();
    },
    
    getTextValue: function() {ULSpEN:;
        return this.get_$1_1().LabelText;
    },
    
    receiveFocus: function() {ULSpEN:;
        this.onBeginFocus();
        var $v_0 = this.get_displayedComponent();
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return;
        }
        ($v_0).set_$1G(true);
        if (!(CUI.ScriptUtility.isNullOrUndefined(this.$h_1))) {
            this.$h_1.focus();
        }
        if (!(CUI.ScriptUtility.isNullOrUndefined(this.$1a_1))) {
            this.$1a_1.focus();
        }
    },
    
    onMenuClosed: function() {ULSpEN:;
        this.$X();
    },
    
    onClick: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined(CUI.PMetrics)) {
            CUI.PMetrics.perfMark(7704);
        }
        this.$X();
        $p0.preventDefault();
        if (!this.get_enabled()) {
            return;
        }
        this.$0_0.set_$3z(this);
        var $v_0 = 1;
        var $v_1 = this.get_$1_1().CommandType;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_1) && $v_1 === 'OptionSelection') {
            $v_0 = 3;
            this.get_stateProperties()['CommandValueId'] = this.$16_1;
        }
        this.get_stateProperties()['On'] = !this.get_stateProperties()['On'];
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_1().Command, $v_0, this.get_stateProperties());
        if (this.$0_0.get_$4x()) {
            this.$4y();
        }
        else {
            this.setState(this.get_stateProperties()['On']);
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(CUI.PMetrics)) {
            CUI.PMetrics.perfMark(7705);
        }
    },
    
    setState: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$9_1)) {
            if ($p0) {
                CUI.Utility.ensureCSSClassOnElement(this.$9_1, 'ms-cui-ctl-on');
            }
            else {
                CUI.Utility.removeCSSClassFromElement(this.$9_1, 'ms-cui-ctl-on');
            }
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$8_1)) {
            if ($p0) {
                CUI.Utility.ensureCSSClassOnElement(this.$8_1, 'ms-cui-ctl-on');
            }
            else {
                CUI.Utility.removeCSSClassFromElement(this.$8_1, 'ms-cui-ctl-on');
            }
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$F_1)) {
            if ($p0) {
                CUI.Utility.ensureCSSClassOnElement(this.$F_1, 'ms-cui-ctl-on');
            }
            else {
                CUI.Utility.removeCSSClassFromElement(this.$F_1, 'ms-cui-ctl-on');
            }
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$1w_1)) {
            if ($p0) {
                CUI.Utility.ensureCSSClassOnElement(this.$1w_1, 'ms-cui-ctl-on');
            }
            else {
                CUI.Utility.removeCSSClassFromElement(this.$1w_1, 'ms-cui-ctl-on');
            }
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$h_1)) {
            if ($p0) {
                CUI.Utility.ensureCSSClassOnElement(this.$h_1, 'ms-cui-ctl-on');
            }
            else {
                CUI.Utility.removeCSSClassFromElement(this.$h_1, 'ms-cui-ctl-on');
            }
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$1a_1)) {
            if ($p0) {
                CUI.Utility.ensureCSSClassOnElement(this.$1a_1, 'ms-cui-ctl-on');
            }
            else {
                CUI.Utility.removeCSSClassFromElement(this.$1a_1, 'ms-cui-ctl-on');
            }
        }
    },
    
    $39_1: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$1w_1)) {
            CUI.Utility.removeCSSClassFromElement(this.$1w_1, 'ms-cui-ctl-disabledHoveredOver');
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$h_1)) {
            CUI.Utility.removeCSSClassFromElement(this.$h_1, 'ms-cui-ctl-disabledHoveredOver');
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$1a_1)) {
            CUI.Utility.removeCSSClassFromElement(this.$1a_1, 'ms-cui-ctl-disabledHoveredOver');
        }
    },
    
    $DG_1: function($p0) {
        this.$0_0.set_$o(this);
        this.$42_1($p0);
    },
    
    $42_1: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled()) {
            this.$39_1();
            return;
        }
        var $v_0 = this.get_displayedComponent();
        if (CUI.MenuItem.isInstanceOfType($v_0)) {
            ($v_0).set_$1G(true);
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_1().CommandPreview)) {
            return;
        }
        var $v_1 = 5;
        var $v_2 = this.get_$1_1().CommandType;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_2) && $v_2 === 'OptionSelection') {
            $v_1 = 7;
            this.get_stateProperties()['CommandValueId'] = this.$16_1;
        }
        $v_0.raiseCommandEvent(this.get_$1_1().CommandPreview, $v_1, this.get_stateProperties());
    },
    
    $5x_1: function($p0) {
        this.onBeginFocus();
        if (!this.get_enabled()) {
            return;
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_1().CommandPreview)) {
            return;
        }
        var $v_0 = 5;
        var $v_1 = this.get_$1_1().CommandType;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_1) && $v_1 === 'OptionSelection') {
            $v_0 = 7;
            this.get_stateProperties()['CommandValueId'] = this.$16_1;
        }
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_1().CommandPreview, $v_0, this.get_stateProperties());
    },
    
    $4u_1: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled()) {
            return;
        }
        var $v_0 = this.get_displayedComponent();
        if (CUI.MenuItem.isInstanceOfType($v_0)) {
            ($v_0).set_$1G(false);
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_1().CommandRevert)) {
            return;
        }
        var $v_1 = 6;
        var $v_2 = this.get_$1_1().CommandType;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_2) && $v_2 === 'OptionSelection') {
            $v_1 = 8;
            this.get_stateProperties()['CommandValueId'] = this.$16_1;
        }
        $v_0.raiseCommandEvent(this.get_$1_1().CommandRevert, $v_1, this.get_stateProperties());
    },
    
    $5w_1: function($p0) {
        this.onEndFocus();
        if (!this.get_enabled()) {
            return;
        }
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_$1_1().CommandRevert)) {
            return;
        }
        var $v_0 = 6;
        var $v_1 = this.get_$1_1().CommandType;
        if (!CUI.ScriptUtility.isNullOrUndefined($v_1) && $v_1 === 'OptionSelection') {
            $v_0 = 8;
            this.get_stateProperties()['CommandValueId'] = this.$16_1;
        }
        this.get_displayedComponent().raiseCommandEvent(this.get_$1_1().CommandRevert, $v_0, this.get_stateProperties());
    },
    
    $4y: function() {ULSpEN:;
        var $v_0 = this.pollForStateAndUpdateInternal(this.get_$1_1().Command, this.get_$1_1().QueryCommand, this.get_stateProperties(), false);
        if ($v_0) {
            this.setState(this.get_stateProperties()['On']);
        }
    },
    
    addDisplayModes: function() {ULSpEN:;
        this.addDisplayMode('Small');
        this.addDisplayMode('Medium');
        this.addDisplayMode('Large');
        this.addDisplayMode('Menu');
        this.addDisplayMode('Menu16');
        this.addDisplayMode('Menu32');
    },
    
    dispose: function() {ULSpEN:;
        CUI.Controls.ToggleButton.callBaseMethod(this, 'dispose');
        this.$9_1 = null;
        this.$8_1 = null;
        this.$h_1 = null;
        this.$1a_1 = null;
        this.$1w_1 = null;
        this.$1u_1 = null;
        this.$1X_1 = null;
    },
    
    get_$1_1: function() {ULSpEN:;
        return this.$5_0;
    }
}


CUI.Controls.JewelMenuLauncher = function(jewel, id, properties, menu) {ULSpEN:;
    this.$8D = Function.createDelegate(this, this.onContextMenu);
    this.$8S = Function.createDelegate(this, this.onKeyPress);
    this.$1H = Function.createDelegate(this, this.onClick);
    this.$3H = Function.createDelegate(this, this.onBlur);
    this.$3K = Function.createDelegate(this, this.onFocus);
    CUI.Controls.JewelMenuLauncher.initializeBase(this, [ jewel, id, properties, menu ]);
    this.addDisplayMode('Default');
}
CUI.Controls.JewelMenuLauncher.prototype = {
    $E_2: null,
    $H_2: null,
    $1t_2: null,
    $5L_2: null,
    $1J_2: null,
    $1Z_2: null,
    $1K_2: null,
    $2r_2: null,
    $2w_2: false,
    
    createDOMElementForDisplayMode: function($p0) {
        if ($p0 !== 'Default') {
            this.ensureValidDisplayMode($p0);
            return null;
        }
        var $v_0 = (CUI.ScriptUtility.isNullOrUndefined(this.get_properties().Alt)) ? '' : this.get_properties().Alt;
        this.$E_2 = CUI.Utility.$3('span');
        this.$E_2.id = this.get_properties().Id + '-Default';
        this.$E_2.className = 'ms-cui-jewel-jewelMenuLauncher';
        this.$H_2 = CUI.Utility.$3('a');
        CUI.Utility.$1s(this.$H_2);
        this.$H_2.title = $v_0;
        this.$2w_2 = !CUI.ScriptUtility.isNullOrEmptyString(this.get_properties().LabelText);
        if (!this.$2w_2) {
            this.$1t_2 = CUI.Utility.$3('img');
            this.$5L_2 = CUI.Utility.$j(2, 10, this.get_properties().Image, this.get_properties().ImageClass, this.$1t_2, true, false, this.get_properties().ImageTop, this.get_properties().ImageLeft);
            this.$1t_2.alt = $v_0;
            this.$H_2.appendChild(this.$5L_2);
        }
        else {
            var $v_1 = !CUI.ScriptUtility.isNullOrEmptyString(this.get_properties().ImageLeftSide);
            var $v_2 = !CUI.ScriptUtility.isNullOrEmptyString(this.get_properties().ImageRightSide);
            if ($v_1) {
                this.$1J_2 = CUI.Utility.$3('span');
                this.$1J_2.className = 'ms-cui-jewel-left';
                this.$1J_2.id = this.get_properties().Id + '-Default-left';
                CUI.Utility.$1h(this.$1J_2, this.get_properties().ImageLeftSide, this.get_properties().ImageLeftSideClass, this.get_properties().ImageLeftSideTop, this.get_properties().ImageLeftSideLeft, null, this.get_properties().Height);
                this.$1J_2.style.width = this.get_properties().ImageLeftSideWidth + 'px';
                this.$1J_2.style.height = this.get_properties().Height + 'px';
                this.$H_2.appendChild(this.$1J_2);
            }
            this.$1Z_2 = CUI.Utility.$3('span');
            this.$1Z_2.className = 'ms-cui-jewel-middle';
            this.$1Z_2.id = this.get_properties().Id + '-Default-middle';
            CUI.Utility.$1h(this.$1Z_2, this.get_properties().Image, this.get_properties().ImageClass, this.get_properties().ImageTop, this.get_properties().ImageLeft, null, this.get_properties().Height);
            this.$2r_2 = CUI.Utility.$3('span');
            if (!CUI.ScriptUtility.isNullOrUndefined(this.get_properties().LabelCss)) {
                this.$2r_2.style.cssText = this.get_properties().LabelCss;
            }
            this.$2r_2.className = 'ms-cui-jewel-label';
            if (!CUI.ScriptUtility.isNullOrEmptyString(this.get_properties().Height)) {
                this.$2r_2.style.marginTop = (Math.floor(parseInt(this.get_properties().Height) - 14) / 2) + 'px';
            }
            CUI.UIUtility.setInnerText(this.$2r_2, this.get_properties().LabelText);
            this.$1Z_2.appendChild(this.$2r_2);
            this.$H_2.appendChild(this.$1Z_2);
            if ($v_2) {
                this.$1K_2 = CUI.Utility.$3('span');
                this.$1K_2.className = 'ms-cui-jewel-right';
                this.$1K_2.id = this.get_properties().Id + '-Default-right';
                CUI.Utility.$1h(this.$1K_2, this.get_properties().ImageRightSide, this.get_properties().ImageRightSideClass, this.get_properties().ImageRightSideTop, this.get_properties().ImageRightSideLeft, null, this.get_properties().Height);
                this.$1K_2.style.width = this.get_properties().ImageRightSideWidth + 'px';
                this.$1K_2.style.height = this.get_properties().Height + 'px';
                this.$H_2.appendChild(this.$1K_2);
            }
        }
        this.$O($p0);
        this.$E_2.appendChild(this.$H_2);
        return this.$E_2;
    },
    
    $35: function($p0) {
        this.ensureValidDisplayMode($p0);
        var $v_0 = $get(this.$6_0 + '-' + $p0);
        this.storeElementForDisplayMode($v_0, $p0);
        var $v_1 = $v_0.childNodes[0];
        this.$E_2 = $v_0;
        this.$H_2 = $v_1;
        this.$2w_2 = !CUI.ScriptUtility.isNullOrEmptyString(this.get_properties().LabelText);
        if (!this.$2w_2) {
            this.$5L_2 = this.$H_2.childNodes[0];
            this.$1t_2 = this.$5L_2.childNodes[0];
        }
        else {
            this.$1J_2 = $get(this.$6_0 + '-' + $p0 + '-left');
            this.$1Z_2 = $get(this.$6_0 + '-' + $p0 + '-middle');
            if (this.$1Z_2) {
                this.$2r_2 = this.$1Z_2.firstChild;
            }
            this.$1K_2 = $get(this.$6_0 + '-' + $p0 + '-right');
        }
    },
    
    $O: function($p0) {
        this.ensureValidDisplayMode($p0);
        $addHandler(this.$H_2, 'mouseover', this.$3K);
        $addHandler(this.$H_2, 'focus', this.$3K);
        $addHandler(this.$H_2, 'mouseout', this.$3H);
        $addHandler(this.$H_2, 'blur', this.$3H);
        $addHandler(this.$H_2, 'click', this.$1H);
        $addHandler(this.$H_2, 'keypress', this.$8S);
        if (Sys.Browser.agent === Sys.Browser.InternetExplorer) {
            $addHandler(this.$H_2, 'contextmenu', this.$8D);
        }
    },
    
    onEnabledChanged: function($p0) {
        CUI.Utility.setEnabledOnElement(this.$H_2, $p0);
    },
    
    onFocus: function($p0) {
        if (!this.get_enabled() || this.$i_1) {
            return;
        }
        this.$39_2();
    },
    
    onBlur: function($p0) {
        if (!this.get_enabled() || this.$i_1) {
            return;
        }
        this.$1U_2();
    },
    
    onClick: function($p0) {
        $p0.preventDefault();
        if (!this.get_enabled() || CUI.ScriptUtility.isNullOrUndefined($p0) || $p0.button) {
            return;
        }
        if (this.$i_1) {
            this.$4o();
            return;
        }
        this.$Ai_2();
    },
    
    onKeyPress: function($p0) {
        if (!this.get_enabled()) {
            return;
        }
        if (!$p0 || !$p0.rawEvent) {
            return;
        }
        var $v_0 = $p0.rawEvent.keyCode;
        if ($v_0 === 13 || $v_0 === 32 || $v_0 === 40) {
            this.$1E_1 = true;
            if (this.$i_1) {
                this.$4o();
            }
            else {
                this.$Ai_2();
            }
            $p0.preventDefault();
        }
    },
    
    onContextMenu: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined($p0)) {
            $p0.preventDefault();
        }
    },
    
    $Ai_2: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_properties().ImageDown)) {
            return;
        }
        if (!this.$2w_2) {
            this.$1t_2.src = this.get_properties().ImageDown;
            if (!CUI.ScriptUtility.isNullOrUndefined(this.get_properties().ImageDownClass)) {
                this.$1t_2.className = this.get_properties().ImageDownClass;
            }
        }
        else {
            if (this.$1J_2) {
                CUI.Utility.$1h(this.$1J_2, this.get_properties().ImageLeftSideDown, this.get_properties().ImageLeftSideDownClass, this.get_properties().ImageLeftSideDownTop, this.get_properties().ImageLeftSideDownLeft, null, this.get_properties().Height);
            }
            CUI.Utility.$1h(this.$1Z_2, this.get_properties().ImageDown, this.get_properties().ImageDownClass, this.get_properties().ImageDownTop, this.get_properties().ImageDownLeft, null, this.get_properties().Height);
            if (this.$1K_2) {
                CUI.Utility.$1h(this.$1K_2, this.get_properties().ImageRightSideDown, this.get_properties().ImageRightSideDownClass, this.get_properties().ImageRightSideDownTop, this.get_properties().ImageRightSideDownLeft, null, this.get_properties().Height);
            }
        }
        this.launchMenuInternal(this.$H_2);
    },
    
    onLaunchedMenuClosed: function() {ULSpEN:;
        this.$1U_2();
        this.get_displayedComponent().raiseCommandEvent(this.get_properties().CommandMenuClose, 10, null);
    },
    
    launchMenuInternal: function($p0) {
        this.launchMenu($p0);
        this.get_displayedComponent().raiseCommandEvent(this.get_properties().CommandMenuOpen, 4, null);
    },
    
    $39_2: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_properties().ImageHover)) {
            return;
        }
        if (!this.$2w_2) {
            this.$1t_2.src = this.get_properties().ImageHover;
            if (!CUI.ScriptUtility.isNullOrUndefined(this.get_properties().ImageHoverClass)) {
                this.$1t_2.className = this.get_properties().ImageHoverClass;
            }
        }
        else {
            if (this.$1J_2) {
                CUI.Utility.$1h(this.$1J_2, this.get_properties().ImageLeftSideHover, this.get_properties().ImageLeftSideHoverClass, this.get_properties().ImageLeftSideHoverTop, this.get_properties().ImageLeftSideHoverLeft, null, this.get_properties().Height);
            }
            CUI.Utility.$1h(this.$1Z_2, this.get_properties().ImageHover, this.get_properties().ImageHoverClass, this.get_properties().ImageHoverTop, this.get_properties().ImageHoverLeft, null, this.get_properties().Height);
            if (this.$1K_2) {
                CUI.Utility.$1h(this.$1K_2, this.get_properties().ImageRightSideHover, this.get_properties().ImageRightSideHoverClass, this.get_properties().ImageRightSideHoverTop, this.get_properties().ImageRightSideHoverLeft, null, this.get_properties().Height);
            }
        }
    },
    
    $1U_2: function() {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.get_properties().ImageHover)) {
            return;
        }
        if (!this.$2w_2) {
            this.$1t_2.src = this.get_properties().Image;
            if (!CUI.ScriptUtility.isNullOrUndefined(this.get_properties().ImageClass)) {
                this.$1t_2.className = this.get_properties().ImageClass;
            }
        }
        else {
            if (this.$1J_2) {
                CUI.Utility.$1h(this.$1J_2, this.get_properties().ImageLeftSide, this.get_properties().ImageLeftSideClass, this.get_properties().ImageLeftSideTop, this.get_properties().ImageLeftSideLeft, null, this.get_properties().Height);
            }
            CUI.Utility.$1h(this.$1Z_2, this.get_properties().Image, this.get_properties().ImageClass, this.get_properties().ImageTop, this.get_properties().ImageLeft, null, this.get_properties().Height);
            if (this.$1K_2) {
                CUI.Utility.$1h(this.$1K_2, this.get_properties().ImageRightSide, this.get_properties().ImageRightSideClass, this.get_properties().ImageRightSideTop, this.get_properties().ImageRightSideLeft, null, this.get_properties().Height);
            }
        }
    },
    
    get_properties: function() {ULSpEN:;
        return this.$5_0;
    },
    
    $Cs: function() {ULSpEN:;
        this.$H_2.focus();
    }
}


Type.registerNamespace('CUI.Page');

CUI.Page.CommandDispatcher = function() {ULSpEN:;
    this.$2L_0 = {};
}
CUI.Page.CommandDispatcher.prototype = {
    $2L_0: null,
    
    $7U: function() {
    },
    
    $5h_0: 0,
    
    getNextSequenceNumber: function() {ULSpEN:;
        if (this.$5h_0 + 1 < 0) {
            throw Error.create('Command Dispatcher sequence numbers overflowed into negative numbers.');
        }
        return ++this.$5h_0;
    },
    
    peekNextSequenceNumber: function() {ULSpEN:;
        return this.$5h_0 + 1;
    },
    
    getLastSequenceNumber: function() {ULSpEN:;
        return this.$5h_0;
    },
    
    executeCommand: function(commandId, properties) {ULSpEN:;
        return this.$Cl(commandId, properties, this.getNextSequenceNumber());
    },
    
    $Cl: function($p0, $p1, $p2) {
        var $v_0 = this.$2L_0[$p0];
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return false;
        }
        else if (Array.isInstanceOfType($v_0)) {
            var $v_1 = $v_0;
            var $v_2 = false;
            for (var $v_3 = 0; $v_3 < $v_1.length; $v_3++) {
                var $v_4 = $v_1[$v_3];
                if (this.callCommandHandler($v_4, $p0, $p1, $p2)) {
                    $v_2 = true;
                }
            }
            return $v_2;
        }
        else {
            return this.callCommandHandler($v_0, $p0, $p1, $p2);
        }
    },
    
    isCommandEnabled: function(commandId) {ULSpEN:;
        var $v_0 = this.$2L_0[commandId];
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return false;
        }
        else if (Array.isInstanceOfType($v_0)) {
            var $v_1 = $v_0;
            for (var $v_2 = 0; $v_2 < $v_1.length; $v_2++) {
                var $v_3 = $v_1[$v_2];
                if (this.callCommandHandlerForEnabled($v_3, commandId)) {
                    return true;
                }
            }
            return false;
        }
        else {
            return this.callCommandHandlerForEnabled($v_0, commandId);
        }
    },
    
    $AQ: function($p0) {
        return this.$2L_0[$p0];
    },
    
    registerCommandHandler: function(commandId, handler) {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(commandId) || CUI.ScriptUtility.isNullOrUndefined(handler)) {
            throw Error.create('commandId and handler may not be null or undefined');
        }
        var $v_0 = this.$2L_0[commandId];
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            this.$2L_0[commandId] = handler;
        }
        else if (Array.isInstanceOfType($v_0)) {
            if (!Array.contains($v_0, handler)) {
                Array.add($v_0, handler);
            }
        }
        else {
            if ($v_0 === handler) {
                return;
            }
            var $v_1 = [];
            Array.add($v_1, $v_0);
            Array.add($v_1, handler);
            this.$2L_0[commandId] = $v_1;
        }
    },
    
    unregisterCommandHandler: function(commandId, handler) {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(commandId) || CUI.ScriptUtility.isNullOrUndefined(handler)) {
            throw Error.create('commandId and handler may not be null or undefined');
        }
        var $v_0 = this.$2L_0[commandId];
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return;
        }
        else if (Array.isInstanceOfType($v_0)) {
            Array.remove($v_0, handler);
        }
        else {
            if ($v_0 === handler) {
                this.$2L_0[commandId] = null;
            }
        }
    },
    
    registerMultipleCommandHandler: function(component, commands) {ULSpEN:;
        for (var $v_0 = 0; $v_0 < commands.length; $v_0++) {
            this.registerCommandHandler(commands[$v_0], component);
        }
    },
    
    unregisterMultipleCommandHandler: function(component, commands) {ULSpEN:;
        for (var $v_0 = 0; $v_0 < commands.length; $v_0++) {
            this.unregisterCommandHandler(commands[$v_0], component);
        }
    },
    
    callCommandHandler: function(handler, commandId, properties, sequenceNumber) {ULSpEN:;
        return handler.handleCommand(commandId, properties, sequenceNumber);
    },
    
    callCommandHandlerForEnabled: function(handler, commandId) {ULSpEN:;
        return handler.canHandleCommand(commandId);
    }
}


CUI.Page.FocusManager = function(pageManager) {ULSpEN:;
    CUI.Page.FocusManager.initializeBase(this);
    this.$23_1 = pageManager;
    this.$k_1 = [];
    this.$2b_1 = {};
    this.$1N_1 = [];
    this.$2X_1 = {};
}
CUI.Page.FocusManager.prototype = {
    $1N_1: null,
    $2b_1: null,
    $23_1: null,
    $2X_1: null,
    
    $7U: function() {
    },
    
    $AZ_1: function() {ULSpEN:;
        this.$2X_1 = {};
        var $v_0 = this.$1N_1.length;
        for (var $v_1 = 0; $v_1 < $v_0; $v_1++) {
            var $v_2 = this.$1N_1[$v_1];
            this.$2X_1[($v_2)] = $v_2;
        }
    },
    
    requestFocusForComponent: function(component) {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(component)) {
            return false;
        }
        if (Array.contains(this.$1N_1, component)) {
            return true;
        }
        Array.add(this.$1N_1, component);
        this.$AZ_1();
        component.receiveFocus();
        return true;
    },
    
    releaseFocusFromComponent: function(component) {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(component)) {
            return false;
        }
        if (!Array.contains(this.$1N_1, component)) {
            return true;
        }
        Array.remove(this.$1N_1, component);
        this.$AZ_1();
        component.yieldFocus();
        return true;
    },
    
    releaseAllFoci: function() {ULSpEN:;
        this.$2X_1 = {};
        var $v_0 = this.$1N_1.length;
        for (var $v_1 = $v_0 - 1; $v_1 >= 0; $v_1--) {
            var $v_2 = this.$1N_1[$v_1];
            Array.remove(this.$1N_1, $v_2);
            $v_2.yieldFocus();
        }
        return true;
    },
    
    getFocusedComponents: function() {ULSpEN:;
        return Array.clone(this.$1N_1);
    },
    
    handleCommand: function(commandId, properties, sequenceNumber) {ULSpEN:;
        var $v_0 = this.$AQ(commandId);
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return false;
        }
        else if (Array.isInstanceOfType($v_0)) {
            var $v_1 = $v_0;
            for (var $v_2 = 0; $v_2 < $v_1.length; $v_2++) {
                var $v_3 = $v_1[$v_2];
                if (CUI.ScriptUtility.isNullOrUndefined(this.$2X_1[$v_3])) {
                    continue;
                }
                if (this.callCommandHandler($v_3, commandId, properties, sequenceNumber)) {
                    return true;
                }
            }
            return false;
        }
        else {
            if (CUI.ScriptUtility.isNullOrUndefined(this.$2X_1[$v_0])) {
                return false;
            }
            return this.callCommandHandler($v_0, commandId, properties, sequenceNumber);
        }
    },
    
    canHandleCommand: function(commandId) {ULSpEN:;
        var $v_0 = this.$AQ(commandId);
        if (CUI.ScriptUtility.isNullOrUndefined($v_0)) {
            return false;
        }
        else if (Array.isInstanceOfType($v_0)) {
            var $v_1 = $v_0;
            for (var $v_2 = 0; $v_2 < $v_1.length; $v_2++) {
                var $v_3 = $v_1[$v_2];
                if (CUI.ScriptUtility.isNullOrUndefined(this.$2X_1[$v_3])) {
                    continue;
                }
                if (this.callCommandHandlerForEnabled($v_3, commandId)) {
                    return true;
                }
            }
            return false;
        }
        else {
            if (CUI.ScriptUtility.isNullOrUndefined(this.$2X_1[$v_0])) {
                return false;
            }
            return this.callCommandHandlerForEnabled($v_0, commandId);
        }
    },
    
    $k_1: null,
    
    $BY: function($p0) {
        if (Array.contains(this.$k_1, $p0)) {
            return;
        }
        this.registerMultipleCommandHandler($p0, $p0.getFocusedCommands());
        Array.add(this.$k_1, $p0);
    },
    
    $Dw: function($p0) {
        if (!Array.contains(this.$k_1, $p0)) {
            return;
        }
        this.unregisterMultipleCommandHandler($p0, $p0.getFocusedCommands());
        this.releaseFocusFromComponent($p0);
        Array.remove(this.$k_1, $p0);
    },
    
    executeCommand: function(commandId, properties) {ULSpEN:;
        throw Error.create('ExecuteCommand should not be called on the main CommandDispatcher of the page, not the FocusManager');
    },
    
    registerCommandHandler: function(commandId, handler) {ULSpEN:;
        CUI.Page.FocusManager.callBaseMethod(this, 'registerCommandHandler', [ commandId, handler ]);
        if (CUI.ScriptUtility.isNullOrUndefined(this.$2b_1[commandId])) {
            this.$23_1.$z_1.registerCommandHandler(commandId, this);
            this.$2b_1[commandId] = 0;
        }
        var $v_0 = this.$2b_1[commandId];
        this.$2b_1[commandId] = $v_0 + 1;
    },
    
    unregisterCommandHandler: function(commandId, handler) {ULSpEN:;
        CUI.Page.FocusManager.callBaseMethod(this, 'unregisterCommandHandler', [ commandId, handler ]);
        var $v_0 = this.$2b_1[commandId];
        if (!CUI.ScriptUtility.isNullOrUndefined($v_0) && $v_0 > 0) {
            this.$2b_1[commandId] = --$v_0;
            if ($v_0 <= 0) {
                this.$23_1.$z_1.unregisterCommandHandler(commandId, this);
                delete this.$2b_1[commandId];
            }
        }
    },
    
    getNextSequenceNumber: function() {ULSpEN:;
        throw Error.create('The FocusManager does not issue command sequence numbers.  This is only done by the main CommandDispatcher of the page.');
    },
    
    peekNextSequenceNumber: function() {ULSpEN:;
        throw Error.create('The FocusManager does not issue command sequence numbers.  This is only done by the main CommandDispatcher of the page.');
    },
    
    getLastSequenceNumber: function() {ULSpEN:;
        throw Error.create('The FocusManager does not issue command sequence numbers.  This is only done by the main CommandDispatcher of the page.');
    },
    
    callCommandHandler: function(handler, commandId, properties, sequenceNumber) {ULSpEN:;
        if (!Array.contains(this.$1N_1, handler)) {
            return false;
        }
        return handler.handleCommand(commandId, properties, sequenceNumber);
    },
    
    callCommandHandlerForEnabled: function(handler, commandId) {ULSpEN:;
        if (!Array.contains(this.$1N_1, handler)) {
            return false;
        }
        return handler.canHandleCommand(commandId);
    }
}


CUI.Page.PageManager = function() {ULSpEN:;
    this.$59 = Function.createDelegate(this, this.$7Z_1);
    CUI.Page.PageManager.initializeBase(this);
    this.$k_1 = [];
    this.$4C_1 = {};
    this.$z_1 = new CUI.Page.CommandDispatcher();
    this.$3h_1 = new CUI.Page.FocusManager(this);
    this.$5k_1 = new CUI.Page.UndoManager(this);
    this.$2M_1 = [];
    this.$22_1 = this.$59;
    $addHandler(window, 'unload', this.$22_1);
}
CUI.Page.PageManager.initialize = function() {ULSpEN:;
    if (!CUI.ScriptUtility.isNullOrUndefined(CUI.Page.PageManager._instance)) {
        return;
    }
    CUI.Page.PageManager._instance = CUI.Page.PageManager.createPageManager();
    CUI.Page.PageManager._instance.initializeInternal();
}
CUI.Page.PageManager.createPageManager = function() {ULSpEN:;
    return new CUI.Page.PageManager();
}
CUI.Page.PageManager.get_instance = function() {ULSpEN:;
    if (!CUI.Page.PageManager._instance) {
        CUI.Page.PageManager.initialize();
    }
    return CUI.Page.PageManager._instance;
}
CUI.Page.PageManager.prototype = {
    $22_1: null,
    
    initializeInternal: function() {ULSpEN:;
        this.$z_1.$7U();
        this.$5k_1.$7U();
        this.$3h_1.$7U();
        this.$z_1.registerCommandHandler('appstatechanged', this);
    },
    
    $7Z_1: function($p0) {
        this.dispose();
    },
    
    dispose: function() {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.get_ribbon())) {
            this.get_ribbon().$Cp();
        }
        this.$3h_1 = null;
        this.$5k_1 = null;
        this.$z_1 = null;
        this.$2M_1 = null;
        this.$k_1 = null;
        $addHandler(window, 'unload', this.$22_1);
    },
    
    $z_1: null,
    
    get_commandDispatcher: function() {ULSpEN:;
        return this.$z_1;
    },
    
    $3h_1: null,
    
    get_focusManager: function() {ULSpEN:;
        return this.$3h_1;
    },
    
    $5k_1: null,
    
    get_undoManager: function() {ULSpEN:;
        return this.$5k_1;
    },
    
    $6R_1: null,
    
    get_$7H_1: function() {ULSpEN:;
        if (!this.$6R_1) {
            this.$6R_1 = new Sys.EventHandlerList();
        }
        return this.$6R_1;
    },
    
    $3o_1: null,
    
    get_ribbon: function() {ULSpEN:;
        return this.$3o_1;
    },
    set_ribbon: function(value) {ULSpEN:;
        if (value === this.$3o_1) {
            return;
        }
        if (CUI.ScriptUtility.isNullOrUndefined(value) && !CUI.ScriptUtility.isNullOrUndefined(this.$3o_1)) {
            this.removeRoot(this.$3o_1);
            this.$3o_1 = null;
        }
        else if (!Array.contains(this.$2M_1, value)) {
            this.addRoot(value);
            this.$3o_1 = value;
        }
        return value;
    },
    
    add_ribbonInited: function(value) {ULSpEN:;
        this.get_$7H_1().addHandler('RibbonInited', value);
    },
    remove_ribbonInited: function(value) {ULSpEN:;
        this.get_$7H_1().removeHandler('RibbonInited', value);
    },
    
    onComponentBuilt: function(root, componentId) {ULSpEN:;
        this.pollRootState(root);
        if (CUI.Ribbon.isInstanceOfType(root)) {
            var $v_0 = this.get_$7H_1().getHandler('RibbonInited');
            if ($v_0) {
                $v_0(this, Sys.EventArgs.Empty);
            }
        }
    },
    
    onComponentCreated: function(root, componentId) {ULSpEN:;
        if (CUI.Ribbon.isInstanceOfType(root) && CUI.ScriptUtility.isNullOrUndefined(this.get_ribbon())) {
            this.set_ribbon(root);
        }
        else {
            this.addRoot(root);
        }
    },
    
    $2M_1: null,
    
    addRoot: function(root) {ULSpEN:;
        if (Array.contains(this.$2M_1, root)) {
            throw Error.create('This Root has already been added to the PageManager');
        }
        Array.add(this.$2M_1, root);
        root.set_rootUser(this);
    },
    
    removeRoot: function(root) {ULSpEN:;
        if (!Array.contains(this.$2M_1, root)) {
            throw Error.create('This Root has not been added to the PageManager.');
        }
        Array.remove(this.$2M_1, root);
        root.set_rootUser(null);
    },
    
    $k_1: null,
    $4C_1: null,
    
    getPageComponentById: function(id) {ULSpEN:;
        return this.$4C_1[id];
    },
    
    addPageComponent: function(component) {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$4C_1[component.getId()])) {
            Error.create('A PageComponent with id: ' + component.getId() + ' has already been added to the PageManger.');
        }
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$k_1) && !Array.contains(this.$k_1, component)) {
            this.$4C_1[component.getId()] = component;
            component.init();
            this.$z_1.registerMultipleCommandHandler(component, component.getGlobalCommands());
            Array.add(this.$k_1, component);
            if (component.isFocusable()) {
                this.$3h_1.$BY(component);
            }
        }
    },
    
    removePageComponent: function(component) {ULSpEN:;
        if (CUI.ScriptUtility.isNullOrUndefined(this.$k_1) || !Array.contains(this.$k_1, component)) {
            return;
        }
        this.$z_1.unregisterMultipleCommandHandler(component, component.getGlobalCommands());
        Array.remove(this.$k_1, component);
        if (component.isFocusable()) {
            this.$3h_1.$Dw(component);
        }
        this.$4C_1[component.getId()] = null;
    },
    
    executeRootCommand: function(commandId, properties, commandInfo, root) {ULSpEN:;
        return this.$z_1.executeCommand(commandId, properties);
    },
    
    isRootCommandEnabled: function(commandId, root) {ULSpEN:;
        return this.$z_1.isCommandEnabled(commandId);
    },
    
    onRootRefreshed: function(root) {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(root)) {
            this.pollRootState(root);
        }
    },
    
    handleCommand: function(commandId, properties, sequenceNumber) {ULSpEN:;
        if (commandId === 'appstatechanged') {
            for (var $v_0 = 0; $v_0 < this.$2M_1.length; $v_0++) {
                var $v_1 = this.$2M_1[$v_0];
                this.pollRootState($v_1);
                if ($v_1.$g_0) {
                    $v_1.$L();
                }
            }
            return true;
        }
        return false;
    },
    
    $6q_1: false,
    
    get_rootPollingInProgress: function() {ULSpEN:;
        return this.$6q_1;
    },
    
    pollRootState: function(root) {ULSpEN:;
        try {
            this.$6q_1 = true;
            root.pollForStateAndUpdate();
        }
        finally {
            this.$6q_1 = false;
        }
    },
    
    changeCommandContext: function(commandContextId) {ULSpEN:;
        if (!CUI.ScriptUtility.isNullOrUndefined(this.get_ribbon())) {
            return this.get_ribbon().selectTabByCommand(commandContextId);
        }
        return false;
    },
    
    canHandleCommand: function(commandId) {ULSpEN:;
        return commandId === 'appstatechanged';
    },
    
    restoreFocusToRibbon: function() {ULSpEN:;
        if (!this.get_ribbon().restoreFocus()) {
            this.get_ribbon().setFocus();
        }
    }
}


CUI.Page.UndoManager = function(pageManager) {ULSpEN:;
    this.$6p_0 = CUI.Page.UndoManager.$28_0;
    this.$23_0 = pageManager;
    this.$1F_0 = [];
    this.$14_0 = [];
    this.$25_0 = {};
}
CUI.Page.UndoManager.prototype = {
    $23_0: null,
    $25_0: null,
    $1F_0: null,
    $14_0: null,
    
    $7U: function() {ULSpEN:;
        this.$23_0.$z_1.registerCommandHandler('GlobalUndo', this);
        this.$23_0.$z_1.registerCommandHandler('GlobalRedo', this);
        this.$23_0.$z_1.registerCommandHandler('grpedit', this);
    },
    
    addUndoSequenceNumber: function(sequenceNumber) {ULSpEN:;
        this.$Dr_0(sequenceNumber);
        if (sequenceNumber !== this.$6p_0) {
            this.$CY_0();
        }
    },
    
    addRedoSequenceNumber: function(sequenceNumber) {ULSpEN:;
        this.$Dq_0(sequenceNumber);
    },
    
    get_oldestSequenceNumber: function() {ULSpEN:;
        if (!this.$1F_0.length) {
            return CUI.Page.UndoManager.$28_0;
        }
        var $v_0 = CUI.Page.UndoManager.$28_0;
        var $v_1 = CUI.Page.UndoManager.$28_0;
        if (this.$1F_0.length > 0) {
            $v_0 = this.$1F_0[this.$1F_0.length - 1];
        }
        if (this.$14_0.length > 0) {
            $v_1 = this.$14_0[0];
        }
        if ($v_0 === CUI.Page.UndoManager.$28_0) {
            return $v_0;
        }
        else {
            return $v_0;
        }
    },
    
    $CW_0: function() {ULSpEN:;
        var $v_0 = this.$Dm_0();
        if ($v_0 === CUI.Page.UndoManager.$28_0) {
            return;
        }
        var $v_1 = {};
        $v_1['SequenceNumber'] = $v_0;
        this.$23_0.$z_1.executeCommand('Undo', $v_1);
    },
    
    $CV_0: function() {ULSpEN:;
        var $v_0 = this.$Dl_0();
        if ($v_0 === CUI.Page.UndoManager.$28_0) {
            return;
        }
        var $v_1 = {};
        $v_1['SequenceNumber'] = $v_0;
        this.$6p_0 = this.$23_0.$z_1.peekNextSequenceNumber();
        this.$23_0.$z_1.executeCommand('Redo', $v_1);
    },
    
    $Dl_0: function() {ULSpEN:;
        if (!this.$14_0.length) {
            return CUI.Page.UndoManager.$28_0;
        }
        var $v_0 = this.$14_0[0];
        Array.removeAt(this.$14_0, 0);
        this.$25_0[$v_0.toString()] = null;
        return $v_0;
    },
    
    $Dq_0: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$25_0[$p0.toString()])) {
            if (this.$1F_0[0] !== $p0) {
                throw Error.create('This command sequence number is already on the undo or the redo stack but it is not ontop of the redo stack.  Pushing it would result in out of sequence redo and undo stacks.');
            }
            return;
        }
        Array.insert(this.$14_0, 0, $p0);
        this.$25_0[$p0.toString()] = $p0;
    },
    
    $Dm_0: function() {ULSpEN:;
        if (!this.$1F_0.length) {
            return CUI.Page.UndoManager.$28_0;
        }
        var $v_0 = this.$1F_0[0];
        Array.removeAt(this.$1F_0, 0);
        this.$25_0[$v_0.toString()] = null;
        return $v_0;
    },
    
    $Dr_0: function($p0) {
        if (!CUI.ScriptUtility.isNullOrUndefined(this.$25_0[$p0.toString()])) {
            if (this.$1F_0[0] !== $p0) {
                throw Error.create('This command sequence number is already on the stack and not on top.  Pushing it would result in an out of sequence undo stack.');
            }
            return;
        }
        Array.insert(this.$1F_0, 0, $p0);
        this.$25_0[$p0.toString()] = $p0;
    },
    
    $CY_0: function() {ULSpEN:;
        for (var $v_0 = 0; $v_0 < this.$14_0.length; $v_0++) {
            this.$25_0[(this.$14_0[$v_0]).toString()] = null;
            Array.remove(this.$14_0, this.$14_0[$v_0]);
        }
        Array.clear(this.$14_0);
    },
    
    invalidateUndoSequenceNumber: function(sequenceNumber) {ULSpEN:;
        for (var $v_0 = this.$1F_0.length - 1; $v_0 > -1; $v_0--) {
            var $v_1 = this.$1F_0[$v_0];
            if ($v_1 <= sequenceNumber) {
                Array.removeAt(this.$1F_0, $v_0);
                this.$25_0[$v_1.toString()] = null;
            }
        }
        while (this.$14_0.length > 0 && this.$14_0[0] <= sequenceNumber) {
            this.$25_0[(this.$14_0[0]).toString()] = null;
            Array.removeAt(this.$14_0, 0);
        }
    },
    
    canHandleCommand: function(commandId) {ULSpEN:;
        if (commandId === 'GlobalUndo') {
            return this.$1F_0.length > 0;
        }
        else if (commandId === 'GlobalRedo') {
            return this.$14_0.length > 0;
        }
        else if (commandId === 'grpedit') {
            return true;
        }
        return false;
    },
    
    handleCommand: function(commandId, properties, sequenceNumber) {ULSpEN:;
        switch (commandId) {
            case 'GlobalUndo':
                this.$CW_0();
                return true;
            case 'GlobalRedo':
                this.$CV_0();
                return true;
        }
        return false;
    }
}


Type.registerNamespace('Commands');

Commands.CommandIds = function() {
}


Commands.GlobalRedoProperties = function() {
}


Commands.RedoProperties = function() {
}


Commands.GlobalUndoProperties = function() {
}


Commands.UndoProperties = function() {
}


CUI.BuildOptions.registerClass('CUI.BuildOptions');
CUI.BuildContext.registerClass('CUI.BuildContext');
CUI.DataNodeWrapper.registerClass('CUI.DataNodeWrapper');
CUI.Builder.registerClass('CUI.Builder', null, Sys.IDisposable);
CUI.CommandEventArgs.registerClass('CUI.CommandEventArgs', Sys.EventArgs);
CUI.Component.registerClass('CUI.Component', null, CUI.IMenuItem, Sys.IDisposable);
CUI.Menu.registerClass('CUI.Menu', CUI.Component);
CUI.ContextMenu.registerClass('CUI.ContextMenu', CUI.Menu);
CUI.ContextMenuDock.registerClass('CUI.ContextMenuDock', CUI.Component);
CUI.Control.registerClass('CUI.Control', null, Sys.IDisposable, CUI.IMenuItem);
CUI.MenuLauncher.registerClass('CUI.MenuLauncher', CUI.Control, CUI.IModalController);
CUI.ContextMenuLauncher.registerClass('CUI.ContextMenuLauncher', CUI.MenuLauncher);
CUI.RootProperties.registerClass('CUI.RootProperties');
CUI.ContextMenuRootProperties.registerClass('CUI.ContextMenuRootProperties', CUI.RootProperties);
CUI.Root.registerClass('CUI.Root', CUI.Component, Sys.IDisposable);
CUI.ContextMenuRoot.registerClass('CUI.ContextMenuRoot', CUI.Root);
CUI.ControlProperties.registerClass('CUI.ControlProperties');
CUI.ControlComponent.registerClass('CUI.ControlComponent', CUI.Component);
CUI.DataQueryResult.registerClass('CUI.DataQueryResult');
CUI.DataQuery.registerClass('CUI.DataQuery');
CUI.DataSource.registerClass('CUI.DataSource');
CUI.Gallery.registerClass('CUI.Gallery', CUI.Component);
CUI.Jewel.registerClass('CUI.Jewel', CUI.Root);
CUI.JewelBuildContext.registerClass('CUI.JewelBuildContext', CUI.BuildContext);
CUI.JewelBuildOptions.registerClass('CUI.JewelBuildOptions', CUI.BuildOptions);
CUI.JewelBuilder.registerClass('CUI.JewelBuilder', CUI.Builder);
CUI.MenuItem.registerClass('CUI.MenuItem', CUI.ControlComponent);
CUI.MenuLauncherControlProperties.registerClass('CUI.MenuLauncherControlProperties', CUI.ControlProperties);
CUI.BrowserUtility.registerClass('CUI.BrowserUtility');
CUI.MenuSection.registerClass('CUI.MenuSection', CUI.Component);
CUI.QAT.registerClass('CUI.QAT', CUI.Root);
CUI.QATBuildContext.registerClass('CUI.QATBuildContext', CUI.BuildContext);
CUI.QATBuildOptions.registerClass('CUI.QATBuildOptions', CUI.BuildOptions);
CUI.QATBuilder.registerClass('CUI.QATBuilder', CUI.Builder);
CUI.RibbonPeripheralSection.registerClass('CUI.RibbonPeripheralSection');
CUI.ContextualGroup.registerClass('CUI.ContextualGroup', null, Sys.IDisposable);
CUI.Template.registerClass('CUI.Template');
CUI.DeclarativeTemplate.registerClass('CUI.DeclarativeTemplate', CUI.Template);
CUI.RibbonComponent.registerClass('CUI.RibbonComponent', CUI.Component);
CUI.Group.registerClass('CUI.Group', CUI.RibbonComponent);
CUI.GroupPopup.registerClass('CUI.GroupPopup', CUI.Component);
CUI.Layout.registerClass('CUI.Layout', CUI.RibbonComponent);
CUI.GroupPopupLayout.registerClass('CUI.GroupPopupLayout', CUI.Layout);
CUI.RootEventCommandProperties.registerClass('CUI.RootEventCommandProperties');
CUI.RibbonEventCommandProperties.registerClass('CUI.RibbonEventCommandProperties', CUI.RootEventCommandProperties);
CUI.CommandContextSwitchCommandProperties.registerClass('CUI.CommandContextSwitchCommandProperties');
CUI.Ribbon.registerClass('CUI.Ribbon', CUI.Root);
CUI.RibbonCommand.registerClass('CUI.RibbonCommand');
CUI.RibbonBuildContext.registerClass('CUI.RibbonBuildContext', CUI.BuildContext);
CUI.RibbonBuildOptions.registerClass('CUI.RibbonBuildOptions', CUI.BuildOptions);
CUI.RibbonBuilder.registerClass('CUI.RibbonBuilder', CUI.Builder);
CUI.Row.registerClass('CUI.Row', CUI.Component);
CUI.ScalingStep.registerClass('CUI.ScalingStep');
CUI.Scaling.registerClass('CUI.Scaling');
CUI.Section.registerClass('CUI.Section', CUI.RibbonComponent);
CUI.Strip.registerClass('CUI.Strip', CUI.RibbonComponent);
CUI.Tab.registerClass('CUI.Tab', CUI.RibbonComponent);
CUI.TemplateManager.registerClass('CUI.TemplateManager');
CUI.RootUser.registerClass('CUI.RootUser');
CUI.ButtonDock.registerClass('CUI.ButtonDock', CUI.Component);
CUI.Toolbar.registerClass('CUI.Toolbar', CUI.Root);
CUI.ToolbarBuildContext.registerClass('CUI.ToolbarBuildContext', CUI.BuildContext);
CUI.ToolbarBuildOptions.registerClass('CUI.ToolbarBuildOptions', CUI.BuildOptions);
CUI.ToolbarBuilder.registerClass('CUI.ToolbarBuilder', CUI.Builder);
CUI.ToolTip.registerClass('CUI.ToolTip', CUI.Component);
CUI.Unit.registerClass('CUI.Unit');
CUI.Utility.registerClass('CUI.Utility');
CUI.ScriptUtility.registerClass('CUI.ScriptUtility');
CUI.UIUtility.registerClass('CUI.UIUtility');
CUI.ListNode.registerClass('CUI.ListNode');
CUI.List.registerClass('CUI.List', null, IEnumerable);
CUI.ListEnumerator.registerClass('CUI.ListEnumerator', null, IEnumerator);
CUI.JsonXmlElement.registerClass('CUI.JsonXmlElement');
CUI.Controls.ContextMenuControlProperties.registerClass('CUI.Controls.ContextMenuControlProperties', CUI.MenuLauncherControlProperties);
CUI.Controls.ContextMenuControl.registerClass('CUI.Controls.ContextMenuControl', CUI.ContextMenuLauncher);
CUI.Controls.Button.registerClass('CUI.Controls.Button', CUI.Control, CUI.IMenuItem, CUI.ISelectableControl);
CUI.Controls.CheckBoxCommandProperties.registerClass('CUI.Controls.CheckBoxCommandProperties');
CUI.Controls.ToggleButton.registerClass('CUI.Controls.ToggleButton', CUI.Control, CUI.IMenuItem, CUI.ISelectableControl);
CUI.Controls.CheckBox.registerClass('CUI.Controls.CheckBox', CUI.Controls.ToggleButton);
CUI.Controls.ColorPickerCommandProperties.registerClass('CUI.Controls.ColorPickerCommandProperties');
CUI.Controls.ColorPicker.registerClass('CUI.Controls.ColorPicker', CUI.Control, CUI.IMenuItem);
CUI.Controls.ComboBoxCommandProperties.registerClass('CUI.Controls.ComboBoxCommandProperties');
CUI.Controls.DropDown.registerClass('CUI.Controls.DropDown', CUI.MenuLauncher);
CUI.Controls.ComboBox.registerClass('CUI.Controls.ComboBox', CUI.Controls.DropDown);
CUI.Controls.DropDownCommandProperties.registerClass('CUI.Controls.DropDownCommandProperties');
CUI.Controls.FlyoutAnchor.registerClass('CUI.Controls.FlyoutAnchor', CUI.MenuLauncher);
CUI.Controls.GalleryButtonCommandProperties.registerClass('CUI.Controls.GalleryButtonCommandProperties');
CUI.Controls.GalleryButton.registerClass('CUI.Controls.GalleryButton', CUI.Control, CUI.ISelectableControl);
CUI.Controls.InsertTableCommandProperties.registerClass('CUI.Controls.InsertTableCommandProperties');
CUI.Controls.InsertTable.registerClass('CUI.Controls.InsertTable', CUI.Control);
CUI.Controls.LabelCommandProperties.registerClass('CUI.Controls.LabelCommandProperties');
CUI.Controls.Label.registerClass('CUI.Controls.Label', CUI.Control);
CUI.Controls.MRUSplitButton.registerClass('CUI.Controls.MRUSplitButton', CUI.Controls.DropDown);
CUI.Controls.Separator.registerClass('CUI.Controls.Separator', CUI.Control);
CUI.Controls.SpinnerCommandProperties.registerClass('CUI.Controls.SpinnerCommandProperties');
CUI.Controls.Spinner.registerClass('CUI.Controls.Spinner', CUI.Control);
CUI.Controls.SplitButton.registerClass('CUI.Controls.SplitButton', CUI.MenuLauncher);
CUI.Controls.TextBoxCommandProperties.registerClass('CUI.Controls.TextBoxCommandProperties');
CUI.Controls.TextBox.registerClass('CUI.Controls.TextBox', CUI.Control);
CUI.Controls.ToggleButtonCommandProperties.registerClass('CUI.Controls.ToggleButtonCommandProperties');
CUI.Controls.JewelMenuLauncher.registerClass('CUI.Controls.JewelMenuLauncher', CUI.MenuLauncher);
CUI.Page.CommandDispatcher.registerClass('CUI.Page.CommandDispatcher');
CUI.Page.FocusManager.registerClass('CUI.Page.FocusManager', CUI.Page.CommandDispatcher, CUI.Page.ICommandHandler);
CUI.Page.PageManager.registerClass('CUI.Page.PageManager', CUI.RootUser, CUI.Page.ICommandHandler, CUI.IRootBuildClient);
CUI.Page.UndoManager.registerClass('CUI.Page.UndoManager', null, CUI.Page.ICommandHandler);
Commands.CommandIds.registerClass('Commands.CommandIds');
Commands.GlobalRedoProperties.registerClass('Commands.GlobalRedoProperties');
Commands.RedoProperties.registerClass('Commands.RedoProperties');
Commands.GlobalUndoProperties.registerClass('Commands.GlobalUndoProperties');
Commands.UndoProperties.registerClass('Commands.UndoProperties');
CUI.DataNodeWrapper.ATTRIBUTES = 'attrs';
CUI.DataNodeWrapper.CHILDREN = 'children';
CUI.DataNodeWrapper.NAME = 'name';
CUI.DataNodeWrapper.ALIGNMENT = 'Alignment';
CUI.DataNodeWrapper.ALT = 'Alt';
CUI.DataNodeWrapper.CLASSNAME = 'Classname';
CUI.DataNodeWrapper.COLOR = 'Color';
CUI.DataNodeWrapper.COMMAND = 'Command';
CUI.DataNodeWrapper.CONTEXTUALGROUPID = 'ContextualGroupId';
CUI.DataNodeWrapper.CSSCLASS = 'CssClass';
CUI.DataNodeWrapper.DARKBLUE = 'DarkBlue';
CUI.DataNodeWrapper.DECIMALDIGITS = 'DecimalDigits';
CUI.DataNodeWrapper.DESCRIPTION = 'Description';
CUI.DataNodeWrapper.DISPLAYCOLOR = 'DisplayColor';
CUI.DataNodeWrapper.DISPLAYMODE = 'DisplayMode';
CUI.DataNodeWrapper.DIVIDER = 'Divider';
CUI.DataNodeWrapper.ELEMENTDIMENSIONS = 'ElementDimensions';
CUI.DataNodeWrapper.GREEN = 'Green';
CUI.DataNodeWrapper.GROUPID = 'GroupId';
CUI.DataNodeWrapper.id = 'Id';
CUI.DataNodeWrapper.INDEX = 'Index';
CUI.DataNodeWrapper.INTERVAL = 'Interval';
CUI.DataNodeWrapper.LABELTEXT = 'LabelText';
CUI.DataNodeWrapper.LAYOUTTITLE = 'LayoutTitle';
CUI.DataNodeWrapper.LIGHTBLUE = 'LightBlue';
CUI.DataNodeWrapper.LOWSCALEWARNING = 'LowScaleWarning';
CUI.DataNodeWrapper.MAGENTA = 'Magenta';
CUI.DataNodeWrapper.MAXHEIGHT = 'MaxHeight';
CUI.DataNodeWrapper.MAXIMUMVALUE = 'MaximumValue';
CUI.DataNodeWrapper.MAXWIDTH = 'MaxWidth';
CUI.DataNodeWrapper.MENUITEMID = 'MenuItemId';
CUI.DataNodeWrapper.MESSAGE = 'Message';
CUI.DataNodeWrapper.MINIMUMVALUE = 'MinimumValue';
CUI.DataNodeWrapper.namE_CAPS = 'Name';
CUI.DataNodeWrapper.ONEROW = 'OneRow';
CUI.DataNodeWrapper.ORANGE = 'Orange';
CUI.DataNodeWrapper.POPUP = 'Popup';
CUI.DataNodeWrapper.POPUPSIZE = 'PopupSize';
CUI.DataNodeWrapper.PURPLE = 'Purple';
CUI.DataNodeWrapper.SCROLLABLE = 'Scrollable';
CUI.DataNodeWrapper.SEQUENCE = 'Sequence';
CUI.DataNodeWrapper.SIZE = 'Size';
CUI.DataNodeWrapper.STYLE = 'Style';
CUI.DataNodeWrapper.TEAL = 'Teal';
CUI.DataNodeWrapper.TEMPLATEALIAS = 'TemplateAlias';
CUI.DataNodeWrapper.THREEROW = 'ThreeRow';
CUI.DataNodeWrapper.TITLE = 'Title';
CUI.DataNodeWrapper.TWOROW = 'TwoRow';
CUI.DataNodeWrapper.TYPE = 'Type';
CUI.DataNodeWrapper.VALUE = 'Value';
CUI.DataNodeWrapper.YELLOW = 'Yellow';
CUI.DataNodeWrapper.RIBBON = 'Ribbon';
CUI.DataNodeWrapper.QAT = 'QAT';
CUI.DataNodeWrapper.JEWEL = 'Jewel';
CUI.DataNodeWrapper.TABS = 'Tabs';
CUI.DataNodeWrapper.CONTEXTUALTABS = 'ContextualTabs';
CUI.DataNodeWrapper.CONTEXTUALGROUP = 'ContextualGroup';
CUI.DataNodeWrapper.TAB = 'Tab';
CUI.DataNodeWrapper.SCALING = 'Scaling';
CUI.DataNodeWrapper.MAXSIZE = 'MaxSize';
CUI.DataNodeWrapper.SCALE = 'Scale';
CUI.DataNodeWrapper.GROUP = 'Group';
CUI.DataNodeWrapper.GROUPS = 'Groups';
CUI.DataNodeWrapper.LAYOUT = 'Layout';
CUI.DataNodeWrapper.SECTION = 'Section';
CUI.DataNodeWrapper.OVERFLOWSECTION = 'OverflowSection';
CUI.DataNodeWrapper.ROW = 'Row';
CUI.DataNodeWrapper.CONTROL = 'ControlRef';
CUI.DataNodeWrapper.OVERFLOWAREA = 'OverflowArea';
CUI.DataNodeWrapper.STRIP = 'Strip';
CUI.DataNodeWrapper.CONTROLS = 'Controls';
CUI.DataNodeWrapper.MENU = 'Menu';
CUI.DataNodeWrapper.MENUSECTION = 'MenuSection';
CUI.DataNodeWrapper.TEMPLATE = 'Template';
CUI.DataNodeWrapper.TEMPLATES = 'Templates';
CUI.DataNodeWrapper.RIBBONTEMPLATES = 'RibbonTemplates';
CUI.DataNodeWrapper.GROUPTEMPLATE = 'GroupTemplate';
CUI.DataNodeWrapper.GALLERY = 'Gallery';
CUI.DataNodeWrapper.colors = 'Colors';
CUI.DataNodeWrapper.color = 'Color';
CUI.DataNodeWrapper.toggleButton = 'ToggleButton';
CUI.DataNodeWrapper.comboBox = 'ComboBox';
CUI.DataNodeWrapper.dropDown = 'DropDown';
CUI.DataNodeWrapper.button = 'Button';
CUI.DataNodeWrapper.splitButton = 'SplitButton';
CUI.DataNodeWrapper.flyoutAnchor = 'FlyoutAnchor';
CUI.DataNodeWrapper.galleryButton = 'GalleryButton';
CUI.DataNodeWrapper.insertTable = 'InsertTable';
CUI.DataNodeWrapper.label = 'Label';
CUI.DataNodeWrapper.mruSplitButton = 'MRUSplitButton';
CUI.DataNodeWrapper.spinner = 'Spinner';
CUI.DataNodeWrapper.textBox = 'TextBox';
CUI.DataNodeWrapper.checkBox = 'CheckBox';
CUI.DataNodeWrapper.colorPicker = 'ColorPicker';
CUI.DataNodeWrapper.separator = 'Separator';
CUI.DataNodeWrapper.jewelMenuLauncher = 'JewelMenuLauncher';
CUI.DataNodeWrapper.BUTTONDOCK = 'ButtonDock';
CUI.DataNodeWrapper.BUTTONDOCKS = 'ButtonDocks';
CUI.DataNodeWrapper.CENTERALIGN = 'Center';
CUI.DataNodeWrapper.LEFTALIGN = 'Left';
CUI.DataNodeWrapper.RIGHTALIGN = 'Right';
CUI.DataNodeWrapper.TOOLBAR = 'Toolbar';
CUI.DataNodeWrapper.LARGE = 'Large';
CUI.DataNodeWrapper.MEDIUM = 'Medium';
CUI.DataNodeWrapper.SMALL = 'Small';
CUI.DataNodeWrapper.DIVIDERAFTER = 'DividerAfter';
CUI.DataNodeWrapper.DIVIDERBEFORE = 'DividerBefore';
CUI.DataNodeWrapper.$61_0 = null;
CUI.RibbonPeripheralSection.tabRowLeft = 'TabRowLeft';
CUI.RibbonPeripheralSection.tabRowRight = 'TabRowRight';
CUI.RibbonPeripheralSection.qatRowCenter = 'QATRowCenter';
CUI.RibbonPeripheralSection.qatRowRight = 'QATRowRight';
CUI.TemplateManager.$5W_0 = null;
CUI.Unit.$7V = -1;
CUI.Utility.$Ae = [ '', 'ms-cui-img-5by3', 'ms-cui-img-13by13', 'ms-cui-img-16by16', 'ms-cui-img-32by32', 'ms-cui-img-48by48', 'ms-cui-img-64by48', 'ms-cui-img-72by96', 'ms-cui-img-96by72', 'ms-cui-img-96by96', 'ms-cui-img-56by24', 'ms-cui-img-2by16' ];
CUI.Utility.$AJ = [ '', 'Size16by16', 'Size32by32', 'Size48by48', 'Size64by48', 'Size72by96', 'Size96by72', 'Size96by96', 'Size128by128', 'Size190by30', 'Size190by40', 'Size190by50', 'Size190by60' ];
CUI.Utility.$Ac_0 = [ 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 7, 0, 0, 6, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 8, 0, 1, 0, 0, 0, 2, 3, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 4, 0, 5, 0 ];
CUI.Utility.$19_0 = [ '', '&quot;', '&amp;', '&#39;', '&lt;', '&gt;', ' ', '<br>', '&nbsp;', '<b>', '<i>', '<p>', '<u>', '</b>', '</i>', '</p>', '</u>' ];
CUI.Utility.$BP_0 = false;
CUI.Utility.$BO_0 = false;
CUI.Utility.$6W_0 = false;
CUI.Utility.$6V_0 = false;
CUI.Utility.$5e_0 = null;
CUI.ScriptUtility.emptyString = '';
CUI.Controls.CheckBoxCommandProperties.On = 'On';
CUI.Controls.CheckBoxCommandProperties.CommandValueId = 'CommandValueId';
CUI.Controls.ColorPickerCommandProperties.Color = 'Color';
CUI.Controls.ColorPickerCommandProperties.Style = 'Style';
CUI.Controls.ColorPicker.$7_1 = -10;
CUI.Controls.ComboBoxCommandProperties.SelectedItemId = 'SelectedItemId';
CUI.Controls.ComboBoxCommandProperties.IsFreeForm = 'IsFreeForm';
CUI.Controls.ComboBoxCommandProperties.Value = 'Value';
CUI.Controls.DropDownCommandProperties.SelectedItemId = 'SelectedItemId';
CUI.Controls.DropDownCommandProperties.Value = 'Value';
CUI.Controls.GalleryButtonCommandProperties.On = 'On';
CUI.Controls.GalleryButtonCommandProperties.CommandValueId = 'CommandValueId';
CUI.Controls.InsertTableCommandProperties.Rows = 'Rows';
CUI.Controls.InsertTableCommandProperties.Columns = 'Columns';
CUI.Controls.LabelCommandProperties.Value = 'Value';
CUI.Controls.SpinnerCommandProperties.ChangedByMouse = 'ChangedByMouse';
CUI.Controls.SpinnerCommandProperties.ChangeType = 'ChangeType';
CUI.Controls.SpinnerCommandProperties.Value = 'Value';
CUI.Controls.SpinnerCommandProperties.Unit = 'Unit';
CUI.Controls.Spinner.$7C_1 = -1;
CUI.Controls.TextBoxCommandProperties.Value = 'Value';
CUI.Controls.ToggleButtonCommandProperties.On = 'On';
CUI.Controls.ToggleButtonCommandProperties.CommandValueId = 'CommandValueId';
CUI.Page.PageManager._instance = null;
CUI.Page.UndoManager.$28_0 = -1;
Commands.CommandIds.ApplicationStateChanged = 'appstatechanged';
Commands.CommandIds.GlobalRedo = 'GlobalRedo';
Commands.CommandIds.Redo = 'Redo';
Commands.CommandIds.GlobalUndo = 'GlobalUndo';
Commands.CommandIds.Undo = 'Undo';
Commands.GlobalRedoProperties.SequenceNumber = 'SequenceNumber';
Commands.RedoProperties.SequenceNumber = 'SequenceNumber';
Commands.GlobalUndoProperties.SequenceNumber = 'SequenceNumber';
Commands.UndoProperties.SequenceNumber = 'SequenceNumber';

var g_cuiXMLDOMDocument = null;
var g_cuiXMLParser = null;

CUI.NativeUtility = function CUI_NativeUtility()
{};

CUI.NativeUtility.createXMLDocFromString = function (xml)
{ULSpEN:;
    return CUI.NativeUtility.createXMLDocFromStringCore(xml, false);
}

CUI.NativeUtility.createXMLDocFromStringCore = function (xml, newObj)
{ULSpEN:;
    if (window.ActiveXObject) 
    {
        var msxmlDomDoc = newObj ? null : g_cuiXMLDOMDocument;
        if (!msxmlDomDoc) {
            try
            {
                msxmlDomDoc = new ActiveXObject("MSXML.DomDocument");
                if (!newObj) 
                    g_cuiXMLDOMDocument = msxmlDomDoc;
            }
            catch(e)
            {

            }
        }
        if(msxmlDomDoc != null)
            msxmlDomDoc.loadXML(xml);
        return msxmlDomDoc;
    }
    else if (DOMParser) 
    {
        var domParser = newObj ? null : g_cuiXMLParser;
        if (!domParser) {
            domParser = new DOMParser();
            if (!newObj) 
                g_cuiXMLParser = domParser;
        }
        return domParser.parseFromString(xml, "text/xml");
    }
    else if (window.XMLHttpRequest) 
    {

        var request = new XMLHttpRequest();

        request.open("GET", "data:text/xml;charset=utf-8," + xml, false);
        request.send(null);
        return request.responseXML();
    }

    return null;
}

if( typeof(Sys) != "undefined" && Sys && Sys.Application ){
   Sys.Application.notifyScriptLoaded();
}

CUI.NativeUtility.setInnerText = function (elem, text)
{ULSpEN:;
    var doc = elem.ownerDocument;
    if (doc.createTextNode)
    {
        var textNode = doc.createTextNode(text);
        elem.innerHTML = '';
        elem.appendChild(textNode);        
    }
    else
    {
        elem.innerText = text;
    }
};

CUI.NativeUtility.ecmaScriptStringLiteralEncode = function (str)
{ULSpEN:;
    if(null == str || typeof(str) == 'undefined')
        return "";
    var strIn = new String(str);
    var strOut = new Array();
    var ix = 0;
    var max = strIn.length;

    for (ix = 0; ix < max; ix++)
    {
        var charCode = strIn.charCodeAt(ix);
        if (charCode > 0x0fff)
        {

            strOut.push("\\u" + charCode.toString(16).toUpperCase());
        }
        else if (charCode > 0x00ff)
        {

            strOut.push("\\u0" + charCode.toString(16).toUpperCase());
        }
        else if (charCode > 0x007f)
        {

            strOut.push("\\u00" + charCode.toString(16).toUpperCase());
        }
        else
        {
            var c = strIn.charAt(ix);
            switch (c)
            {
            case '\n':
                strOut.push("\\n");
                break;
            case '\r':
                strOut.push("\\r");
                break;
            case '\"':
                strOut.push("\\u0022");
                break;
            case '%':
                strOut.push("\\u0025");
                break;
            case '&':
                strOut.push("\\u0026");
                break;
            case '\'':
                strOut.push("\\u0027");
                break;
            case '(':
                strOut.push("\\u0028");
                break;
            case ')':
                strOut.push("\\u0029");
                break;
            case '+':
                strOut.push("\\u002b");
                break;
            case '/':
                strOut.push("\\u002f");
                break;
            case '<':
                strOut.push("\\u003c");
                break;
            case '>':
                strOut.push("\\u003e");
                break;
            case '\\':
                strOut.push("\\\\");
                break;
            default:
                strOut.push(c);
            };
        }
    }
    return strOut.join('');
};

CUI.NativeUtility.ffClick = function SP_Ribbon__nativeUtility$FFClick(elm) {ULSpEN:;
  var evt = document.createEvent("MouseEvents");
  evt.initMouseEvent("click", true, true, window, 0, 0, 0, 0, 0, false, false, false, false, 0, null); elm.dispatchEvent(evt);
};

CUI.NativeUtility.getAttribute = function SP_Ribbon__nativeUtility$GetAttribute(attributes, index) {ULSpEN:;
  return attributes[index];
};

CUI.NativeUtility.returnFalse = function SP_Ribbon__nativeUtility$ReturnFalse() {ULSpEN:;
  return false;
};

var g_records = new Array();
CUI.PMetrics = function(){};
CUI.PMetrics.perfMark = function(marker) {ULSpEN:;
    var r = new Object();
    r.m = marker;
    r.mt = new Date();
    if(g_records) {
        if(g_records.length == 1000)
            g_records = new Array();
        g_records.push(r);
    }
}
CUI.PMetrics.perfReport = function(){ULSpEN:;
    if(!g_records)
        return;
    var l = g_records.length;
    if (l>0) {
        var _elmResults = document.getElementById("perf-markers");
        if (!_elmResults) {
            _elmResults = document.createElement('div');
            _elmResults.id = 'perf-markers';
            _elmResults.style.display = 'none';
        }
        var r;
        var rstr = "";
        for(i=0;i<l;i++) {
            r = g_records[i];
            if(r)
                rstr += '<p><span class=\'time\'>' + r.mt.format('MM/dd/yyyy HH:mm:ss.fffffff') + '</span>' + '<span class=\'marker\'>' + r.m + '</span>'+ '<var class=\'milliseconds\'>' + r.mt.getTime() + '</var></p>';
        }
        _elmResults.innerHTML += rstr;
        document.body.appendChild(_elmResults);
        g_records = new Array();
    }
}
CUI.PMetrics.perfClear = function(){ULSpEN:;
    g_records = new Array();
}

if( typeof(Sys) != "undefined" && Sys && Sys.Application ){
   Sys.Application.notifyScriptLoaded();
}
if (typeof(NotifyScriptLoadedAndExecuteWaitingJobs ) != "undefined")
    NotifyScriptLoadedAndExecuteWaitingJobs("CUI.js");
