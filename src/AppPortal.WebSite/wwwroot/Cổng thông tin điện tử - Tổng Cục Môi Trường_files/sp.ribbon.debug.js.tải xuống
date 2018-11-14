function ULSMg8(){var o=new Object;o.ULSTeamName="Microsoft SharePoint Foundation";o.ULSFileName="SP.Ribbon.debug.js";return o;}
// JScript File


Type.registerNamespace('SP');

SP.BWsaStreamTypes = function() {}
SP.BWsaStreamTypes.prototype = {
    static: 1, 
    cyclic: 2
}
SP.BWsaStreamTypes.registerEnum('SP.BWsaStreamTypes', false);


SP.SQMDP = function() {}
SP.SQMDP.prototype = {
    none: 0, 
    dataiD_SESSION_TYPE: 60, 
    dataiD_BSQM_BROWSERINFO: 7982, 
    dataiD_BSQM_MAXSTREAMROWS: 7993, 
    dataiD_BSQM_MAXLSTREAMROWSOVERWRITTEN: 7994, 
    dataiD_BSQM_MAXSTREAMROWSOVERWRITTENSTREAMID: 8047, 
    dataiD_BSQM_MAXSTREAMROWSSTREAMID: 8048, 
    dataiD_BSQM_OSDATA: 8049, 
    dataiD_BSQM_COMMANDUIACTION: 8327, 
    dataiD_BSQM_APPVER: 8472, 
    dataiD_BSQM_INVALIDVALUEDP: 8763, 
    dataiD_OFFICESQMSESSIONTYPE: 8814
}
SP.SQMDP.registerEnum('SP.SQMDP', false);


SP.BWsaConfig = function() {ULSMg8:;
    this.$2G = [ 60, 7982, 7993, 7994, 8047, 8048, 8049, 8472 ];
    this.$1q = '';
    this.$G = false;
    this.$1n = 1800000;
    this.$2T = 65536;
    this.$1o = 2147483647;
    this.$4H = 9;
    this.$4I = 1000;
    this.$2U = 1000;
}
SP.BWsaConfig.prototype = {
    $1q: null,
    $G: false,
    $1n: 0,
    $2T: 0,
    $1o: 0,
    $4I: 0,
    $2U: 0,
    $4H: 0,
    
    get_maxSessionMs: function() {ULSMg8:;
        return this.$1n;
    },
    set_maxSessionMs: function(value) {ULSMg8:;
        this.$1n = value;
        return value;
    }
}


SP.Ticks = function() {
}
SP.Ticks.getTicks32 = function() {ULSMg8:;
    var $v_0 = new Date();
    var $v_1 = $v_0.getTime();
    if (!SP.Ticks.$1x_0) {
        SP.Ticks.$1x_0 = $v_1;
    }
    return ((1 + $v_1 - SP.Ticks.$1x_0) & 2147483647);
}
SP.Ticks.getTicks64 = function() {ULSMg8:;
    var $v_0 = new Date();
    var $v_1 = $v_0.getTime();
    $v_1 = $v_1 + 11644473600000;
    $v_1 = $v_1 * 10000;
    return $v_1;
}


SP.TimerResetCheck = function() {
}
SP.TimerResetCheck.isTimerResetNeeded = function() {ULSMg8:;
    var $v_0 = false;
    var $v_1 = new Date();
    var $v_2 = $v_1.getTime();
    if (!SP.TimerResetCheck.$1c_0 || $v_2 - SP.TimerResetCheck.$1c_0 > 60000) {
        $v_0 = true;
        SP.TimerResetCheck.$1c_0 = $v_2;
    }
    return $v_0;
}


SP.StreamRowCounters = function() {
}


SP.BWsaDatapoint = function(id) {ULSMg8:;
    this.m_WsaId = id;
    this.m_Value = 0;
    this.m_Ticks = SP.Ticks.getTicks32();
    this.m_Count = 0;
    this.m_Sum = 0;
}
SP.BWsaDatapoint.prototype = {
    m_WsaId: 0,
    m_Value: 0,
    m_Ticks: 0,
    m_Count: 0,
    m_Sum: 0
}


SP.WsaStreamRow = function(dwNumElements) {ULSMg8:;
    this.m_Ticks = SP.Ticks.getTicks32();
    this.m_Values = new Array(dwNumElements);
}
SP.WsaStreamRow.prototype = {
    m_Ticks: 0,
    m_Values: null
}


SP.BWsaStream = function(id, type, width, max) {ULSMg8:;
    if (max < 1 || max > 1000) {
        max = 1000;
    }
    this.m_WsaId = id;
    this.m_StreamType = type;
    this.m_Width = width;
    this.m_MaxRows = max;
    this.m_RowCount = 0;
    this.m_RowsOverwritten = 0;
    this.m_Rows = {};
}
SP.BWsaStream.prototype = {
    m_WsaId: 0,
    m_StreamType: 0,
    m_Width: 0,
    m_MaxRows: 0,
    m_RowCount: 0,
    m_RowsOverwritten: 0,
    m_Rows: null
}


SP.BWsaHeader = function() {ULSMg8:;
    this.m_StartTime = SP.Ticks.getTicks64();
    this.m_EndTime = 0;
}
SP.BWsaHeader.prototype = {
    m_StartTime: 0,
    m_EndTime: 0
}


SP.BWsaData = function() {ULSMg8:;
    this.m_cDataPoints = 0;
    this.m_cStreams = 0;
    this.m_cbStreams = 0;
    this.m_wsaHeader = new SP.BWsaHeader();
    this.m_wsaDatapoints = {};
    this.m_wsaStreams = {};
}
SP.BWsaData.prototype = {
    m_cDataPoints: 0,
    m_cStreams: 0,
    m_cbStreams: 0,
    m_wsaHeader: null,
    m_wsaDatapoints: null,
    m_wsaStreams: null
}


SP.BWsaClient = function(uploadUrl, fIsOptedIn) {ULSMg8:;
    this.$2h = Function.createDelegate(this, this.$4q_0);
    this.$7_0 = new SP.BWsaData();
    this.$6_0 = new SP.BWsaConfig();
    this.$2O_0 = false;
    this.$1l_0 = 0;
    this.$t_0 = 0;
    this.$1F_0 = false;
    this.$1g_0 = {};
    for (var $v_0 = 0; $v_0 < this.$6_0.$2G.length; $v_0++) {
        this.$1g_0[this.$6_0.$2G[$v_0]] = true;
    }
    this.$6_0.$1q = uploadUrl;
    this.$6_0.$G = (uploadUrl === '') ? false : fIsOptedIn;
}
SP.BWsaClient.$5i_0 = function() {ULSMg8:;
    var $v_0 = 0;
    var $v_1 = window.navigator.userAgent;
    var $v_2 = -1;
    if (($v_2 = $v_1.indexOf(' MSIE ')) > -1) {
        $v_2 += 6;
        $v_0 = (2) << 24;
    }
    else if (($v_2 = $v_1.indexOf(' Firefox/')) > -1) {
        $v_2 += 9;
        $v_0 = (3) << 24;
    }
    else if (($v_2 = $v_1.indexOf(' Chrome/')) > -1) {
        $v_2 += 8;
        $v_0 = (6) << 24;
    }
    else if (($v_2 = $v_1.indexOf(' Safari/')) > -1 && ($v_2 = $v_1.indexOf(' Version/')) > -1) {
        $v_2 += 9;
        $v_0 = (4) << 24;
    }
    else if (($v_2 = $v_1.indexOf('Opera/')) > -1) {
        $v_2 += 6;
        $v_0 = (5) << 24;
    }
    else {
        $v_0 = (1 << 24);
        $v_2 = -1;
    }
    if ($v_2 >= 0) {
        var $v_3 = SP.BWsaClient.$43_0($v_1.substr($v_2));
        if (Sys.Browser.agent === Sys.Browser.InternetExplorer && $v_3[0] === 7 && $v_1.indexOf('Trident/4.0') >= 0) {
            $v_3[0] = 8;
        }
        $v_0 = $v_0 | (($v_3[0] << 16) + $v_3[1]);
    }
    try {
        if (window.navigator.cookieEnabled) {
            $v_0 = ($v_0 | 1073741824);
        }
        else {
            $v_0 = ($v_0 | 1610612736);
        }
    }
    catch ($$e_1_0) {
    }
    $v_0 = $v_0;
    return $v_0;
}
SP.BWsaClient.$43_0 = function($p0) {
    var $v_0 = [ 0, 0 ];
    if (SP.BWsaClient.$2K_0($p0.charAt(0))) {
        $v_0[0] = parseInt($p0);
    }
    for (var $v_1 = 0; $v_1 < $p0.length; $v_1++) {
        if (!SP.BWsaClient.$2K_0($p0.charAt($v_1))) {
            $p0 = $p0.substr($v_1 + 1);
            break;
        }
    }
    if (SP.BWsaClient.$2K_0($p0.charAt(0))) {
        $v_0[1] = parseInt($p0);
    }
    if ($v_0[0] < 0 || $v_0[0] > 255 || $v_0[1] < 0 || $v_0[1] > 65535) {
        $v_0[0] = 0;
        $v_0[1] = 0;
    }
    return $v_0;
}
SP.BWsaClient.$5m_0 = function() {ULSMg8:;
    var $v_0 = 0;
    var $v_1 = 1;
    var $v_2 = window.navigator.userAgent;
    if ($v_2.indexOf('Windows CE') >= 0) {
        $v_1 = 3;
    }
    else if ($v_2.indexOf('Windows') >= 0) {
        $v_1 = 2;
    }
    else if ($v_2.indexOf('PPC') >= 0 || $v_2.indexOf('Macintosh') >= 0) {
        $v_1 = 4;
    }
    else if ($v_2.indexOf('SunOS') >= 0) {
        $v_1 = 5;
    }
    else if ($v_2.indexOf('Linux') >= 0) {
        $v_1 = 6;
    }
    $v_0 = ($v_1 << 24);
    if ($v_2.indexOf('Windows 95') >= 0) {
        $v_0 = $v_0 + 6225920;
    }
    else if ($v_2.indexOf('Windows 9x') >= 0) {
        $v_0 = $v_0 + 6488064;
    }
    else if ($v_2.indexOf('Windows 98') >= 0) {
        $v_0 = $v_0 + 6422528;
    }
    else if ($v_2.indexOf('Windows NT 5.01') >= 0) {
        $v_0 = $v_0 + 327680 | 254;
    }
    else {
        var $v_4 = 'Windows NT ';
        var $v_5 = $v_2.indexOf($v_4);
        if ($v_5 < 0) {
            $v_4 = 'Mac OS X ';
            $v_5 = $v_2.indexOf($v_4);
        }
        if ($v_5 >= 0) {
            var $v_6 = SP.BWsaClient.$43_0($v_2.substr($v_5 + $v_4.length));
            $v_0 = $v_0 + (($v_6[0] << 16) + $v_6[1]);
        }
    }
    var $v_3 = 0;
    try {
        var $v_7 = window.navigator.platform;
        if ($v_2.indexOf('WOW64') !== -1) {
            $v_3 = 2;
        }
        else if ($v_7 === 'Win64') {
            $v_3 = 3;
        }
        else if ($v_7 === 'Win32' || $v_7 === 'Linux i686') {
            $v_3 = 1;
        }
    }
    catch ($$e_1_0) {
    }
    $v_0 = ($v_0 | ($v_3 << 29));
    return $v_0;
}
SP.BWsaClient.$6V_0 = function($p0) {
    var $v_0 = new Sys.StringBuilder();
    var $v_1 = true;
    $v_0.append('{');
    $v_0.append('\"StartTime\":' + $p0.m_wsaHeader.m_StartTime + ',');
    $v_0.append('\"EndTime\":' + $p0.m_wsaHeader.m_EndTime + ',');
    $v_0.append('\"wsaDatapoints\":[');
    var $$dict_1_0 = $p0.m_wsaDatapoints;
    for (var $$key_1_1 in $$dict_1_0) {
        var $v_2 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
        var $v_3 = $v_2.value;
        if (!$v_1) {
            $v_0.append(',');
        }
        $v_0.append('{\"Id\":' + $v_3.m_WsaId + ',');
        $v_0.append('\"Val\":' + $v_3.m_Value + ',');
        $v_0.append('\"Tic\":' + $v_3.m_Ticks + '}');
        $v_1 = false;
    }
    $v_0.append('],\"wsaStreams\":[');
    $v_1 = true;
    var $$dict_1_0 = $p0.m_wsaStreams;
    for (var $$key_1_1 in $$dict_1_0) {
        var $v_4 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
        var $v_5 = $v_4.value;
        var $v_6 = true;
        if (!$v_1) {
            $v_0.append(',');
        }
        $v_0.append('{\"Id\":' + $v_5.m_WsaId + ',');
        $v_0.append('\"Width\":' + $v_5.m_Width + ',');
        $v_0.append('\"Rows\":[');
        var $$dict_3_0 = $v_5.m_Rows;
        for (var $$key_3_1 in $$dict_3_0) {
            var $v_7 = { key: $$key_3_1, value: $$dict_3_0[$$key_3_1] };
            var $v_8 = $v_7.value;
            if (!$v_6) {
                $v_0.append(',');
            }
            $v_0.append('{\"Tic\":' + $v_8.m_Ticks + ',');
            $v_0.append('\"Vals\":[');
            for (var $v_9 = 0; $v_9 < $v_8.m_Values.length; $v_9++) {
                if ($v_9 > 0) {
                    $v_0.append(',');
                }
                $v_0.append($v_8.m_Values[$v_9]);
            }
            $v_0.append(']}');
            $v_6 = false;
        }
        $v_0.append(']}');
        $v_1 = false;
    }
    $v_0.append(']}');
    return $v_0.toString();
}
SP.BWsaClient.$2K_0 = function($p0) {
    return ($p0 >= '0' && $p0 <= '9');
}
SP.BWsaClient.getSQMLocationFromCUICommandInfo = function(commandInfo) {ULSMg8:;
    if (!commandInfo) {
        return 0;
    }
    var $v_0 = 0;
    var $v_1 = commandInfo['RootType'];
    var $v_2 = commandInfo['RootLocation'];
    if ($v_1) {
        if ($v_1 === 'Ribbon') {
            if ($v_2 === 'LowerRibbon') {
                $v_0 = 2;
            }
            else if ($v_2 === 'UpperRibbon') {
                $v_0 = 1;
            }
        }
        else if ($v_1 === 'QAT') {
            $v_0 = 3;
        }
        else if ($v_1 === 'Jewel') {
            $v_0 = 4;
        }
    }
    return $v_0;
}
SP.BWsaClient.prototype = {
    $7_0: null,
    $6_0: null,
    $2O_0: false,
    $1l_0: 0,
    $t_0: 0,
    $1F_0: false,
    $1g_0: null,
    $f_0: null,
    
    get_wsaConfig: function() {ULSMg8:;
        return this.$6_0;
    },
    
    $2Y_0: function() {ULSMg8:;
        var $v_0 = (this.$7_0.m_cDataPoints * SP.BWsaClient.$1J_0) + this.$7_0.m_cbStreams;
        if ($v_0 >= this.$6_0.$2T) {
            this.uploadWsaData();
            $v_0 = (this.$7_0.m_cDataPoints * SP.BWsaClient.$1J_0) + this.$7_0.m_cbStreams;
            return ($v_0 >= this.$6_0.$2T);
        }
        return (false);
    },
    
    $4X_0: function($p0) {
        try {
            if (this.$1F_0 || this.$1g_0[$p0]) {
                return;
            }
            this.$1F_0 = true;
            var $v_0 = SP.OfficeVersion.fullBuildBase.split('.');
            this.$1S_0(8472, ((parseInt($v_0[2]) << 16) + parseInt($v_0[0])));
            this.$1S_0(7982, SP.BWsaClient.$5i_0());
            this.$1S_0(8049, SP.BWsaClient.$5m_0());
            this.$1S_0(8814, 3);
        }
        catch ($$e_1_0) {
        }
    },
    
    setDw: function(dwDatapointId, dwDatapointValue) {ULSMg8:;
        try {
            if (!this.$6_0.$G) {
                return;
            }
            if (Object.getType(dwDatapointId) !== Number || Object.getType(dwDatapointValue) !== Number) {
                return;
            }
            if (dwDatapointId < 1 || dwDatapointId > this.$6_0.$1o) {
                return;
            }
            if (dwDatapointValue < 0 || dwDatapointValue > 4294967295) {
                this.setDw(8763, dwDatapointId);
                return;
            }
            if (this.$2Y_0()) {
                return;
            }
            this.$4X_0(dwDatapointId);
            this.$n_0();
            var $v_0 = this.$7_0.m_wsaDatapoints[dwDatapointId];
            if (!$v_0) {
                $v_0 = new SP.BWsaDatapoint(dwDatapointId);
                this.$7_0.m_wsaDatapoints[dwDatapointId] = $v_0;
                this.$7_0.m_cDataPoints++;
            }
            $v_0.m_Value = dwDatapointValue;
            $v_0.m_Count++;
            $v_0.m_Sum = dwDatapointValue + $v_0.m_Sum;
        }
        catch ($$e_1_0) {
        }
    },
    
    setBool: function(dwDatapointId, dwDatapointValue) {ULSMg8:;
        if (dwDatapointValue) {
            dwDatapointValue = 1;
        }
        this.setDw(dwDatapointId, dwDatapointValue);
    },
    
    setBitsOrAnd: function(dwDatapointId, dwOrBits, dwAndBitsFirst) {ULSMg8:;
        try {
            if (!this.$6_0.$G) {
                return;
            }
            if (Object.getType(dwDatapointId) !== Number || Object.getType(dwOrBits) !== Number || Object.getType(dwAndBitsFirst) !== Number) {
                return;
            }
            if (dwOrBits < 0 || dwOrBits > 4294967295 || dwAndBitsFirst < 0 || dwAndBitsFirst > 4294967295) {
                this.setDw(8763, dwDatapointId);
                return;
            }
            var $v_0 = this.$7_0.m_wsaDatapoints[dwDatapointId];
            if ($v_0) {
                this.$n_0();
                $v_0.m_Value &= dwAndBitsFirst;
                $v_0.m_Value |= dwOrBits;
                $v_0.m_Count++;
            }
            else {
                this.setDw(dwDatapointId, dwOrBits);
            }
        }
        catch ($$e_1_0) {
        }
    },
    
    setBitsOr: function(dwDatapointId, dwOrBits) {ULSMg8:;
        this.setBitsOrAnd(dwDatapointId, dwOrBits, 4294967295);
    },
    
    setBitsAnd: function(dwDatapointId, dwAndBits) {ULSMg8:;
        this.setBitsOrAnd(dwDatapointId, 0, dwAndBits);
    },
    
    setIfMax: function(dwDatapointId, dwDatapointValue) {ULSMg8:;
        try {
            if (!this.$6_0.$G) {
                return;
            }
            if (Object.getType(dwDatapointId) !== Number || Object.getType(dwDatapointValue) !== Number) {
                return;
            }
            var $v_0 = this.$7_0.m_wsaDatapoints[dwDatapointId];
            if (!$v_0 || $v_0.m_Value < dwDatapointValue) {
                this.setDw(dwDatapointId, dwDatapointValue);
            }
            else {
                this.$n_0();
            }
        }
        catch ($$e_1_0) {
        }
    },
    
    setIfMin: function(dwDatapointId, dwDatapointValue) {ULSMg8:;
        try {
            if (!this.$6_0.$G) {
                return;
            }
            if (Object.getType(dwDatapointId) !== Number || Object.getType(dwDatapointValue) !== Number) {
                return;
            }
            var $v_0 = this.$7_0.m_wsaDatapoints[dwDatapointId];
            if (!$v_0 || $v_0.m_Value > dwDatapointValue) {
                this.setDw(dwDatapointId, dwDatapointValue);
            }
            else {
                this.$n_0();
            }
        }
        catch ($$e_1_0) {
        }
    },
    
    incrementDw: function(dwDatapointId, dwInc) {ULSMg8:;
        try {
            if (!this.$6_0.$G) {
                return;
            }
            if (Object.getType(dwDatapointId) !== Number || Object.getType(dwInc) !== Number) {
                return;
            }
            if (!dwInc) {
                this.$n_0();
                return;
            }
            var $v_0 = 0;
            var $v_1 = this.$7_0.m_wsaDatapoints[dwDatapointId];
            if ($v_1) {
                $v_0 = $v_1.m_Value;
            }
            this.setDw(dwDatapointId, $v_0 + dwInc);
        }
        catch ($$e_1_0) {
        }
    },
    
    addToAverage: function(dwDatapointId, dwDatapointValue) {ULSMg8:;
        try {
            if (!this.$6_0.$G) {
                return;
            }
            if (Object.getType(dwDatapointId) !== Number || Object.getType(dwDatapointValue) !== Number) {
                return;
            }
            this.setDw(dwDatapointId, dwDatapointValue);
            var $v_0 = this.$7_0.m_wsaDatapoints[dwDatapointId];
            if ($v_0) {
                $v_0.m_Value = Math.floor($v_0.m_Sum / $v_0.m_Count);
            }
        }
        catch ($$e_1_0) {
        }
    },
    
    createStream: function(WsaStreamEntryId, dwStreamType, dwWidth, dwMaxRows) {ULSMg8:;
        try {
            if (!this.$6_0.$G) {
                return;
            }
            if (WsaStreamEntryId < 1 || WsaStreamEntryId > this.$6_0.$1o) {
                return;
            }
            if (dwStreamType !== 1 && dwStreamType !== 2) {
                return;
            }
            if (dwWidth < 1 || dwWidth > this.$6_0.$4H) {
                return;
            }
            if (this.$2Y_0()) {
                return;
            }
            if (dwMaxRows < 1 || dwMaxRows > this.$6_0.$2U) {
                dwMaxRows = this.$6_0.$2U;
            }
            if (!this.$7_0.m_wsaStreams[WsaStreamEntryId]) {
                var $v_0 = new SP.BWsaStream(WsaStreamEntryId, dwStreamType, dwWidth, dwMaxRows);
                this.$7_0.m_wsaStreams[WsaStreamEntryId] = $v_0;
                this.$7_0.m_cStreams++;
                this.$7_0.m_cbStreams += SP.BWsaClient.$1J_0;
            }
        }
        catch ($$e_1_0) {
        }
    },
    
    $6M_0: function($p0) {
        delete $p0.m_Rows[$p0.m_RowsOverwritten];
        this.$7_0.m_cbStreams -= (($p0.m_Width + 1) * 4);
        $p0.m_RowCount--;
        $p0.m_RowsOverwritten++;
        if ($p0.m_RowsOverwritten > SP.StreamRowCounters.maxOverwritten) {
            SP.StreamRowCounters.maxOverwritten = $p0.m_RowsOverwritten;
            this.setDw(7994, $p0.m_RowsOverwritten);
            this.setDw(8047, $p0.m_WsaId);
        }
    },
    
    addToStreamDw8: function(dwStreamId, dwValue1, dwValue2, dwValue3, dwValue4, dwValue5, dwValue6, dwValue7, dwValue8) {ULSMg8:;
        try {
            var $v_0 = new SP.WsaStreamRow(8);
            $v_0.m_Values[0] = dwValue1;
            $v_0.m_Values[1] = dwValue2;
            $v_0.m_Values[2] = dwValue3;
            $v_0.m_Values[3] = dwValue4;
            $v_0.m_Values[4] = dwValue5;
            $v_0.m_Values[5] = dwValue6;
            $v_0.m_Values[6] = dwValue7;
            $v_0.m_Values[7] = dwValue8;
            this.$4l_0(dwStreamId, $v_0);
        }
        catch ($$e_1_0) {
        }
    },
    
    $4l_0: function($p0, $p1) {
        if (!this.$6_0.$G) {
            return;
        }
        if ($p0 < 1 || $p0 > this.$6_0.$1o) {
            return;
        }
        if (this.$2Y_0()) {
            return;
        }
        this.$4X_0($p0);
        for (var $v_1 = 0; $v_1 < $p1.m_Values.length; $v_1++) {
            var $v_2 = $p1.m_Values[$v_1];
            if ($v_2 < 0 || $v_2 > 4294967295) {
                this.setDw(8763, $p0);
                return;
            }
        }
        var $v_0 = this.$7_0.m_wsaStreams[$p0];
        if ($v_0) {
            this.$n_0();
            if ($v_0.m_Width !== $p1.m_Values.length) {
                return;
            }
            if ($v_0.m_RowCount >= $v_0.m_MaxRows && $v_0.m_StreamType === 2) {
                this.$6M_0($v_0);
            }
            if ($v_0.m_RowCount < $v_0.m_MaxRows) {
                var $v_3 = ($v_0.m_RowCount + $v_0.m_RowsOverwritten);
                $v_0.m_Rows[$v_3] = $p1;
                $v_0.m_RowCount++;
                this.$7_0.m_cbStreams += (($v_0.m_Width + 1) * 4);
                if ($v_0.m_RowCount > SP.StreamRowCounters.maxRowCount) {
                    SP.StreamRowCounters.maxRowCount = $v_0.m_RowCount;
                    this.setDw(7993, $v_0.m_RowCount);
                    this.setDw(8048, $v_0.m_WsaId);
                }
            }
            else {
                $v_0.m_RowsOverwritten++;
                if ($v_0.m_RowsOverwritten > SP.StreamRowCounters.maxOverwritten) {
                    SP.StreamRowCounters.maxOverwritten = $v_0.m_RowsOverwritten;
                    this.setDw(7994, $v_0.m_RowsOverwritten);
                    this.setDw(8047, $v_0.m_WsaId);
                }
            }
        }
    },
    
    terminate: function() {ULSMg8:;
        this.uploadWsaData();
    },
    
    uploadWsaData: function() {ULSMg8:;
        try {
            this.$1U_0();
            if (!this.$7_0 || !this.$6_0) {
                return;
            }
            if (!this.$6_0.$G) {
                return;
            }
            if (this.$6_0.$1q === '') {
                this.$6_0.$G = false;
                return;
            }
            var $v_0 = SP.Ticks.getTicks32();
            if (this.$1l_0 > 0 && $v_0 <= this.$1l_0 + this.$6_0.$4I) {
                return;
            }
            this.$1l_0 = $v_0;
            var $v_1 = new Array(0);
            var $$dict_2_0 = this.$7_0.m_wsaStreams;
            for (var $$key_2_1 in $$dict_2_0) {
                var $v_2 = { key: $$key_2_1, value: $$dict_2_0[$$key_2_1] };
                var $v_3 = $v_2.value;
                if (!$v_3.m_RowCount) {
                    $v_1[$v_1.length] = $v_2.key;
                }
            }
            for (var $v_4 = 0; $v_4 < $v_1.length; $v_4++) {
                delete this.$7_0.m_wsaStreams[$v_1[$v_4]];
                this.$7_0.m_cStreams--;
                this.$7_0.m_cbStreams -= SP.BWsaClient.$1J_0;
            }
            if (this.$1F_0) {
                if (this.$2O_0) {
                    this.setDw(60, 1);
                }
                else {
                    this.setDw(60, 0);
                    this.$2O_0 = true;
                }
                this.$7_0.m_wsaHeader.m_EndTime = SP.Ticks.getTicks64();
                var $v_5 = SP.BWsaClient.$6V_0(this.$7_0);
                this.$7_0 = new SP.BWsaData();
                this.$1F_0 = false;
                if ($v_5 && $v_5.length > 0) {
                    this.uploadWsaDataRequest($v_5);
                }
            }
        }
        catch ($$e_1_0) {
        }
    },
    
    uploadWsaDataRequest: function(json) {ULSMg8:;
        if (!this.$f_0) {
            this.$f_0 = new XMLHttpRequest();
        }
        if (this.$f_0.readyState === 0 || this.$f_0.readyState === 4) {
            this.$f_0.open('POST', this.$6_0.$1q, true);
            this.$f_0.setRequestHeader('Content-Type', 'application/json');
            this.$f_0.send(json);
        }
    },
    
    isUserOptedIn: function() {ULSMg8:;
        return this.$6_0.$G;
    },
    
    disable: function() {ULSMg8:;
        try {
            this.$1U_0();
            this.$6_0.$G = false;
        }
        catch ($$e_1_0) {
        }
    },
    
    $1S_0: function($p0, $p1) {
        if (!this.$7_0.m_wsaDatapoints[$p0]) {
            var $v_0 = new SP.BWsaDatapoint($p0);
            $v_0.m_Value = $p1;
            this.$7_0.m_wsaDatapoints[$p0] = $v_0;
            this.$7_0.m_cDataPoints++;
        }
    },
    
    $1U_0: function() {ULSMg8:;
        if (this.$t_0) {
            window.clearTimeout(this.$t_0);
            this.$t_0 = 0;
        }
    },
    
    $n_0: function() {ULSMg8:;
        if (SP.TimerResetCheck.isTimerResetNeeded()) {
            this.$1U_0();
            this.$t_0 = window.setTimeout(this.$2h, this.$6_0.$1n);
        }
    },
    
    $4q_0: function() {ULSMg8:;
        this.$t_0 = 0;
        this.$1U_0();
        this.uploadWsaData();
        this.$n_0();
    },
    
    addCommonDatapoint: function(datapointId) {ULSMg8:;
        this.$1g_0[datapointId] = true;
    }
}


Type.registerNamespace('SP.Ribbon');

SP.Ribbon.ControlDataRecord = function() {}
SP.Ribbon.$create_ControlDataRecord = function() {ULSMg8:;
    return new SP.Ribbon.ControlDataRecord();
}


SP.Ribbon.IRelatedFieldsInfoRequestor = function() {}
SP.Ribbon.IRelatedFieldsInfoRequestor.registerInterface('SP.Ribbon.IRelatedFieldsInfoRequestor');


SP.Ribbon.Utility = function() {
}
SP.Ribbon.Utility.$2H_0 = function() {ULSMg8:;
    return window.self.self;
}
SP.Ribbon.Utility.$4o = function($p0, $p1) {
    var $v_0 = SP.Ribbon.Utility.$2H_0();
    $addHandler($v_0, $p0, $p1);
}
SP.Ribbon.Utility.$5Z = function($p0, $p1) {
    var $v_0 = SP.Ribbon.Utility.$2H_0();
    $removeHandler($v_0, $p0, $p1);
}
SP.Ribbon.Utility.$F = function($p0, $p1) {
    return ($p0 && $p0.className && Sys.UI.DomElement.containsCssClass($p0, $p1));
}
SP.Ribbon.Utility.get_$U = function() {ULSMg8:;
    if (!SP.Ribbon.Utility.$z_0 && window._spWebPermMasks) {
        var $v_0 = window._spWebPermMasks;
        if (!SP.Ribbon.SU.$0($v_0) && !(SP.BasePermissions.isInstanceOfType($v_0))) {
            SP.Ribbon.Utility.$z_0 = new SP.BasePermissions();
            if (!SP.Ribbon.Utility.$z_0.customFromJson($v_0)) {
                SP.Ribbon.Utility.$z_0.fromJson($v_0);
            }
        }
    }
    return SP.Ribbon.Utility.$z_0;
}


SP.Ribbon.UtilityInternal = function() {
}
SP.Ribbon.UtilityInternal.$61_0 = function() {ULSMg8:;
    return Sys.Browser.agent === Sys.Browser.Firefox || Sys.Browser.name.toLowerCase().indexOf('firefox') !== -1;
}
SP.Ribbon.UtilityInternal.$2H_0 = function() {ULSMg8:;
    if (!SP.Ribbon.UtilityInternal.$61_0()) {
        return document.body;
    }
    else {
        return window.self.self;
    }
}
SP.Ribbon.UtilityInternal.$4n = function($p0, $p1) {
    var $v_0 = SP.Ribbon.UtilityInternal.$2H_0();
    $addHandler($v_0, $p0, $p1);
}
SP.Ribbon.UtilityInternal.$e = function() {ULSMg8:;
    if (SP.Ribbon.UtilityInternal.$1s_0 > 0) {
        window.clearTimeout(SP.Ribbon.UtilityInternal.$1s_0);
    }
    SP.Ribbon.UtilityInternal.$1s_0 = window.setTimeout(SP.Ribbon.UtilityInternal.$4W_0, 0);
}
SP.Ribbon.UtilityInternal.$6U = function() {ULSMg8:;
    SP.Ribbon.PageManager.get_instance().get_commandDispatcher().executeCommand(Commands.CommandIds.ApplicationStateChanged, null);
    var $v_0 = window._spNextRibbonTabId;
    if (!SP.Ribbon.SU.$0($v_0)) {
        window.SelectRibbonTab($v_0);
        window._spNextRibbonTabId = null;
    }
    CUI.PMetrics.perfMark(7736);
}


SP.Ribbon.SQMUtility = function() {
}
SP.Ribbon.SQMUtility.calcActionId = function(actionName) {ULSMg8:;
    var $v_0 = 5381;
    var $v_1 = $v_0;
    var $v_2 = actionName.length;
    for (var $v_6 = 0; $v_6 < $v_2; $v_6 += 2) {
        $v_0 = ((($v_0 << 5) + $v_0) ^ actionName.charCodeAt($v_6)) & 4294967295;
        if ($v_6 === $v_2 - 1) {
            break;
        }
        $v_1 = ((($v_1 << 5) + $v_1) ^ actionName.charCodeAt($v_6 + 1)) & 4294967295;
    }
    var $v_3 = ($v_1 * 35685);
    var $v_4 = ($v_1 * 23896) << 16;
    var $v_5 = (($v_0 + $v_3 + $v_4) & 4294967295);
    if ($v_5 < 0) {
        $v_5 += 4294967296;
    }
    return $v_5;
}


SP.Ribbon.SU = function() {
}
SP.Ribbon.SU.$2 = function($p0) {
    var $v_0 = null;
    return $p0 === $v_0 || typeof($p0) === 'undefined' || !$p0.length;
}
SP.Ribbon.SU.$0 = function($p0) {
    var $v_0 = null;
    return $p0 === $v_0 || typeof($p0) === 'undefined';
}
SP.Ribbon.SU.$1C = function($p0) {
    return typeof($p0) === 'undefined';
}


SP.Ribbon.CommandUIExtensionPageComponent = function() {ULSMg8:;
    this.$3O = Function.createDelegate(this, this.onHandlersReturned);
    SP.Ribbon.CommandUIExtensionPageComponent.initializeBase(this);
}
SP.Ribbon.CommandUIExtensionPageComponent.get_instance = function() {ULSMg8:;
    if (null === SP.Ribbon.CommandUIExtensionPageComponent.$1I_1) {
        SP.Ribbon.CommandUIExtensionPageComponent.$1I_1 = new SP.Ribbon.CommandUIExtensionPageComponent();
    }
    return SP.Ribbon.CommandUIExtensionPageComponent.$1I_1;
}
SP.Ribbon.CommandUIExtensionPageComponent.registerWithPageManager = function() {ULSMg8:;
    if (!SP.Ribbon.SU.$0(SP.Ribbon.CommandUIExtensionPageComponent.get_instance().$10_1) && !SP.Ribbon.CommandUIExtensionPageComponent.$25_1) {
        SP.Ribbon.CommandUIExtensionPageComponent.$6O_1();
        return;
    }
    SP.Ribbon.PageManager.get_instance().addPageComponent(SP.Ribbon.CommandUIExtensionPageComponent.get_instance());
    if (!SP.ScriptUtility.isNullOrUndefined(SP.Ribbon.PageManager.get_instance().get_ribbon())) {
        SP.Ribbon.PageManager.get_instance().get_commandDispatcher().executeCommand(Commands.CommandIds.ApplicationStateChanged, null);
    }
}
SP.Ribbon.CommandUIExtensionPageComponent.$6O_1 = function() {ULSMg8:;
    var $v_0 = null;
    var $v_1 = SP.Ribbon.CommandUIExtensionPageComponent.get_instance();
    if (!SP.Ribbon.SU.$0($v_1.$10_1)) {
        $v_0 = $v_1.$10_1;
    }
    else {
        return;
    }
    var $v_2 = null;
    if (!SP.Ribbon.SU.$0($v_1.$1L_1)) {
        $v_2 = $v_1.$1L_1;
    }
    var $v_3 = null;
    if (!SP.Ribbon.SU.$0($v_1.$1K_1)) {
        $v_3 = $v_1.$1K_1;
    }
    var $v_4;
    if ($v_0.indexOf('?') === -1) {
        $v_4 = $v_0 + '?ver=';
    }
    else {
        $v_4 = $v_0 + '&ver=';
    }
    $v_4 = $v_4 + $v_2 + '&lcid=' + $v_3 + '&qt=commandhandlers';
    var $v_5 = new Sys.Net.WebRequest();
    $v_5.set_httpVerb('GET');
    $v_5.set_url($v_4);
    $v_5.add_completed($v_1.$3O);
    $v_5.invoke();
}
SP.Ribbon.CommandUIExtensionPageComponent.unregisterWithPageManager = function() {ULSMg8:;
    if (null !== SP.Ribbon.CommandUIExtensionPageComponent.$1I_1) {
        SP.Ribbon.PageManager.get_instance().removePageComponent(SP.Ribbon.CommandUIExtensionPageComponent.get_instance());
    }
}
SP.Ribbon.CommandUIExtensionPageComponent.prototype = {
    $10_1: null,
    
    get_dataUrl: function() {ULSMg8:;
        return this.$10_1;
    },
    set_dataUrl: function(value) {ULSMg8:;
        this.$10_1 = value;
        return value;
    },
    
    $1K_1: null,
    
    get_dataLCID: function() {ULSMg8:;
        return this.$1K_1;
    },
    set_dataLCID: function(value) {ULSMg8:;
        this.$1K_1 = value;
        return value;
    },
    
    $1L_1: null,
    
    get_dataVersion: function() {ULSMg8:;
        return this.$1L_1;
    },
    set_dataVersion: function(value) {ULSMg8:;
        this.$1L_1 = value;
        return value;
    },
    
    $W_1: null,
    $28_1: null,
    
    onHandlersReturned: function(executor) {ULSMg8:;
        if (executor.get_responseAvailable()) {
            this.$28_1 = executor.get_object();
        }
        SP.Ribbon.CommandUIExtensionPageComponent.$25_1 = true;
        SP.Ribbon.CommandUIExtensionPageComponent.registerWithPageManager();
    },
    
    $3Z_1: function($p0) {
        if (SP.Ribbon.SU.$0(this.$W_1)) {
            this.$W_1 = [];
        }
        var $v_0 = $p0.children;
        if (SP.ScriptUtility.isNullOrUndefined($v_0)) {
            return;
        }
        var $v_1 = $v_0.length;
        for (var $v_2 = 0; $v_2 < $v_1; $v_2++) {
            this.$W_1[this.$W_1.length] = $v_0[$v_2].attrs;
        }
    },
    
    init: function() {ULSMg8:;
        if (!SP.Ribbon.SU.$0(this.$28_1)) {
            this.$3Z_1(this.$28_1);
        }
        var $v_0 = window.g_commandUIHandlers;
        if (!SP.Ribbon.SU.$0($v_0)) {
            this.$3Z_1($v_0);
        }
        this.$5V_1();
    },
    
    $V_1: null,
    
    get_$5s_1: function() {ULSMg8:;
        if (SP.Ribbon.SU.$0(this.$V_1)) {
            this.$V_1 = [];
            for (var $v_0 = 0; $v_0 < this.$W_1.length; $v_0++) {
                var $v_1 = this.$W_1[$v_0];
                if (!SP.Ribbon.SU.$0($v_1)) {
                    var $v_2 = $v_1.Command;
                    if (!SP.Ribbon.SU.$0($v_2)) {
                        this.$V_1[$v_0] = $v_2;
                    }
                }
            }
            this.$V_1[this.$V_1.length] = 'CustomCommandsTab';
            this.$V_1[this.$V_1.length] = 'CustomCommandsGroup';
        }
        return this.$V_1;
    },
    
    getGlobalCommands: function() {ULSMg8:;
        return this.get_$5s_1();
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        if ((commandId === 'CustomCommandsTab') || (commandId === 'CustomCommandsGroup')) {
            return true;
        }
        var $v_0 = this.get_$2I_1()[commandId];
        if (SP.Ribbon.SU.$0($v_0)) {
            return false;
        }
        if (Array.isInstanceOfType($v_0)) {
            for (var $v_1 = 0; $v_1 < ($v_0).length; $v_1++) {
                if (this.$3j_1(($v_0)[$v_1], commandId)) {
                    return true;
                }
            }
        }
        else {
            return this.$3j_1($v_0, commandId);
        }
        return false;
    },
    
    $3p_1: function($p0) {
        if (SP.Ribbon.SU.$0($p0)) {
            return true;
        }
        var $v_0 = SP.Ribbon.WebPartComponent.get_pageComponentIdOfActiveWebPart();
        return (!SP.Ribbon.SU.$0($v_0) && $v_0 === $p0);
    },
    
    $3j_1: function($p0, $p1) {
        var $v_0 = $p0.WebPartId;
        var $v_1 = $p0.EnabledScript;
        if (!this.$3p_1($v_0)) {
            return false;
        }
        var $v_2 = SP.Ribbon.Utility.get_$U();
        if ((!SP.Ribbon.SU.$2($p0.HPerms)) && (!SP.Ribbon.SU.$2($p0.LPerms)) && (!SP.Ribbon.SU.$0($v_2))) {
            var $v_3 = parseInt($p0.HPerms, 10);
            var $v_4 = parseInt($p0.LPerms, 10);
            if (!$v_2.hasPermissions($v_3, $v_4)) {
                return false;
            }
        }
        if (!SP.Ribbon.SU.$0($v_1) && $v_1.toLowerCase().startsWith('javascript:')) {
            window.g_CUIcommandId = $p1;
            var $v_5 = eval($p0.EnabledScript);
            window.g_CUIcommandId = null;
            return $v_5;
        }
        return true;
    },
    
    $23_1: null,
    
    get_$2I_1: function() {ULSMg8:;
        if (SP.Ribbon.SU.$0(this.$23_1)) {
            this.$23_1 = {};
        }
        return this.$23_1;
    },
    
    $5V_1: function() {ULSMg8:;
        var $v_0 = this.get_$2I_1();
        var $v_1 = this.$W_1.length;
        for (var $v_2 = 0; $v_2 < $v_1; $v_2++) {
            var $v_3 = this.$W_1[$v_2];
            if (SP.Ribbon.SU.$0($v_3.Command)) {
                continue;
            }
            var $v_4 = $v_0[$v_3.Command];
            if (SP.Ribbon.SU.$0($v_4)) {
                $v_0[$v_3.Command] = $v_3;
            }
            else if (Array.isInstanceOfType($v_4)) {
                Array.add($v_4, $v_3);
            }
            else {
                var $v_5 = [];
                Array.add($v_5, $v_4);
                Array.add($v_5, $v_3);
                $v_0[$v_3.Command] = $v_5;
            }
        }
    },
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        var $v_0 = this.get_$2I_1()[commandId];
        if (SP.Ribbon.SU.$0($v_0)) {
            return false;
        }
        if (Array.isInstanceOfType($v_0)) {
            for (var $v_1 = 0; $v_1 < ($v_0).length; $v_1++) {
                if (this.$45_1(($v_0)[$v_1], commandId, properties)) {
                    return true;
                }
            }
        }
        else {
            return this.$45_1($v_0, commandId, properties);
        }
        return false;
    },
    
    $45_1: function($p0, $p1, $p2) {
        var $v_0 = $p0.CommandAction;
        var $v_1 = $p0.Command;
        var $v_2 = $p0.WebPartId;
        if (this.$3p_1($v_2)) {
            if (!SP.Ribbon.SU.$2($v_0)) {
                if ($v_0.toLowerCase().startsWith('javascript:')) {
                    window.g_CUIcommandProperties = $p2;
                    window.g_CUIcommandId = $p1;
                    eval(this.$4U_1($v_0, false));
                    window.g_CUIcommandProperties = null;
                    window.g_CUIcommandId = null;
                }
                else {
                    STSNavigate(this.$4U_1($v_0, true));
                }
                return true;
            }
        }
        return false;
    },
    
    $4U_1: function($p0, $p1) {
        var $v_0 = null;
        var $v_1 = null;
        var $v_2 = SP.ListOperation.Selection.getSelectedItems();
        $v_1 = SP.ListOperation.Selection.getSelectedList();
        if (!SP.Ribbon.SU.$0($v_1) && $p1) {
            $v_1 = $v_1.replace('{', '%7B');
            $v_1 = $v_1.replace('-', '%2D');
            $v_1 = $v_1.replace('}', '%7D');
        }
        if (!SP.Ribbon.SU.$0($v_2)) {
            var $v_3 = 0;
            var $v_4 = null;
            var $$dict_2_0 = $v_2;
            for (var $$key_2_1 in $$dict_2_0) {
                var $v_5 = { key: $$key_2_1, value: $$dict_2_0[$$key_2_1] };
                $v_4 = $v_5.value.id.toString();
                $v_3++;
            }
            if ($v_3 === 1) {
                $v_0 = $v_4;
            }
        }
        $p0 = $p0.replace(new RegExp('{SelectedListId}', 'g'), $v_1);
        $p0 = $p0.replace(new RegExp('{SelectedItemId}', 'g'), $v_0);
        return $p0;
    }
}


SP.Ribbon.ToolbarRibbonAdapterData = function() {
}
SP.Ribbon.ToolbarRibbonAdapterData.prototype = {
    ToolbarData: null
}


SP.Ribbon.ToolbarRibbonAdapter = function(id, data) {ULSMg8:;
    SP.Ribbon.ToolbarRibbonAdapter.initializeBase(this);
    this._data = data;
    this.$3W_1 = id;
}
SP.Ribbon.ToolbarRibbonAdapter.prototype = {
    _controlData: null,
    _componentData: null,
    $3W_1: null,
    _data: null,
    
    get_controlData: function() {ULSMg8:;
        return this._controlData;
    },
    
    ensureCommandInfoStructure: function() {ULSMg8:;
        var $v_0 = eval(this._data.ToolbarData);
        for (var $v_1 = 0; $v_1 < $v_0.length; $v_1++) {
            var $v_2 = $v_0[$v_1];
            if (SP.Ribbon.SU.$0($v_2.Command)) {
                continue;
            }
            var $v_3 = this._controlData[$v_2.Command];
            if (SP.Ribbon.SU.$0($v_3)) {
                this._controlData[$v_2.Command] = $v_2;
                if (!SP.Ribbon.SU.$0($v_2.ContextualGroupCommand)) {
                    this._componentData[$v_2.ContextualGroupCommand] = true;
                }
                if (!SP.Ribbon.SU.$0($v_2.TabCommand)) {
                    this._componentData[$v_2.TabCommand] = true;
                }
                if (!SP.Ribbon.SU.$0($v_2.GroupCommand)) {
                    this._componentData[$v_2.GroupCommand] = true;
                }
            }
        }
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        if (this._componentData[commandId]) {
            return true;
        }
        var $v_0 = this._controlData[commandId];
        if (SP.Ribbon.SU.$0($v_0)) {
            return false;
        }
        if (SP.Ribbon.SU.$2($v_0.HiddenScript) || SP.Ribbon.SU.$0($v_0.HiddenScript)) {
            return true;
        }
        return !eval($v_0.HiddenScript);
    },
    
    getGlobalCommands: function() {ULSMg8:;
        return this.getToolbarCommands();
    },
    
    getFocusedCommands: function() {ULSMg8:;
        return [];
    },
    
    getToolbarCommands: function() {ULSMg8:;
        var $v_0 = [];
        var $$dict_1_0 = this._componentData;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_1 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            Array.add($v_0, $v_1.key);
        }
        var $$dict_1_0 = this._controlData;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_2 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            Array.add($v_0, $v_2.key);
        }
        return $v_0;
    },
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        var $v_0 = this._controlData[commandId];
        if (SP.Ribbon.SU.$0($v_0)) {
            return false;
        }
        this.executeClickScript($v_0.ClickScript);
        return true;
    },
    
    executeClickScript: function(script) {ULSMg8:;
        eval(script);
    },
    
    init: function() {ULSMg8:;
        this._controlData = {};
        this._componentData = {};
        this.ensureCommandInfoStructure();
    },
    
    isFocusable: function() {ULSMg8:;
        return false;
    },
    
    receiveFocus: function() {ULSMg8:;
        throw Error.create('The ToolbarRibbonAdapter cannot receive focus.');
    },
    
    yieldFocus: function() {ULSMg8:;
        throw Error.create('The ToolbarRibbonAdapter cannot receive or yield focus.');
    },
    
    getId: function() {ULSMg8:;
        return this.$3W_1;
    }
}


SP.Ribbon.WebPartPageComponentData = function() {ULSMg8:;
    SP.Ribbon.WebPartPageComponentData.initializeBase(this);
}


SP.Ribbon.WebPartPageComponent = function(id, data) {ULSMg8:;
    SP.Ribbon.WebPartPageComponent.initializeBase(this, [ id, data ]);
}
SP.Ribbon.WebPartPageComponent.prototype = {
    
    isFocusable: function() {ULSMg8:;
        return true;
    },
    
    $24_2: false,
    
    receiveFocus: function() {ULSMg8:;
        this.$24_2 = true;
        return this.$24_2;
    },
    
    yieldFocus: function() {ULSMg8:;
        this.$24_2 = false;
        return true;
    },
    
    get_webPartIsSelected: function() {ULSMg8:;
        return this.getId() === SP.Ribbon.WebPartComponent.get_pageComponentIdOfActiveWebPart();
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        if (this.get_alwaysEnabledCommands()[commandId]) {
            return true;
        }
        return SP.Ribbon.WebPartPageComponent.callBaseMethod(this, 'canHandleCommand', [ commandId ]);
    },
    
    _alwaysEnabledCommands: null,
    
    get_alwaysEnabledCommands: function() {ULSMg8:;
        if (SP.Ribbon.SU.$0(this._alwaysEnabledCommands)) {
            this._alwaysEnabledCommands = {};
            this.addAlwaysEnabledCommands();
        }
        return this._alwaysEnabledCommands;
    },
    
    addAlwaysEnabledCommands: function() {
    },
    
    simulateClick: function(elm) {ULSMg8:;
        if (Sys.Browser.agent === Sys.Browser.InternetExplorer) {
            elm.click();
        }
        else {
            SP.Ribbon.NativeUtility.ffClick(elm);
        }
    },
    
    executeOnClick: function(elm) {ULSMg8:;
        var $v_0 = elm.attributes.getNamedItem('onclick').value;
        if (SP.Ribbon.SU.$0($v_0)) {
            elm.click();
        }
        else {
            this.executeClickScript($v_0);
        }
    },
    
    getGlobalCommands: function() {ULSMg8:;
        return this.getCommands();
    },
    
    getFocusedCommands: function() {ULSMg8:;
        return SP.Ribbon.WebPartPageComponent.callBaseMethod(this, 'getFocusedCommands');
    },
    
    getCommands: function() {ULSMg8:;
        var $v_0 = SP.Ribbon.WebPartPageComponent.callBaseMethod(this, 'getToolbarCommands');
        var $$dict_1_0 = this.get_alwaysEnabledCommands();
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_1 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            Array.add($v_0, $v_1.key);
        }
        return $v_0;
    }
}


SP.Ribbon.ListViewWebPartPageComponentData = function() {ULSMg8:;
    SP.Ribbon.ListViewWebPartPageComponentData.initializeBase(this);
}
SP.Ribbon.ListViewWebPartPageComponentData.prototype = {
    ViewId: null,
    ViewName: null,
    ViewReadOnly: null,
    ListId: null,
    ListEnableAttachments: null,
    BaseViewId: null,
    ListBaseType: null,
    ListTemplateType: null,
    ListPermissions: null,
    ListFolderPermissions: null,
    ListHasExternalDataSource: null,
    ServerRelativeWebUrl: null
}


SP.Ribbon.PagingInformation = function() {
}
SP.Ribbon.PagingInformation.prototype = {
    NextNode: null,
    PreviousNode: null,
    CurrentRange: null
}


SP.Ribbon.ECBMenuItem = function() {ULSMg8:;
    SP.Ribbon.ECBMenuItem.initializeBase(this);
}
SP.Ribbon.ECBMenuItem.prototype = {
    CUICommand: null,
    CUIEnabledCommands: null,
    onMenuClick: null,
    IsSubMenu: false
}


SP.Ribbon.CLVP = function() {
}
SP.Ribbon.CLVP.prototype = {
    CUIItemInfo: null,
    ctx: null
}


SP.Ribbon.ListViewWebPartData = function() {ULSMg8:;
    SP.Ribbon.ListViewWebPartData.initializeBase(this);
}
SP.Ribbon.ListViewWebPartData.prototype = {
    WebPartId: null,
    ViewDropDownOptions: null,
    NewMenuData: null
}


SP.Ribbon.ListViewWebPartPageComponent = function(id, data) {ULSMg8:;
    this.$1a_3 = '/_layouts/$Resources:core,Language;/images/formatmap16x16.png'.replace('$Resources:core,Language;', SP.Res.lcid);
    this.$1b_3 = '/_layouts/$Resources:core,Language;/images/formatmap32x32.png'.replace('$Resources:core,Language;', SP.Res.lcid);
    SP.Ribbon.ListViewWebPartPageComponent.initializeBase(this, [ id, data ]);
    this.$b_3 = data.ViewId;
    this.$2X_3 = data.ViewName;
    this.$4N_3 = data.ViewReadOnly === 'true';
    this.$Z_3 = data.ListId;
    this.$4G_3 = data.ListEnableAttachments;
    this.$65_3 = data.BaseViewId;
    this.$4F_3 = data.ListBaseType;
    this.$2S_3 = data.ListTemplateType;
    var $v_0 = eval('(' + data.ListPermissions + ')');
    this.$l_3 = new SP.BasePermissions();
    if (!this.$l_3.customFromJson($v_0)) {
        this.$l_3.fromJson($v_0);
    }
    $v_0 = eval('(' + data.ListFolderPermissions + ')');
    this.$1m_3 = new SP.BasePermissions();
    if (!this.$1m_3.customFromJson($v_0)) {
        this.$1m_3.fromJson($v_0);
    }
    this.$2R_3 = data.ListHasExternalDataSource;
    this.$4M_3 = data.ServerRelativeWebUrl;
}
SP.Ribbon.ListViewWebPartPageComponent.navigateToView = function(evt, url) {ULSMg8:;
    if (SP.Ribbon.PageManager.get_instance().get_ribbon() && !SP.ScriptUtility.isNullOrEmptyString(SP.Ribbon.PageManager.get_instance().get_ribbon().get_selectedTabId())) {
        url = SP.Utilities.UrlBuilder.replaceOrAddQueryString(url, 'InitialTabId', SP.Ribbon.PageManager.get_instance().get_ribbon().get_selectedTabId());
        url = SP.Utilities.UrlBuilder.replaceOrAddQueryString(url, 'VisibilityContext', 'WSSListAndLibrary');
    }
    window.STSNavigateToView(evt, url);
}
SP.Ribbon.ListViewWebPartPageComponent.prototype = {
    $b_3: null,
    $2X_3: null,
    $4N_3: false,
    $Z_3: null,
    $4G_3: null,
    $65_3: null,
    $4F_3: null,
    $2S_3: null,
    $4M_3: null,
    $l_3: null,
    $1m_3: null,
    $2R_3: null,
    $1P_3: null,
    $26_3: null,
    $1M_3: false,
    
    executeClickScript: function(script) {ULSMg8:;
        SP.Ribbon.NativeUtility.executeClickScript(script, '{' + this.$b_3.toUpperCase() + '}');
    },
    
    $4A_3: function() {ULSMg8:;
        var $v_0 = window.location.search;
        var $v_1 = $v_0.match(SP.Ribbon.ListViewWebPartPageComponent.$4R_3);
        return ($v_1 && $v_1.length > 0);
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        if (!SP.Ribbon.SU.$0(this.get_alwaysEnabledCommands()[commandId])) {
            return true;
        }
        if (commandId === 'DisplayView' || commandId === 'QueryDisplayView') {
            return !SP.Ribbon.SU.$0(this.get_viewSelectorOptions());
        }
        var $v_0 = SP.Ribbon.ListViewWebPartPageComponent.callBaseMethod(this, 'canHandleCommand', [ commandId ]);
        if ($v_0) {
            return true;
        }
        var $v_1 = this.getCountOfSelectedItems();
        if (commandId === 'CustomViewsGroup' || commandId === 'ViewsTab') {
            return true;
        }
        if (commandId === 'ModifyView' || commandId === 'ModifyThisView' || commandId === 'PopulateModifyViewMenu') {
            if (SP.Ribbon.SU.$0(this.get_viewSelectorOptions()) || this.$4A_3()) {
                return false;
            }
            else if (this.$4N_3) {
                return false;
            }
            return this.get_viewSelectorOptions().showEditView;
        }
        if (commandId === 'ModifyViewInDesigner') {
            if (SP.Ribbon.SU.$0(this.get_viewSelectorOptions())) {
                return false;
            }
            return (this.get_viewSelectorOptions().showEditView && this.$2J_3());
        }
        if (commandId === 'LibraryPermissions') {
            return this.$l_3.has(63);
        }
        if (commandId === 'EditList') {
            return (this.$2J_3());
        }
        if (commandId === 'ManageCopies') {
            return this.$62_3($v_1);
        }
        if (commandId === 'AttachFile') {
            return (this.$4G_3 === 'True') && this.canHandleECBCommand('EditProperties') && this.$64_3();
        }
        if (commandId === 'CreateView') {
            if (SP.Ribbon.SU.$0(this.get_viewSelectorOptions())) {
                return false;
            }
            return this.get_viewSelectorOptions().showCreateView;
        }
        if (commandId === 'CurrentPage') {
            return true;
        }
        if (commandId === 'PreviousPage') {
            var $v_2 = this.$17_3();
            return !SP.Ribbon.SU.$0($v_2.PreviousNode);
        }
        if (commandId === 'NextPage') {
            var $v_3 = this.$17_3();
            return !SP.Ribbon.SU.$0($v_3.NextNode);
        }
        if (commandId === 'EditDefaultForms') {
            return this.$l_3.has(19) && !this.$4A_3();
        }
        if (commandId === 'EditDefaultForm') {
            return true;
        }
        if (commandId === 'PopulateDefaultFormsForList') {
            return true;
        }
        if (commandId === 'PopulateViewDropDown') {
            return this.get_hasViewSelectorInfo();
        }
        if (commandId === 'EmailLibraryLink') {
            return (this.get_ctx());
        }
        if (commandId === 'DisplayDatasheetView') {
            if (!$v_0 && !SP.Ribbon.ListViewWebPartPageComponent.callBaseMethod(this, 'canHandleCommand', [ 'DisplayStandardView' ])) {
                return false;
            }
            else {
                return (Sys.Browser.agent === Sys.Browser.InternetExplorer);
            }
        }
        else if (commandId === 'DisplayStandardView') {
            return true;
        }
        else if (commandId === 'NavigateUp') {
            return CanNavigateUp(this.get_ctx());
        }
        if (commandId === 'QueryDisplayDatasheetView') {
            return (Sys.Browser.agent === Sys.Browser.InternetExplorer);
        }
        if (commandId === 'QueryDisplayStandardView') {
            return true;
        }
        if (commandId === 'NavZoomIn' || commandId === 'NavZoomOut' || commandId === 'NavScrollTask') {
            return true;
        }
        if (commandId === 'AssociateWorkflows' || commandId === 'EditWorkflowSettings' || commandId === 'PopulateManageWorkFlowsMenu' || commandId === 'ManageWorkflows' || commandId === 'CreateReusableWorkflowInDesigner' || commandId === 'CreateWorkflowInDesigner' || commandId === 'AddButton') {
            return (this.$2J_3() && this.$2R_3 !== 'True');
        }
        return this.canHandleECBCommand(commandId);
    },
    
    $62_3: function($p0) {
        if ($p0 !== 1) {
            return false;
        }
        var $v_0 = this.$19_3();
        var $$dict_1_0 = $v_0;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_2 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            var $v_3 = $v_2.key.split(',');
            if ($v_3[2] === '1') {
                return false;
            }
        }
        if (this.$2R_3 === 'True') {
            return false;
        }
        if (!this.$1m_3.has(3)) {
            return false;
        }
        var $v_1 = eval('parseInt(' + this.$2S_3 + ');');
        if ($v_1 === 101 || $v_1 === 109 || $v_1 === 130 || $v_1 === 115) {
            return true;
        }
        return false;
    },
    
    $64_3: function() {ULSMg8:;
        var $v_0 = this.$19_3();
        var $v_1 = 0;
        var $$dict_1_0 = $v_0;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_2 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            var $v_3 = $v_2.key.split(',');
            if ($v_3[2] === '1') {
                return false;
            }
            var $v_4 = $v_3[1];
            if ($v_4.indexOf('.0.') !== -1 || $v_4.indexOf('.1.') !== -1 || $v_4.indexOf('.2.') !== -1) {
                return false;
            }
            $v_1++;
        }
        return (1 === $v_1);
    },
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        var $v_0 = this.get_ctx();
        var $v_1 = this.getCountOfSelectedItems();
        var $v_2 = this._controlData[commandId];
        if (!SP.Ribbon.SU.$0($v_2)) {
            this.executeClickScript($v_2.ClickScript);
            return true;
        }
        else if (commandId === 'PopulateModifyViewMenu') {
            properties.PopulationXML = this.$5l_3();
            return true;
        }
        else if (commandId === 'ModifyView' || commandId === 'ModifyThisView') {
            var $v_3 = new SP.Utilities.UrlBuilder(this.$16_3('ViewEdit.aspx'));
            var $v_4 = new SP.Guid(this.$b_3);
            $v_3.addKeyValueQueryString('List', this.$Z_3);
            $v_3.addKeyValueQueryString('View', $v_4.toString('B').toUpperCase());
            SP.Utilities.HttpUtility.appendSourceAndNavigateTo($v_3.get_url());
        }
        else if (commandId === 'ModifyViewInDesigner') {
            EditInSPD(document.URL, true);
        }
        else if (commandId === 'CreateView') {
            var $v_5 = new SP.Utilities.UrlBuilder(this.$16_3('ViewType.aspx'));
            $v_5.addKeyValueQueryString('List', this.$Z_3);
            SP.Utilities.HttpUtility.appendSourceAndNavigateTo($v_5.get_url());
        }
        else if (commandId === 'DisplayView') {
            if (!this.get_hasViewSelectorInfo()) {
                return false;
            }
            this.executeClickScript(properties['CommandValueId']);
        }
        else if (commandId === 'QueryDisplayView') {
            properties['Value'] = (!SP.ScriptUtility.isNullOrEmptyString(this.$2X_3)) ? this.$2X_3 : SP.Res.viewGroupDefault;
            return this.get_hasViewSelectorInfo();
        }
        else if (commandId === 'QueryCurrentPage') {
            var $v_6 = this.$17_3();
            if (!SP.Ribbon.SU.$0($v_6.CurrentRange)) {
                properties['Value'] = $v_6.CurrentRange;
            }
            else {
                properties['Value'] = '';
            }
            return true;
        }
        else if (commandId === 'PreviousPage') {
            var $v_7 = this.$17_3();
            if (!SP.Ribbon.SU.$0($v_7.PreviousNode)) {
                this.simulateClick($v_7.PreviousNode);
            }
            return true;
        }
        else if (commandId === 'NextPage') {
            var $v_8 = this.$17_3();
            if (!SP.Ribbon.SU.$0($v_8.NextNode)) {
                this.simulateClick($v_8.NextNode);
            }
            return true;
        }
        if (commandId === 'EditDefaultForms') {
            return true;
        }
        if (commandId === 'EditDefaultForm') {
            var $v_9 = properties['CommandValueId'];
            this.navigateToFormPageDesignMode($v_9);
            return true;
        }
        else if (commandId === 'PopulateDefaultFormsForList') {
            if (SP.Ribbon.SU.$0(this.$11_3)) {
                this.getDefaultFormsInfo();
                var $v_A = (properties);
                $v_A.PollAgainInterval = 100;
                ++this.$27_3;
                if (SP.Ribbon.SU.$0(this.$1O_3) && this.$27_3 > 5) {
                    this.$1O_3 = SP.UI.Notify.addNotification(SP.Utilities.HttpUtility.htmlEncode(SP.Res.genericLoading), true);
                }
                return true;
            }
            else {
                properties.PopulationXML = this.$11_3;
                if (!SP.Ribbon.SU.$0(this.$1O_3)) {
                    SP.UI.Notify.removeNotification(this.$1O_3);
                }
                this.$27_3 = 0;
                return true;
            }
        }
        else if (commandId === 'PopulateViewDropDown') {
            if (!this.get_hasViewSelectorInfo()) {
                return false;
            }
            if (SP.Ribbon.SU.$0(this.$1Q_3)) {
                this.getViewGroupInfo();
                var $v_B = (properties);
                $v_B.PollAgainInterval = 100;
                return true;
            }
            else {
                properties.PopulationJSON = this.$1Q_3;
                return true;
            }
        }
        else if (commandId === 'QueryDisplayStandardView') {
            properties['On'] = !SP.Ribbon.ListViewWebPartPageComponent.callBaseMethod(this, 'canHandleCommand', [ 'DisplayStandardView' ]);
            return true;
        }
        else if (commandId === 'QueryDisplayDatasheetView') {
            properties['On'] = SP.Ribbon.ListViewWebPartPageComponent.callBaseMethod(this, 'canHandleCommand', [ 'DisplayStandardView' ]);
            return true;
        }
        else if (commandId === 'DisplayStandardView') {
            return true;
        }
        else if (commandId === 'DisplayDatasheetView') {
            return true;
        }
        else if (commandId === 'LibraryPermissions') {
            var $v_C = new SP.Guid(this.$Z_3);
            var $v_D = this.$16_3('user.aspx') + '?obj=' + SP.Utilities.HttpUtility.urlKeyValueEncode($v_C.toString('B').toUpperCase());
            if (this.$4F_3 === '1' && this.$2S_3 !== '113') {
                $v_D = $v_D + ',doclib';
            }
            else {
                $v_D = $v_D + ',list';
            }
            $v_D = $v_D + '&list=' + SP.Utilities.HttpUtility.urlKeyValueEncode($v_C.toString('B').toUpperCase());
            SP.Utilities.HttpUtility.navigateTo($v_D);
        }
        else if (commandId === 'EditList') {
            this.$1d_3('?Cmd=EditList', true);
        }
        else if (commandId === 'PopulateManageWorkFlowsMenu') {
            properties.PopulationXML = this.$5k_3();
            return true;
        }
        else if (commandId === 'EditWorkflowSettings' || commandId === 'ManageWorkflows') {
            var $v_E = new SP.Guid(this.$Z_3);
            var $v_F = this.$16_3('wrksetng.aspx') + '?List=' + SP.Utilities.HttpUtility.urlKeyValueEncode($v_E.toString('B').toUpperCase());
            SP.Utilities.HttpUtility.navigateTo($v_F);
        }
        else if (commandId === 'AssociateWorkflows') {
            var $v_G = new SP.Guid(this.$Z_3);
            var $v_H = this.$16_3('Addwrkfl.aspx') + '?List=' + SP.Utilities.HttpUtility.urlKeyValueEncode($v_G.toString('B').toUpperCase());
            SP.Utilities.HttpUtility.navigateTo($v_H);
        }
        else if (commandId === 'CreateWorkflowInDesigner') {
            this.$1d_3('?Cmd=NewWorkFlow', true);
        }
        else if (commandId === 'CreateReusableWorkflowInDesigner') {
            this.$1d_3('?Cmd=NewReusableWorkFlow', false);
        }
        else if (commandId === 'AddButton') {
            this.$1d_3('?Cmd=AddButton', true);
        }
        else if (commandId === 'NavigateUp') {
            NavigateUp(this.get_ctx());
            SP.Ribbon.PageManager.get_instance().get_commandDispatcher().executeCommand('appstatechanged', properties);
        }
        else if (commandId === 'ManageCopies') {
            if ($v_1 === 1) {
                var $v_I = this.get_ctx();
                ManageCopies($v_I);
            }
        }
        else if (commandId === 'AttachFile') {
            if ($v_1 === 1) {
                var $v_J = this.get_ctx();
                AttachFile($v_J);
            }
        }
        else if (commandId === 'EmailLibraryLink') {
            var $v_K = $v_0.HttpRoot;
            var $v_L = SP.Utilities.HttpUtility.urlPathEncode(this.$5j_3($v_K));
            var $v_M = this.get_$g().rootFolder;
            if (SP.Ribbon.SU.$0($v_M)) {
                $v_M = $v_0.listUrlDir;
            }
            else {
                $v_M = SP.Utilities.HttpUtility.urlPathEncode($v_M);
            }
            var $v_N = new Sys.StringBuilder($v_L);
            $v_N.append($v_M);
            SP.Ribbon.EMailLink.openMailerWithUrl($v_N.toString());
            return true;
        }
        else if (commandId === 'NavZoomIn') {
            this.get_$2L_3().ZoomInGantt();
        }
        else if (commandId === 'NavZoomOut') {
            this.get_$2L_3().ZoomOutGantt();
        }
        else if (commandId === 'NavScrollTask') {
            this.get_$2L_3().ScrollGanttToTask();
        }
        else {
            this.$1M_3 = true;
            if ($v_1 === 1 && !this.$3d_3(commandId) && this.$4b_3()) {
                return this.$3q(commandId);
            }
            else {
                var $v_O = this.get_ctx();
                if (commandId === 'CheckOut') {
                    CheckoutSelectedItems($v_O);
                }
                else if (commandId === 'CheckIn') {
                    CheckinSelectedItems($v_O);
                }
                else if (commandId === 'Delete') {
                    DeleteSelectedItems($v_O);
                }
                else if (commandId === 'DiscardCheckOut') {
                    DiscardCheckoutSelectedItems($v_O);
                }
                else {
                    return false;
                }
            }
        }
        return false;
    },
    
    $2J_3: function() {ULSMg8:;
        return (this.$l_3.has(12) && this.$l_3.has(19));
    },
    
    $1d_3: function($p0, $p1) {
        var $v_0 = new SP.Guid(this.$Z_3);
        var $v_1 = new Sys.StringBuilder();
        $v_1.append(SP.PageContextInfo.get_webServerRelativeUrl());
        if ($v_1.toString() !== '/') {
            $v_1.append('/');
        }
        $v_1.append($p0);
        if ($p1) {
            $v_1.append('&ListId=');
            $v_1.append($v_0.toString('B').toUpperCase());
        }
        EditInSPD($v_1.toString(), true);
    },
    
    $16_3: function($p0) {
        return SP.Utilities.UrlBuilder.urlCombine(this.$4M_3, '_layouts/' + $p0);
    },
    
    getGlobalCommands: function() {ULSMg8:;
        return [];
    },
    
    $5j_3: function($p0) {
        if (SP.Ribbon.SU.$0($p0)) {
            return '';
        }
        var $v_0 = $p0.length;
        var $v_1 = $p0.indexOf('://');
        if ($v_1 !== -1) {
            var $v_2 = $v_1 + 3;
            var $v_3 = $v_0 - 1;
            var $v_4 = ($v_2 < $v_3) ? $v_2 : $v_3;
            var $v_5 = $p0.substr($v_4, $v_3);
            var $v_6 = $v_5.indexOf('/');
            if ($v_6 !== -1) {
                return $p0.substr(0, $v_4 + $v_6);
            }
        }
        return $p0;
    },
    
    getFocusedCommands: function() {ULSMg8:;
        var $v_0 = SP.Ribbon.ListViewWebPartPageComponent.callBaseMethod(this, 'getCommands');
        Array.add($v_0, 'ModifyThisView');
        Array.add($v_0, 'ModifyView');
        Array.add($v_0, 'PopulateModifyViewMenu');
        Array.add($v_0, 'ModifyViewInDesigner');
        Array.add($v_0, 'PopulateViewDropDown');
        Array.add($v_0, 'NextPage');
        Array.add($v_0, 'CurrentPage');
        Array.add($v_0, 'QueryCurrentPage');
        Array.add($v_0, 'PreviousPage');
        Array.add($v_0, 'LibraryPermissions');
        Array.add($v_0, 'EditList');
        Array.add($v_0, 'ManageCopies');
        Array.add($v_0, 'AttachFile');
        Array.add($v_0, 'DisplayExplorerView');
        Array.add($v_0, 'EditDefaultForms');
        Array.add($v_0, 'EditDefaultForm');
        Array.add($v_0, 'PopulateDefaultFormsForList');
        Array.add($v_0, 'EmailLibraryLink');
        Array.add($v_0, 'Moderate');
        Array.add($v_0, 'ChangeNewButton');
        Array.add($v_0, 'QueryDisplayStandardView');
        Array.add($v_0, 'QueryDisplayDatasheetView');
        Array.add($v_0, 'ViewWorkflows');
        Array.add($v_0, 'PopulateManageWorkFlowsMenu');
        Array.add($v_0, 'ManageWorkflows');
        Array.add($v_0, 'AssociateWorkflows');
        Array.add($v_0, 'EditWorkflowSettings');
        Array.add($v_0, 'CreateReusableWorkflowInDesigner');
        Array.add($v_0, 'CreateWorkflowInDesigner');
        Array.add($v_0, 'AddButton');
        Array.add($v_0, 'NavigateUp');
        if (!Array.contains($v_0, 'DisplayStandardView')) {
            Array.add($v_0, 'DisplayStandardView');
        }
        if (!Array.contains($v_0, 'DisplayDatasheetView')) {
            Array.add($v_0, 'DisplayDatasheetView');
        }
        if (!Array.contains($v_0, 'CreateView')) {
            Array.add($v_0, 'CreateView');
        }
        Array.add($v_0, 'NavZoomIn');
        Array.add($v_0, 'NavZoomOut');
        Array.add($v_0, 'NavScrollTask');
        return $v_0;
    },
    
    $5l_3: function() {ULSMg8:;
        var $v_0 = new Sys.StringBuilder();
        $v_0.append('<Menu Id=\'Ribbon.List.CustomViews.ModifyView.Menu\'>');
        $v_0.append('<MenuSection DisplayMode=\'Menu\' Id=\'Ribbon.List.CustomViews.ModifyView.Menu.Manage\'>');
        $v_0.append('<Controls Id=\'Ribbon.List.CustomViews.ModifyView.Menu.Manage.Controls\'>');
        $v_0.append('<Button');
        $v_0.append(' Id=\'Ribbon.List.CustomViews.ModifyView.Menu.Manage.ModifyView\'');
        $v_0.append(' Command=\'');
        $v_0.append('ModifyView');
        $v_0.append('\'');
        $v_0.append(' LabelText=\'');
        $v_0.append(SP.Utilities.HttpUtility.htmlEncode(SP.Res.modifyViewLabel));
        $v_0.append('\'');
        $v_0.append('/>');
        $v_0.append('<Button');
        $v_0.append(' Id=\'Ribbon.List.CustomViews.ModifyView.Menu.Manage.ModifyViewInDesigner\'');
        $v_0.append(' Command=\'');
        $v_0.append('ModifyViewInDesigner');
        $v_0.append('\'');
        $v_0.append(' LabelText=\'');
        $v_0.append(SP.Utilities.HttpUtility.htmlEncode(SP.Res.modifyInDesignerLabel));
        $v_0.append('\'');
        $v_0.append('/>');
        $v_0.append('</Controls>');
        $v_0.append('</MenuSection>');
        $v_0.append('</Menu>');
        return $v_0.toString();
    },
    
    $5k_3: function() {ULSMg8:;
        var $v_0 = new Sys.StringBuilder();
        $v_0.append('<Menu Id=\'Ribbon.List.Settings.ManageWorkflows.Menu\'>');
        $v_0.append('<MenuSection DisplayMode=\'Menu\' Id=\'Ribbon.List.Settings.ManageWorkflows.Menu.Manage\'>');
        $v_0.append('<Controls Id=\'Ribbon.List.Settings.ManageWorkflows.Menu.Manage.Controls\'>');
        $v_0.append('<Button');
        $v_0.append(' Id=\'Ribbon.List.Settings.ManageWorkflows.Menu.Manage.EditSettings\'');
        $v_0.append(' Command=\'');
        $v_0.append('EditWorkflowSettings');
        $v_0.append('\'');
        $v_0.append(' MenuItemId=\'Ribbon.List.Settings.ManageWorkflows.Menu.Manage.WorkflowSettings.Menu\'');
        $v_0.append(' LabelText=\'');
        $v_0.append(SP.Utilities.HttpUtility.htmlEncode(SP.Res.workflowSettingsLabel));
        $v_0.append('\'');
        $v_0.append('/>');
        $v_0.append('<Button');
        $v_0.append(' Id=\'Ribbon.List.Settings.ManageWorkflows.Menu.Manage.Associate\'');
        $v_0.append(' Command=\'');
        $v_0.append('AssociateWorkflows');
        $v_0.append('\'');
        $v_0.append(' MenuItemId=\'Ribbon.List.Settings.ManageWorkflows.Menu.Manage.Associate.Menu\'');
        $v_0.append(' LabelText=\'');
        $v_0.append(SP.Utilities.HttpUtility.htmlEncode(SP.Res.associateWorkflowLabel));
        $v_0.append('\'');
        $v_0.append('/>');
        $v_0.append('</Controls>');
        $v_0.append('</MenuSection>');
        $v_0.append('<MenuSection DisplayMode=\'Menu\' Id=\'Ribbon.List.Settings.ManageWorkflows.Menu.CreateInSP\'>');
        $v_0.append('<Controls Id=\'Ribbon.List.Settings.ManageWorkflows.Menu.CreateInSP.Controls\'>');
        $v_0.append('<Button');
        $v_0.append(' Id=\'Ribbon.List.Settings.ManageWorkflows.Menu.CreateInSP.CreateWorkflowInDesigner\'');
        $v_0.append(' Command=\'');
        $v_0.append('CreateWorkflowInDesigner');
        $v_0.append('\'');
        $v_0.append(' LabelText=\'');
        $v_0.append(SP.Utilities.HttpUtility.htmlEncode(SP.Res.createWorkflowInDesignerLabel));
        $v_0.append('\'');
        $v_0.append('/>');
        $v_0.append('<Button');
        $v_0.append(' Id=\'Ribbon.List.Settings.ManageWorkflows.Menu.CreateInSP.CreateReusableWorkflowInDesigner\'');
        $v_0.append(' Command=\'');
        $v_0.append('CreateReusableWorkflowInDesigner');
        $v_0.append('\'');
        $v_0.append(' LabelText=\'');
        $v_0.append(SP.Utilities.HttpUtility.htmlEncode(SP.Res.createReUsableWorkflowInDesignerLabel));
        $v_0.append('\'');
        $v_0.append('/>');
        $v_0.append('</Controls>');
        $v_0.append('</MenuSection>');
        $v_0.append('</Menu>');
        return $v_0.toString();
    },
    
    addAlwaysEnabledCommands: function() {ULSMg8:;
        SP.Ribbon.ListViewWebPartPageComponent.callBaseMethod(this, 'addAlwaysEnabledCommands');
        var $v_0 = this.get_alwaysEnabledCommands();
        $v_0['ViewsTab'] = true;
        $v_0['TrackTab'] = true;
        $v_0['ViewFormatGroup'] = true;
        $v_0['WorkflowGroup'] = true;
        $v_0['DisplayView'] = true;
        $v_0['QueryDisplayView'] = true;
        $v_0['DatasheetGroup'] = true;
        $v_0['ViewActionsGroup'] = true;
        $v_0['CustomViewsGroup'] = true;
        $v_0['NotificationsGroup'] = true;
        $v_0['ShareGroup'] = true;
        $v_0['GanttViewGroup'] = true;
        $v_0['CurrentView'] = true;
    },
    
    setEcbStateDirty: function() {ULSMg8:;
        this.$1M_3 = true;
    },
    
    $3q: function($p0) {
        var $v_0 = this.$p($p0);
        if (SP.Ribbon.SU.$0($v_0)) {
            return false;
        }
        var $v_1 = this.get_ctx();
        var $v_2 = $v_0.onMenuClick;
        if (SP.Ribbon.SU.$0($v_2)) {
            if (SP.Ribbon.SU.$0($v_0.attributes.getNamedItem('onmenuclick'))) {
                return false;
            }
            $v_2 = $v_0.attributes.getNamedItem('onmenuclick').value;
        }
        if (!SP.Ribbon.SU.$0($v_2)) {
            SP.Ribbon.NativeUtility.executeECBCommand($v_2, $v_1);
            return true;
        }
        else {
            return false;
        }
    },
    
    $p: function($p0) {
        var $v_0 = this.$19_3();
        var $v_1 = this.$3y_3($v_0);
        return this.$3x_3($v_1, $p0);
    },
    
    $3x_3: function($p0, $p1) {
        for (var $v_0 = 0; $v_0 < $p0.childNodes.length; $v_0++) {
            var $v_1 = $p0.childNodes[$v_0];
            if ($v_1.getAttributeNode('type').value !== 'separator') {
                var $v_2 = $v_1;
                if ($v_2.CUICommand === $p1) {
                    return $v_2;
                }
                else if ($v_2.IsSubMenu) {
                    var $v_3 = this.$3x_3($v_2, $p1);
                    if (!SP.Ribbon.SU.$0($v_3)) {
                        return $v_3;
                    }
                }
            }
        }
        return null;
    },
    
    $19_3: function() {ULSMg8:;
        var $v_0 = null;
        var $v_1 = this.get_ctx();
        $v_0 = GetSelectedItemsDict($v_1);
        return $v_0;
    },
    
    getCountOfSelectedItems: function() {ULSMg8:;
        var $v_0 = this.$19_3();
        if (SP.Ribbon.SU.$0($v_0)) {
            return 0;
        }
        var $v_1 = this.get_ctx();
        return CountSelectedItems($v_1);
    },
    
    canHandleECBCommand: function(commandId) {ULSMg8:;
        if (!this.$4b_3()) {
            return false;
        }
        if (this.$1M_3) {
            this.get_$g().CUIItemInfo = null;
            this.$1M_3 = false;
        }
        var $v_0 = this.$19_3();
        if (SP.Ribbon.SU.$0($v_0)) {
            return false;
        }
        var $v_1 = this.getCountOfSelectedItems();
        if ($v_1 === 1) {
            if (!this.$5c_3($v_0)) {
                return false;
            }
            var $v_2 = this.$3y_3($v_0);
            if (this.$2E_3($v_2, commandId)) {
                return true;
            }
        }
        else if ($v_1 > 1 && this.$3d_3(commandId)) {
            return this.$4m_3($v_0, commandId);
        }
        return false;
    },
    
    $4b_3: function() {ULSMg8:;
        if (SP.Ribbon.SU.$0(this.get_ctx())) {
            return false;
        }
        var $v_0 = this.get_ctx();
        if ($v_0) {
            return ($v_0['listTemplate'] !== '106' || $v_0['isXslView']);
        }
        else {
            return false;
        }
    },
    
    $4m_3: function($p0, $p1) {
        var $v_0 = this.get_$g();
        if (SP.Ribbon.SU.$0($v_0)) {
            return false;
        }
        var $$dict_1_0 = $p0;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_1 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            var $v_2 = $v_1.key.split(',');
            if (!this.$3n_3($v_0, $v_2[1])) {
                return false;
            }
            var $v_3 = this.get_$g().CUIItemInfo[$v_2[1]];
            if (!this.$2E_3($v_3, $p1)) {
                return false;
            }
        }
        return true;
    },
    
    $3d_3: function($p0) {
        return ($p0 === 'CheckOut' || $p0 === 'CheckIn' || $p0 === 'Delete' || $p0 === 'DiscardCheckOut');
    },
    
    $3y_3: function($p0) {
        var $$dict_1_0 = $p0;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_0 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            var $v_1 = $v_0.key.split(',');
            var $v_2 = this.get_$g().CUIItemInfo[$v_1[1]];
            return $v_2;
        }
        return null;
    },
    
    $2E_3: function($p0, $p1) {
        var $v_0 = 'cacheVal_' + $p1;
        var $v_1 = $p0.getAttribute($v_0);
        if (!SP.Ribbon.SU.$0($v_1)) {
            return $v_1 === 'TRUE';
        }
        for (var $v_2 = 0; $v_2 < $p0.childNodes.length; $v_2++) {
            var $v_3 = $p0.childNodes[$v_2];
            if ($v_3.getAttributeNode('type').value !== 'separator') {
                var $v_4 = $v_3;
                if (this.$67_3($v_4, $p1)) {
                    $p0.setAttribute($v_0, 'TRUE');
                    return true;
                }
                else if ($v_4.IsSubMenu) {
                    var $v_5 = this.$2E_3($v_4, $p1);
                    if ($v_5) {
                        $p0.setAttribute($v_0, 'TRUE');
                        return true;
                    }
                }
            }
        }
        $p0.setAttribute($v_0, 'FALSE');
        return false;
    },
    
    $67_3: function($p0, $p1) {
        if (SP.Ribbon.SU.$0($p0.CUIEnabledCommands)) {
            return false;
        }
        for (var $v_0 = 0; $v_0 < $p0.CUIEnabledCommands.length; $v_0++) {
            if ($p0.CUIEnabledCommands[$v_0] === $p1) {
                return true;
            }
        }
        return false;
    },
    
    $5c_3: function($p0) {
        var $v_0 = this.get_$g();
        if (SP.Ribbon.SU.$0($v_0)) {
            return false;
        }
        var $$dict_1_0 = $p0;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_1 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            var $v_2 = $v_1.key.split(',');
            if (!this.$3n_3($v_0, $v_2[1])) {
                return false;
            }
        }
        return true;
    },
    
    $3n_3: function($p0, $p1) {
        var $v_0 = $p0.CUIItemInfo;
        if (SP.Ribbon.SU.$0($v_0)) {
            $v_0 = {};
            $p0.CUIItemInfo = $v_0;
        }
        var $v_1 = $v_0[$p1];
        if (SP.Ribbon.SU.$0($v_1)) {
            $v_1 = this.$4r_3($p0, $p1);
            if (SP.Ribbon.SU.$0($v_1)) {
                return false;
            }
            $v_0[$p1] = $v_1;
        }
        return true;
    },
    
    $4r_3: function($p0, $p1) {
        var $v_0 = window.itemTable;
        window.itemTable = $p0.GetEcbInfo($p1);
        if (SP.Ribbon.SU.$0(window.itemTable)) {
            return null;
        }
        var $v_1 = this.get_ctx();
        window.dict = GetSelectedItemsDict($v_1);
        var $v_2 = BuildMenuWithInit($v_1);
        window.itemTable = $v_0;
        if (!$v_0) {
            $v_0 = null;
        }
        return $v_2;
    },
    
    get_ctx: function() {ULSMg8:;
        var $v_0 = this.get_$g();
        if (!$v_0) {
            return null;
        }
        else {
            return $v_0.ctx;
        }
    },
    
    get_$g: function() {ULSMg8:;
        var $v_0 = SP.Ribbon.NativeUtility.getCtxForView('{' + this.$b_3.toUpperCase() + '}');
        if (!$v_0) {
            return null;
        }
        else {
            return $v_0.clvp;
        }
    },
    
    $1N_3: false,
    $11_3: null,
    $1O_3: null,
    $27_3: 0,
    
    get_defaultFormsDropDownXml: function() {ULSMg8:;
        return this.$11_3;
    },
    
    getDefaultFormsInfo: function() {ULSMg8:;
        if (this.$1N_3) {
            return;
        }
        this.$1N_3 = true;
        var $v_0 = new SP.Guid(this.$Z_3);
        SP.Application.UI.DefaultFormsMenuBuilder.getDefaultFormsInformation(this, $v_0);
    },
    
    onDefaultFormsInformationRetrieveSuccess: function(formsInfo) {ULSMg8:;
        this.$1N_3 = false;
        this.$11_3 = this.$5S_3(formsInfo);
    },
    
    onDefaultFormsInformationRetrieveFailure: function() {ULSMg8:;
        this.$1N_3 = false;
        this.$11_3 = this.$3o_3(SP.Utilities.HttpUtility.htmlEncode(SP.Res.relationships_ListFormsFetchFailed));
    },
    
    $3a_3: function($p0, $p1, $p2) {
        if (!SP.ScriptUtility.isNullOrEmptyString($p1.NewFormUrl)) {
            var $v_0 = SP.Utilities.HttpUtility.htmlEncode((!$p2) ? SP.Res.relationships_DefaultNewForm : String.format(SP.Res.relationships_CTNewForm, $p1.ContentTypeName));
            var $v_1 = '-176';
            var $v_2 = '-16';
            var $v_3 = '-256';
            var $v_4 = '-320';
            $p0.append('<Button \r\n                                    Id=\"Ribbon.List.Settings.EditDefaultForms.Menu.MS.EditDefaultFormNew' + $p2 + '\"\r\n                                    CommandValueId=\"' + SP.Utilities.HttpUtility.htmlEncode($p1.NewFormUrl) + '\"\r\n                                    Command=\"EditDefaultForm\"\r\n                                    Image16by16=\"' + this.$1a_3 + '\"\r\n                                    Image16by16Top=\"' + $v_1 + '\"\r\n                                    Image16by16Left=\"' + $v_2 + '\"\r\n                                    Image32by32=\"' + this.$1b_3 + '\"\r\n                                    Image32by32Top=\"' + $v_3 + '\"\r\n                                    Image32by32Left=\"' + $v_4 + '\"\r\n                                    LabelText=\"' + $v_0 + '\" \r\n                                />');
        }
        if (!SP.ScriptUtility.isNullOrEmptyString($p1.DisplayFormUrl)) {
            var $v_5 = SP.Utilities.HttpUtility.htmlEncode((!$p2) ? SP.Res.relationships_DefaultDisplayForm : String.format(SP.Res.relationships_CTDisplayForm, $p1.ContentTypeName));
            var $v_6 = '-32';
            var $v_7 = '-80';
            var $v_8 = '-96';
            var $v_9 = '-448';
            $p0.append('<Button \r\n                                    Id=\"Ribbon.List.Settings.EditDefaultForms.Menu.MS.EditDefaultFormDisplay' + $p2 + '\"\r\n                                    CommandValueId=\"' + SP.Utilities.HttpUtility.htmlEncode($p1.DisplayFormUrl) + '\"\r\n                                    Command=\"EditDefaultForm\"\r\n                                    Image16by16=\"' + this.$1a_3 + '\"\r\n                                    Image16by16Top=\"' + $v_6 + '\"\r\n                                    Image16by16Left=\"' + $v_7 + '\"\r\n                                    Image32by32=\"' + this.$1b_3 + '\"\r\n                                    Image32by32Top=\"' + $v_8 + '\"\r\n                                    Image32by32Left=\"' + $v_9 + '\"\r\n                                    LabelText=\"' + $v_5 + '\" \r\n                                />');
        }
        if (!SP.ScriptUtility.isNullOrEmptyString($p1.EditFormUrl)) {
            var $v_A = SP.Utilities.HttpUtility.htmlEncode((!$p2) ? SP.Res.relationships_DefaultEditForm : String.format(SP.Res.relationships_CTEditForm, $p1.ContentTypeName));
            var $v_B = '-128';
            var $v_C = '-224';
            var $v_D = '-128';
            var $v_E = '-96';
            $p0.append('<Button \r\n                                    Id=\"Ribbon.List.Settings.EditDefaultForms.Menu.MS.EditDefaultFormEdit' + $p2 + '\"\r\n                                    CommandValueId=\"' + SP.Utilities.HttpUtility.htmlEncode($p1.EditFormUrl) + '\"\r\n                                    Command=\"EditDefaultForm\"\r\n                                    Image16by16=\"' + this.$1a_3 + '\"\r\n                                    Image16by16Top=\"' + $v_B + '\"\r\n                                    Image16by16Left=\"' + $v_C + '\"\r\n                                    Image32by32=\"' + this.$1b_3 + '\"\r\n                                    Image32by32Top=\"' + $v_D + '\"\r\n                                    Image32by32Left=\"' + $v_E + '\"\r\n                                    LabelText=\"' + $v_A + '\" \r\n                                />');
        }
    },
    
    $5S_3: function($p0) {
        if (SP.ScriptUtility.isNullOrEmptyString($p0.DefaultForms.DisplayFormUrl) && SP.ScriptUtility.isNullOrEmptyString($p0.DefaultForms.NewFormUrl) && SP.ScriptUtility.isNullOrEmptyString($p0.DefaultForms.EditFormUrl)) {
            return this.$3o_3(SP.Utilities.HttpUtility.htmlEncode(SP.Res.relationships_NoNewEditDisplayListForms));
        }
        var $v_0 = new Sys.StringBuilder();
        $v_0.append('\r\n                <Menu Id=\"Ribbon.List.Settings.EditDefaultForms.Menu\">');
        $v_0.append('\r\n                  <MenuSection Id=\"Ribbon.List.Settings.EditDefaultForms.Menu.Default\" Scrollable=\"false\" DisplayMode=\"Menu16\">\r\n                    <Controls Id=\"Ribbon.List.Settings.EditDefaultForms.Menu.Default.Controls\">');
        this.$3a_3($v_0, $p0.DefaultForms, 0);
        $v_0.append('\r\n                    </Controls>\r\n                  </MenuSection>');
        var $v_1 = new Sys.StringBuilder();
        for (var $v_2 = 0; $v_2 < $p0.OtherForms.length; ++$v_2) {
            var $v_3 = $p0.OtherForms[$v_2];
            this.$3a_3($v_1, $v_3, $v_2 + 1);
        }
        if (!$v_1.isEmpty()) {
            $v_0.append(String.format('\r\n                  <MenuSection Title=\"{0}\" Id=\"Ribbon.List.Settings.EditDefaultForms.Menu.Other\" Scrollable=\"false\" DisplayMode=\"Menu16\">\r\n                    <Controls Id=\"Ribbon.List.Settings.EditDefaultForms.Menu.Other.Controls\">', SP.Utilities.HttpUtility.htmlEncode(SP.Res.relationships_CTForms)));
            $v_0.append($v_1.toString());
            $v_0.append('\r\n                    </Controls>\r\n                  </MenuSection>');
        }
        $v_0.append('\r\n                </Menu>');
        return $v_0.toString();
    },
    
    $3o_3: function($p0) {
        var $v_0 = new Sys.StringBuilder();
        $v_0.append('\r\n                <Menu Id=\"Ribbon.List.Settings.EditDefaultForms.Menu\">');
        $v_0.append('\r\n                  <MenuSection Id=\"Ribbon.List.Settings.EditDefaultForms.Menu.Default\" Scrollable=\"false\" DisplayMode=\"Menu16\">\r\n                    <Controls Id=\"Ribbon.List.Settings.EditDefaultForms.Menu.Default.Controls\">');
        $v_0.append('\r\n                    <Button \r\n                        Id=\"Ribbon.List.Settings.EditDefaultForms.Menu.MS.ListFormFetchErrorMessage\"\r\n                        Image16by16=\"/_layouts/images/edit.gif\"\r\n                        Image32by32=\"/_layouts/images/placeholder32x32.png\"\r\n                        LabelText=\"' + $p0 + '\"\r\n                    />');
        $v_0.append('\r\n                    </Controls>\r\n                  </MenuSection>');
        $v_0.append('\r\n                </Menu>');
        return $v_0.toString();
    },
    
    navigateToFormPageDesignMode: function(formServerUrl) {ULSMg8:;
        var $v_0 = new SP.Utilities.UrlBuilder(formServerUrl);
        $v_0.addKeyValueQueryString('DisplayMode', 'Design');
        $v_0.addKeyValueQueryString('InitialTabId', 'Ribbon.WebPartPage');
        $v_0.addKeyValueQueryString('VisibilityContext', 'WSSWebPartPage');
        SP.Utilities.HttpUtility.appendSourceAndNavigateTo($v_0.get_url());
    },
    
    get_viewSelectorOptions: function() {ULSMg8:;
        if (SP.Ribbon.SU.$0(this.$1P_3) && !SP.Ribbon.SU.$0(this.get_$15_3().ViewDropDownOptions)) {
            this.$1P_3 = eval('(' + this.get_$15_3().ViewDropDownOptions + ')');
        }
        return this.$1P_3;
    },
    
    $3X_3: null,
    $22_3: false,
    $1Q_3: null,
    
    get_viewDropDownXml: function() {ULSMg8:;
        return this.$1Q_3;
    },
    
    get_hasViewSelectorInfo: function() {ULSMg8:;
        return !SP.Ribbon.SU.$0(this.get_viewSelectorOptions());
    },
    
    getViewGroupInfo: function() {ULSMg8:;
        if (this.$22_3) {
            return;
        }
        this.$22_3 = true;
        SP.Application.UI.ViewSelectorMenuBuilder.getViewInformation(this, this.$1P_3);
    },
    
    onViewInformationReturned: function(viewGroups) {ULSMg8:;
        this.$3X_3 = viewGroups;
        this.$22_3 = false;
        this.$1Q_3 = this.$5T_3(this.$3X_3);
    },
    
    $1T_3: function($p0, $p1, $p2, $p3) {
        var $v_0 = $p3.appendChild('MenuSection', { Id: $p1 });
        if (!SP.Ribbon.SU.$0($p0)) {
            $v_0.get_attributes()['Title'] = $p0;
        }
        var $v_1 = $v_0.appendChild('Controls', { Id: $p1 + '.Controls' });
        for (var $v_2 = 0; $v_2 < $p2.length; $v_2++) {
            if (SP.Application.UI.ViewSelectorSubMenu.isInstanceOfType($p2[$v_2])) {
                var $v_5 = $p2[$v_2];
                this.$4k_3($v_5, $p1, $v_1);
            }
            var $v_3 = $p2[$v_2];
            var $v_4 = this.$2F_3($v_3);
            this.$29_3($v_3.Text, $p1 + '.' + $v_3.Id.toString(), $v_4, $v_1);
        }
    },
    
    $2F_3: function($p0) {
        return $p0.ActionScriptText;
    },
    
    $4k_3: function($p0, $p1, $p2) {
        var $v_0 = $p1 + '.SubMenu';
        var $v_1 = $p0.Text;
        var $v_2 = SP.Ribbon.SU.$0($v_1);
        var $v_3 = '';
        if (!$v_2) {
            $v_3 = $v_1;
        }
        var $v_4 = $p2.appendChild('FlyoutAnchor', { Id: $v_0, Command: 'PopulateViewDropDown' });
        if (!$v_2) {
            $v_4.get_attributes()['Title'] = $v_3;
        }
        $v_0 += '.Menu';
        var $v_5 = $v_4.appendChild('Menu', { Id: $v_0 });
        $v_0 += '.SubMenu1';
        var $v_6 = $v_5.appendChild('MenuSection', { Id: $v_0 });
        if (!$v_2) {
            $v_6.get_attributes()['Title'] = $v_3;
        }
        var $v_7 = $v_6.appendChild('Controls', { Id: $v_0 + '.Controls' });
        for (var $v_8 = 0; $v_8 < $p0.SubMenuItems.length; $v_8++) {
            var $v_9 = $p0.SubMenuItems[$v_8];
            var $v_A = this.$2F_3($v_9);
            this.$29_3($v_9.Text, $v_0 + '.' + $v_9.Id.toString(), $v_A, $v_7);
        }
    },
    
    $29_3: function($p0, $p1, $p2, $p3) {
        var $v_0 = (!SP.Ribbon.SU.$2($p0)) ? $p0 : SP.Res.viewGroupDefault;
        $p3.appendChild('Button', { Id: $p1, MenuItemId: $p2, CommandValueId: $p2, CommandType: 'OptionSelection', Command: 'DisplayView', LabelText: $v_0 });
    },
    
    $5T_3: function($p0) {
        var $v_0 = new CUI.JsonXmlElement('Menu', { Id: this.get_viewDropDownIdPrefix() + '.Menu' });
        if ($p0.DefaultView) {
            var $v_1 = $v_0.appendChild('MenuSection', { Title: SP.Res.viewGroupDefault, Id: this.get_viewDropDownIdPrefix() + '.Menu.DefaultView' }).appendChild('Controls', { Id: this.get_viewDropDownIdPrefix() + '.Menu.DefaultView.Controls' });
            this.$29_3($p0.DefaultView.Text, this.get_viewDropDownIdPrefix() + '.Menu.DefaultView.DefaultView.' + $p0.DefaultView.Id.toString(), this.$2F_3($p0.DefaultView), $v_1);
        }
        if ($p0.PersonalViews.length > 0) {
            this.$1T_3(SP.Res.viewGroupPersonal, this.get_viewDropDownIdPrefix() + '.Menu.Personal', $p0.PersonalViews, $v_0);
        }
        if ($p0.PublicViews.length > 0) {
            this.$1T_3(SP.Res.viewGroupPublic, this.get_viewDropDownIdPrefix() + '.Menu.Public', $p0.PublicViews, $v_0);
        }
        if ($p0.ModeratedViews.length > 0) {
            this.$1T_3(SP.Res.viewGroupModerated, this.get_viewDropDownIdPrefix() + '.Menu.Moderated', $p0.ModeratedViews, $v_0);
        }
        if ($p0.OtherViews.length > 0) {
            this.$1T_3(SP.Res.viewGroupOther, this.get_viewDropDownIdPrefix() + '.Menu.Other', $p0.OtherViews, $v_0);
        }
        return $v_0;
    },
    
    get_newMenuRecords: function() {ULSMg8:;
        if (SP.Ribbon.SU.$0(this.$26_3) && !SP.Ribbon.SU.$0(this.get_$15_3().NewMenuData)) {
            this.$26_3 = eval(this.get_$15_3().NewMenuData);
        }
        return this.$26_3;
    },
    
    getDefaultNewMenuItemScript: function() {ULSMg8:;
        if (this.get_newMenuData().length > 0) {
            var $v_0 = this.get_newMenuData()[0];
            if (!SP.ScriptUtility.isNullOrUndefined($v_0.CommandValueId)) {
                return $v_0.CommandValueId;
            }
            else if (!SP.ScriptUtility.isNullOrUndefined($v_0.ClickScript)) {
                return $v_0.ClickScript;
            }
            else {
                return null;
            }
        }
        return null;
    },
    
    $d_3: null,
    
    get_newMenuData: function() {ULSMg8:;
        if (SP.Ribbon.SU.$0(this.$d_3)) {
            this.$d_3 = eval('(' + this.get_$15_3().NewMenuData + ')');
        }
        return this.$d_3;
    },
    
    getNewMenuXml: function(commandId, controlName) {ULSMg8:;
        var $v_0 = new CUI.JsonXmlElement('Menu', { Id: controlName });
        var $v_1 = $v_0.appendChild('MenuSection', { DisplayMode: 'Menu32', Id: controlName + '.Menu.ContentTypes' }).appendChild('Controls', { Id: controlName + '.Menu.ContentTypes.Controls' });
        for (var $v_2 = 0; $v_2 < this.get_newMenuData().length; $v_2++) {
            this.$4j_3(controlName + '.Menu.ContentTypes.' + $v_2.toString(), commandId, this.$d_3[$v_2].ClickScript, this.$d_3[$v_2].LabelText, this.$d_3[$v_2].Description, this.$d_3[$v_2].Image32by32, $v_1);
        }
        return $v_0;
    },
    
    $4j_3: function($p0, $p1, $p2, $p3, $p4, $p5, $p6) {
        $p6.appendChild('Button', { Id: $p0, Command: $p1, MenuItemId: $p2, CommandValueId: $p2, CommandType: 'OptionSelection', LabelText: $p3, Description: $p4, Image32by32: $p5 });
    },
    
    $17_3: function() {ULSMg8:;
        var $v_0 = new SP.Ribbon.PagingInformation();
        var $v_1 = 'WPQ1';
        var $v_2 = this.getId();
        if ($v_2.startsWith('WebPart') && $v_2.length > 7) {
            $v_1 = $v_2.substring(7, $v_2.length);
        }
        var $v_3 = $get('bottomPagingCell' + $v_1);
        if (!SP.Ribbon.SU.$0($v_3)) {
            var $v_4 = $v_3.firstChild.firstChild.firstChild;
            for (var $v_5 = 0; $v_5 < $v_4.childNodes.length; $v_5++) {
                var $v_6 = $v_4.childNodes[$v_5];
                if ($v_6.className === 'ms-paging') {
                    $v_0.CurrentRange = SP.UI.UIUtility.getInnerText($v_6);
                }
                else if (($v_6.firstChild.firstChild.src).endsWith('prev.gif')) {
                    $v_0.PreviousNode = $v_6.firstChild;
                }
                else if (($v_6.firstChild.firstChild.src).endsWith('next.gif')) {
                    $v_0.NextNode = $v_6.firstChild;
                }
                else {
                }
            }
        }
        return $v_0;
    },
    
    get_$2L_3: function() {ULSMg8:;
        return window.self[this.getId() + '_JSGridController'];
    },
    
    get_$15_3: function() {ULSMg8:;
        return this._data;
    },
    
    get_viewDropDownIdPrefix: function() {ULSMg8:;
        return 'Ribbon.List.CustomViews.DisplayView';
    }
}


SP.Ribbon.ListFormWebPartPageComponentData = function() {ULSMg8:;
    SP.Ribbon.ListFormWebPartPageComponentData.initializeBase(this);
}
SP.Ribbon.ListFormWebPartPageComponentData.prototype = {
    ViewId: null
}


SP.Ribbon.ListFormWebPartPageComponent = function(id, data) {ULSMg8:;
    SP.Ribbon.ListFormWebPartPageComponent.initializeBase(this, [ id, data ]);
    this.$b_3 = data.ViewId;
}
SP.Ribbon.ListFormWebPartPageComponent.prototype = {
    $b_3: null,
    
    canHandleCommand: function(commandId) {ULSMg8:;
        if (commandId === 'Ribbon.ListForm.Edit.Clipboard.Cut' || commandId === 'Ribbon.ListForm.Edit.Clipboard.Copy' || commandId === 'Ribbon.ListForm.Edit.Clipboard.Paste') {
            return true;
        }
        if (!SP.Ribbon.SU.$0(this.get_alwaysEnabledCommands()[commandId])) {
            return true;
        }
        var $v_0 = this._controlData[commandId];
        if (!SP.Ribbon.SU.$0($v_0)) {
            if ($v_0.Enabled === 'False') {
                return false;
            }
        }
        if (SP.Ribbon.ListFormWebPartPageComponent.callBaseMethod(this, 'canHandleCommand', [ commandId ])) {
            return true;
        }
        return false;
    },
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        var $v_0 = this._controlData[commandId];
        if (!SP.Ribbon.SU.$0($v_0)) {
            if (commandId === 'Ribbon.ListForm.Edit.Commit.SaveAsDraft' || commandId === 'Ribbon.ListForm.Edit.Commit.Publish' || commandId === 'Ribbon.ListForm.Edit.Commit.CheckIn' || commandId === 'Ribbon.ListForm.Edit.Commit.Cancel' || commandId === 'Ribbon.ListForm.Display.Manage.ClaimReleaseTask' || commandId === 'Ribbon.ListForm.Display.Manage.DeleteItemVersion' || commandId === 'Ribbon.ListForm.Display.Manage.RestoreItemVersion' || commandId === 'Ribbon.ListForm.Display.HealthActions.HealthRuleRunNow' || commandId === 'Ribbon.ListForm.Display.HealthActions.HealthReportRunNow' || commandId === 'Ribbon.ListForm.Display.HealthActions.HealthReportRepair') {
                var $v_1 = $get($v_0.ElementClientId);
                if ($v_1) {
                    this.simulateClick($v_1);
                }
            }
            else if (commandId === 'Ribbon.ListForm.Display.Manage.DeleteItem') {
                var $v_2 = '';
                var $v_3 = '';
                if (!SP.Ribbon.SU.$2($v_0.ClickScript)) {
                    if ($v_0.ClickScript.indexOf('DeleteInstanceConfirmation()') !== -1) {
                        $v_3 = 'DeleteInstanceConfirmation()';
                    }
                    else if ($v_0.ClickScript.indexOf('DeleteItemConfirmation()') !== -1) {
                        $v_3 = 'DeleteItemConfirmation()';
                    }
                }
                var $v_4 = $get($v_0.ElementClientId);
                if ($v_4 && !SP.Ribbon.SU.$2($v_3)) {
                    $v_2 = $v_4.getAttribute('href');
                    if (!SP.Ribbon.SU.$2($v_2)) {
                        $v_2 = $v_2.replace('javascript:', '');
                        $v_2 = 'if(' + $v_3 + '){' + $v_2 + ';};';
                    }
                }
                if (!SP.Ribbon.SU.$2($v_2)) {
                    this.executeClickScript($v_2);
                }
                else if ($v_4) {
                    this.simulateClick($v_4);
                }
            }
            else if (commandId === 'Ribbon.ListForm.Display.Solution.ActivateSolution' || commandId === 'Ribbon.ListForm.Display.Solution.DeactivateSolution' || commandId === 'Ribbon.ListForm.Display.Solution.UpgradeSolution') {
                var $v_5 = $get($v_0.ElementClientId);
                var $v_6 = '';
                if ($v_5) {
                    $v_6 = $v_5.getAttribute('href');
                    if (!SP.Ribbon.SU.$2($v_6)) {
                        $v_6 = $v_6.replace('javascript:', '');
                    }
                }
                if (!SP.Ribbon.SU.$2($v_6)) {
                    this.executeClickScript($v_6);
                }
                else if ($v_5) {
                    this.simulateClick($v_5);
                }
            }
            else {
                if (!SP.Ribbon.SU.$2($v_0.ClickScript)) {
                    this.executeClickScript($v_0.ClickScript);
                }
            }
            return true;
        }
        if (commandId === 'Ribbon.ListForm.Edit.Clipboard.Cut') {
            this.executeClipboardCommand('Cut');
            return true;
        }
        else if (commandId === 'Ribbon.ListForm.Edit.Clipboard.Copy') {
            this.executeClipboardCommand('Copy');
            return true;
        }
        else if (commandId === 'Ribbon.ListForm.Edit.Clipboard.Paste') {
            this.executeClipboardCommand('Paste');
            return true;
        }
        return false;
    },
    
    executeClipboardCommand: function(commandName) {ULSMg8:;
        try {
            document.body.ownerDocument.execCommand(commandName, false, null);
        }
        catch ($$e_1_0) {
            alert(SP.Res.errorClipboard);
        }
    },
    
    executeClickScript: function(script) {ULSMg8:;
        SP.Ribbon.NativeUtility.executeClickScriptSimple(script);
    },
    
    getGlobalCommands: function() {ULSMg8:;
        var $v_0 = SP.Ribbon.ListFormWebPartPageComponent.callBaseMethod(this, 'getGlobalCommands');
        Array.add($v_0, 'Ribbon.ListForm.Edit.Clipboard.Paste');
        Array.add($v_0, 'Ribbon.ListForm.Edit.Clipboard.Copy');
        Array.add($v_0, 'Ribbon.ListForm.Edit.Clipboard.Cut');
        return $v_0;
    },
    
    getFocusedCommands: function() {ULSMg8:;
        return SP.Ribbon.ListFormWebPartPageComponent.callBaseMethod(this, 'getFocusedCommands');
    },
    
    addAlwaysEnabledCommands: function() {ULSMg8:;
        var $v_0 = this.get_alwaysEnabledCommands();
        $v_0['Ribbon.ListForm.Edit'] = true;
        $v_0['Ribbon.ListForm.Edit.CommitGroup'] = true;
        $v_0['Ribbon.ListForm.Edit.ActionsGroup'] = true;
        $v_0['Ribbon.ListForm.Edit.ClipboardGroup'] = true;
        $v_0['Ribbon.ListForm.Display'] = true;
        $v_0['Ribbon.ListForm.Display.ManageGroup'] = true;
        $v_0['Ribbon.ListForm.Display.HealthActionsGroup'] = true;
        $v_0['Ribbon.ListForm.Display.Solution.SolutionGroup'] = true;
        $v_0['Ribbon.ListForm.Display.ActionsGroup'] = true;
    },
    
    isFocusable: function() {ULSMg8:;
        return false;
    }
}


SP.Ribbon.DocLibWebPartPageComponent = function(id, data) {ULSMg8:;
    SP.Ribbon.DocLibWebPartPageComponent.initializeBase(this, [ id, data ]);
    this.$b_4 = data.ViewId;
}
SP.Ribbon.DocLibWebPartPageComponent.prototype = {
    $b_4: null,
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        var $v_0 = this.get_ctx();
        var $v_1 = this.getCountOfSelectedItems();
        if (commandId === 'PopulateSendToMenu') {
            properties.PopulationXML = this.$5p_4();
            return true;
        }
        else if (commandId === 'PopulateNewDocumentMenu') {
            properties.PopulationJSON = this.getNewMenuXml('NewDocument', 'Ribbon.Document.All.NewDocument');
            return true;
        }
        else if (commandId === 'NewDocument') {
            var $v_2 = properties['CommandValueId'];
            this.executeClickScript($v_2);
            return true;
        }
        else if (commandId === 'NewDefaultDocument') {
            this.executeClickScript(this.getDefaultNewMenuItemScript());
            return true;
        }
        else if (commandId === 'SendToOfficialFile') {
            var $v_3 = properties['CommandValueId'];
            this.$3q($v_3);
            return true;
        }
        return SP.Ribbon.DocLibWebPartPageComponent.callBaseMethod(this, 'handleCommand', [ commandId, properties, sequence ]);
    },
    
    addAlwaysEnabledCommands: function() {ULSMg8:;
        SP.Ribbon.DocLibWebPartPageComponent.callBaseMethod(this, 'addAlwaysEnabledCommands');
        var $v_0 = this.get_alwaysEnabledCommands();
        $v_0['DocumentNewGroup'] = true;
        $v_0['DocumentTab'] = true;
        $v_0['DocumentEditCheckoutGroup'] = true;
        $v_0['DocumentCopiesGroup'] = true;
        $v_0['DocumentManageGroup'] = true;
        $v_0['DocumentPublishingGroup'] = true;
        $v_0['FormActionsGroup'] = true;
        $v_0['DocumentsQuickStepsGroup'] = true;
        $v_0['LibraryTab'] = true;
        $v_0['SettingsGroup'] = true;
        $v_0['ActionsGroup'] = true;
        $v_0['LibraryNavigationGroup'] = true;
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        if (commandId === 'UploadDocumentMenuOpen') {
            return SP.Ribbon.DocLibWebPartPageComponent.callBaseMethod(this, 'canHandleCommand', [ 'UploadDocument' ]);
        }
        if (commandId === 'NewDefaultDocument' || commandId === 'PopulateNewDocumentMenu' || commandId === 'NewDocument') {
            return !(SP.Ribbon.SU.$0(this.get_newMenuData()));
        }
        if (commandId === 'NewDocumentMenuOpen') {
            if (SP.Ribbon.SU.$0(this.get_newMenuData())) {
                return false;
            }
            return this.get_newMenuData().length > 0;
        }
        if (commandId === 'SendToOfficialFile') {
            return this.canHandleECBCommand('SendToOfficialFile0');
        }
        return SP.Ribbon.DocLibWebPartPageComponent.callBaseMethod(this, 'canHandleCommand', [ commandId ]);
    },
    
    $5p_4: function() {ULSMg8:;
        var $v_0;
        var $v_1 = new Sys.StringBuilder();
        $v_1.append('<Menu Id=\'Ribbon.Document.All.SendTo.Menu\'>');
        $v_1.append('<MenuSection Id=\'Ribbon.Document.All.SendTo.Menu.Items\' DisplayMode=\'Menu16\'>');
        $v_1.append('<Controls Id=\'Ribbon.Document.All.SendTo.Menu.Items.Controls\'>');
        if (this.canHandleECBCommand('SendToRecommendedLocation')) {
            $v_1.append('<Button');
            $v_1.append(' Id=\'Ribbon.Document.All.SendTo.Menu.Items.RecommendedLocation\'');
            $v_1.append(' Command=\'');
            $v_1.append('SendToRecommendedLocation');
            $v_1.append('\' LabelText=\'');
            $v_0 = this.$p('SendToRecommendedLocation');
            $v_1.append(SP.Utilities.HttpUtility.htmlEncode($v_0.attributes.getNamedItem('text').value));
            $v_1.append('\'');
            $v_1.append('/>');
        }
        if (this.canHandleECBCommand('SendToExistingCopies')) {
            $v_1.append('<Button');
            $v_1.append(' Id=\'Ribbon.Document.All.SendTo.Menu.Items.ExistingCopies\'');
            $v_1.append(' Command=\'');
            $v_1.append('SendToExistingCopies');
            $v_1.append('\' Image16by16=\'/_layouts/images/existingLocations.gif\'');
            $v_1.append(' LabelText=\'');
            $v_0 = this.$p('SendToExistingCopies');
            $v_1.append(SP.Utilities.HttpUtility.htmlEncode($v_0.attributes.getNamedItem('text').value));
            $v_1.append('\'');
            $v_1.append('/>');
        }
        $v_1.append('<Button');
        $v_1.append(' Id=\'Ribbon.Document.All.SendTo.Menu.Items.OtherLocation\'');
        $v_1.append(' Command=\'');
        $v_1.append('SendToOtherLocation');
        $v_1.append('\' Image16by16=\'/_layouts/images/sendOtherLoc.gif\'');
        $v_1.append(' LabelText=\'');
        $v_0 = this.$p('SendToOtherLocation');
        if (!SP.Ribbon.SU.$0($v_0)) {
            $v_1.append(SP.Utilities.HttpUtility.htmlEncode($v_0.attributes.getNamedItem('text').value));
        }
        else {
            $v_1.append(SP.Utilities.HttpUtility.htmlEncode(SP.Res.sendToOtherLocation));
        }
        $v_1.append('\'');
        $v_1.append('/>');
        var $v_2 = 0;
        while (true) {
            var $v_3 = 'SendToOfficialFile' + $v_2.toString();
            if (this.canHandleECBCommand($v_3)) {
                $v_1.append('<Button');
                $v_1.append(' Id=\'Ribbon.Document.All.SendTo.Menu.Items.OfficialFile');
                $v_1.append($v_2.toString());
                $v_1.append('\'');
                $v_1.append(' Command=\'');
                $v_1.append('SendToOfficialFile');
                $v_1.append('\'');
                $v_1.append(' MenuItemId=\'');
                $v_1.append(SP.Utilities.HttpUtility.htmlEncode($v_3));
                $v_1.append('\'');
                $v_1.append(' CommandValueId=\'');
                $v_1.append(SP.Utilities.HttpUtility.htmlEncode($v_3));
                $v_1.append('\'');
                $v_1.append(' CommandType=\'OptionSelection\'');
                $v_1.append(' LabelText=\'');
                $v_0 = this.$p($v_3);
                $v_1.append(SP.Utilities.HttpUtility.htmlEncode($v_0.attributes.getNamedItem('text').value));
                $v_1.append('\'');
                $v_1.append('/>');
            }
            else {
                break;
            }
            $v_2++;
        }
        if (this.canHandleECBCommand('CreateDocumentWorkspace')) {
            $v_1.append('<Button');
            $v_1.append(' Id=\'Ribbon.Document.All.SendTo.Menu.Items.CreateDocumentWorkspace\'');
            $v_1.append(' Command=\'');
            $v_1.append('CreateDocumentWorkspace');
            $v_1.append('\' LabelText=\'');
            $v_0 = this.$p('CreateDocumentWorkspace');
            $v_1.append(SP.Utilities.HttpUtility.htmlEncode($v_0.attributes.getNamedItem('text').value));
            $v_1.append('\'');
            $v_1.append('/>');
        }
        $v_1.append('</Controls>');
        $v_1.append('</MenuSection>');
        $v_1.append('</Menu>');
        return $v_1.toString();
    },
    
    getGlobalCommands: function() {ULSMg8:;
        return SP.Ribbon.DocLibWebPartPageComponent.callBaseMethod(this, 'getGlobalCommands');
    },
    
    getFocusedCommands: function() {ULSMg8:;
        var $v_0 = SP.Ribbon.DocLibWebPartPageComponent.callBaseMethod(this, 'getFocusedCommands');
        Array.add($v_0, 'ViewProperties');
        Array.add($v_0, 'EditProperties');
        Array.add($v_0, 'EditDocument');
        Array.add($v_0, 'ManagePermissions');
        Array.add($v_0, 'Delete');
        Array.add($v_0, 'CheckOut');
        Array.add($v_0, 'CheckIn');
        Array.add($v_0, 'DiscardCheckOut');
        Array.add($v_0, 'EmailLink');
        Array.add($v_0, 'Publish');
        Array.add($v_0, 'Unpublish');
        Array.add($v_0, 'CancelApproval');
        Array.add($v_0, 'ViewVersions');
        Array.add($v_0, 'Subscribe');
        Array.add($v_0, 'GotoSourceItem');
        Array.add($v_0, 'SendTo');
        Array.add($v_0, 'SendToOtherLocation');
        Array.add($v_0, 'SendToExistingCopies');
        Array.add($v_0, 'SendToRecommendedLocation');
        Array.add($v_0, 'CreateDocumentWorkspace');
        Array.add($v_0, 'PopulateSendToMenu');
        Array.add($v_0, 'NewDocumentMenuOpen');
        Array.add($v_0, 'DownloadCopy');
        Array.add($v_0, 'EmailDocumentLink');
        Array.add($v_0, 'SendToOfficialFile');
        Array.add($v_0, 'NewDocument');
        Array.add($v_0, 'PopulateNewDocumentMenu');
        Array.add($v_0, 'NewDefaultDocument');
        Array.add($v_0, 'UploadDocumentMenuOpen');
        return $v_0;
    },
    
    get_viewDropDownIdPrefix: function() {ULSMg8:;
        return 'Ribbon.Library.CustomViews.DisplayView';
    }
}


SP.Ribbon.GenericListWebPartPageComponentData = function() {ULSMg8:;
    SP.Ribbon.GenericListWebPartPageComponentData.initializeBase(this);
}


SP.Ribbon.GenericListWebPartPageComponent = function(id, data) {ULSMg8:;
    SP.Ribbon.GenericListWebPartPageComponent.initializeBase(this, [ id, data ]);
}
SP.Ribbon.GenericListWebPartPageComponent.prototype = {
    
    canHandleCommand: function(commandId) {ULSMg8:;
        if (commandId === 'NewListItemMenuOpen') {
            if (SP.Ribbon.SU.$0(this.get_newMenuData())) {
                return false;
            }
            return this.get_newMenuData().length > 0;
        }
        if (commandId === 'NewDefaultListItem' || commandId === 'PopulateNewListItemMenu' || commandId === 'NewListItem') {
            return !(SP.Ribbon.SU.$0(this.get_newMenuData()));
        }
        if (SP.Ribbon.GenericListWebPartPageComponent.callBaseMethod(this, 'canHandleCommand', [ commandId ])) {
            return true;
        }
        return false;
    },
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        if (commandId === 'PopulateNewListItemMenu') {
            properties.PopulationJSON = this.getNewMenuXml('NewListItem', 'Ribbon.Document.All.NewListItem');
            return true;
        }
        else if (commandId === 'NewListItem') {
            var $v_0 = properties['CommandValueId'];
            this.executeClickScript($v_0);
            return true;
        }
        else if (commandId === 'NewDefaultListItem') {
            this.executeClickScript(this.getDefaultNewMenuItemScript());
            return true;
        }
        return SP.Ribbon.GenericListWebPartPageComponent.callBaseMethod(this, 'handleCommand', [ commandId, properties, sequence ]);
    },
    
    getGlobalCommands: function() {ULSMg8:;
        return SP.Ribbon.GenericListWebPartPageComponent.callBaseMethod(this, 'getGlobalCommands');
    },
    
    getFocusedCommands: function() {ULSMg8:;
        var $v_0 = SP.Ribbon.GenericListWebPartPageComponent.callBaseMethod(this, 'getFocusedCommands');
        Array.add($v_0, 'ViewProperties');
        Array.add($v_0, 'EditProperties');
        Array.add($v_0, 'ManagePermissions');
        Array.add($v_0, 'Delete');
        Array.add($v_0, 'ViewVersions');
        Array.add($v_0, 'Subscribe');
        Array.add($v_0, 'NewListItemMenuOpen');
        Array.add($v_0, 'NewDefaultListItem');
        Array.add($v_0, 'PopulateNewListItemMenu');
        Array.add($v_0, 'NewListItem');
        return $v_0;
    },
    
    addAlwaysEnabledCommands: function() {ULSMg8:;
        SP.Ribbon.GenericListWebPartPageComponent.callBaseMethod(this, 'addAlwaysEnabledCommands');
        var $v_0 = this.get_alwaysEnabledCommands();
        $v_0['ListItemTab'] = true;
        $v_0['ListTab'] = true;
        $v_0['ListItemManageGroup'] = true;
        $v_0['ListItemNewGroup'] = true;
        $v_0['ListItemPublishingGroup'] = true;
        $v_0['ListItemWorkflowGroup'] = true;
        $v_0['ListItemQuickStepsGroup'] = true;
        $v_0['SettingsGroup'] = true;
        $v_0['ActionsGroup'] = true;
        $v_0['LibraryNavigationGroup'] = true;
    }
}


SP.Ribbon.SolutionsPageComponent = function(id, data) {ULSMg8:;
    SP.Ribbon.SolutionsPageComponent.initializeBase(this, [ id, data ]);
    this.$b_4 = data.ViewId;
}
SP.Ribbon.SolutionsPageComponent.prototype = {
    $b_4: null,
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        if (commandId === 'DownloadSolutions') {
            window.DownloadSolutionHandler();
            return true;
        }
        else {
            return SP.Ribbon.SolutionsPageComponent.callBaseMethod(this, 'handleCommand', [ commandId, properties, sequence ]);
        }
    },
    
    get_alwaysEnabledCommands: function() {ULSMg8:;
        if (SP.Ribbon.SU.$0(this._alwaysEnabledCommands)) {
            this._alwaysEnabledCommands = SP.Ribbon.SolutionsPageComponent.callBaseMethod(this, 'get_alwaysEnabledCommands');
            this._alwaysEnabledCommands['NewDocument'] = true;
            this._alwaysEnabledCommands['UploadDocumentMenuOpen'] = true;
            this._alwaysEnabledCommands['SolutionTab'] = true;
            this._alwaysEnabledCommands['DocumentAllGroup'] = true;
            this._alwaysEnabledCommands['DocumentNewGroup'] = true;
            this._alwaysEnabledCommands['DocumentShareGroup'] = true;
            this._alwaysEnabledCommands['DocumentManageGroup'] = true;
            this._alwaysEnabledCommands['LibraryTab'] = true;
            this._alwaysEnabledCommands['SettingsGroup'] = true;
            this._alwaysEnabledCommands['ActionsGroup'] = true;
            this._alwaysEnabledCommands['LibraryNavigationGroup'] = true;
            this._alwaysEnabledCommands['DownloadSolutions'] = true;
        }
        return this._alwaysEnabledCommands;
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        if (commandId === 'SolutionTab' || commandId === 'LibraryTab') {
            return true;
        }
        return SP.Ribbon.SolutionsPageComponent.callBaseMethod(this, 'canHandleCommand', [ commandId ]);
    },
    
    getGlobalCommands: function() {ULSMg8:;
        var $v_0 = SP.Ribbon.SolutionsPageComponent.callBaseMethod(this, 'getGlobalCommands');
        Array.add($v_0, 'Delete');
        Array.add($v_0, 'ActivateSolution');
        Array.add($v_0, 'DeactivateSolution');
        Array.add($v_0, 'UpgradeSolution');
        return $v_0;
    },
    
    getFocusedCommands: function() {ULSMg8:;
        return SP.Ribbon.SolutionsPageComponent.callBaseMethod(this, 'getFocusedCommands');
    }
}


SP.Ribbon.WikiPageComponent = function() {ULSMg8:;
    this.$3S = Function.createDelegate(this, this.$6Q_1);
    this.$2u = Function.createDelegate(this, this.$55_1);
    this.$2q = Function.createDelegate(this, this.$51_1);
    this.$2k = Function.createDelegate(this, this.$4u_1);
    this.$2j = Function.createDelegate(this, this.$2C_1);
    this.$2o = Function.createDelegate(this, this.$4z_1);
    this.$39 = Function.createDelegate(this, this.$5N_1);
    this.$34 = Function.createDelegate(this, this.$5G_1);
    this.$32 = Function.createDelegate(this, this.$5E_1);
    this.$35 = Function.createDelegate(this, this.$5H_1);
    this.$36 = Function.createDelegate(this, this.$1V_1);
    this.$3R = Function.createDelegate(this, this.$6N_1);
    SP.Ribbon.WikiPageComponent.initializeBase(this);
}
SP.Ribbon.WikiPageComponent.registerWithPageManager = function(initInfo) {ULSMg8:;
    if (!SP.Ribbon.WikiPageComponent.$3_1) {
        SP.Ribbon.WikiPageComponent.$3_1 = new SP.Ribbon.WikiPageComponent();
        SP.Ribbon.WikiPageComponent.$3_1.$1w(initInfo);
        SP.Ribbon.PageManager.get_instance().addPageComponent(SP.Ribbon.WikiPageComponent.$3_1);
        SP.Ribbon.PageState.PageStateHandler.setHandleSaveMenu(false);
        if (initInfo.editMode) {
            SP.Ribbon.WikiPageComponent.$48_1();
            if (!SP.Ribbon.SU.$0(SP.Ribbon.WikiPageComponent.$S_1)) {
                SP.Ribbon.WikiPageComponent.$S_1.editingPageCallback();
            }
        }
        if (!SP.Ribbon.SU.$2(initInfo.conflictMergeTargetStatusHtml)) {
            SP.Ribbon.SaveConflictHandler.$6Y(initInfo.conflictMergeTargetStatusHtml);
        }
    }
    else {
        SP.Ribbon.WikiPageComponent.$3_1.$1w(initInfo);
    }
}
SP.Ribbon.WikiPageComponent.unregisterWithPageManager = function() {ULSMg8:;
    if (SP.Ribbon.WikiPageComponent.$3_1) {
        SP.Ribbon.PageManager.get_instance().removePageComponent(SP.Ribbon.WikiPageComponent.$3_1);
        SP.Ribbon.PageState.PageStateHandler.setHandleSaveMenu(true);
    }
}
SP.Ribbon.WikiPageComponent.get_instance = function() {ULSMg8:;
    return SP.Ribbon.WikiPageComponent.$3_1;
}
SP.Ribbon.WikiPageComponent.$3g_1 = function() {ULSMg8:;
    return !SP.Ribbon.WikiPageComponent.$P_1 && SP.Ribbon.WikiPageComponent.$D();
}
SP.Ribbon.WikiPageComponent.$3i_1 = function() {ULSMg8:;
    return !SP.Ribbon.WikiPageComponent.$P_1 && SP.Ribbon.WikiPageComponent.$D();
}
SP.Ribbon.WikiPageComponent.$D = function() {ULSMg8:;
    var $v_0 = false;
    var $v_1 = $get('_wikiPageMode');
    if ($v_1) {
        $v_0 = $v_1.value === 'Edit';
    }
    return $v_0;
}
SP.Ribbon.WikiPageComponent.$4B = function() {ULSMg8:;
    return !SP.Ribbon.SU.$0($get('_wikiPageMode'));
}
SP.Ribbon.WikiPageComponent.$5I_1 = function($p0, $p1, $p2) {
    var $v_0 = $p1[CUI.Controls.DropDownCommandProperties.SelectedItemId];
    if (SP.ScriptUtility.isNullOrUndefined($v_0)) {
        return false;
    }
    var $v_1 = $v_0.lastIndexOf('.');
    if ($v_1 < 0) {
        return false;
    }
    var $v_2 = $v_0.substring(0, $v_1 + 1);
    var $v_3 = $v_2;
    if (SP.Ribbon.WikiPageComponent.$D()) {
        $v_3 += 'SaveAndStop';
    }
    else {
        $v_3 += 'Edit';
    }
    $p1[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_3;
    return true;
}
SP.Ribbon.WikiPageComponent.$48_1 = function() {ULSMg8:;
    if (SP.Ribbon.WikiPageComponent.$1v_1) {
        return;
    }
    var $v_0 = window._spWikiPageNameEditorFlag;
    if ($v_0) {
        if (SP.Ribbon.SU.$0(SP.Ribbon.WikiPageComponent.$S_1)) {
            var $v_1 = window._spWikiPageNameDisplayElemId;
            var $v_2 = window._spWikiPageNameEditElemId;
            var $v_3 = window._spWikiPageNameEditTextBoxId;
            SP.Ribbon.WikiPageComponent.$S_1 = new SP.Application.UI.WikiPageNameInPlaceEditor(window.document, $v_1, $v_2, $v_3);
        }
    }
    SP.Ribbon.WikiPageComponent.$1v_1 = true;
}
SP.Ribbon.WikiPageComponent.$5J_1 = function($p0, $p1, $p2) {
    if ($p1) {
        CUI.RibbonCommand.serverButton(($p1['SourceControlId']), ($p1['MenuItemId']));
    }
    return true;
}
SP.Ribbon.WikiPageComponent.$60_1 = function($p0, $p1, $p2, $p3) {
    window._wikiCallback($p0, $p1, $p2, $p3);
}
SP.Ribbon.WikiPageComponent.$4p_1 = function() {ULSMg8:;
    var $v_0 = new Sys.StringBuilder();
    $v_0.append('\r\n<table style=\'padding:10px;\'>\r\n    <tr>\r\n        <td><img src=\'/_layouts/images/warning32by32.gif\' alt=\'\' /></td>\r\n        <td>');
    $v_0.append(SP.Utilities.HttpUtility.htmlEncode(SP.Res.saveChangeDialogDesc));
    $v_0.append('</td>\r\n    </tr>\r\n    <tr>\r\n        <td></td>\r\n        <td nowrap align=\'center\'>\r\n            <input type=\'button\' id=\'SaveDlgYes\' class=\'ms-NarrowButtonHeightWidth\' onclick=\'SP.Ribbon.WikiPageComponent.saveDialogClick(0)\' value=\'');
    $v_0.append(SP.Utilities.HttpUtility.htmlEncode(SP.Res.buttonYes));
    $v_0.append('\' />\r\n            <span class=\'ms-SpaceBetButtons\'>&#160;</span>\r\n            <input type=\'button\' id=\'SaveDlgNo\' class=\'ms-NarrowButtonHeightWidth\' onclick=\'SP.Ribbon.WikiPageComponent.saveDialogClick(1)\' value=\'');
    $v_0.append(SP.Utilities.HttpUtility.htmlEncode(SP.Res.buttonNo));
    $v_0.append('\' />\r\n            <span class=\'ms-SpaceBetButtons\'>&#160;</span>\r\n            <input type=\'button\' id=\'SaveDlgCancel\' class=\'ms-NarrowButtonHeightWidth\' onclick=\'SP.Ribbon.WikiPageComponent.saveDialogClick(2)\' value=\'');
    $v_0.append(SP.Utilities.HttpUtility.htmlEncode(SP.Res.buttonCancel));
    $v_0.append('\' />\r\n        </td>\r\n    </tr>\r\n    <tr><td style=\'height:3px;\'></td></tr>\r\n</table>\r\n');
    var $v_1 = document.createElement('DIV');
    $v_1.innerHTML = $v_0.toString();
    $v_1 = $v_1.getElementsByTagName('table')[0];
    return $v_1;
}
SP.Ribbon.WikiPageComponent.saveDialogClick = function(result) {ULSMg8:;
    if (!result) {
        SP.UI.ModalDialog.get_childDialog().set_returnValue('PageStateGroupSaveAndStop');
        SP.UI.ModalDialog.get_childDialog().close(1);
    }
    else if (result === 1) {
        SP.UI.ModalDialog.get_childDialog().set_returnValue('PageStateGroupDontSaveAndStop');
        SP.UI.ModalDialog.get_childDialog().close(1);
    }
    else {
        SP.UI.ModalDialog.get_childDialog().close(0);
    }
}
SP.Ribbon.WikiPageComponent.prototype = {
    $1_1: null,
    
    $1w: function($p0) {
        this.$1_1 = $p0;
        var $v_0 = this.$1_1.itemPermMasks;
        if (!(SP.BasePermissions.isInstanceOfType($v_0))) {
            this.$1_1.itemPermMasks = new SP.BasePermissions();
            if (!this.$1_1.itemPermMasks.customFromJson($v_0)) {
                this.$1_1.itemPermMasks.fromJson($v_0);
            }
        }
        $v_0 = this.$1_1.listPermMasks;
        if (!(SP.BasePermissions.isInstanceOfType($v_0))) {
            this.$1_1.listPermMasks = new SP.BasePermissions();
            if (!this.$1_1.listPermMasks.customFromJson($v_0)) {
                this.$1_1.listPermMasks.fromJson($v_0);
            }
        }
    },
    
    getGlobalCommands: function() {ULSMg8:;
        if (!SP.Ribbon.WikiPageComponent.$R_1) {
            SP.Ribbon.WikiPageComponent.$R_1 = [ 'CheckoutMenuOpen', 'CPEditTab', 'PageStateGroupEdit', 'EditAndCheckoutGroup', 'EditMobilePageMenuOpen', 'EditInDesigner', 'EditingGroup', 'EditingToolsContextualGroup', 'RenamePage', 'LibrarySettingsGroup', 'LinksGroup', 'MediaGroup', 'NotificationsGroup', 'PageActionsGroup', 'PageLayoutGroup', 'PageStateGroupDontSaveAndStop', 'PageStateGroupSave', 'PageStateGroupSaveAndStop', 'PageStateGroupOpenMenuSave', 'PageStateGroupQuerySaveMenu', 'PageStateGroupSaveSplit', 'ServerButton', 'ShareGroup', 'PageStateGroupStopEditing', 'TablesGroup', 'TrackTab', 'WebPartsGroup', 'WikiEditWebPart', 'WikiPageTab' ];
        }
        return SP.Ribbon.WikiPageComponent.$R_1;
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        this.$5x_1();
        var $v_0 = this.$M_1[commandId];
        if (!SP.Ribbon.SU.$0($v_0)) {
            var $v_1 = $v_0;
            return $v_1();
        }
        if (!SP.Ribbon.WikiPageComponent.$v_1) {
            SP.Ribbon.WikiPageComponent.$v_1 = {};
            var $v_2 = this.getGlobalCommands();
            if ($v_2) {
                var $v_4 = $v_2.length;
                for (var $v_5 = 0; $v_5 < $v_4; $v_5++) {
                    SP.Ribbon.WikiPageComponent.$v_1[$v_2[$v_5]] = true;
                }
            }
            var $v_3 = this.getFocusedCommands();
            if ($v_3) {
                var $v_6 = $v_3.length;
                for (var $v_7 = 0; $v_7 < $v_6; $v_7++) {
                    SP.Ribbon.WikiPageComponent.$v_1[$v_3[$v_7]] = true;
                }
            }
        }
        return !SP.Ribbon.SU.$0(SP.Ribbon.WikiPageComponent.$v_1[commandId]);
    },
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        return this.$44_1(commandId, properties, sequence);
    },
    
    $44_1: function($p0, $p1, $p2) {
        this.$47_1();
        var $v_0 = this.$H_1[$p0];
        if (!SP.Ribbon.SU.$0($v_0)) {
            var $v_1 = $v_0;
            return $v_1($p0, $p1, $p2);
        }
        return true;
    },
    
    getId: function() {ULSMg8:;
        return 'WikiPageComponent';
    },
    
    $4z_1: function() {ULSMg8:;
        return this.$2C_1() || SP.Ribbon.WikiPageComponent.$3g_1() || SP.Ribbon.WikiPageComponent.$3i_1();
    },
    
    $2C_1: function() {ULSMg8:;
        return !SP.Ribbon.WikiPageComponent.$P_1 && !SP.Ribbon.WikiPageComponent.$D() && this.$1_1.editable;
    },
    
    $4u_1: function() {ULSMg8:;
        return (this.$2C_1() && this.$1_1.listPermMasks.has(12) && this.$1_1.listPermMasks.has(19));
    },
    
    $5E_1: function($p0, $p1, $p2) {
        var $v_0 = $p1['CommandValueId'];
        return this.$44_1($v_0, $p1, $p2);
    },
    
    get_$4Q_1: function() {ULSMg8:;
        if (window.SPAutoSaveIsPageDirty && window.SPAutoSaveIsPageDirty()) {
            return true;
        }
        return false;
    },
    
    $5H_1: function($p0, $p1, $p2) {
        if (!SP.Ribbon.WikiPageComponent.$P_1) {
            CUI.PMetrics.perfMark(7111);
            var $v_0 = '<img src=\"/_layouts/images/loadingcirclests16.gif\" style=\"vertical-align: middle\" />';
            $v_0 += SP.Utilities.HttpUtility.htmlEncode(SP.Res.saving);
            var $v_1 = SP.UI.Notify.addNotification($v_0, true);
            var $v_2 = $v_1;
            var $v_3 = Function.createDelegate(this, function($p1_0, $p1_1) {
                SP.Ribbon.WikiPageComponent.$P_1 = false;
                SP.UI.Notify.removeNotification($v_2);
                SP.Ribbon.PageState.PageStateHandler.ignoreNextUnload = false;
                if (!SP.Ribbon.SU.$2($p1_0)) {
                    eval($p1_0);
                }
                CUI.PMetrics.perfMark(7112);
            });
            var $v_4 = Function.createDelegate(this, function($p1_0, $p1_1) {
                SP.Ribbon.WikiPageComponent.$P_1 = false;
                SP.UI.Notify.removeNotification($v_2);
                SP.Ribbon.PageState.PageStateHandler.ignoreNextUnload = false;
                if (SP.Ribbon.SU.$2($p1_0)) {
                    $p1_0 = SP.Res.saveFailed;
                }
                alert($p1_0);
            });
            SP.Ribbon.WikiPageComponent.$P_1 = true;
            SP.Ribbon.WikiPageComponent.$60_1('PageStateGroupSave', $v_3, null, $v_4);
        }
        return true;
    },
    
    $1V_1: function($p0, $p1, $p2) {
        if (!SP.Ribbon.WikiPageComponent.$P_1) {
            if ('PageStateGroupStopEditing' === $p0) {
                if (this.get_$4Q_1()) {
                    this.$6Z_1();
                    return true;
                }
                else {
                    $p0 = 'PageStateGroupDontSaveAndStop';
                }
            }
            if ($p0 === 'EditInDesigner') {
                EditInSPD(document.URL, false);
                return true;
            }
            var $v_0 = null;
            var $v_1;
            var $v_2 = '<img src=\"/_layouts/images/loadingcirclests16.gif\" style=\"vertical-align: middle\" />';
            var $v_3 = false;
            switch ($p0) {
                case 'PageStateGroupEdit':
                    $v_1 = 'Ribbon.WikiPageTab.EditAndCheckout.SaveEdit.Menu.SaveEdit.Edit';
                    $v_2 += SP.Utilities.HttpUtility.htmlEncode(SP.Res.autocompleteLoading);
                    break;
                case 'PageStateGroupDontSaveAndStop':
                    $v_1 = 'Ribbon.WikiPageTab.EditAndCheckout.SaveEdit.Menu.SaveEdit.Revert';
                    $v_2 += SP.Utilities.HttpUtility.htmlEncode(SP.Res.genericLoading);
                    $v_3 = true;
                    break;
                case 'PageStateGroupSaveAndStop':
                    $v_1 = 'Ribbon.WikiPageTab.EditAndCheckout.SaveEdit.Menu.SaveEdit.SaveAndStop';
                    $v_2 += SP.Utilities.HttpUtility.htmlEncode(SP.Res.saving);
                    $v_3 = true;
                    break;
                default:
                    return false;
            }
            if ($p0 === 'PageStateGroupEdit' && (SP.Ribbon.PageState.ImportedNativeData.PageState['DocLibCheckoutRequired'] || this.$1_1.missingRequiredFields) && !SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToCurrentUser']) {
                if (!confirm(window.L_ConfirmCheckout_Text)) {
                    return true;
                }
            }
            if ($v_3) {
                if (typeof(window.SP.UI) !== 'undefined' && typeof(window.SP.UI.Rte) !== 'undefined' && typeof(window.SP.UI.Rte.SnapshotManager) !== 'undefined' && typeof(window.SP.UI.Rte.SnapshotManager.clear) !== 'undefined') {
                    window.SP.UI.Rte.SnapshotManager.clear();
                }
            }
            if (!SP.Ribbon.WebPartComponent.get_$63() && ($p0 === 'PageStateGroupDontSaveAndStop' || $p0 === 'PageStateGroupSaveAndStop')) {
                var $v_4 = $get('_wikiPageCommand');
                $v_4.value = $p0;
                $v_4 = $get('MSOWebPartPage_Shared');
                if ($v_4) {
                    $v_4.value = '';
                }
                $v_4 = $get('MSOLayout_InDesignMode');
                if ($v_4) {
                    $v_4.value = '0';
                }
                $v_4 = $get('MSOSPWebPartManager_DisplayModeName');
                if ($v_4) {
                    $v_4.value = 'Browse';
                }
                var $v_5 = this.$1_1.postbackScript;
                eval($v_5);
                return true;
            }
            if (CUI.RibbonCommand.serverQueryButton($v_1)) {
                $v_0 = SP.UI.Notify.addNotification($v_2, true);
            }
            CUI.PMetrics.perfMark(7111);
            CUI.RibbonCommand.serverButton($v_1, null);
            if ($v_0) {
                SP.Ribbon.WikiPageComponent.$P_1 = true;
                var $v_6 = null;
                var $v_7 = $v_0;
                var $v_8 = Function.createDelegate(this, function($p1_0, $p1_1) {
                    if ($v_6) {
                        Sys.WebForms.PageRequestManager.getInstance().remove_pageLoaded($v_6);
                    }
                    $v_6 = null;
                    SP.Ribbon.UtilityInternal.$e();
                    CUI.PMetrics.perfMark(7112);
                });
                $v_6 = $v_8;
                Sys.WebForms.PageRequestManager.getInstance().add_pageLoaded($v_8);
                var $v_9 = null;
                var $v_A = Function.createDelegate(this, function($p1_0, $p1_1) {
                    SP.UI.Notify.removeNotification($v_7);
                    SP.Ribbon.WikiPageComponent.$P_1 = false;
                    if (!SP.Ribbon.SU.$0($p1_1.get_error())) {
                        if ($v_6) {
                            Sys.WebForms.PageRequestManager.getInstance().remove_pageLoaded($v_6);
                        }
                        $v_6 = null;
                        if ($v_9) {
                            Sys.WebForms.PageRequestManager.getInstance().remove_endRequest($v_9);
                        }
                        $v_9 = null;
                        if (!$p1_1.get_errorHandled()) {
                            alert($p1_1.get_error().message);
                            $p1_1.set_errorHandled(true);
                        }
                    }
                });
                $v_9 = $v_A;
                Sys.WebForms.PageRequestManager.getInstance().add_endRequest($v_A);
                switch ($p0) {
                    case 'PageStateGroupEdit':
                        SP.Ribbon.WikiPageComponent.$48_1();
                        if (!SP.Ribbon.SU.$0(SP.Ribbon.WikiPageComponent.$S_1)) {
                            SP.Ribbon.WikiPageComponent.$S_1.editingPageCallback();
                        }
                        break;
                    case 'PageStateGroupDontSaveAndStop':
                        break;
                    case 'PageStateGroupSaveAndStop':
                        if (!SP.Ribbon.SU.$0(SP.Ribbon.WikiPageComponent.$S_1)) {
                            SP.Ribbon.WikiPageComponent.$S_1.savingPageCallback();
                        }
                        break;
                    default:
                        break;
                }
            }
        }
        return true;
    },
    
    $51_1: function() {ULSMg8:;
        return SP.Ribbon.WikiPageComponent.$1v_1 && window._spWikiPageNameEditorFlag;
    },
    
    $5G_1: function($p0, $p1, $p2) {
        var $v_0 = SP.UI.$create_DialogOptions();
        $v_0.url = SP.Utilities.Utility.getLayoutsPageUrl('RenamePageDialog.aspx');
        var $v_1 = window._spWikiPageNameDisplayElemId;
        $v_0.url += '?Source=' + document.URL;
        $v_0.dialogReturnValueCallback = this.$3R;
        $v_0.title = SP.Res.renamePageDialog_Title;
        SP.UI.ModalDialog.showModalDialog($v_0);
        return true;
    },
    
    $6N_1: function($p0, $p1) {
        if ($p0 !== -1 && !SP.Ribbon.SU.$0($p1)) {
            var $v_0 = window._spWikiPageNameEditTextBoxId;
            ($get($v_0)).value = $p1;
        }
        if ($p0 === 1) {
            this.$1V_1('PageStateGroupSaveAndStop', null, 0);
        }
    },
    
    $55_1: function() {ULSMg8:;
        return this.$1_1.editable && !SP.Ribbon.WikiPageComponent.$D();
    },
    
    $5N_1: function($p0, $p1, $p2) {
        window.ChangeLayoutMode(false);
        return true;
    },
    
    $H_1: null,
    
    $47_1: function() {ULSMg8:;
        if (this.$H_1) {
            return;
        }
        var $v_0;
        this.$H_1 = {};
        $v_0 = this.$36;
        this.$H_1['PageStateGroupEdit'] = $v_0;
        this.$H_1['PageStateGroupSaveAndStop'] = $v_0;
        this.$H_1['PageStateGroupStopEditing'] = $v_0;
        this.$H_1['PageStateGroupDontSaveAndStop'] = $v_0;
        this.$H_1['EditInDesigner'] = $v_0;
        $v_0 = this.$35;
        this.$H_1['PageStateGroupSave'] = $v_0;
        this.$H_1['PageStateGroupQuerySaveMenu'] = SP.Ribbon.WikiPageComponent.$5I_1;
        this.$H_1['PageStateGroupSaveSplit'] = this.$32;
        this.$H_1['ServerButton'] = SP.Ribbon.WikiPageComponent.$5J_1;
        this.$H_1['RenamePage'] = this.$34;
        this.$H_1['WikiEditWebPart'] = this.$39;
    },
    
    $M_1: null,
    
    $5x_1: function() {ULSMg8:;
        if (this.$M_1) {
            return;
        }
        var $v_0;
        this.$M_1 = {};
        this.$M_1['PageStateGroupSaveSplit'] = this.$2o;
        this.$M_1['PageStateGroupEdit'] = this.$2j;
        this.$M_1['EditInDesigner'] = this.$2k;
        $v_0 = SP.Ribbon.WikiPageComponent.$3g_1;
        this.$M_1['PageStateGroupSave'] = $v_0;
        this.$M_1['PageStateGroupSaveAndStop'] = $v_0;
        this.$M_1['PageStateGroupStopEditing'] = SP.Ribbon.WikiPageComponent.$3i_1;
        this.$M_1['EditingToolsContextualGroup'] = SP.Ribbon.WikiPageComponent.$D;
        this.$M_1['RenamePage'] = this.$2q;
        $v_0 = this.$2u;
        this.$M_1['WikiEditWebPart'] = $v_0;
    },
    
    changeWikiPageMode: function(toEditMode) {ULSMg8:;
        if (toEditMode && !SP.Ribbon.WikiPageComponent.$D()) {
            this.$1V_1('PageStateGroupEdit', {}, 0);
        }
    },
    
    revertToRead: function() {ULSMg8:;
        SP.Ribbon.SaveConflictHandler.$14();
    },
    
    $6Z_1: function() {ULSMg8:;
        var $v_0 = SP.UI.$create_DialogOptions();
        $v_0.html = SP.Ribbon.WikiPageComponent.$4p_1();
        $v_0.title = SP.Res.saveChangeDialogTitle;
        $v_0.dialogReturnValueCallback = this.$3S;
        SP.UI.ModalDialog.showModalDialog($v_0);
        window.setTimeout(Function.createDelegate(this, function() {ULSMg8:;
            if ($get('SaveDlgYes')) {
                $get('SaveDlgYes').focus();
            }
        }), 0);
    },
    
    $6Q_1: function($p0, $p1) {
        if ($p0 === 1) {
            this.$1V_1($p1, null, 0);
        }
    }
}


SP.Ribbon.FetchedDocLibItemInfo = function() {
}
SP.Ribbon.FetchedDocLibItemInfo.prototype = {
    itemIsCheckedout: false,
    moderationStatus: 0
}


SP.Ribbon.DocLibAspxPageComponent = function(initInfo) {ULSMg8:;
    this.$2x = Function.createDelegate(this, this.$58_1);
    this.$2z = Function.createDelegate(this, this.$5B_1);
    this.$37 = Function.createDelegate(this, this.$5K_1);
    this.$2y = Function.createDelegate(this, this.$5A_1);
    this.$31 = Function.createDelegate(this, this.$5D_1);
    this.$3A = Function.createDelegate(this, this.$5O_1);
    this.$38 = Function.createDelegate(this, this.$5L_1);
    this.$33 = Function.createDelegate(this, this.$5F_1);
    this.$30 = Function.createDelegate(this, this.$5C_1);
    this.$2i = Function.createDelegate(this, this.$4t_1);
    this.$2s = Function.createDelegate(this, this.$53_1);
    this.$2m = Function.createDelegate(this, this.$4w_1);
    this.$2n = Function.createDelegate(this, this.$4y_1);
    this.$2v = Function.createDelegate(this, this.$56_1);
    this.$2p = Function.createDelegate(this, this.$50_1);
    this.$21 = Function.createDelegate(this, this.$4x_1);
    this.$2l = Function.createDelegate(this, this.$4v_1);
    this.$2t = Function.createDelegate(this, this.$54_1);
    SP.Ribbon.DocLibAspxPageComponent.initializeBase(this);
    this.$1_1 = initInfo;
    var $v_0 = this.$1_1.itemPermMasks;
    if (!(SP.BasePermissions.isInstanceOfType($v_0))) {
        this.$1_1.itemPermMasks = new SP.BasePermissions();
        if (!this.$1_1.itemPermMasks.customFromJson($v_0)) {
            this.$1_1.itemPermMasks.fromJson($v_0);
        }
    }
    $v_0 = this.$1_1.listPermMasks;
    if (!(SP.BasePermissions.isInstanceOfType($v_0))) {
        this.$1_1.listPermMasks = new SP.BasePermissions();
        if (!this.$1_1.listPermMasks.customFromJson($v_0)) {
            this.$1_1.listPermMasks.fromJson($v_0);
        }
    }
}
SP.Ribbon.DocLibAspxPageComponent.registerWithPageManager = function(initInfo) {ULSMg8:;
    if (!SP.Ribbon.DocLibAspxPageComponent.$3_1) {
        SP.Ribbon.DocLibAspxPageComponent.$3_1 = new SP.Ribbon.DocLibAspxPageComponent(initInfo);
        SP.Ribbon.PageManager.get_instance().addPageComponent(SP.Ribbon.DocLibAspxPageComponent.$3_1);
    }
}
SP.Ribbon.DocLibAspxPageComponent.get_instance = function() {ULSMg8:;
    return SP.Ribbon.DocLibAspxPageComponent.$3_1;
}
SP.Ribbon.DocLibAspxPageComponent.$5M_1 = function($p0, $p1, $p2) {
    SP.Ribbon.WebPartComponent.$4Z(4, false);
    return true;
}
SP.Ribbon.DocLibAspxPageComponent.$59_1 = function($p0, $p1, $p2) {
    if (SP.Ribbon.PageState.ImportedNativeData && SP.Ribbon.PageState.ImportedNativeData.PageState && SP.Ribbon.PageState.ImportedNativeData.PageState['DocLibCheckoutRequired'] && !SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToCurrentUser'] && !SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser']) {
        var $v_0 = document.URL;
        $v_0 = $v_0.split('?')[0].split('#')[0];
        $v_0 = window.unescapeProperly($v_0);
        var $v_1 = window.location.protocol + '//' + window.location.host + SP.PageContextInfo.get_webServerRelativeUrl();
        if ($v_1.endsWith('/')) {
            $v_1 = $v_1.substring(0, $v_1.length - 1);
        }
        if (!CheckoutAlertBeforeNavigate(null, true, false, $v_0, $v_1)) {
            return true;
        }
    }
    SP.Ribbon.WebPartComponent.$4Z(6, true);
    return true;
}
SP.Ribbon.DocLibAspxPageComponent.$3l_1 = function($p0, $p1, $p2) {
    SP.Ribbon.WebPartComponent.$6C();
    return true;
}
SP.Ribbon.DocLibAspxPageComponent.$3h = function() {ULSMg8:;
    return SP.Ribbon.Utility.get_$U() && SP.Ribbon.Utility.get_$U().has(31);
}
SP.Ribbon.DocLibAspxPageComponent.$3k = function($p0, $p1, $p2) {
    window.SetHomePage(SP.PageContextInfo.get_webServerRelativeUrl());
    return true;
}
SP.Ribbon.DocLibAspxPageComponent.prototype = {
    $1_1: null,
    
    get_allowInsertNewList: function() {ULSMg8:;
        return SP.Ribbon.Utility.get_$U() && SP.Ribbon.Utility.get_$U().has(12);
    },
    
    $6L: function() {ULSMg8:;
        this.$j_1 = null;
        this.$2P_1 = false;
        this.$3s_1();
    },
    
    $3s_1: function() {ULSMg8:;
        if (this.$2P_1) {
            return;
        }
        this.$2P_1 = true;
        var $v_0 = new SP.ClientContext();
        var $v_1 = $v_0.get_web().get_lists().getById(new SP.Guid(this.$1_1.listId));
        var $v_2 = $v_1.getItemById(this.$1_1.itemId);
        $v_0.load($v_2, '_ModerationStatus', 'CheckoutUser');
        $v_0.executeQueryAsync(Function.createDelegate(this, function() {ULSMg8:;
            this.$j_1 = new SP.Ribbon.FetchedDocLibItemInfo();
            if ($v_2.get_item('CheckoutUser')) {
                this.$j_1.itemIsCheckedout = true;
            }
            else {
                this.$j_1.itemIsCheckedout = false;
            }
            this.$j_1.moderationStatus = $v_2.get_item('_ModerationStatus');
            window.setTimeout(Function.createDelegate(this, function() {ULSMg8:;
                SP.Ribbon.PageManager.get_instance().get_commandDispatcher().executeCommand(Commands.CommandIds.ApplicationStateChanged, null);
            }), 0);
        }));
    },
    
    $j_1: null,
    $2P_1: false,
    
    get_$1X: function() {ULSMg8:;
        if (!this.$j_1) {
            this.$3s_1();
        }
        return this.$j_1;
    },
    
    getGlobalCommands: function() {ULSMg8:;
        if (!SP.Ribbon.DocLibAspxPageComponent.$R_1) {
            SP.Ribbon.DocLibAspxPageComponent.$R_1 = [ 'editPageProperties', 'pagePropertiesMenuOpen', 'viewPageProperties', 'webPartPageWorkflow', 'webPartPageManageWorkflow', 'webPartPageVerions', 'webPartPagePermissions', 'IncomingLinks', 'AlertMePage', 'EditTitleBar', 'ManageGroup', 'WikiEditProperties', 'LibrarySettingsGroup', 'PageActionsGroup', 'PagePropertiesMenuOpen', 'Permissions', 'SetHomePage', 'ShareGroup', 'VersionHistory', 'VersionsMenuOpen', 'VersionDiff', 'ViewAllPages', 'WikiViewProperties', 'WikiLibraryPermissions', 'WikiLibrarySettings', 'WorkflowGroup' ];
        }
        return SP.Ribbon.DocLibAspxPageComponent.$R_1;
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        this.$5w_1();
        var $v_0 = this.$9_1[commandId];
        if ($v_0) {
            return $v_0();
        }
        var $v_1 = this.get_$57_1()[commandId];
        if ($v_1) {
            return true;
        }
        return false;
    },
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        this.$47_1();
        var $v_0 = this.$A_1[commandId];
        if ($v_0) {
            return $v_0(commandId, properties, sequence);
        }
        return true;
    },
    
    getId: function() {ULSMg8:;
        return 'DocLibAspxPageComponent';
    },
    
    $1f_1: null,
    
    get_$57_1: function() {ULSMg8:;
        if (!this.$1f_1) {
            this.$1f_1 = {};
            var $v_0 = this.getGlobalCommands();
            var $v_1 = $v_0.length;
            for (var $v_2 = 0; $v_2 < $v_0.length; $v_2++) {
                this.$1f_1[$v_0[$v_2]] = true;
            }
        }
        return this.$1f_1;
    },
    
    $9_1: null,
    
    $5w_1: function() {ULSMg8:;
        if (!this.$9_1) {
            this.$9_1 = {};
            var $v_0 = this.$2t;
            this.$9_1['PagePropertiesMenuOpen'] = $v_0;
            this.$9_1['WikiViewProperties'] = $v_0;
            this.$9_1['pagePropertiesMenuOpen'] = $v_0;
            this.$9_1['viewPageProperties'] = $v_0;
            $v_0 = this.$2l;
            this.$9_1['WikiEditProperties'] = $v_0;
            this.$9_1['editPageProperties'] = $v_0;
            this.$9_1['LibraryPermissions'] = this.$21;
            this.$9_1['WikiLibraryPermissions'] = this.$21;
            $v_0 = this.$2p;
            this.$9_1['Permissions'] = $v_0;
            this.$9_1['webPartPagePermissions'] = $v_0;
            this.$9_1['WikiLibrarySettings'] = this.$2v;
            $v_0 = this.$2n;
            this.$9_1['ManageWorkflow'] = $v_0;
            this.$9_1['webPartPageManageWorkflow'] = $v_0;
            $v_0 = SP.Ribbon.DocLibAspxPageComponent.$3h;
            this.$9_1['SetHomePage'] = $v_0;
            $v_0 = this.$2m;
            this.$9_1['EditTitleBar'] = $v_0;
            $v_0 = this.$2s;
            this.$9_1['VersionDiff'] = $v_0;
            this.$9_1['VersionHistory'] = $v_0;
            this.$9_1['VersionsMenuOpen'] = $v_0;
            this.$9_1['webPartPageVerions'] = $v_0;
            this.$9_1['AlertMePage'] = this.$2i;
        }
    },
    
    $A_1: null,
    
    $47_1: function() {ULSMg8:;
        if (!this.$A_1) {
            this.$A_1 = {};
            var $v_0 = SP.Ribbon.DocLibAspxPageComponent.$3l_1;
            this.$A_1['VersionHistory'] = $v_0;
            $v_0 = SP.Ribbon.DocLibAspxPageComponent.$5M_1;
            this.$A_1['WikiViewProperties'] = $v_0;
            this.$A_1['viewPageProperties'] = $v_0;
            $v_0 = SP.Ribbon.DocLibAspxPageComponent.$59_1;
            this.$A_1['WikiEditProperties'] = $v_0;
            this.$A_1['editPageProperties'] = $v_0;
            $v_0 = this.$30;
            this.$A_1['WikiLibraryPermissions'] = $v_0;
            $v_0 = this.$33;
            this.$A_1['Permissions'] = $v_0;
            this.$A_1['webPartPagePermissions'] = $v_0;
            this.$A_1['ViewAllPages'] = this.$38;
            this.$A_1['WikiLibrarySettings'] = this.$3A;
            $v_0 = this.$31;
            this.$A_1['ManageWorkflow'] = $v_0;
            this.$A_1['webPartPageManageWorkflow'] = $v_0;
            $v_0 = SP.Ribbon.DocLibAspxPageComponent.$3k;
            this.$A_1['SetHomePage'] = $v_0;
            $v_0 = this.$2y;
            this.$A_1['EditTitleBar'] = $v_0;
            $v_0 = SP.Ribbon.DocLibAspxPageComponent.$3l_1;
            this.$A_1['VersionHistory'] = $v_0;
            this.$A_1['webPartPageVerions'] = $v_0;
            $v_0 = this.$37;
            this.$A_1['VersionDiff'] = $v_0;
            this.$A_1['IncomingLinks'] = this.$2z;
            this.$A_1['AlertMePage'] = this.$2x;
        }
    },
    
    $54_1: function() {ULSMg8:;
        return !this.$1_1.doNotShowProperties;
    },
    
    $4v_1: function() {ULSMg8:;
        var $v_0 = SP.Ribbon.PageState.ImportedNativeData && SP.Ribbon.PageState.ImportedNativeData.PageState;
        var $v_1 = !$v_0 || ($v_0 && !SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser']);
        return !this.$1_1.doNotShowProperties && this.$1_1.editable && $v_1 && this.$1_1.itemPermMasks.has(3);
    },
    
    $56_1: function() {ULSMg8:;
        return this.$1_1.listPermMasks.has(12);
    },
    
    $5O_1: function($p0, $p1, $p2) {
        var $v_0 = SP.Utilities.Utility.getLayoutsPageUrl('listedit.aspx');
        $v_0 = $v_0 + '?List=' + this.$1_1.listId;
        SP.Utilities.HttpUtility.navigateTo($v_0);
        return true;
    },
    
    $50_1: function() {ULSMg8:;
        if (this.$1_1.itemPermMasks.has(63)) {
            return true;
        }
        return false;
    },
    
    $5F_1: function($p0, $p1, $p2) {
        var $v_0 = SP.Utilities.Utility.getLayoutsPageUrl('User.aspx');
        var $v_1 = new SP.Utilities.UrlBuilder($v_0);
        var $v_2 = new SP.Guid(this.$1_1.listId);
        $v_1.addKeyValueQueryString('obj', $v_2.toString('B') + ',' + this.$1_1.itemId.toString() + ',LISTITEM');
        $v_1.addKeyValueQueryString('List', $v_2.toString('B'));
        $v_0 = $v_1.get_url() + '&Source' + GetSource();
        SP.Utilities.HttpUtility.navigateTo($v_0);
        return true;
    },
    
    $4x_1: function() {ULSMg8:;
        if (this.$1_1.listPermMasks.has(63)) {
            return true;
        }
        return false;
    },
    
    $5C_1: function($p0, $p1, $p2) {
        var $v_0 = SP.Utilities.Utility.getLayoutsPageUrl('User.aspx');
        var $v_1 = new SP.Utilities.UrlBuilder($v_0);
        var $v_2 = new SP.Guid(this.$1_1.listId);
        $v_1.addKeyValueQueryString('obj', $v_2.toString('B') + ',doclib');
        $v_1.addKeyValueQueryString('List', $v_2.toString('B'));
        $v_0 = $v_1.get_url() + '&Source' + GetSource();
        SP.Utilities.HttpUtility.navigateTo($v_0);
        return true;
    },
    
    $5L_1: function($p0, $p1, $p2) {
        this.$6A_1();
        return true;
    },
    
    $6A_1: function() {ULSMg8:;
        var $v_0 = SP.Utilities.Utility.getLayoutsPageUrl('listform.aspx');
        var $v_1 = new SP.Utilities.UrlBuilder($v_0);
        var $v_2 = new SP.Guid(this.$1_1.listId);
        $v_1.addKeyValueQueryString('ListId', $v_2.toString('B'));
        $v_1.addKeyValueQueryString('PageType', '0');
        SP.Utilities.HttpUtility.navigateTo($v_1.get_url());
    },
    
    $5B_1: function($p0, $p1, $p2) {
        var $v_0 = SP.Utilities.Utility.getLayoutsPageUrl('BackLinks.aspx');
        var $v_1 = new SP.Utilities.UrlBuilder($v_0);
        $v_1.addKeyValueQueryString('List', (new SP.Guid(this.$1_1.listId)).toString());
        $v_1.addKeyValueQueryString('ID', this.$1_1.itemId.toString());
        SP.Utilities.HttpUtility.navigateTo($v_1.get_url());
        return true;
    },
    
    $5K_1: function($p0, $p1, $p2) {
        var $v_0 = SP.Utilities.Utility.getLayoutsPageUrl('VersionDiff.aspx');
        var $v_1 = new SP.Utilities.UrlBuilder($v_0);
        var $v_2 = new SP.Guid(this.$1_1.listId);
        $v_1.addKeyValueQueryString('List', $v_2.toString('B'));
        $v_1.addKeyValueQueryString('ID', this.$1_1.itemId.toString());
        SP.Utilities.HttpUtility.navigateTo($v_1.get_url());
        return true;
    },
    
    $53_1: function() {ULSMg8:;
        if (SP.Ribbon.SU.$0(this.$1_1.itemId)) {
            return false;
        }
        if (!this.$1_1.itemPermMasks.has(7)) {
            return false;
        }
        return this.$1_1.enableVersioning;
    },
    
    $5D_1: function($p0, $p1, $p2) {
        var $v_0 = new SP.Utilities.UrlBuilder(SP.Utilities.Utility.getLayoutsPageUrl('Workflow.aspx'));
        var $v_1 = new SP.Guid(this.$1_1.listId);
        $v_0.addKeyValueQueryString('ID', this.$1_1.itemId.toString());
        $v_0.addKeyValueQueryString('List', $v_1.toString('B'));
        var $v_2 = $v_0.get_url() + '&Source' + GetSource();
        SP.Utilities.HttpUtility.navigateTo($v_2);
        return true;
    },
    
    $4y_1: function() {ULSMg8:;
        return (!SP.Ribbon.SU.$0(this.$1_1.itemId) && this.$1_1.workflowsAssociated && this.$1_1.itemPermMasks.has(3));
    },
    
    $4w_1: function() {ULSMg8:;
        return this.$1_1.editable;
    },
    
    $5A_1: function($p0, $p1, $p2) {
        var $v_0 = window.document.getElementById($p0);
        if (!$v_0) {
            return false;
        }
        var $v_1 = $v_0.getAttribute('href');
        if ($v_1 && $v_1.length > 0) {
            if ($v_1.startsWith('javascript:')) {
                $v_1 = $v_1.substr(11);
            }
            eval($v_1);
            SP.Ribbon.PageManager.get_instance().get_commandDispatcher().executeCommand(Commands.CommandIds.ApplicationStateChanged, null);
            return true;
        }
        return false;
    },
    
    $4t_1: function() {ULSMg8:;
        if (this.$1_1.itemPermMasks.has(40)) {
            return true;
        }
        return false;
    },
    
    $58_1: function($p0, $p1, $p2) {
        var $v_0 = SP.Utilities.Utility.getLayoutsPageUrl('SubNew.aspx');
        var $v_1 = new SP.Utilities.UrlBuilder($v_0);
        $v_1.addKeyValueQueryString('List', this.$1_1.listId);
        $v_1.addKeyValueQueryString('ID', this.$1_1.itemId.toString());
        $v_0 = $v_1.get_url() + '&Source' + GetSource();
        var $v_2 = SP.UI.$create_DialogOptions();
        $v_2.url = $v_0;
        SP.UI.ModalDialog.showModalDialog($v_2);
        return true;
    }
}


SP.Ribbon.WebPartComponent = function() {ULSMg8:;
    this.$3Q = Function.createDelegate(this, this.$6K_1);
    this.$3L = Function.createDelegate(this, this.$6B_1);
    SP.Ribbon.WebPartComponent.initializeBase(this);
    this.$4L_1 = new SP.Ribbon.RelatedFieldsHelper(false);
    this.$4K_1 = new SP.Ribbon.RelatedFieldsHelper(true);
}
SP.Ribbon.WebPartComponent.get_instance = function() {ULSMg8:;
    return SP.Ribbon.WebPartComponent.$3_1;
}
SP.Ribbon.WebPartComponent.registerWithPageManager = function(initInfo) {ULSMg8:;
    if (!SP.Ribbon.WebPartComponent.$3_1) {
        SP.Ribbon.WebPartComponent.$3_1 = new SP.Ribbon.WebPartComponent();
        SP.Ribbon.WebPartComponent.$3_1.$1w(initInfo);
        SP.Ribbon.PageManager.get_instance().addPageComponent(SP.Ribbon.WebPartComponent.$3_1);
        SP.Ribbon.UtilityInternal.$4n('click', SP.Ribbon.WebPartComponent.$69_1);
    }
    else {
        SP.Ribbon.WebPartComponent.$3_1.$1w(initInfo);
    }
}
SP.Ribbon.WebPartComponent.$69_1 = function($p0) {
    if (SP.UI.UIUtility.focusValidOnThisNode($p0.target) && SP.Ribbon.WebPartComponent.$3_1) {
        CUI.PMetrics.perfMark(7186);
        SP.Ribbon.WebPartComponent.$3_1.$5Y($p0.target);
        CUI.PMetrics.perfMark(7187);
    }
}
SP.Ribbon.WebPartComponent.$1Y_1 = function($p0) {
    var $v_0 = window._spWebPartComponents;
    if (SP.Ribbon.SU.$0($v_0)) {
        return null;
    }
    return $v_0[$p0];
}
SP.Ribbon.WebPartComponent.$6C = function() {ULSMg8:;
    var $v_0 = new Sys.StringBuilder();
    SP.Ribbon.WebPartComponent.$2A_1('versions.aspx', $v_0);
    $v_0.append('list=');
    $v_0.append(SP.PageContextInfo.get_pageListId());
    $v_0.append('&ID=');
    $v_0.append(SP.PageContextInfo.get_pageItemId().toString());
    SP.Utilities.HttpUtility.navigateTo($v_0.toString());
}
SP.Ribbon.WebPartComponent.$2A_1 = function($p0, $p1) {
    var $v_0 = SP.PageContextInfo.get_webServerRelativeUrl();
    $p1.append($v_0);
    if (!$v_0.endsWith('/')) {
        $p1.append('/');
    }
    $p1.append('_layouts/');
    $p1.append($p0);
    $p1.append('?');
    return;
}
SP.Ribbon.WebPartComponent.$4Z = function($p0, $p1) {
    var $v_0 = new Sys.StringBuilder();
    SP.Ribbon.WebPartComponent.$2A_1('listform.aspx', $v_0);
    $v_0.append('PageType=');
    $v_0.append($p0.toString());
    $v_0.append('&ListId=');
    $v_0.append(SP.PageContextInfo.get_pageListId());
    $v_0.append('&ID=');
    $v_0.append(SP.PageContextInfo.get_pageItemId().toString());
    if ($p1) {
        if ($p0 === 6) {
            SP.Utilities.HttpUtility.navigateTo($v_0.toString());
        }
        else {
            SP.Utilities.HttpUtility.appendSourceAndNavigateTo($v_0.toString());
        }
    }
    else {
        window.OpenPopUpPage($v_0.toString());
    }
}
SP.Ribbon.WebPartComponent.$1W = function() {ULSMg8:;
    var $v_0 = window.document.getElementById('_wpSelected');
    if (!SP.Ribbon.SU.$0($v_0) && !SP.Ribbon.SU.$0($v_0.value)) {
        var $v_1 = SP.Ribbon.PageManager.get_instance().getPageComponentById(SP.Ribbon.WebPartComponent.$40_1($v_0.value));
        if (!SP.Ribbon.SU.$0($v_1)) {
            SP.Ribbon.PageManager.get_instance().get_focusManager().releaseFocusFromComponent($v_1);
        }
    }
}
SP.Ribbon.WebPartComponent.$3t = function() {ULSMg8:;
    var $v_0 = window.document.getElementById('_wpSelected');
    if (!SP.Ribbon.SU.$0($v_0) && !SP.Ribbon.SU.$0($v_0.value)) {
        var $v_1 = SP.Ribbon.PageManager.get_instance().getPageComponentById(SP.Ribbon.WebPartComponent.$40_1($v_0.value));
        if (!SP.Ribbon.SU.$0($v_1)) {
            SP.Ribbon.PageManager.get_instance().get_focusManager().requestFocusForComponent($v_1);
        }
    }
}
SP.Ribbon.WebPartComponent.$40_1 = function($p0) {
    if (!SP.Ribbon.SU.$0($p0) && $p0.length > 12) {
        var $v_0 = $p0.substring(12, $p0.length);
        var $v_1 = SP.Ribbon.WebPartComponent.$1Y_1($v_0);
        if ($v_1 && !SP.Ribbon.SU.$2($v_1.pageComponentId)) {
            return $v_1.pageComponentId;
        }
    }
    return $p0;
}
SP.Ribbon.WebPartComponent.getWebPartAdder = function() {ULSMg8:;
    return window.WPAdder;
}
SP.Ribbon.WebPartComponent.get_$63 = function() {ULSMg8:;
    var $v_0 = $get('MSOLayout_InDesignMode');
    if ($v_0 && $v_0.value === '1') {
        return false;
    }
    var $v_1 = $get('MSOSPWebPartManager_DisplayModeName');
    if ($v_1 && $v_1.value && $v_1.value.toUpperCase() !== 'BROWSE') {
        return false;
    }
    return true;
}
SP.Ribbon.WebPartComponent.get_$1B = function() {ULSMg8:;
    var $v_0 = $get('MSOSPWebPartManager_DisplayModeName');
    if ($v_0 && $v_0.value && $v_0.value.toUpperCase() === 'EDIT') {
        return true;
    }
    return false;
}
SP.Ribbon.WebPartComponent.get_activeWebPartId = function() {ULSMg8:;
    var $v_0 = null;
    if (SP.Ribbon.WebPartComponent.$3_1 && !SP.Ribbon.SU.$2(SP.Ribbon.WebPartComponent.$3_1.get_$K())) {
        return SP.Ribbon.WebPartComponent.$3_1.get_$K();
    }
    if (window.document.getElementById('_wpSelected')) {
        $v_0 = (window.document.getElementById('_wpSelected')).value;
        if (!SP.Ribbon.SU.$2($v_0)) {
            return $v_0.substr(12);
        }
    }
    return null;
}
SP.Ribbon.WebPartComponent.get_pageComponentIdOfActiveWebPart = function() {ULSMg8:;
    var $v_0 = SP.Ribbon.WebPartComponent.get_activeWebPartId();
    if (SP.Ribbon.SU.$2($v_0)) {
        return null;
    }
    var $v_1 = SP.Ribbon.WebPartComponent.$1Y_1($v_0);
    if (!$v_1 || SP.Ribbon.SU.$2($v_1.pageComponentId)) {
        return $v_0;
    }
    return $v_1.pageComponentId;
}
SP.Ribbon.WebPartComponent.get_activeWebPartZoneId = function() {ULSMg8:;
    if (SP.Ribbon.WebPartComponent.$3_1 && !SP.Ribbon.SU.$2(SP.Ribbon.WebPartComponent.$3_1.get_$X())) {
        return SP.Ribbon.WebPartComponent.$3_1.get_$X();
    }
    return null;
}
SP.Ribbon.WebPartComponent.fetchListViewWebPartPageComponent = function(webPartId, pageComponentId, list, view) {ULSMg8:;
    var $v_0 = new SP.Ribbon.FetchListViewWebPartPageComponentWorker(webPartId, pageComponentId, list, view);
    $v_0.fetch();
}
SP.Ribbon.WebPartComponent.$3r = function($p0) {
    var $v_0 = document.createElement('SCRIPT');
    $v_0.setAttribute('type', 'text/javascript');
    if (Sys.Browser.agent === Sys.Browser.Safari || Sys.Browser.agent === Sys.Browser.AppleWebKit) {
        $v_0.innerHTML = $p0;
    }
    else {
        $v_0.text = $p0;
    }
    var $v_1 = document.getElementsByTagName('HEAD')[0];
    $v_1.appendChild($v_0);
}
SP.Ribbon.WebPartComponent.prototype = {
    $1: null,
    $4L_1: null,
    $4K_1: null,
    
    $1w: function($p0) {
        this.$1 = $p0;
        var $v_0 = this.$1.itemPermissions;
        if (!SP.Ribbon.SU.$0($v_0) && !(SP.BasePermissions.isInstanceOfType($v_0))) {
            this.$1.itemPermissions = new SP.BasePermissions();
            if (!this.$1.itemPermissions.customFromJson($v_0)) {
                this.$1.itemPermissions.fromJson($v_0);
            }
        }
    },
    
    $5Y: function($p0) {
        var $v_0 = null;
        var $v_1 = null;
        while ($p0 && $p0 !== document.body) {
            if ($p0.tagName === 'A' || $p0.tagName === 'INPUT') {
                return;
            }
            if (!$v_0 && (SP.Ribbon.Utility.$F($p0, 's4-wpActive') || SP.Ribbon.Utility.$F($p0, 's4-wpcell'))) {
                $v_0 = $p0;
            }
            else if (!$v_1 && SP.Ribbon.Utility.$F($p0, 'ms-SPZone') && $p0.getAttribute('zoneID')) {
                $v_1 = $p0;
            }
            $p0 = $p0.parentNode;
        }
        this.deselectWebPartAndZone($v_0, $v_1);
    },
    
    deselectWebPartAndZone: function(webpart, webpartZone) {ULSMg8:;
        if (this.get_$4_1() && !SP.Ribbon.SU.$0(this.get_$4_1().getAttribute('WPToolPaneOpen'))) {
            return;
        }
        var $v_0 = false;
        if (this.$6e(webpart)) {
            $v_0 = true;
        }
        if (this.$6f(webpartZone)) {
            $v_0 = true;
        }
        if ($v_0) {
            SP.Ribbon.UtilityInternal.$e();
        }
    },
    
    $6e: function($p0) {
        if (!$p0 && this.get_$4_1() && $p0 !== this.get_$4_1()) {
            var $v_0 = this.$5r_1(this.get_$4_1());
            if ($v_0 && $v_0.isDefaultWebPart) {
                return false;
            }
            Sys.UI.DomElement.removeCssClass(this.get_$4_1(), 's4-wpActive');
            if (!SP.Ribbon.Utility.$F(this.get_$4_1(), 's4-wpcell-plain')) {
                Sys.UI.DomElement.addCssClass(this.get_$4_1(), 's4-wpcell');
            }
            DeselectAllWPItems();
            var $v_1 = 'SelectionCbx' + this.$q_1(this.get_$4_1());
            var $v_2 = $get($v_1);
            if (!SP.Ribbon.SU.$0($v_2)) {
                $v_2.checked = false;
            }
            SP.Ribbon.WebPartComponent.$1W();
            this.$r_1 = null;
            this.$2Z_1(null);
            return true;
        }
        return false;
    },
    
    $6f: function($p0) {
        if (this.get_$J_1() && !$p0 && this.get_$E_1()) {
            Sys.UI.DomElement.removeCssClass(this.get_$E_1(), 's4-wzActive');
            this.$i_1 = null;
            this.$4T_1(null);
            return true;
        }
        return false;
    },
    
    selectWebPartById: function(id, setNextRibbonTab) {ULSMg8:;
        var $v_0 = $get('MSOZoneCell_' + id);
        return this.selectWebPart($v_0, setNextRibbonTab);
    },
    
    selectWebPart: function(zc, setNextRibbonTab) {ULSMg8:;
        if (SP.Ribbon.SU.$0(zc)) {
            return false;
        }
        if (this.get_$4_1() && this.get_$4_1() !== zc && !SP.Ribbon.SU.$0(this.get_$4_1().getAttribute('WPToolPaneOpen'))) {
            return false;
        }
        this.$4c_1(zc, setNextRibbonTab);
        SP.Ribbon.UtilityInternal.$e();
        return true;
    },
    
    selectWebPartZone: function(z, zoneID) {ULSMg8:;
        if (this.get_$4_1() && !SP.Ribbon.SU.$0(this.get_$4_1().getAttribute('WPToolPaneOpen'))) {
            return;
        }
        if (!z) {
            var $v_0 = GetElementsByName('MSOZone');
            if ($v_0 && $v_0.length > 0) {
                for (var $v_1 = 0; $v_1 < $v_0.length; $v_1++) {
                    var $v_2 = $v_0[$v_1].getAttribute('zoneId');
                    if (zoneID === $v_2) {
                        z = $v_0[$v_1];
                        break;
                    }
                }
            }
        }
        if (z) {
            this.$4d_1(z);
            this.$4T_1(z);
        }
    },
    
    isFocusable: function() {ULSMg8:;
        return false;
    },
    
    receiveFocus: function() {ULSMg8:;
        return true;
    },
    
    yieldFocus: function() {ULSMg8:;
        return true;
    },
    
    getGlobalCommands: function() {ULSMg8:;
        this.$49_1();
        var $v_0 = [];
        Array.addRange($v_0, SP.Ribbon.WebPartComponent.$R_1);
        Array.addRange($v_0, this.$1i_1);
        return $v_0;
    },
    
    $1i_1: null,
    $1E_1: null,
    
    $49_1: function() {ULSMg8:;
        if (this.$1i_1) {
            return;
        }
        this.$1i_1 = [];
        this.$1E_1 = {};
        var $v_0 = window._spWebPartComponents;
        if (SP.Ribbon.SU.$0($v_0)) {
            return;
        }
        var $$dict_1_0 = $v_0;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_1 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            var $v_2 = $v_1.value;
            for (var $v_3 = 0; $v_3 < $v_2.contextualGroupCommands.length; $v_3++) {
                var $v_4 = this.$1E_1[$v_2.contextualGroupCommands[$v_3]];
                if (SP.Ribbon.SU.$0($v_4)) {
                    $v_4 = [];
                    this.$1E_1[$v_2.contextualGroupCommands[$v_3]] = $v_4;
                }
                Array.add($v_4, $v_1.key);
            }
        }
        var $$dict_1_0 = this.$1E_1;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_5 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            Array.add(this.$1i_1, $v_5.key);
        }
    },
    
    $5r_1: function($p0) {
        var $v_0 = this.$q_1($p0);
        if (SP.Ribbon.SU.$2($v_0)) {
            return null;
        }
        return SP.Ribbon.WebPartComponent.$1Y_1($v_0);
    },
    
    get_$1X_1: function() {ULSMg8:;
        if (SP.Ribbon.DocLibAspxPageComponent.$3_1) {
            return SP.Ribbon.DocLibAspxPageComponent.$3_1.get_$1X();
        }
        return null;
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        switch (commandId) {
            case 'MSOMenu_Minimize':
            case 'MSOMenu_Restore':
            case 'MSOMenu_Close':
            case 'MSOMenu_Edit':
            case 'MSOMenu_Delete':
                if (!this.get_$4_1()) {
                    return false;
                }
                return this.$4s_1(commandId);
            case 'webPartPageApproval':
            case 'approveWebpartPage':
            case 'rejectWebpartPage':
                if (!SP.Ribbon.SU.$0(this.$1.itemId) && this.$1.enableModeration && this.$1.itemPermissions.has(3) && this.$1.itemPermissions.has(5) && this.get_$1X_1() && (this.get_$1X_1().moderationStatus === 2 || !this.$1.enableMinorVersioning) && !this.get_$1X_1().itemIsCheckedout) {
                    return true;
                }
                return false;
            case 'WebPartContextualGroup':
                return (SP.Ribbon.WikiPageComponent.$D() || this.get_$J_1() || SP.Ribbon.WebPartComponent.get_$1B()) && !SP.Ribbon.SU.$0(this.get_$4_1());
            case 'insertTextWebPart':
            case 'insertImageWebPart':
                return this.$2f_1(commandId, true, null) && !SP.Ribbon.SU.$0(this.get_$E_1());
            case 'insertExistingList':
                return this.$2f_1(commandId, true, null);
            case 'EditMobileSharedPage':
                if (SP.Ribbon.WikiPageComponent.$4B() || !this.$1.editable) {
                    return false;
                }
                return this.$3f_1();
            case 'EditMobilePersonalPage':
                if (SP.Ribbon.WikiPageComponent.$4B() || !this.$1.editable) {
                    return false;
                }
                return this.$3e_1();
            case 'webPartPageDelete':
                if (SP.Ribbon.SU.$0(this.$1.itemId)) {
                    return false;
                }
                if (!this.$1.itemPermissions.has(4)) {
                    return false;
                }
                return true;
            case 'webPartPageEdit':
                return this.$1.editable || this.$1.isEditMode;
            case 'webPartPageStartEdit':
                if (this.get_$J_1() || SP.Ribbon.WebPartComponent.get_$1B()) {
                    return false;
                }
                return this.$1.editable;
            case 'webPartPageStopEdit':
                if (!this.get_$J_1() && !SP.Ribbon.WebPartComponent.get_$1B()) {
                    return false;
                }
                return true;
            case 'Ribbon.WebPartOption':
                return (SP.Ribbon.WikiPageComponent.$D() || this.get_$J_1() || SP.Ribbon.WebPartComponent.get_$1B()) && !SP.Ribbon.SU.$0(this.get_$4_1());
            case 'InsertRelatedWebPartToListViewMenuAnchor':
            case 'InsertRelatedWebPartToListView':
                return (SP.Ribbon.WikiPageComponent.$D() || this.get_$J_1()) && !SP.Ribbon.SU.$0(this.get_$4_1()) && !SP.Ribbon.SU.$0(this.get_$3Y_1());
            case 'InsertRelatedWebPartToListFormMenuAnchor':
            case 'InsertRelatedWebPartToListForm':
                return this.get_$J_1();
            case 'WebPartInsertContextualGroup':
                return !SP.Ribbon.SU.$0(this.get_$E_1()) && this.$1.allowWebPartAdder;
            case 'EditMobilePageMenuOpen':
                return this.$3f_1() || this.$3e_1();
            case 'makeHomePage':
                return SP.Ribbon.DocLibAspxPageComponent.$3h();
            case 'EditInDesigner':
                return !SP.Ribbon.WikiPageComponent.$D() && this.$1.editable && !this.get_$J_1() && !SP.Ribbon.WebPartComponent.get_$1B();
            default:
                this.$49_1();
                var $v_0 = this.$1E_1[commandId];
                if (!SP.Ribbon.SU.$0($v_0)) {
                    return Array.contains($v_0, this.get_$K());
                }
                break;
        }
        return true;
    },
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        switch (commandId) {
            case 'MSOMenu_Minimize':
            case 'MSOMenu_Restore':
            case 'MSOMenu_Close':
            case 'MSOMenu_Edit':
            case 'MSOMenu_Delete':
                this.$4e_1(commandId, properties, sequence);
                break;
            case 'InsertRelatedWebPartToListView':
                if (!SP.Ribbon.SU.$0(properties)) {
                    SP.Ribbon.RelatedFieldsHelper.addAndConnectRelatedWebPart(properties, this.get_$X(), this.get_$4h_1(), SP.Ribbon.WikiPageComponent.$D());
                }
                break;
            case 'GetRelatedFieldsToListViewMenuXml':
                if (!SP.Ribbon.SU.$0(properties)) {
                    var $v_2 = (properties);
                    $v_2 = this.$4L_1.getRelatedFieldsMenuXml($v_2, this.get_$3Y_1(), this.get_$4g_1());
                }
                break;
            case 'InsertRelatedWebPartToListForm':
                if (!SP.Ribbon.SU.$0(properties)) {
                    SP.Ribbon.RelatedFieldsHelper.addAndConnectRelatedWebPart(properties, 'Main', null, false);
                }
                break;
            case 'GetRelatedFieldsToListFormMenuXml':
                if (!SP.Ribbon.SU.$0(properties)) {
                    var $v_3 = (properties);
                    $v_3 = this.$4K_1.getRelatedFieldsMenuXml($v_3, null, null);
                }
                break;
            case 'approveWebpartPage':
                this.$4P_1(true);
                break;
            case 'rejectWebpartPage':
                this.$4P_1(false);
                break;
            case 'webPartPageDelete':
                this.$5X_1();
                break;
            case 'webPartPageEdit':
                switch (properties['CommandValueId']) {
                    case 'Ribbon.WebPartPage.Edit.Edit.Menu.Actions.Edit':
                        this.handleCommand('webPartPageStartEdit', null, sequence);
                        break;
                    case 'Ribbon.WebPartPage.Edit.Edit.Menu.Actions.Stop':
                        this.handleCommand('webPartPageStopEdit', null, sequence);
                        break;
                    default:
                        break;
                }
                break;
            case 'webPartPageStartEdit':
                if (this.$1.itemId > 0 && this.$1.forceCheckout) {
                    window.EnsureCheckoutAndChangeLayoutModeToEdit(this.$1.listId, this.$1.itemId, false);
                }
                else {
                    window.ChangeLayoutMode(false, false);
                }
                break;
            case 'webPartPageStopEdit':
                window.ChangeLayoutMode(null, true);
                break;
            case 'webPartPageEditQuery':
                var $v_4 = window.document.getElementById('MSOLayout_InDesignMode');
                var $v_5 = window.document.getElementById('MSOSPWebPartManager_DisplayModeName');
                if ($v_4 && $v_4.value !== '1' && (!$v_5 || $v_5.value !== 'Edit')) {
                    properties['SelectedItemId'] = 'Ribbon.WebPartPage.Edit.Edit.Menu.Actions.Edit';
                }
                else {
                    properties['SelectedItemId'] = 'Ribbon.WebPartPage.Edit.Edit.Menu.Actions.Stop';
                }
                break;
            case 'insertWebPart':
            case 'insertExistingList':
                this.$6a_1(commandId);
                break;
            case 'insertTextWebPart':
            case 'insertImageWebPart':
                this.$2f_1(commandId, false, null);
                break;
            case 'CommandContextChanged':
                this.$6G_1(properties);
                break;
            case 'EditMobileSharedPage':
                var $v_0 = SP.Utilities.HttpUtility.urlPathEncode(SP.PageContextInfo.get_webServerRelativeUrl());
                if (!$v_0.endsWith('/')) {
                    $v_0 += '/';
                }
                $v_0 += SP.Utilities.HttpUtility.urlPathEncode('_layouts/mwpsettings.aspx?pageview=shared&url=');
                $v_0 += SP.Utilities.HttpUtility.urlPathEncode(document.URL);
                window.location = $v_0;
                break;
            case 'EditMobilePersonalPage':
                var $v_1 = SP.Utilities.HttpUtility.urlPathEncode(SP.PageContextInfo.get_webServerRelativeUrl());
                if (!$v_1.endsWith('/')) {
                    $v_1 += '/';
                }
                $v_1 += SP.Utilities.HttpUtility.urlPathEncode('_layouts/mwpsettings.aspx?pageview=personal&url=');
                $v_1 += SP.Utilities.HttpUtility.urlPathEncode(document.URL);
                window.location = $v_1;
                break;
            case 'makeHomePage':
                SP.Ribbon.DocLibAspxPageComponent.$3k(commandId, properties, sequence);
                break;
            case 'EditInDesigner':
                EditInSPD(document.URL, false);
                break;
            default:
                break;
        }
        return true;
    },
    
    $3f_1: function() {ULSMg8:;
        return SP.Ribbon.Utility.get_$U() && SP.Ribbon.Utility.get_$U().has(19);
    },
    
    $3e_1: function() {ULSMg8:;
        return SP.Ribbon.Utility.get_$U() && SP.Ribbon.Utility.get_$U().has(30);
    },
    
    $6G_1: function($p0) {
        if ($p0.ChangedByUser && ((this.get_$J_1() && $p0.OldContextCommand === 'Ribbon.WebPartInsert.Tab') || SP.Ribbon.WikiPageComponent.$D() && $p0.OldContextCommand === 'InsertTab')) {
            var $v_0 = window.WPAdder;
            if ($v_0) {
                $v_0.hide();
            }
        }
    },
    
    $6a_1: function($p0) {
        var $v_0 = SP.Ribbon.WebPartComponent.getWebPartAdder();
        if (!$v_0) {
            window.LoadWPAdderOnDemand();
            return;
        }
        var $v_1 = this.$42_1($v_0, $p0);
        if ($v_0) {
            var $v_2 = true;
            if ($v_1) {
                var $v_3 = $v_1;
                $v_0.selectCategoryByTitle($v_3);
                $v_2 = false;
            }
            $v_0._showCategoryColumn($v_2);
            $v_0._setZone(this.get_$X());
            $v_0.show();
        }
    },
    
    $42_1: function($p0, $p1) {
        var $v_0 = null;
        if ($p0) {
            var $v_1 = $p0._ribbonMap;
            if ($v_1) {
                $v_0 = $v_1[$p1];
            }
        }
        return $v_0;
    },
    
    $2f_1: function($p0, $p1, $p2) {
        var $v_0 = SP.Ribbon.WebPartComponent.getWebPartAdder();
        if (!$v_0) {
            window.LoadWPAdderOnDemand();
        }
        $v_0 = SP.Ribbon.WebPartComponent.getWebPartAdder();
        if (!$v_0) {
            return false;
        }
        var $v_1 = false;
        var $v_2 = this.$42_1($v_0, $p0);
        if ($v_0 && $v_2) {
            var $v_3 = $v_2;
            $v_1 = $v_3.length > 0;
            if (!$p1) {
                if ($p2) {
                    var $v_4 = $v_0._getHiddenField('wpVal');
                    if ($v_4) {
                        $v_4.value = $p2;
                    }
                }
                $v_0.addItemToPageByItemIdAndZoneId($v_3, this.get_$X());
            }
        }
        return $v_1;
    },
    
    $5X_1: function() {ULSMg8:;
        var $v_0 = this.$1.recycleBinEnabled;
        var $v_1;
        if ($v_0) {
            $v_1 = SP.Res.webPartPageRecycleConfirmation;
        }
        else {
            $v_1 = SP.Res.webPartPageDeleteConfirmation;
        }
        if (confirm($v_1)) {
            var $v_2 = new SP.ClientContext();
            var $v_3 = $v_2.get_web().get_lists().getById(new SP.Guid(this.$1.listId)).getItemById(this.$1.itemId);
            if ($v_0) {
                $v_3.recycle();
            }
            else {
                $v_3.deleteObject();
            }
            $v_2.executeQueryAsync(this.$3L);
        }
    },
    
    $6B_1: function($p0, $p1) {
        var $v_0 = this.$1.rootFolderUrl;
        if (!$v_0) {
            window.navigate(SP.PageContextInfo.get_webServerRelativeUrl());
        }
        else {
            window.navigate($v_0);
        }
    },
    
    $4P_1: function($p0) {
        var $v_0 = new Sys.StringBuilder();
        SP.Ribbon.WebPartComponent.$2A_1('approve.aspx', $v_0);
        $v_0.append('&List=');
        $v_0.append(SP.PageContextInfo.get_pageListId());
        $v_0.append('&ID=');
        $v_0.append(SP.PageContextInfo.get_pageItemId().toString());
        $v_0.append('&action=');
        if ($p0) {
            $v_0.append('0');
        }
        else {
            $v_0.append('1');
        }
        window.OpenPopUpPage($v_0.toString(), this.$3Q);
    },
    
    $6K_1: function($p0, $p1) {
        if ($p0 === 1) {
            if (SP.Ribbon.DocLibAspxPageComponent.$3_1) {
                SP.Ribbon.DocLibAspxPageComponent.$3_1.$6L();
            }
        }
    },
    
    $r_1: null,
    $i_1: null,
    
    get_$E_1: function() {ULSMg8:;
        if (this.$i_1) {
            return this.$i_1;
        }
        if (this.get_$4_1()) {
            var $v_0 = this.get_$4_1();
            while ($v_0 && $v_0 !== document.body) {
                if (SP.Ribbon.Utility.$F($v_0, 'ms-SPZone') && !SP.Ribbon.SU.$0($v_0.getAttribute('zoneID'))) {
                    this.$i_1 = $v_0;
                    break;
                }
                $v_0 = $v_0.parentNode;
            }
        }
        return this.$i_1;
    },
    set_$E_1: function($p0) {
        this.$i_1 = $p0;
        return $p0;
    },
    
    get_$4_1: function() {ULSMg8:;
        if (!this.$r_1) {
            var $v_0 = $get('_wpSelected');
            if ($v_0) {
                var $v_1 = ($v_0).value;
                if (!SP.Ribbon.SU.$2($v_1)) {
                    this.$r_1 = window.document.getElementById($v_1);
                }
            }
        }
        return this.$r_1;
    },
    set_$4_1: function($p0) {
        this.$i_1 = null;
        this.$r_1 = $p0;
        return $p0;
    },
    
    $5a_1: function($p0) {
        var $v_0 = SP.Ribbon.WebPartComponent.$1Y_1($p0);
        if (SP.Ribbon.SU.$0($v_0)) {
            return false;
        }
        return $v_0.hasNonPromotedContextualGroups;
    },
    
    $4c_1: function($p0, $p1) {
        var $v_0 = window._spWebPartComponents;
        if (this.get_$4_1() !== $p0 && this.get_$4_1()) {
            Sys.UI.DomElement.removeCssClass(this.get_$4_1(), 's4-wpActive');
            if (!SP.Ribbon.Utility.$F(this.get_$4_1(), 's4-wpcell') && !SP.Ribbon.Utility.$F(this.get_$4_1(), 's4-wpcell-plain')) {
                Sys.UI.DomElement.addCssClass(this.get_$4_1(), 's4-wpcell');
            }
            DeselectAllWPItems();
            var $v_2 = 'SelectionCbx' + this.$q_1(this.get_$4_1());
            var $v_3 = $get($v_2);
            if (!SP.Ribbon.SU.$0($v_3)) {
                $v_3.checked = false;
            }
        }
        this.set_$4_1($p0);
        if (!SP.Ribbon.SU.$0($v_0) && $p1) {
            var $v_4 = $v_0[this.get_$K()];
            if (!SP.Ribbon.SU.$0($v_4)) {
                var $v_5 = $v_4['firstTabId'];
                if (!SP.Ribbon.SU.$0($v_5)) {
                    window._spNextRibbonTabId = $v_5;
                }
            }
        }
        if (SP.Ribbon.WikiPageComponent.$D() || this.get_$J_1() || this.$5a_1(this.get_$K())) {
            if (!SP.Ribbon.Utility.$F($p0, 's4-wpActive')) {
                Sys.UI.DomElement.addCssClass($p0, 's4-wpActive');
                if (SP.Ribbon.Utility.$F($p0, 's4-wpcell')) {
                    Sys.UI.DomElement.removeCssClass($p0, 's4-wpcell');
                }
            }
            var $v_6 = 'SelectionCbx' + this.$q_1($p0);
            var $v_7 = $get($v_6);
            if (!SP.Ribbon.SU.$0($v_7)) {
                $v_7.checked = true;
            }
        }
        SP.Ribbon.WebPartComponent.$1W();
        this.$2Z_1($p0);
        SP.Ribbon.WebPartComponent.$3t();
        if (this.get_$J_1()) {
            var $v_8 = GetElementsByName('MSOZone');
            if ($v_8 && $v_8.length > 0) {
                for (var $v_B = 0; $v_B < $v_8.length; $v_B++) {
                    Sys.UI.DomElement.removeCssClass($v_8[$v_B], 's4-wzActive');
                }
                var $v_9 = this.get_$E_1();
                if ($v_9 && !SP.Ribbon.Utility.$F($v_9, 's4-wzActive')) {
                    Sys.UI.DomElement.addCssClass(this.get_$E_1(), 's4-wzActive');
                }
                var $v_A = SP.Ribbon.WebPartComponent.getWebPartAdder();
                if ($v_A) {
                    $v_A._setZone(this.get_$X());
                }
            }
        }
        if (SP.Ribbon.SU.$0($v_0)) {
            return;
        }
        var $v_1 = $v_0[this.get_$K()];
        if (SP.Ribbon.SU.$0($v_1)) {
            return;
        }
        if (!SP.Ribbon.SU.$2($v_1.initPageComponentScript) && !this.get_$4_1()._wpRibbonFetched) {
            this.get_$4_1()._wpRibbonFetched = '1';
            eval($v_1.initPageComponentScript);
        }
        else {
            SP.Ribbon.UtilityInternal.$e();
        }
    },
    
    $2Z_1: function($p0) {
        var $v_0 = window.document.getElementById('_wpSelected');
        if ($v_0) {
            if ($p0) {
                var $v_1 = $p0.id;
                $v_0.value = $v_1;
            }
            else {
                $v_0.value = '';
            }
        }
    },
    
    $4T_1: function($p0) {
        var $v_0 = window.document.getElementById('_wzSelected');
        if ($v_0) {
            if ($p0) {
                var $v_1 = $p0.getAttribute('zoneID');
                if (SP.Ribbon.SU.$0($v_1)) {
                    $v_1 = '';
                }
                $v_0.value = $v_1;
            }
            else {
                $v_0.value = '';
            }
        }
    },
    
    $4d_1: function($p0) {
        var $v_0 = SP.Ribbon.WebPartComponent.getWebPartAdder();
        if (this.get_$E_1() === $p0) {
            if (this.get_$J_1() && !SP.Ribbon.Utility.$F(this.get_$E_1(), 's4-wzActive')) {
                Sys.UI.DomElement.addCssClass(this.get_$E_1(), 's4-wzActive');
            }
            if ($v_0) {
                $v_0._setZone(this.get_$X());
            }
            return;
        }
        if (this.get_$E_1()) {
            Sys.UI.DomElement.removeCssClass(this.get_$E_1(), 's4-wzActive');
        }
        this.set_$E_1($p0);
        if (this.get_$J_1()) {
            if (!SP.Ribbon.Utility.$F($p0, 's4-wzActive')) {
                Sys.UI.DomElement.addCssClass($p0, 's4-wzActive');
            }
        }
        if ($v_0) {
            $v_0._setZone(this.get_$X());
        }
        if (this.get_$4_1()) {
            var $v_1 = this.get_$4_1();
            while ($v_1 && $v_1 !== document.body && $v_1 !== $p0) {
                $v_1 = $v_1.parentNode;
            }
            if ($v_1 !== $p0) {
                Sys.UI.DomElement.removeCssClass(this.get_$4_1(), 's4-wpActive');
                if (!SP.Ribbon.Utility.$F(this.get_$4_1(), 's4-wpcell') && !SP.Ribbon.Utility.$F(this.get_$4_1(), 's4-wpcell-plain')) {
                    Sys.UI.DomElement.addCssClass(this.get_$4_1(), 's4-wpcell');
                }
                DeselectAllWPItems();
                var $v_2 = 'SelectionCbx' + this.$q_1(this.get_$4_1());
                var $v_3 = $get($v_2);
                if (!SP.Ribbon.SU.$0($v_3)) {
                    $v_3.checked = false;
                }
                SP.Ribbon.WebPartComponent.$1W();
                this.$r_1 = null;
                this.$2Z_1(null);
            }
        }
        SP.Ribbon.UtilityInternal.$e();
    },
    
    get_$X: function() {ULSMg8:;
        if (!this.get_$E_1()) {
            return null;
        }
        return this.get_$E_1().attributes.getNamedItem('ZoneID').value;
    },
    
    get_$4f_1: function() {ULSMg8:;
        if (!this.get_$4_1()) {
            return null;
        }
        return window.document.getElementById(this.get_$K() + '_MenuLink');
    },
    
    get_$3Y_1: function() {ULSMg8:;
        if (!this.get_$4_1()) {
            return null;
        }
        var $v_0 = this.get_$4_1().attributes.getNamedItem(this.get_$K() + '_RelatedListId');
        if (!$v_0) {
            return null;
        }
        return $v_0.value;
    },
    
    get_$4g_1: function() {ULSMg8:;
        if (!this.get_$4_1()) {
            return null;
        }
        var $v_0 = this.get_$4_1().attributes.getNamedItem(this.get_$K() + '_RelatedWebId');
        if (!$v_0) {
            return null;
        }
        return $v_0.value;
    },
    
    get_$4h_1: function() {ULSMg8:;
        if (!this.get_$4_1()) {
            return null;
        }
        var $v_0 = this.get_$4_1().attributes.getNamedItem(this.get_$K() + '_WebPartStorageKey');
        if (!$v_0) {
            return null;
        }
        return $v_0.value;
    },
    
    get_$J_1: function() {ULSMg8:;
        var $v_0 = $get('MSOLayout_InDesignMode');
        if ($v_0) {
            var $v_2 = $v_0.attributes.getNamedItem('value');
            if ($v_2 && $v_2.value === '1') {
                return true;
            }
        }
        var $v_1 = $get('MSOSPWebPartManager_DisplayModeName');
        if ($v_1) {
            var $v_3 = $v_1.attributes.getNamedItem('value');
            if ($v_3 && $v_3.value.toUpperCase() === 'DESIGN') {
                return true;
            }
        }
        return false;
    },
    
    get_$1R_1: function() {ULSMg8:;
        var $v_0 = this.get_$4f_1();
        if (!$v_0) {
            return null;
        }
        return $v_0.getAttribute('menuid');
    },
    
    get_$K: function() {ULSMg8:;
        var $v_0 = this.get_$4_1();
        if ($v_0) {
            return this.$q_1(this.get_$4_1());
        }
        return null;
    },
    
    $q_1: function($p0) {
        if (!$p0) {
            return null;
        }
        return $p0.id.substr(12);
    },
    
    $4s_1: function($p0) {
        if (SP.Ribbon.SU.$2(this.get_$1R_1())) {
            return false;
        }
        try {
            window.MSOWebPartPage_OpenMenu(this.get_$1R_1(), null, this.get_$K(), false, false);
            var $v_0 = this.$3v_1($p0);
            return $v_0 && $v_0.style.display !== 'none';
        }
        catch ($$e_1_0) {
            window.OpenWebPartMenu(this.get_$1R_1(), null, this.get_$K(), false, true);
            return false;
        }
    },
    
    $3v_1: function($p0) {
        var $v_0 = this.get_$1R_1();
        if (SP.Ribbon.SU.$2($v_0)) {
            return null;
        }
        var $v_1 = $get($v_0);
        if (!$v_1) {
            return null;
        }
        var $v_2 = $v_1.getElementsByTagName('ie:menuitem');
        for (var $v_3 = 0; $v_3 < $v_2.length; $v_3++) {
            if ($v_2[$v_3].id === $p0) {
                return $v_2[$v_3];
            }
        }
        $v_2 = $v_1.getElementsByTagName('menuitem');
        for (var $v_4 = 0; $v_4 < $v_2.length; $v_4++) {
            if ($v_2[$v_4].id === $p0) {
                return $v_2[$v_4];
            }
        }
        return null;
    },
    
    $4e_1: function($p0, $p1, $p2) {
        var $v_0 = this.$3v_1($p0);
        if (!$v_0) {
            return false;
        }
        var $v_1 = $v_0.getAttribute('onmenuclick');
        if ($v_1 && $v_1.length > 0) {
            if ($v_1.startsWith('javascript:')) {
                $v_1 = $v_1.substr(11);
            }
            eval($v_1);
            switch ($p0) {
                case 'MSOMenu_Minimize':
                case 'MSOMenu_Restore':
                    break;
                default:
                    SP.Ribbon.PageManager.get_instance().get_commandDispatcher().executeCommand(Commands.CommandIds.ApplicationStateChanged, null);
                    break;
            }
            return true;
        }
        return false;
    }
}


SP.Ribbon.FetchListViewWebPartPageComponentWorker = function(webPartId, pageComponentId, list, view) {ULSMg8:;
    this.$3F = Function.createDelegate(this, this.$5e_0);
    this.$3G = Function.createDelegate(this, this.$5f_0);
    this.$4O_0 = webPartId;
    this.$4J_0 = pageComponentId;
    this.$k_0 = list;
    this.$2W_0 = view;
}
SP.Ribbon.FetchListViewWebPartPageComponentWorker.prototype = {
    $m_0: null,
    $4O_0: null,
    $4J_0: null,
    $k_0: null,
    $2W_0: null,
    
    fetch: function() {ULSMg8:;
        this.$m_0 = SP.UI.Notify.addNotification(SP.Utilities.HttpUtility.htmlEncode(SP.Res.genericLoading), false);
        var $v_0 = null;
        var $v_1 = SP.Ribbon.NativeUtility.getCtxForView('{' + this.$2W_0.toUpperCase() + '}');
        if ($v_1) {
            $v_0 = $v_1.HttpRoot;
        }
        if (SP.ScriptUtility.isNullOrUndefined($v_0)) {
            $v_0 = SP.PageContextInfo.get_webServerRelativeUrl();
        }
        var $v_2 = new SP.Utilities.UrlBuilder($v_0);
        $v_2.combinePath('_layouts/wpribbon.aspx');
        $v_2.addKeyValueQueryString('WebPartId', this.$4O_0);
        $v_2.addKeyValueQueryString('PageComponentId', this.$4J_0);
        $v_2.addKeyValueQueryString('List', this.$k_0);
        $v_2.addKeyValueQueryString('View', this.$2W_0);
        var $v_3 = document.URL;
        var $v_4 = GetUrlKeyValue('RootFolder', false, $v_3);
        if (!SP.ScriptUtility.isNullOrEmptyString($v_4)) {
            $v_2.addKeyValueQueryString('RootFolder', $v_4);
        }
        var $v_5 = GetUrlKeyValue('FolderCTID', false, $v_3);
        if (!SP.ScriptUtility.isNullOrEmptyString($v_5)) {
            $v_2.addKeyValueQueryString('FolderCTID', $v_5);
        }
        var $v_6 = GetUrlKeyValue('Source', false, $v_3);
        if (!SP.ScriptUtility.isNullOrEmptyString($v_6)) {
            $v_2.addKeyValueQueryString('Source', $v_6);
        }
        var $v_7 = $v_3.indexOf('?');
        if ($v_7 > 0) {
            $v_3 = $v_3.substr(0, $v_7);
        }
        $v_7 = $v_3.indexOf('#');
        if ($v_7 > 0) {
            $v_3 = $v_3.substr(0, $v_7);
        }
        $v_7 = $v_3.indexOf('//');
        if ($v_7 > 0) {
            $v_3 = $v_3.substr($v_7 + 2);
            $v_7 = $v_3.indexOf('/');
            if ($v_7 < 0) {
                throw Error.invalidOperation();
            }
            $v_3 = $v_3.substr($v_7);
        }
        $v_3 = unescape($v_3);
        $v_2.addKeyValueQueryString('FileUrl', $v_3);
        SP.PageRequest.doGet($v_2.get_url(), 'text/html', this.$3G, this.$3F);
    },
    
    $5f_0: function($p0, $p1) {
        SP.UI.Notify.removeNotification(this.$m_0);
        var $v_0 = $p1.get_executor().get_responseData();
        var $v_1 = $v_0.indexOf('function _initTRA');
        if ($v_1 < 0) {
            return;
        }
        var $v_2 = $v_0.indexOf('</script>', $v_1);
        if ($v_2 < 0) {
            return;
        }
        var $v_3 = $v_0.substring($v_1, $v_2);
        SP.Ribbon.WebPartComponent.$3r($v_3);
        $v_1 = $v_2 + 9;
        while (($v_1 = $v_0.indexOf('<script ', $v_1)) > 0) {
            $v_1 = $v_0.indexOf('>', $v_1);
            if ($v_1 < 0) {
                break;
            }
            $v_1++;
            $v_2 = $v_0.indexOf('</script>', $v_1);
            if ($v_2 < 0) {
                break;
            }
            $v_3 = $v_0.substring($v_1, $v_2);
            SP.Ribbon.WebPartComponent.$3r($v_3);
            $v_1 = $v_2 + 9;
        }
        SP.Ribbon.WebPartComponent.$1W();
        SP.Ribbon.WebPartComponent.$3t();
        SP.Ribbon.UtilityInternal.$e();
    },
    
    $5e_0: function($p0, $p1) {
        SP.UI.Notify.removeNotification(this.$m_0);
    }
}


SP.Ribbon.BlogPostWebPartPageComponent = function(id, data) {ULSMg8:;
    SP.Ribbon.BlogPostWebPartPageComponent.initializeBase(this, [ id, data ]);
    this.$b_5 = data.ViewId;
}
SP.Ribbon.BlogPostWebPartPageComponent.prototype = {
    $b_5: null,
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        var $v_0 = this.get_ctx();
        var $v_1 = this.getCountOfSelectedItems();
        if (commandId === 'NewListItem') {
            this.executeClickScript(this.getDefaultNewMenuItemScript());
            return true;
        }
        return SP.Ribbon.BlogPostWebPartPageComponent.callBaseMethod(this, 'handleCommand', [ commandId, properties, sequence ]);
    },
    
    get_alwaysEnabledCommands: function() {ULSMg8:;
        this._alwaysEnabledCommands = SP.Ribbon.BlogPostWebPartPageComponent.callBaseMethod(this, 'get_alwaysEnabledCommands');
        this._alwaysEnabledCommands['Ribbon.Blog.Posts'] = true;
        this._alwaysEnabledCommands['Ribbon.Blog.Posts.NewGroup'] = true;
        this._alwaysEnabledCommands['Ribbon.Blog.Posts.PostsGroup'] = true;
        this._alwaysEnabledCommands['Ribbon.Blog.Posts.StateGroup'] = true;
        this._alwaysEnabledCommands['NewListItem'] = true;
        this._alwaysEnabledCommands['Ribbon.Blog.Comments'] = true;
        this._alwaysEnabledCommands['Ribbon.Blog.Comments.CommentsGroup'] = true;
        this._alwaysEnabledCommands['Ribbon.Blog.Comments.StateGroup'] = true;
        this._alwaysEnabledCommands['Ribbon.Blog.Categories'] = true;
        this._alwaysEnabledCommands['Ribbon.Blog.Categories.NewGroup'] = true;
        this._alwaysEnabledCommands['Ribbon.Blog.Categories.CategoriesGroup'] = true;
        this._alwaysEnabledCommands['Ribbon.Blog.Categories.StateGroup'] = true;
        this._alwaysEnabledCommands['Ribbon.Blog.Lists'] = true;
        this._alwaysEnabledCommands['Ribbon.Blog.Lists.Settings.SettingsGroup'] = true;
        this._alwaysEnabledCommands['Ribbon.Blog.Lists.Actions.ActionsGroup'] = true;
        return this._alwaysEnabledCommands;
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        return SP.Ribbon.BlogPostWebPartPageComponent.callBaseMethod(this, 'canHandleCommand', [ commandId ]);
    },
    
    getGlobalCommands: function() {ULSMg8:;
        var $v_0 = SP.Ribbon.BlogPostWebPartPageComponent.callBaseMethod(this, 'getGlobalCommands');
        return $v_0;
    },
    
    getFocusedCommands: function() {ULSMg8:;
        return SP.Ribbon.BlogPostWebPartPageComponent.callBaseMethod(this, 'getFocusedCommands');
    }
}


SP.Ribbon.PageManager = function() {ULSMg8:;
    SP.Ribbon.PageManager.initializeBase(this);
}
SP.Ribbon.PageManager.get_instance = function() {ULSMg8:;
    if (SP.ScriptUtility.isNullOrUndefined(SP.Ribbon.PageManager.$12_2)) {
        SP.Ribbon.PageManager.$12_2 = new SP.Ribbon.PageManager();
        SP.Ribbon.PageManager.$12_2.initializeInternal();
    }
    return SP.Ribbon.PageManager.$12_2;
}
SP.Ribbon.PageManager.prototype = {
    
    executeRootCommand: function(commandId, properties, commandInfo, root) {ULSMg8:;
        var $v_0;
        if (!SP.ScriptUtility.isNullOrUndefined(commandInfo) && commandId !== 'RibbonEvent' && (commandId !== 'CommandContextChanged' || (!SP.ScriptUtility.isNullOrUndefined(properties) && properties['ChangedByUser']))) {
            var $v_1 = new Date();
            $v_0 = SP.Ribbon.PageManager.callBaseMethod(this, 'executeRootCommand', [ commandId, properties, commandInfo, root ]);
            var $v_2 = new Date();
            var $v_3 = $v_1.getTime();
            var $v_4 = $v_2.getTime() - $v_3;
            $v_3 = $v_3 & 4294967295;
            $v_4 = $v_4 & 4294967295;
            if ($v_3 < 0) {
                $v_3 += 4294967296;
            }
            if ($v_4 < 0) {
                $v_4 += 4294967296;
            }
            SP.Ribbon.NativeUtility.addCommandStreamToWSA(commandInfo, $v_3, $v_4);
        }
        else {
            $v_0 = SP.Ribbon.PageManager.callBaseMethod(this, 'executeRootCommand', [ commandId, properties, commandInfo, root ]);
        }
        return $v_0;
    }
}


SP.Ribbon.PageStateActionButton = function() {
}
SP.Ribbon.PageStateActionButton.updateState = function() {ULSMg8:;
    var $v_0 = SP.Ribbon.PageManager.get_instance();
    var $v_1 = window._spPageStateActionControlId;
    if ($v_0 && !SP.Ribbon.SU.$2($v_1)) {
        var $v_2 = $get($v_1);
        if ($v_2) {
            var $v_3 = null;
            var $v_4 = $v_2.getElementsByTagName('span')[0];
            if ($v_4) {
                $v_3 = $v_4.getElementsByTagName('img')[0];
            }
            if ($v_0.get_commandDispatcher().isCommandEnabled('PageStateGroupEdit')) {
                $v_2.setAttribute('_action', 'edit');
                $v_2.title = $v_2.getAttribute('_edittooltip').toString();
                if ($v_3) {
                    $v_3.style.left = '-' + $v_2.getAttribute('_editoffsetx') + 'px';
                    $v_3.style.top = '-' + $v_2.getAttribute('_editoffsety') + 'px';
                    $v_3.alt = $v_2.getAttribute('_edittooltip').toString();
                }
            }
            else if ($v_0.get_commandDispatcher().isCommandEnabled('PageStateGroupSaveAndStop')) {
                $v_2.setAttribute('_action', 'save');
                $v_2.title = $v_2.getAttribute('_savetooltip').toString();
                if ($v_3) {
                    $v_3.style.left = '-' + $v_2.getAttribute('_saveoffsetx') + 'px';
                    $v_3.style.top = '-' + $v_2.getAttribute('_saveoffsety') + 'px';
                    $v_3.alt = $v_2.getAttribute('_savetooltip').toString();
                }
            }
        }
    }
}
SP.Ribbon.PageStateActionButton.sendCommand = function() {ULSMg8:;
    var $v_0 = SP.Ribbon.PageManager.get_instance();
    if ($v_0) {
        if ($v_0.get_commandDispatcher().isCommandEnabled('PageStateGroupEdit')) {
            $v_0.get_commandDispatcher().executeCommand('PageStateGroupEdit', null);
        }
        else if ($v_0.get_commandDispatcher().isCommandEnabled('PageStateGroupSaveAndStop')) {
            $v_0.get_commandDispatcher().executeCommand('PageStateGroupSaveAndStop', null);
        }
    }
}


SP.Ribbon.RelatedFieldsFetcher = function(activeWebPartRelatedListId, activeWebPartRelatedWebId) {ULSMg8:;
    this.$3D = Function.createDelegate(this, this.fetchFailure);
    this.$3E = Function.createDelegate(this, this.fetchSuccess);
    this.$2M_0 = activeWebPartRelatedListId;
    this.$2N_0 = activeWebPartRelatedWebId;
}
SP.Ribbon.RelatedFieldsFetcher.prototype = {
    $2V_0: null,
    $k_0: null,
    $1D_0: null,
    $O_0: null,
    $2M_0: null,
    $2N_0: null,
    
    getSelectedListValue: function() {ULSMg8:;
        var $v_0 = null;
        if (this.$O_0.getIsListForm()) {
            var $v_1 = $get('currentListForRelationshipsRibbon');
            if (!SP.Ribbon.SU.$0($v_1)) {
                $v_0 = $v_1.value;
            }
        }
        else {
            if (!SP.Ribbon.SU.$0(this.$2M_0)) {
                $v_0 = this.$2M_0;
            }
        }
        return $v_0;
    },
    
    fetchRelatedFieldsBegin: function($p0) {
        if (this.$O_0) {
        }
        this.$O_0 = $p0;
        var $v_0 = this.getSelectedListValue();
        if (SP.Ribbon.SU.$2($v_0)) {
            this.$O_0.fetchRelatedFieldsFailure(SP.Utilities.HttpUtility.htmlEncode(SP.Res.relationships_UnknownError));
            return true;
        }
        if (!this.$1D_0) {
            this.$1D_0 = new SP.ClientContext();
        }
        var $v_1 = null;
        if (!this.$O_0.getIsListForm() && !SP.Ribbon.SU.$0(this.$2N_0)) {
            $v_1 = this.$1D_0.get_site().openWebById(new SP.Guid(this.$2N_0));
        }
        else {
            $v_1 = this.$1D_0.get_web();
        }
        var $v_2 = new SP.Guid($v_0);
        this.$k_0 = $v_1.get_lists().getById($v_2);
        this.$k_0.retrieve(SP.ListPropertyNames.title, SP.ListPropertyNames.baseType);
        this.$2V_0 = this.$k_0.getRelatedFieldsExtendedData();
        var $v_3 = this.$2V_0.retrieveItems();
        $v_3.retrieve([ SP.RelatedFieldExtendedDataPropertyNames.webId, SP.RelatedFieldExtendedDataPropertyNames.listId, SP.RelatedFieldExtendedDataPropertyNames.fieldId, SP.RelatedFieldExtendedDataPropertyNames.resolvedListTitle, SP.RelatedFieldExtendedDataPropertyNames.toolTipDescription, SP.RelatedFieldExtendedDataPropertyNames.listImageUrl ]);
        this.$1D_0.executeQueryAsync(this.$3E, this.$3D);
        return false;
    },
    
    fetchSuccess: function($p0, $p1) {
        if (!SP.Ribbon.SU.$0(this.$O_0)) {
            var $v_0 = (this.$k_0.get_baseType() === 1);
            this.$O_0.fetchRelatedFieldsSuccess(this.$k_0.get_title(), $v_0, this.$2V_0);
        }
        this.$O_0 = null;
    },
    
    fetchFailure: function($p0, $p1) {
        if ($p1 && !SP.Ribbon.SU.$0($p1.get_message())) {
        }
        if (!SP.Ribbon.SU.$0(this.$O_0)) {
            this.$O_0.fetchRelatedFieldsFailure(SP.Utilities.HttpUtility.htmlEncode(SP.Res.relationships_RelatedFieldsFetchFailed));
        }
        this.$O_0 = null;
    }
}


SP.Ribbon.RelatedFieldsHelper = function(bIsListForm) {ULSMg8:;
    this.$s_0 = -1;
    this.$4C_0 = bIsListForm;
    if (bIsListForm) {
        this.$T_0 = 'ListForm';
    }
    else {
        this.$T_0 = 'ListView';
    }
}
SP.Ribbon.RelatedFieldsHelper.addAndConnectRelatedWebPart = function(properties, activeZoneId, activeStorageKeyId, bInWikiEditMode) {ULSMg8:;
    var $v_0 = properties.CommandValueId;
    var $v_1 = $v_0.split(';');
    if ($v_1.length >= 2) {
        var $v_2 = $v_1[0];
        var $v_3 = $v_1[1];
        var $v_4 = $v_1[2];
        var $v_5 = activeZoneId;
        var $v_6 = activeStorageKeyId;
        var $v_7 = bInWikiEditMode && (!$v_5);
        var $v_8 = String.format('RelatedAdder_addItemAndConnect(\'{0}\', \'{1}\', \'{2}\', \'{3}\', \'{4}\', {5})', $v_5, $v_2, $v_3, $v_4, $v_6, $v_7);
        eval($v_8);
    }
}
SP.Ribbon.RelatedFieldsHelper.prototype = {
    $a_0: null,
    $1G_0: false,
    $4D_0: null,
    $m_0: null,
    $T_0: null,
    $4C_0: false,
    
    getIsListForm: function() {ULSMg8:;
        return this.$4C_0;
    },
    
    $41_0: function() {ULSMg8:;
        return '\r\n                <Menu Id=\"Ribbon.Page.InsertRelatedDataTo' + this.$T_0 + '.RelatedWebPart.Menu\">\r\n                  <MenuSection Id=\"Ribbon.Page.InsertRelatedDataTo' + this.$T_0 + '.RelatedWebPart.Menu.MS\" Scrollable=\"false\" DisplayMode=\"Menu16\">\r\n                    <Controls Id=\"Ribbon.Page.InsertRelatedDataTo' + this.$T_0 + '.RelatedWebPart.Menu.MS.Controls\">\r\n                  ';
    },
    
    $4S_0: '\r\n                    </Controls>\r\n                  </MenuSection>\r\n                </Menu>\r\n        ',
    
    fetchRelatedFieldsSuccess: function(listTitle, bIsDocumentLibrary, relatedFields) {ULSMg8:;
        if (!SP.Ribbon.SU.$0(this.$a_0)) {
            return;
        }
        this.$1G_0 = false;
        var $v_0 = new Sys.StringBuilder();
        $v_0.append(this.$41_0());
        if (!relatedFields || !relatedFields.get_count()) {
            var $v_1 = null;
            if (bIsDocumentLibrary) {
                $v_1 = SP.Res.relationships_DocLibHasNoRelatedLists;
            }
            else {
                $v_1 = SP.Res.relationships_ListHasNoRelatedLists;
            }
            var $v_2 = String.format($v_1, listTitle);
            $v_0.append('\r\n                    <Button \r\n                        Id=\"Ribbon.Page.InsertRelatedDataTo' + this.$T_0 + '.RelatedWebPart.Menu.MS.InsertRelatedPartMessage\"\r\n                        Image16by16=\"/_layouts/images/edit.gif\"\r\n                        Image32by32=\"/_layouts/images/placeholder32x32.png\"\r\n                        LabelText=\"' + SP.Utilities.HttpUtility.htmlEncode($v_2) + '\"\r\n                    />');
        }
        else {
            var $v_3 = relatedFields.get_count();
            for (var $v_4 = 0; $v_4 < $v_3; ++$v_4) {
                var $v_5 = relatedFields.itemAt($v_4);
                var $v_6 = $v_5.get_webId().toString('B');
                var $v_7 = $v_5.get_listId().toString('B');
                var $v_8 = $v_5.get_fieldId().toString('B');
                var $v_9 = $v_6 + ';' + $v_7 + ';' + $v_8;
                $v_0.append('\r\n                        <Button \r\n                            Id=\"Ribbon.Page.InsertRelatedDataTo' + this.$T_0 + '.RelatedWebPart.Menu.MS.InsertRelatedPart' + $v_4 + '\"\r\n                            CommandValueId=\"' + SP.Utilities.HttpUtility.htmlEncode($v_9) + '\"\r\n                            Command=\"InsertRelatedWebPartTo' + this.$T_0 + '\"\r\n                            Image16by16=\"' + $v_5.get_listImageUrl() + '\"\r\n                            Image32by32=\"/_layouts/images/placeholder32x32.png\"\r\n                            LabelText=\"' + SP.Utilities.HttpUtility.htmlEncode($v_5.get_resolvedListTitle()) + '\" \r\n                            ToolTipTitle=\"' + SP.Utilities.HttpUtility.htmlEncode($v_5.get_resolvedListTitle()) + '\"\r\n                            ToolTipDescription=\"' + SP.Utilities.HttpUtility.htmlEncode($v_5.get_toolTipDescription()) + '\"\r\n                        />');
            }
        }
        $v_0.append(this.$4S_0);
        this.$a_0 = $v_0.toString();
    },
    
    fetchRelatedFieldsFailure: function(localizedErrorMessage) {ULSMg8:;
        if (!SP.Ribbon.SU.$0(this.$a_0)) {
            return;
        }
        this.$1G_0 = false;
        var $v_0 = new Sys.StringBuilder();
        $v_0.append(this.$41_0());
        $v_0.append('\r\n                <Button \r\n                    Id=\"Ribbon.Page.InsertRelatedDataTo' + this.$T_0 + '.RelatedWebPart.Menu.MS.InsertRelatedPartMessage\"\r\n                    Image16by16=\"/_layouts/images/edit.gif\"\r\n                    Image32by32=\"/_layouts/images/placeholder32x32.png\"\r\n                    LabelText=\"' + SP.Utilities.HttpUtility.htmlEncode(localizedErrorMessage) + '\"\r\n                />');
        $v_0.append(this.$4S_0);
        this.$a_0 = $v_0.toString();
    },
    
    getRelatedFieldsMenuXml: function(props, activeWebPartListId, activeWebPartWebId) {ULSMg8:;
        if (this.$s_0 >= 200) {
            this.fetchRelatedFieldsFailure(SP.Utilities.HttpUtility.htmlEncode(SP.Res.relationships_RelatedFetchFieldsTookTooLong));
        }
        if (SP.Ribbon.SU.$0(this.$a_0)) {
            this.$s_0 = this.$s_0 + 1;
            if (!this.$1G_0) {
                this.$1G_0 = true;
                this.$4D_0 = new SP.Ribbon.RelatedFieldsFetcher(activeWebPartListId, activeWebPartWebId);
                var $v_0 = this.$4D_0.fetchRelatedFieldsBegin(this);
                if ($v_0) {
                    props.PopulationXML = this.$a_0;
                    this.$4V_0();
                    return props;
                }
            }
            if (SP.Ribbon.SU.$0(this.$m_0) && this.$s_0 > 5) {
                this.$m_0 = SP.UI.Notify.addNotification(SP.Utilities.HttpUtility.htmlEncode(SP.Res.genericLoading), true);
            }
            props.PollAgainInterval = 100;
            return props;
        }
        else {
            props.PopulationXML = this.$a_0;
            this.$4V_0();
            if (!SP.Ribbon.SU.$0(this.$m_0)) {
                SP.UI.Notify.removeNotification(this.$m_0);
            }
            return props;
        }
    },
    
    $4V_0: function() {ULSMg8:;
        this.$a_0 = null;
        this.$s_0 = 0;
        this.$1G_0 = false;
    }
}


SP.Ribbon.UsageReportPageComponent = function() {ULSMg8:;
    SP.Ribbon.UsageReportPageComponent.initializeBase(this);
}
SP.Ribbon.UsageReportPageComponent.initialize = function() {ULSMg8:;
    var $v_0 = SP.Ribbon.PageManager.get_instance();
    if ($v_0) {
        $v_0.addPageComponent(SP.Ribbon.UsageReportPageComponent.$1u_1);
    }
}
SP.Ribbon.UsageReportPageComponent.prototype = {
    
    init: function() {
    },
    
    getFocusedCommands: function() {ULSMg8:;
        return [];
    },
    
    getGlobalCommands: function() {ULSMg8:;
        return getGlobalCommands();
    },
    
    isFocusable: function() {ULSMg8:;
        return true;
    },
    
    receiveFocus: function() {ULSMg8:;
        return true;
    },
    
    yieldFocus: function() {ULSMg8:;
        return true;
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        return commandEnabled(commandId);
    },
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        return handleCommand(commandId, properties, sequence);
    }
}


SP.Ribbon.GroupBoardWebPartPageComponent = function(id, data) {ULSMg8:;
    this.$5_5 = {};
    SP.Ribbon.GroupBoardWebPartPageComponent.initializeBase(this, [ id, data ]);
    this.$6W_5();
}
SP.Ribbon.GroupBoardWebPartPageComponent.prototype = {
    
    $6W_5: function() {ULSMg8:;
        var $v_0;
        $v_0 = Function.createDelegate(this, function($p1_0, $p1_1, $p1_2) {
            return this.$4a_5('CirculationConfirm.aspx');
        });
        this.$5_5['CirculationConfirm'] = $v_0;
        this.$5_5['CirculationDisconfirm'] = $v_0;
        $v_0 = Function.createDelegate(this, function($p1_0, $p1_1, $p1_2) {
            return this.$4a_5('CalltrackMark.aspx');
        });
        this.$5_5['CallTrackResolve'] = $v_0;
        this.$5_5['CallTrackUnresolve'] = $v_0;
    },
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        if (this.$5_5[commandId]) {
            var $v_0 = this.$5_5[commandId];
            return $v_0(commandId, properties, sequence);
        }
        return SP.Ribbon.GroupBoardWebPartPageComponent.callBaseMethod(this, 'handleCommand', [ commandId, properties, sequence ]);
    },
    
    $4a_5: function($p0) {
        if (this.getCountOfSelectedItems() !== 1) {
            return false;
        }
        var $v_0 = this.get_ctx();
        var $v_1 = this.$18_5($v_0);
        var $v_2 = this.$3z_5($v_0, $v_1);
        var $v_3 = window.location;
        var $v_4 = $v_3.pathname;
        var $v_5 = $v_3.search;
        if (!SP.ScriptUtility.isNullOrEmptyString($v_5)) {
            $v_4 += $v_5;
        }
        $v_4 = SP.Utilities.HttpUtility.urlKeyValueEncode($v_4);
        var $v_6 = new Sys.StringBuilder();
        $v_6.append('SubmitFormPost(\"');
        $v_6.append(SP.Utilities.Utility.getLayoutsPageUrl($p0));
        $v_6.append('?List=');
        $v_6.append($v_0.listName);
        $v_6.append('&Cmd=');
        $v_6.append($v_2);
        $v_6.append('&ID=');
        $v_6.append($v_1);
        $v_6.append('&Source=');
        $v_6.append($v_4);
        $v_6.append('\")');
        this.executeClickScript($v_6.toString());
        return true;
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        if (this.$5_5[commandId]) {
            var $v_0 = this.get_ctx();
            if (this.getCountOfSelectedItems() === 1) {
                var $v_1 = this.$3z_5($v_0, this.$18_5($v_0));
                if (!SP.Ribbon.SU.$0($v_1)) {
                    switch (commandId) {
                        case 'CirculationConfirm':
                            return $v_1 === 'Confirm';
                        case 'CirculationDisconfirm':
                            return $v_1 === 'Disconfirm';
                        case 'CallTrackResolve':
                            return $v_1 === 'Resolve';
                        case 'CallTrackUnresolve':
                            return $v_1 === 'Unresolve';
                    }
                }
            }
        }
        return SP.Ribbon.GroupBoardWebPartPageComponent.callBaseMethod(this, 'canHandleCommand', [ commandId ]);
    },
    
    $18_5: function($p0) {
        var $v_0 = GetSelectedItemsDict($p0);
        if (!SP.Ribbon.SU.$0($v_0)) {
            var $$dict_2_0 = $v_0;
            for (var $$key_2_1 in $$dict_2_0) {
                var $v_1 = { key: $$key_2_1, value: $$dict_2_0[$$key_2_1] };
                var $v_2 = $v_1.key.split(',');
                return $v_2[1];
            }
        }
        return null;
    },
    
    $3z_5: function($p0, $p1) {
        var $v_0 = 'Action#' + $p0.listName + '#' + $p1;
        var $v_1 = $get($v_0);
        if (SP.Ribbon.SU.$0($v_1)) {
            return null;
        }
        else {
            return $v_1.value;
        }
    },
    
    getGlobalCommands: function() {ULSMg8:;
        var $v_0 = SP.Ribbon.GroupBoardWebPartPageComponent.callBaseMethod(this, 'getGlobalCommands');
        Array.add($v_0, 'CirculationConfirm');
        Array.add($v_0, 'CirculationDisconfirm');
        Array.add($v_0, 'CallTrackResolve');
        Array.add($v_0, 'CallTrackUnresolve');
        return $v_0;
    },
    
    getFocusedCommands: function() {ULSMg8:;
        return SP.Ribbon.GroupBoardWebPartPageComponent.callBaseMethod(this, 'getFocusedCommands');
    },
    
    addAlwaysEnabledCommands: function() {ULSMg8:;
        SP.Ribbon.GroupBoardWebPartPageComponent.callBaseMethod(this, 'addAlwaysEnabledCommands');
        var $v_0 = this.get_alwaysEnabledCommands();
        $v_0['TimecardTab'] = true;
        $v_0['TimecardActions'] = true;
        $v_0['TimecardManage'] = true;
        $v_0['TimecardSettings'] = true;
        $v_0['CirculationMenuOpen'] = true;
        $v_0['CallTrackMenuOpen'] = true;
    }
}


SP.Ribbon.CalendarPageComponentData = function() {ULSMg8:;
    SP.Ribbon.CalendarPageComponentData.initializeBase(this);
}
SP.Ribbon.CalendarPageComponentData.prototype = {
    CurrentUserInfo: null,
    EnablePeopleSelector: false,
    EnableResourceSelector: false
}


SP.Ribbon.CalendarListPageComponent = function(id, data) {ULSMg8:;
    this.$3V = Function.createDelegate(this, this.$6T_5);
    this.$2r = Function.createDelegate(this, this.$52_5);
    this.$2w = Function.createDelegate(this, this.$2D_5);
    this.$3J = Function.createDelegate(this, this.$5u_5);
    this.$3K = Function.createDelegate(this, this.$5v_5);
    this.$3I = Function.createDelegate(this, this.$5t_5);
    this.$3N = Function.createDelegate(this, this.$6E_5);
    this.$3M = Function.createDelegate(this, this.$6D_5);
    this.$3P = Function.createDelegate(this, this.$6J_5);
    this.$3T = Function.createDelegate(this, this.$6R_5);
    this.$3C = Function.createDelegate(this, this.$5d_5);
    this.$3U = Function.createDelegate(this, this.$6S_5);
    this.$2g = Function.createDelegate(this, this.$4i_5);
    this.$3B = Function.createDelegate(this, this.$5W_5);
    this.$3H = Function.createDelegate(this, this.$5h_5);
    this.$5g_5 = '/_layouts/' + SP.Res.lcid + '/images/formatmap32x32.png';
    this.$8_5 = {};
    this.$5_5 = {};
    SP.Ribbon.CalendarListPageComponent.initializeBase(this, [ id, data ]);
    var $v_0 = this.get_ctx();
    if (!$v_0) {
        return;
    }
    this.$1A_5 = $v_0.ctxId;
    this.$I_5 = data.CurrentUserInfo;
    this.$o_5 = data.EnablePeopleSelector;
    this.$h_5 = data.EnableResourceSelector;
    this.$N_5 = ('106' === this.get_ctx().listTemplate);
    this.$5z_5();
    this.$5y_5();
}
SP.Ribbon.CalendarListPageComponent.prototype = {
    $2B_5: null,
    $1A_5: null,
    $2c_5: null,
    $u_5: null,
    $I_5: null,
    $h_5: false,
    $o_5: false,
    $N_5: false,
    
    get_$Y_5: function() {ULSMg8:;
        if (!this.$2B_5) {
            this.$2B_5 = SP.UI.ApplicationPages.CalendarInstanceRepository.lookupInstance(this.$1A_5);
        }
        return this.$2B_5;
    },
    
    $5y_5: function() {ULSMg8:;
        if (!this.get_ctx()) {
            return;
        }
        var $v_0;
        $v_0 = this.$3H;
        this.$5_5['Subscribe'] = $v_0;
        this.$5_5['ViewProperties'] = $v_0;
        this.$5_5['EditProperties'] = $v_0;
        this.$5_5['ManagePermissions'] = $v_0;
        this.$5_5['ViewVersions'] = $v_0;
        this.$5_5['Moderate'] = $v_0;
        this.$5_5['ViewWorkflows'] = $v_0;
        this.$5_5['AttachFile'] = $v_0;
        this.$5_5['Delete'] = this.$3B;
        this.$5_5['CalendarAddCalendar'] = this.$2g;
        $v_0 = this.$3U;
        this.$5_5['CalendarPeopleSelect'] = $v_0;
        this.$5_5['CalendarResourceSelect'] = $v_0;
        $v_0 = this.$3C;
        this.$5_5['CalendarExpand'] = $v_0;
        this.$5_5['CalendarCollapse'] = $v_0;
        $v_0 = this.$3T;
        this.$5_5['CalendarScopeDay'] = $v_0;
        this.$5_5['CalendarScopeWeek'] = $v_0;
        this.$5_5['CalendarScopeMonth'] = $v_0;
        this.$5_5['CalendarScopeWeekGroup'] = $v_0;
        this.$5_5['CalendarScopeDayGroup'] = $v_0;
        $v_0 = this.$3P;
        this.$5_5['QueryCalendarScopeWeekGroup'] = $v_0;
        this.$5_5['QueryCalendarScopeDayGroup'] = $v_0;
        this.$5_5['QueryCalendarScopeDay'] = $v_0;
        this.$5_5['QueryCalendarScopeWeek'] = $v_0;
        this.$5_5['QueryCalendarScopeMonth'] = $v_0;
        if (this.$N_5) {
            $v_0 = this.$3M;
        }
        else {
            $v_0 = this.$3N;
        }
        this.$5_5['NewListItem'] = $v_0;
        this.$5_5['NewDefaultListItem'] = $v_0;
        this.$5_5['PopulateNewDocumentMenu'] = Function.createDelegate(this, function($p1_0, $p1_1, $p1_2) {
            $p1_1.PopulationJSON = this.getNewMenuXml('NewDocument', 'Ribbon.Document.All.NewDocument');
            return true;
        });
        this.$5_5['NewDocument'] = Function.createDelegate(this, function($p1_0, $p1_1, $p1_2) {
            var $v_1 = $p1_1['CommandValueId'];
            this.executeClickScript($v_1);
            return true;
        });
        this.$5_5['NewDefaultDocument'] = Function.createDelegate(this, function($p1_0, $p1_1, $p1_2) {
            this.executeClickScript(this.getDefaultNewMenuItemScript());
            return true;
        });
        if (this.$N_5) {
            this.$5_5['ConnectToClient'] = this.$3I;
        }
        this.$5_5['PopulatePeopleMenu'] = this.$3K;
        this.$5_5['CalendarPeopleMenuSelect'] = this.$3J;
    },
    
    $4i_5: function($p0, $p1, $p2) {
        var $v_0 = this.get_ctx();
        var $v_1 = String.format('STSNavigate(\'{0}/_layouts/aggregationsettings.aspx?List={1}&View={2}&Source={3}\')', $v_0.HttpRoot, $v_0.listName, $v_0.view, GetSource());
        SP.Ribbon.NativeUtility.executeECBCommand($v_1, $v_0);
        return true;
    },
    
    $5u_5: function($p0, $p1, $p2) {
        var $v_0 = $p1['CommandValueId'];
        for (var $v_1 = 0; $v_1 < this.$I_5.length; $v_1++) {
            if (this.$I_5[$v_1]['id'] === $v_0) {
                var $v_2 = SP.UI.ApplicationPages.CalendarSelector.instance().getSelector(3, this.$1A_5);
                if (!SP.Ribbon.SU.$0($v_2)) {
                    var $v_3 = new SP.UI.ApplicationPages.ResolveEntity();
                    $v_3.entityType = SP.UI.ApplicationPages.ResolveEntity.typE_USER;
                    $v_3.displayName = this.$I_5[$v_1]['displayName'];
                    $v_3.id = this.$I_5[$v_1]['id'];
                    if ($v_1) {
                        $v_3.needResolve = true;
                        $v_3.isGroup = true;
                    }
                    else {
                        $v_3.email = this.$I_5[$v_1]['email'];
                        $v_3.accountName = this.$I_5[$v_1]['accountName'];
                    }
                    $v_2.setEntity($v_3);
                }
                break;
            }
        }
        return true;
    },
    
    $5v_5: function($p0, $p1, $p2) {
        var $v_0 = new Sys.StringBuilder();
        $v_0.append('<Menu Id=\'');
        $v_0.append(SP.Utilities.HttpUtility.htmlEncode('Ribbon.Calendar.Selector.People'));
        $v_0.append('.Menu\'>');
        $v_0.append('<MenuSection Id=\'');
        $v_0.append('Ribbon.Calendar.Selector.People');
        $v_0.append('.Menu.ContentTypes\'>');
        $v_0.append('<Controls Id=\'');
        $v_0.append(SP.Utilities.HttpUtility.htmlEncode('Ribbon.Calendar.Selector.People'));
        $v_0.append('.Menu.ContentTypes.Controls\'>');
        this.$3b_5($v_0, 'Ribbon.Calendar.Selector.People.Menu.Entities.AddPerson', 'CalendarPeopleSelect', 'CalendarPeopleSelect', 'CalendarPeopleSelect', SP.Res.cui_AddPerson);
        if (!SP.Ribbon.SU.$0(this.$I_5)) {
            for (var $v_1 = 0; $v_1 < this.$I_5.length; $v_1++) {
                this.$3b_5($v_0, 'Ribbon.Calendar.Selector.People.Menu.Entities.' + $v_1.toString(), 'CalendarPeopleMenuSelect', this.$I_5[$v_1]['id'], this.$I_5[$v_1]['id'], this.$I_5[$v_1]['displayName']);
            }
        }
        $v_0.append('</Controls>');
        $v_0.append('</MenuSection>');
        $v_0.append('</Menu>');
        $p1.PopulationXML = $v_0.toString();
        return true;
    },
    
    $3b_5: function($p0, $p1, $p2, $p3, $p4, $p5) {
        $p0.append('<Button Id=\'');
        $p0.append(SP.Utilities.HttpUtility.htmlEncode($p1));
        $p0.append('\' Command=\'');
        $p0.append(SP.Utilities.HttpUtility.htmlEncode($p2));
        $p0.append('\' MenuItemId=\'');
        $p0.append(SP.Utilities.HttpUtility.htmlEncode($p3));
        $p0.append('\' CommandValueId=\'');
        $p0.append(SP.Utilities.HttpUtility.htmlEncode($p4));
        $p0.append('\' CommandType=\'OptionSelection\' LabelText=\'');
        $p0.append(SP.Utilities.HttpUtility.htmlEncode($p5));
        $p0.append('\'/>');
    },
    
    $5t_5: function($p0, $p1, $p2) {
        if (SP.Ribbon.SU.$0(this.$u_5)) {
            var $v_0 = this._controlData[$p0];
            this.executeClickScript($v_0.ClickScript);
        }
        else {
            window.self.offlineBtnUser = this.$u_5.id;
            var $v_1 = this._controlData[$p0];
            if (!SP.Ribbon.SU.$0($v_1)) {
                var $v_2 = $v_1.ClickScript.split('\',\'');
                var $v_3 = new Sys.StringBuilder($v_2[0]);
                for (var $v_4 = 1; $v_4 < $v_2.length; $v_4++) {
                    $v_3.append('\',\'');
                    if ($v_4 === 4) {
                        $v_3.append(SP.Utilities.HttpUtility.ecmaScriptStringLiteralEncode(EEDecodeSpecialChars(this.$u_5.displayName)));
                    }
                    else {
                        $v_3.append($v_2[$v_4]);
                    }
                }
                this.executeClickScript($v_3.toString());
            }
        }
        return true;
    },
    
    $5h_5: function($p0, $p1, $p2) {
        var $v_0 = this.get_ctx();
        var $v_1 = this.$18_5($v_0);
        if (!$v_1 || !this.$2D_5($p0)) {
            return true;
        }
        var $v_2 = $v_1;
        if ($v_1.indexOf('.0.') !== -1 || $v_1.indexOf('.1.') !== -1) {
            $v_2 = $v_1.substr(0, $v_1.indexOf('.'));
        }
        var $v_3 = null;
        switch ($p0) {
            case 'AttachFile':
                AttachFile($v_0);
                break;
            case 'Subscribe':
                this.$1r_5(String.format('{0}/_layouts/SubNew.aspx?List={1}&ID={2}&Source={3}', $v_0['HttpRoot'], SP.Utilities.HttpUtility.urlKeyValueEncode($v_0['listName']), SP.Utilities.HttpUtility.urlKeyValueEncode($v_2), GetSource()), false);
                break;
            case 'ViewProperties':
                this.$1r_5(String.format('{0}&ID={1}', $v_0['displayFormUrl'], SP.Utilities.HttpUtility.urlKeyValueEncode($v_1)), true);
                break;
            case 'EditProperties':
                this.$1r_5(String.format('{0}&ID={1}', $v_0['editFormUrl'], SP.Utilities.HttpUtility.urlKeyValueEncode($v_1)), true);
                break;
            case 'ManagePermissions':
                $v_3 = String.format('NavigateToManagePermsPage(\'{0}\',\'{1}\',\'{2}\')', $v_0['HttpRoot'], SP.Utilities.HttpUtility.urlKeyValueEncode($v_0['listName']), SP.Utilities.HttpUtility.urlKeyValueEncode($v_2));
                break;
            case 'ViewVersions':
                $v_3 = String.format('NavigateToVersionsAspxV4(event,\'{0}\',\'List={1}&ID={2}\')', $v_0['HttpRoot'], SP.Utilities.HttpUtility.urlKeyValueEncode($v_0['listName']), SP.Utilities.HttpUtility.urlKeyValueEncode($v_2));
                break;
            case 'Moderate':
                $v_3 = String.format('NavigateToApproveRejectAspx(event,\'{0}/_layouts/approve.aspx?List={1}&ID={2}&Source={3}\')', $v_0['HttpRoot'], SP.Utilities.HttpUtility.urlKeyValueEncode($v_0['listName']), SP.Utilities.HttpUtility.urlKeyValueEncode($v_2), GetSource());
                break;
            case 'ViewWorkflows':
                $v_3 = String.format('STSNavigate(\'{0}/_layouts/Workflow.aspx?List={1}&ID={2}&Source={3}\')', $v_0['HttpRoot'], SP.Utilities.HttpUtility.urlKeyValueEncode($v_0['listName']), SP.Utilities.HttpUtility.urlKeyValueEncode($v_2), GetSource());
                break;
        }
        if ($v_3) {
            SP.Ribbon.NativeUtility.executeECBCommand($v_3, $v_0);
        }
        return true;
    },
    
    $1r_5: function($p0, $p1) {
        var $v_0 = SP.UI.$create_DialogOptions();
        $v_0.url = $p0;
        if ($p1 && this.get_$Y_5()) {
            $v_0.dialogReturnValueCallback = Function.createDelegate(this, function($p1_0, $p1_1) {
                if ($p1_0 === 1) {
                    this.get_$Y_5().refreshItems();
                }
            });
        }
        SP.UI.ModalDialog.showModalDialog($v_0);
    },
    
    $5W_5: function($p0, $p1, $p2) {
        var $v_0 = this.get_$Y_5();
        var $v_1 = this.get_ctx();
        var $v_2 = this.$18_5($v_1);
        if (!$v_2 || !this.$2D_5($p0) || !$v_0) {
            return true;
        }
        $v_0.deleteItem($v_2);
        return true;
    },
    
    $6D_5: function($p0, $p1, $p2) {
        var $v_0 = this.get_$Y_5();
        if ($v_0) {
            $v_0.newItemDialog(this.$3w_5($p1['CommandValueId']));
        }
        return true;
    },
    
    $6E_5: function($p0, $p1, $p2) {
        var $v_0 = this.get_ctx();
        var $v_1 = new SP.Utilities.UrlBuilder($v_0['newFormUrl']);
        var $v_2 = this.$3w_5($p1['CommandValueId']);
        if (!SP.Ribbon.SU.$2($v_2)) {
            $v_1.addKeyValueQueryString('ContentTypeId', $v_2);
        }
        this.$1r_5($v_1.get_url(), true);
        return true;
    },
    
    $3w_5: function($p0) {
        var $v_0 = null;
        if (!SP.Ribbon.SU.$0($p0)) {
            var $v_1 = $p0.toUpperCase();
            var $v_2 = $v_1.lastIndexOf('CONTENTTYPEID=');
            var $v_3 = $v_1.lastIndexOf('\')');
            if ($v_2 !== -1 && $v_3 !== -1 && $v_2 + 14 < $v_3) {
                $v_0 = $p0.substring($v_2 + 14, $v_3);
            }
        }
        return $v_0;
    },
    
    $6R_5: function($p0, $p1, $p2) {
        var $v_0 = this.$3m_5($p0);
        var $v_1 = this.get_$Y_5();
        if ($v_1) {
            $v_1.moveToView($v_0);
        }
        return true;
    },
    
    $5d_5: function($p0, $p1, $p2) {
        var $v_0 = this.get_$Y_5();
        if (!$v_0) {
            return true;
        }
        if ($p0 === 'CalendarExpand') {
            $v_0.expandAll();
        }
        else if ($p0 === 'CalendarCollapse') {
            $v_0.collapseAll();
        }
        return true;
    },
    
    $6S_5: function($p0, $p1, $p2) {
        var $v_0 = this.get_$Y_5();
        if (!$v_0) {
            return true;
        }
        var $v_1;
        if ($p0 === 'CalendarPeopleSelect') {
            $v_1 = 2;
        }
        else {
            $v_1 = 1;
        }
        var $v_2 = $v_0.getActiveScope();
        var $v_3 = ($v_2 === 5 || $v_2 === 2);
        var $v_4 = new Sys.StringBuilder();
        $v_4.append('__spPickerDialogFunc(');
        $v_4.append(($v_1).toString());
        $v_4.append(',\'');
        $v_4.append(this.$1A_5);
        $v_4.append('\',');
        $v_4.append(($v_3) ? 'true' : 'false');
        $v_4.append(');');
        this.executeClickScript($v_4.toString());
        return true;
    },
    
    $6J_5: function($p0, $p1, $p2) {
        var $v_0 = this.$3m_5($p0);
        $p1['On'] = (this.$3u_5() === $v_0);
        return true;
    },
    
    $3m_5: function($p0) {
        switch ($p0) {
            case 'QueryCalendarScopeDayGroup':
            case 'CalendarScopeDayGroup':
                return 5;
            case 'QueryCalendarScopeWeekGroup':
            case 'CalendarScopeWeekGroup':
                return 2;
            case 'QueryCalendarScopeDay':
            case 'CalendarScopeDay':
                return 3;
            case 'QueryCalendarScopeWeek':
            case 'CalendarScopeWeek':
                return 4;
            case 'QueryCalendarScopeMonth':
            case 'CalendarScopeMonth':
                return 1;
        }
        return 0;
    },
    
    $2D_5: function($p0) {
        var $v_0 = this.get_ctx();
        var $v_1 = this.$18_5($v_0);
        if (!$v_1) {
            return false;
        }
        var $v_2 = $v_1.indexOf('.0.') !== -1;
        var $v_3 = $v_1.indexOf('.1.') !== -1;
        var $v_4 = GetSelectedItemsDict($v_0);
        var $$dict_1_0 = $v_4;
        for (var $$key_1_1 in $$dict_1_0) {
            var $v_5 = { key: $$key_1_1, value: $$dict_1_0[$$key_1_1] };
            var $v_6 = $v_5.value;
            var $v_7 = this.$5U_5($v_6['Permissions']);
            switch ($p0) {
                case 'Subscribe':
                    if (!$v_2) {
                        return $v_7.has(40);
                    }
                    break;
                case 'ViewProperties':
                    return $v_7.has(1) && $v_7.has(13);
                case 'Delete':
                    return $v_7.has(4) && this.$N_5;
                case 'EditProperties':
                    return $v_7.has(3) && this.$N_5;
                case 'AttachFile':
                    return $v_7.has(3) && this.$N_5 && !$v_2 && !$v_3;
                case 'ManagePermissions':
                    if (!$v_2 && !$v_3) {
                        return $v_7.has(63) && this.$N_5;
                    }
                    break;
                case 'ViewVersions':
                    return ($v_0['verEnabled'] === 1 && $v_7.has(7) && this.$N_5);
                case 'Moderate':
                    return ($v_0['isModerated'] && $v_7.has(3) && $v_7.has(5) && $v_7.has(18) && $v_7.has(13) && this.$N_5);
                case 'ViewWorkflows':
                    return ($v_0['WorkflowsAssociated'] && $v_7.has(3) && this.$N_5);
            }
            return false;
        }
        return false;
    },
    
    $5U_5: function($p0) {
        var $v_0 = new SP.BasePermissions();
        if (SP.Ribbon.SU.$2($p0)) {
            return $v_0;
        }
        var $v_1 = 0;
        var $v_2 = 0;
        var $v_3 = $p0.length;
        if ($v_3 < 8) {
            $v_2 = parseInt($p0, 16);
        }
        else {
            $v_2 = parseInt($p0.substr($v_3 - 8), 16);
            $v_1 = parseInt($p0.substr(0, $v_3 - 8), 16);
        }
        for (var $v_4 = 1; $v_2 > 0; $v_4++, $v_2 >>>= 1) {
            if (($v_2 & 1) === 1) {
                $v_0.set($v_4);
            }
        }
        for (var $v_5 = 33; $v_1 > 0; $v_5++, $v_1 >>>= 1) {
            if (($v_1 & 1) === 1) {
                $v_0.set($v_5);
            }
        }
        return $v_0;
    },
    
    $5z_5: function() {ULSMg8:;
        if (!this.get_ctx()) {
            return;
        }
        var $v_0 = this.$2w;
        var $v_1 = Function.createDelegate(this, function($p1_0) {
            var $v_7 = this.$3u_5();
            return $v_7 === 1 || $v_7 === 2;
        });
        var $v_2 = Function.createDelegate(this, function($p1_0) {
            return false;
        });
        var $v_3 = Function.createDelegate(this, function($p1_0) {
            return true;
        });
        this.$8_5['CalendarAddCalendar'] = (this.$N_5) ? $v_3 : $v_2;
        this.$8_5['CalendarScopeDayGroup'] = (this.$o_5 | this.$h_5) ? $v_3 : $v_2;
        this.$8_5['CalendarScopeWeekGroup'] = (this.$o_5 | this.$h_5) ? $v_3 : $v_2;
        this.$8_5['QueryCalendarScopeDayGroup'] = (this.$o_5 | this.$h_5) ? $v_3 : $v_2;
        this.$8_5['QueryCalendarScopeWeekGroup'] = (this.$o_5 | this.$h_5) ? $v_3 : $v_2;
        this.$8_5['Subscribe'] = $v_0;
        this.$8_5['ViewProperties'] = $v_0;
        this.$8_5['Delete'] = $v_0;
        this.$8_5['EditProperties'] = $v_0;
        this.$8_5['ManagePermissions'] = $v_0;
        this.$8_5['ViewVersions'] = $v_0;
        this.$8_5['Moderate'] = $v_0;
        this.$8_5['ViewWorkflows'] = $v_0;
        this.$8_5['AttachFile'] = $v_0;
        this.$8_5['UploadDocumentMenuOpen'] = this.$2r;
        var $v_4 = Function.createDelegate(this, function($p1_0) {
            return !SP.Ribbon.SU.$0(this.get_newMenuData()) && this.get_newMenuData().length > 0;
        });
        this.$8_5['NewDefaultDocument'] = $v_4;
        this.$8_5['PopulateNewDocumentMenu'] = $v_4;
        this.$8_5['NewDocument'] = $v_4;
        this.$8_5['NewDocumentMenuOpen'] = $v_4;
        this.$8_5['CalendarExpand'] = $v_1;
        this.$8_5['CalendarCollapse'] = $v_1;
        var $v_5 = (SP.Ribbon.SU.$1C(this.$I_5)) ? $v_2 : $v_3;
        this.$8_5['CalendarPeopleSelect'] = $v_5;
        this.$8_5['PopulatePeopleMenu'] = $v_5;
        this.$8_5['CalendarPeopleMenuOpen'] = $v_5;
        this.$8_5['CalendarPeopleMenuSelect'] = $v_5;
        this.$8_5['CalendarResourceSelect'] = (this.$h_5) ? $v_3 : $v_2;
        if (this.$o_5 | this.$h_5) {
            this.$8_5['ConnectToClient'] = this.$3V;
            var $v_6 = SP.UI.ApplicationPages.CalendarSelector.instance();
            $v_6.addHandler(this.$1A_5, true, true, Function.createDelegate(this, function($p1_0, $p1_1) {
                this.$2c_5 = $p1_1.get_entities();
                SP.Ribbon.UtilityInternal.$e();
            }));
        }
    },
    
    $6T_5: function($p0) {
        var $v_0 = [];
        var $v_1 = this.$2c_5.length;
        for (var $v_2 = 0; $v_2 < $v_1; $v_2++) {
            var $v_3 = this.$2c_5[$v_2];
            if ($v_3.entityType !== SP.UI.ApplicationPages.ResolveEntity.typE_USER) {
                return false;
            }
            if ($v_3.isGroup) {
                if ($v_3.needResolve) {
                    return false;
                }
                for (var $v_4 = 0; $v_4 < $v_3.members.length; $v_4++) {
                    if ($v_3.members[$v_4]) {
                        Array.add($v_0, $v_3.members[$v_4]);
                    }
                }
            }
            else {
                Array.add($v_0, $v_3);
            }
        }
        if ($v_0.length === 1) {
            this.$u_5 = $v_0[0];
            if (this.$u_5.id) {
                return true;
            }
        }
        this.$u_5 = null;
        return false;
    },
    
    $52_5: function($p0) {
        return SP.Ribbon.CalendarListPageComponent.callBaseMethod(this, 'canHandleCommand', [ 'UploadDocument' ]);
    },
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        var $v_0 = this.$5_5[commandId];
        if (!SP.Ribbon.SU.$0($v_0) && $v_0(commandId, properties, sequence)) {
            return true;
        }
        return SP.Ribbon.CalendarListPageComponent.callBaseMethod(this, 'handleCommand', [ commandId, properties, sequence ]);
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        var $v_0 = this.$8_5[commandId];
        if (!SP.Ribbon.SU.$0($v_0)) {
            return $v_0(commandId);
        }
        return SP.Ribbon.CalendarListPageComponent.callBaseMethod(this, 'canHandleCommand', [ commandId ]);
    },
    
    getGlobalCommands: function() {ULSMg8:;
        var $v_0 = SP.Ribbon.CalendarListPageComponent.callBaseMethod(this, 'getGlobalCommands');
        Array.add($v_0, 'CalendarPeopleSelect');
        Array.add($v_0, 'CalendarResourceSelect');
        Array.add($v_0, 'CalendarPeopleMenuOpen');
        Array.add($v_0, 'PopulatePeopleMenu');
        Array.add($v_0, 'CalendarPeopleMenuSelect');
        Array.add($v_0, 'CalendarExpand');
        Array.add($v_0, 'CalendarCollapse');
        Array.add($v_0, 'CalendarAddCalendar');
        Array.add($v_0, 'CalendarScopeDayGroup');
        Array.add($v_0, 'CalendarScopeWeekGroup');
        Array.add($v_0, 'QueryCalendarScopeDayGroup');
        Array.add($v_0, 'QueryCalendarScopeWeekGroup');
        Array.add($v_0, 'NewDocument');
        Array.add($v_0, 'PopulateNewDocumentMenu');
        Array.add($v_0, 'NewDefaultDocument');
        Array.add($v_0, 'UploadDocumentMenuOpen');
        Array.add($v_0, 'NewDocumentMenuOpen');
        return $v_0;
    },
    
    getFocusedCommands: function() {ULSMg8:;
        return SP.Ribbon.CalendarListPageComponent.callBaseMethod(this, 'getFocusedCommands');
    },
    
    addAlwaysEnabledCommands: function() {ULSMg8:;
        SP.Ribbon.CalendarListPageComponent.callBaseMethod(this, 'addAlwaysEnabledCommands');
        var $v_0 = this.get_alwaysEnabledCommands();
        $v_0['CalendarTab'] = true;
        $v_0['DocumentTab'] = true;
        $v_0['LibraryTab'] = true;
        $v_0['DocumentNewGroup'] = true;
        $v_0['DocumentManageGroup'] = true;
        $v_0['CalendarSelectorGroup'] = true;
        $v_0['CalendarScopeGroup'] = true;
        $v_0['CalendarExpanderGroup'] = true;
        $v_0['CalendarScopeDay'] = true;
        $v_0['CalendarScopeWeek'] = true;
        $v_0['CalendarScopeMonth'] = true;
        $v_0['QueryCalendarScopeDay'] = true;
        $v_0['QueryCalendarScopeWeek'] = true;
        $v_0['QueryCalendarScopeMonth'] = true;
    },
    
    $3u_5: function() {ULSMg8:;
        var $v_0 = this.get_$Y_5();
        if ($v_0) {
            return $v_0.getActiveScope();
        }
        else {
            return 0;
        }
    },
    
    $18_5: function($p0) {
        var $v_0 = GetSelectedItemsDict($p0);
        if (!SP.Ribbon.SU.$0($v_0)) {
            var $$dict_2_0 = $v_0;
            for (var $$key_2_1 in $$dict_2_0) {
                var $v_1 = { key: $$key_2_1, value: $$dict_2_0[$$key_2_1] };
                var $v_2 = $v_1.key.split(',');
                return $v_2[1];
            }
        }
        return null;
    }
}


SP.Ribbon.HelpCommandNames = function() {
}


SP.Ribbon.HelpPageComponent = function() {ULSMg8:;
    SP.Ribbon.HelpPageComponent.initializeBase(this);
}
SP.Ribbon.HelpPageComponent.get_instance = function() {ULSMg8:;
    if (!SP.Ribbon.HelpPageComponent.$3_1) {
        SP.Ribbon.HelpPageComponent.$3_1 = new SP.Ribbon.HelpPageComponent();
    }
    return SP.Ribbon.HelpPageComponent.$3_1;
}
SP.Ribbon.HelpPageComponent.registerWithPageManager = function() {ULSMg8:;
    SP.Ribbon.PageManager.get_instance().addPageComponent(SP.Ribbon.HelpPageComponent.get_instance());
}
SP.Ribbon.HelpPageComponent.unregisterWithPageManager = function() {ULSMg8:;
    if (SP.Ribbon.HelpPageComponent.$3_1) {
        SP.Ribbon.PageManager.get_instance().removePageComponent(SP.Ribbon.HelpPageComponent.get_instance());
    }
}
SP.Ribbon.HelpPageComponent.prototype = {
    $4E_1: null,
    $1j_1: null,
    
    init: function() {ULSMg8:;
        this.$4E_1 = [ 'RequestContextualHelp' ];
        this.$1j_1 = [ 'RequestContextualHelp' ];
    },
    
    getFocusedCommands: function() {ULSMg8:;
        return this.$4E_1;
    },
    
    getGlobalCommands: function() {ULSMg8:;
        return this.$1j_1;
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        if (commandId === 'RequestContextualHelp') {
            return true;
        }
        else {
            return false;
        }
    },
    
    getId: function() {ULSMg8:;
        return 'HelpComponent';
    },
    
    $1k_1: false,
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        if (SP.Ribbon.SU.$2(commandId) || SP.Ribbon.SU.$0(properties) || SP.Ribbon.SU.$0(sequence)) {
            return false;
        }
        if (commandId === 'RequestContextualHelp') {
            this.$1k_1 = true;
            HelpWindowKey(properties['HelpKeyword']);
            this.$1k_1 = false;
        }
        else {
            return false;
        }
        return true;
    },
    
    isFocusable: function() {ULSMg8:;
        return true;
    },
    
    receiveFocus: function() {ULSMg8:;
        return true;
    },
    
    yieldFocus: function() {ULSMg8:;
        return true;
    }
}


SP.Ribbon.SaveConflictHandler = function() {
}
SP.Ribbon.SaveConflictHandler.$14 = function() {ULSMg8:;
    if (!SP.Ribbon.SU.$2(SP.Ribbon.SaveConflictHandler.$w_0)) {
        SP.UI.Status.removeStatus(SP.Ribbon.SaveConflictHandler.$w_0);
        SP.Ribbon.SaveConflictHandler.$w_0 = null;
    }
    if (!SP.Ribbon.SU.$2(SP.Ribbon.SaveConflictHandler.$x_0)) {
        SP.UI.Status.removeStatus(SP.Ribbon.SaveConflictHandler.$x_0);
        SP.Ribbon.SaveConflictHandler.$x_0 = null;
    }
    if (!SP.Ribbon.SU.$2(SP.Ribbon.SaveConflictHandler.$y_0)) {
        SP.UI.Status.removeStatus(SP.Ribbon.SaveConflictHandler.$y_0);
        SP.Ribbon.SaveConflictHandler.$y_0 = null;
    }
}
SP.Ribbon.SaveConflictHandler.$6Y = function($p0) {
    SP.Ribbon.SaveConflictHandler.$y_0 = SP.UI.Status.addStatus(SP.Utilities.HttpUtility.htmlEncode(SP.Res.saveConflictStatusBarTitle), $p0, true);
    SP.UI.Status.setStatusPriColor(SP.Ribbon.SaveConflictHandler.$y_0, 'yellow');
}
SP.Ribbon.SaveConflictHandler.showSaveConflictDialog = function(lastModifiedUserId, continueStatusHtml, mergeChangesUrl, mergeChangesStatusHtml, discardScript, overwriteScript) {ULSMg8:;
    var $v_0 = SP.Utilities.Utility.getLayoutsPageUrl('saveconflict.aspx');
    var $v_1 = new SP.Utilities.UrlBuilder($v_0);
    $v_1.addKeyValueQueryString('UserId', lastModifiedUserId.toString());
    var $v_2 = SP.UI.$create_DialogOptions();
    $v_2.args = mergeChangesUrl;
    $v_2.url = $v_1.get_url();
    $v_2.showClose = false;
    $v_2.dialogReturnValueCallback = function($p1_0, $p1_1) {
        if ($p1_0 === 1) {
            var $v_4 = $p1_1;
            switch ($v_4) {
                case 'continue':
                    SP.Ribbon.SaveConflictHandler.$14();
                    SP.Ribbon.SaveConflictHandler.$w_0 = SP.UI.Status.addStatus(SP.Utilities.HttpUtility.htmlEncode(SP.Res.saveConflictStatusBarTitle), continueStatusHtml, true);
                    SP.UI.Status.setStatusPriColor(SP.Ribbon.SaveConflictHandler.$w_0, 'red');
                    break;
                case 'merge':
                    SP.Ribbon.SaveConflictHandler.$14();
                    SP.Ribbon.SaveConflictHandler.$x_0 = SP.UI.Status.addStatus(SP.Utilities.HttpUtility.htmlEncode(SP.Res.saveConflictStatusBarTitle), mergeChangesStatusHtml, true);
                    SP.UI.Status.setStatusPriColor(SP.Ribbon.SaveConflictHandler.$x_0, 'red');
                    break;
                case 'discard':
                    SP.Ribbon.SaveConflictHandler.$14();
                    if (!SP.Ribbon.SU.$2(discardScript)) {
                        window.setTimeout(function() {ULSMg8:;
                            eval(discardScript);
                        }, 0);
                    }
                    break;
                case 'overwrite':
                    SP.Ribbon.SaveConflictHandler.$14();
                    if (!SP.Ribbon.SU.$2(overwriteScript)) {
                        window.setTimeout(function() {ULSMg8:;
                            eval(overwriteScript);
                        }, 0);
                    }
                    break;
            }
        }
    };
    var $v_3 = SP.UI.ModalDialog.showModalDialog($v_2);
    return $v_3;
}


SP.Ribbon.TrackTabPageComponent = function() {ULSMg8:;
    SP.Ribbon.TrackTabPageComponent.initializeBase(this);
}
SP.Ribbon.TrackTabPageComponent.registerWithPageManager = function() {ULSMg8:;
    if (!SP.Ribbon.TrackTabPageComponent.$3_1) {
        SP.Ribbon.TrackTabPageComponent.$3_1 = new SP.Ribbon.TrackTabPageComponent();
        SP.Ribbon.PageManager.get_instance().addPageComponent(SP.Ribbon.TrackTabPageComponent.$3_1);
    }
}
SP.Ribbon.TrackTabPageComponent.prototype = {
    
    getGlobalCommands: function() {ULSMg8:;
        if (!SP.Ribbon.TrackTabPageComponent.$1t_1) {
            SP.Ribbon.TrackTabPageComponent.$1t_1 = [ 'EmailPageUrl', 'EmailPageLink', 'ShareGroup', 'ManageAlerts' ];
        }
        return SP.Ribbon.TrackTabPageComponent.$1t_1;
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        if (commandId === 'ManageAlerts') {
            if (window._spPageContextInfo && window._spPageContextInfo.userId) {
                return true;
            }
            else {
                return false;
            }
        }
        return true;
    },
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        var $v_0 = false;
        switch (commandId) {
            case 'EmailPageUrl':
                SP.Ribbon.EMailLink.openMailerWithUrl(document.URL);
                $v_0 = true;
                break;
            case 'EmailPageLink':
                window.navigateMailToLink(document.URL);
                $v_0 = true;
                break;
            case 'ManageAlerts':
                SP.Utilities.HttpUtility.navigateTo(SP.Utilities.Utility.getLayoutsPageUrl('MySubs.aspx'));
                $v_0 = true;
                break;
        }
        return $v_0;
    }
}


SP.Ribbon.UserInterfacePageComponent = function() {ULSMg8:;
    SP.Ribbon.UserInterfacePageComponent.initializeBase(this);
    var $v_0 = window.g_spribbon;
    this.$68_1 = $v_0.minimizedHeight;
    this.$66_1 = $v_0.maximizedHeight;
}
SP.Ribbon.UserInterfacePageComponent.get_instance = function() {ULSMg8:;
    if (!SP.Ribbon.UserInterfacePageComponent.$3_1) {
        SP.Ribbon.UserInterfacePageComponent.$3_1 = new SP.Ribbon.UserInterfacePageComponent();
    }
    return SP.Ribbon.UserInterfacePageComponent.$3_1;
}
SP.Ribbon.UserInterfacePageComponent.registerWithPageManager = function() {ULSMg8:;
    SP.Ribbon.PageManager.get_instance().addPageComponent(SP.Ribbon.UserInterfacePageComponent.get_instance());
}
SP.Ribbon.UserInterfacePageComponent.unregisterWithPageManager = function() {ULSMg8:;
    if (SP.Ribbon.UserInterfacePageComponent.$3_1) {
        SP.Ribbon.PageManager.get_instance().removePageComponent(SP.Ribbon.UserInterfacePageComponent.get_instance());
    }
}
SP.Ribbon.UserInterfacePageComponent.prototype = {
    $1j_1: null,
    $68_1: null,
    $66_1: null,
    $2Q_1: null,
    
    init: function() {ULSMg8:;
        this.$1j_1 = [ 'RibbonEvent', 'CommandContextChanged' ];
    },
    
    getGlobalCommands: function() {ULSMg8:;
        return this.$1j_1;
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        if (commandId === 'RibbonEvent' || commandId === 'CommandContextChanged') {
            return true;
        }
        else {
            return false;
        }
    },
    
    getId: function() {ULSMg8:;
        return 'UIComponent';
    },
    
    $1k_1: false,
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        var $v_0 = false;
        this.$1k_1 = true;
        if (SP.Ribbon.SU.$2(commandId) || SP.Ribbon.SU.$0(properties) || SP.Ribbon.SU.$0(sequence)) {
            return false;
        }
        if (commandId === 'RibbonEvent') {
            MenuHtc_hide();
            var $v_1 = properties;
            $v_0 = this.$46_1($v_1.Minimized || this.$2Q_1 === 'Ribbon.Read');
        }
        else if (commandId === 'CommandContextChanged') {
            var $v_2 = properties;
            if ((!SP.Ribbon.SU.$0($v_2.ChangedByUser)) && $v_2.ChangedByUser) {
                MenuHtc_hide();
            }
            if ((!SP.Ribbon.SU.$0($v_2.NewContextId) && $v_2.NewContextId === 'Ribbon.Read') || this.$2Q_1 === 'Ribbon.Read') {
                $v_0 = this.$46_1($v_2.NewContextId === 'Ribbon.Read');
            }
            this.$2Q_1 = $v_2.NewContextId;
        }
        this.$1k_1 = false;
        return $v_0;
    },
    
    isFocusable: function() {ULSMg8:;
        return false;
    },
    
    $46_1: function($p0) {
        OnRibbonMinimizedChanged($p0);
        return true;
    }
}


SP.Ribbon.EMailLink = function() {
}
SP.Ribbon.EMailLink.get_$3c_0 = function() {ULSMg8:;
    if (!SP.Ribbon.SU.$2(SP.Ribbon.EMailLink.$1e_0)) {
        return SP.Ribbon.EMailLink.$1e_0;
    }
    return SP.Res.emailDefaultBody;
}
SP.Ribbon.EMailLink.openMailerWithUrl = function(URL) {ULSMg8:;
    SP.Ribbon.EMailLink.$1h_0 = new SP.ClientContext();
    SP.Ribbon.EMailLink.$1p_0 = SP.Utilities.Utility.createEmailBodyForInvitation(SP.Ribbon.EMailLink.$1h_0, URL);
    SP.Ribbon.EMailLink.$1h_0.executeQueryAsync(SP.Ribbon.EMailLink.onSucceededEmailBody, SP.Ribbon.EMailLink.onFailed);
}
SP.Ribbon.EMailLink.onSucceededEmailBody = function(sender, args) {ULSMg8:;
    if (SP.Ribbon.EMailLink.$1p_0) {
        SP.Ribbon.EMailLink.$1e_0 = SP.Ribbon.EMailLink.$1p_0.get_value();
    }
    window.navigateMailToLinkWithMessage('', SP.Ribbon.EMailLink.get_$3c_0());
}
SP.Ribbon.EMailLink.onFailed = function(sender, args) {ULSMg8:;
    window.navigateMailToLinkWithMessage('', SP.Ribbon.EMailLink.get_$3c_0());
}


Type.registerNamespace('SP.Ribbon.PageState');

SP.Ribbon.PageState.PageStateStrings = function() {
}


SP.Ribbon.PageState.PageStateCommands = function() {
}


SP.Ribbon.PageState.PageStateHandler = function() {ULSMg8:;
    SP.Ribbon.PageState.PageStateHandler.initializeBase(this);
}
SP.Ribbon.PageState.PageStateHandler.getButtonId = function(pageStateCommand) {ULSMg8:;
    if (!SP.Ribbon.PageState.PageStateHandler.$c_1) {
        SP.Ribbon.PageState.PageStateHandler.$c_1 = {};
        SP.Ribbon.PageState.PageStateHandler.$c_1['PageStateGroupPublish'] = 'Publish';
        SP.Ribbon.PageState.PageStateHandler.$c_1['PageStateGroupUnpublish'] = 'Unpublish';
        SP.Ribbon.PageState.PageStateHandler.$c_1['PageStateGroupSubmitForApproval'] = 'SubmitForApproval';
        SP.Ribbon.PageState.PageStateHandler.$c_1['PageStateGroupCancelApproval'] = 'CancelApproval';
    }
    return SP.Ribbon.PageState.PageStateHandler.$c_1[pageStateCommand];
}
SP.Ribbon.PageState.PageStateHandler.setHandleSaveMenu = function(handleSave) {ULSMg8:;
    SP.Ribbon.PageState.PageStateHandler.$1Z_1 = handleSave;
}
SP.Ribbon.PageState.PageStateHandler.$5n_1 = function($p0) {
    var $v_0 = null;
    var $v_1 = false;
    if (!SP.Ribbon.SU.$0(SP.Ribbon.PageState.PageStateHandler.$13_1[$p0])) {
        var $v_2 = SP.Ribbon.PageState.PageStateHandler.$13_1[$p0];
        for (var $v_3 = 0; $v_3 < $v_2.length && !$v_1; $v_3++) {
            if (eval(SP.Ribbon.PageState.ImportedNativeData.EnabledHandlers[$v_2[$v_3]])) {
                if (!$v_0) {
                    $v_0 = $v_2[$v_3];
                }
                else {
                    $v_0 = null;
                    $v_1 = true;
                }
            }
        }
    }
    return $v_0;
}
SP.Ribbon.PageState.PageStateHandler.$5o_1 = function($p0) {
    var $v_0 = $p0[CUI.Controls.DropDownCommandProperties.SelectedItemId];
    var $v_1 = $v_0.lastIndexOf('.');
    if ($v_1 < 0) {
        return null;
    }
    return $v_0.substring(0, $v_1 + 1);
}
SP.Ribbon.PageState.PageStateHandler.$6X_1 = function() {ULSMg8:;
    var $v_0 = false;
    if (((SP.Ribbon.PageState.ImportedNativeData.PageState['DocLibMinorVersionsEnabled']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsMinorVersion'])) || (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsRejected']) || (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsPendingApproval']) || (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsScheduled']) || (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToCurrentUser']) || (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser'])) {
        $v_0 = true;
    }
    return $v_0;
}
SP.Ribbon.PageState.PageStateHandler.showPageStatus = function() {ULSMg8:;
    if (SP.Ribbon.PageState.PageStateHandler.$6X_1()) {
        var $v_0 = '';
        for (var $v_1 = 0; $v_1 < SP.Ribbon.PageState.ImportedNativeData.StatusBody.length; $v_1++) {
            if (!SP.Ribbon.SU.$2(SP.Ribbon.PageState.ImportedNativeData.StatusTitle[$v_1]) && !SP.Ribbon.SU.$2(SP.Ribbon.PageState.ImportedNativeData.StatusBody[$v_1])) {
                if (!SP.Ribbon.SU.$2(SP.Ribbon.PageState.PageStateHandler.$C_1[$v_1]) && $get(SP.Ribbon.PageState.PageStateHandler.$C_1[$v_1] + '_body')) {
                    SP.UI.Status.updateStatus(SP.Ribbon.PageState.PageStateHandler.$C_1[$v_1], SP.Ribbon.PageState.ImportedNativeData.StatusBody[$v_1]);
                    SP.UI.Status.setStatusPriColor(SP.Ribbon.PageState.PageStateHandler.$C_1[$v_1], SP.Ribbon.PageState.ImportedNativeData.StatusPriority);
                    if (SP.Ribbon.SU.$2($v_0)) {
                        $v_0 = SP.Ribbon.PageState.PageStateHandler.$C_1[$v_1];
                    }
                }
                else {
                    if (SP.Ribbon.SU.$2($v_0)) {
                        SP.Ribbon.PageState.PageStateHandler.$C_1[$v_1] = SP.UI.Status.addStatus(SP.Ribbon.PageState.ImportedNativeData.StatusTitle[$v_1], SP.Ribbon.PageState.ImportedNativeData.StatusBody[$v_1], false);
                        $v_0 = SP.Ribbon.PageState.PageStateHandler.$C_1[$v_1];
                    }
                    else {
                        SP.Ribbon.PageState.PageStateHandler.$C_1[$v_1] = SP.UI.Status.appendStatus($v_0, SP.Ribbon.PageState.ImportedNativeData.StatusTitle[$v_1], SP.Ribbon.PageState.ImportedNativeData.StatusBody[$v_1]);
                    }
                    SP.UI.Status.setStatusPriColor(SP.Ribbon.PageState.PageStateHandler.$C_1[$v_1], SP.Ribbon.PageState.ImportedNativeData.StatusPriority);
                }
            }
            else {
                if (!SP.Ribbon.SU.$2(SP.Ribbon.PageState.PageStateHandler.$C_1[$v_1])) {
                    SP.UI.Status.removeStatus(SP.Ribbon.PageState.PageStateHandler.$C_1[$v_1]);
                    SP.Ribbon.PageState.PageStateHandler.$C_1[$v_1] = null;
                }
            }
        }
    }
    else {
        for (var $v_2 = 0; $v_2 < SP.Ribbon.PageState.PageStateHandler.$C_1.length; $v_2++) {
            if (!SP.Ribbon.SU.$2(SP.Ribbon.PageState.PageStateHandler.$C_1[$v_2])) {
                SP.UI.Status.removeStatus(SP.Ribbon.PageState.PageStateHandler.$C_1[$v_2]);
                SP.Ribbon.PageState.PageStateHandler.$C_1[$v_2] = null;
            }
        }
    }
}
SP.Ribbon.PageState.PageStateHandler.showErrorDialog = function() {ULSMg8:;
    if (SP.Ribbon.SU.$2(SP.Ribbon.PageState.NativeErrorState.ShowErrorDialogScript)) {
        var $v_0 = '<p>' + SP.Ribbon.PageState.NativeErrorState.Message + '</p><center><ul class=\'ms-dlgErrList\'>';
        for (var $v_3 = 0; $v_3 < SP.Ribbon.PageState.NativeErrorState.ButtonCount; $v_3++) {
            $v_0 += '<li class=\"ms-dlgErrItem\"><input type=\"button\" onclick=\"' + SP.Ribbon.PageState.NativeErrorState.ButtonCommand[$v_3] + '\" value=\"' + SP.Ribbon.PageState.NativeErrorState.ButtonText[$v_3] + '\" /></li>';
        }
        $v_0 += '</ul></center>';
        var $v_1 = document.createElement('DIV');
        $v_1.className = 's4-dlg-err-itm';
        $v_1.style.paddingLeft = '11px';
        $v_1.style.paddingRight = '11px';
        $v_1.style.paddingTop = '11px';
        $v_1.style.paddingBottom = '0px';
        $v_1.style.minWidth = '200px';
        $v_1.innerHTML = $v_0;
        var $v_2 = SP.UI.$create_DialogOptions();
        $v_2.html = $v_1;
        $v_2.title = SP.Ribbon.PageState.NativeErrorState.Title;
        $v_2.dialogReturnValueCallback = null;
        SP.Ribbon.PageState.PageStateHandler.ignoreNextUnload = true;
        SP.Ribbon.PageState.NativeErrorState.ErrorDialog = SP.UI.ModalDialog.showModalDialog($v_2);
    }
    else {
        SP.Ribbon.PageState.NativeErrorState.ErrorDialog = eval(SP.Ribbon.PageState.NativeErrorState.ShowErrorDialogScript);
    }
}
SP.Ribbon.PageState.PageStateHandler.dismissErrorDialog = function() {ULSMg8:;
    if (!SP.Ribbon.SU.$0(SP.Ribbon.PageState.NativeErrorState.ErrorDialog)) {
        SP.Ribbon.PageState.NativeErrorState.ErrorDialog.close(1);
    }
}
SP.Ribbon.PageState.PageStateHandler.popupWaitScreen = function(title, body) {ULSMg8:;
    SP.Ribbon.PageState.PageStateHandler.ignoreNextUnload = true;
    SP.Ribbon.PageState.ImportedNativeData.WaitScreen = SP.UI.ModalDialog.showWaitScreenWithNoClose(title, body, 100, 200);
    SP.Ribbon.PageState.PageStateHandler.ignoreNextUnload = false;
}
SP.Ribbon.PageState.PageStateHandler.dismissWaitScreen = function() {ULSMg8:;
    if (!SP.Ribbon.SU.$0(SP.Ribbon.PageState.ImportedNativeData.WaitScreen)) {
        SP.Ribbon.PageState.ImportedNativeData.WaitScreen.close(1);
    }
}
SP.Ribbon.PageState.PageStateHandler.EnableSaveBeforeNavigate = function(enable) {ULSMg8:;
    if (enable) {
        if (!SP.Ribbon.PageState.PageStateHandler.$1H_1) {
            SP.Ribbon.Utility.$4o('beforeunload', SP.Ribbon.PageState.PageStateHandler.$2b_1);
            SP.Ribbon.PageState.PageStateHandler.$1H_1 = true;
            var $v_0 = Sys.WebForms.PageRequestManager.getInstance();
            if ($v_0) {
                $v_0.add_pageLoaded(SP.Ribbon.PageState.PageStateHandler.$2a_1);
            }
            SP.Ribbon.PageState.PageStateHandler.ignoreNextUnload = false;
        }
    }
    else {
        try {
            if (SP.Ribbon.PageState.PageStateHandler.$1H_1) {
                SP.Ribbon.PageState.PageStateHandler.$1H_1 = false;
                var $v_1 = Sys.WebForms.PageRequestManager.getInstance();
                if ($v_1) {
                    $v_1.remove_pageLoaded(SP.Ribbon.PageState.PageStateHandler.$2a_1);
                }
                SP.Ribbon.Utility.$5Z('beforeunload', SP.Ribbon.PageState.PageStateHandler.$2b_1);
            }
        }
        catch ($$e_2_0) {
        }
    }
}
SP.Ribbon.PageState.PageStateHandler.$6H_1 = function($p0, $p1) {
    SP.Ribbon.PageState.PageStateHandler.ignoreNextUnload = false;
}
SP.Ribbon.PageState.PageStateHandler.pageStateOnSubmit = function(evt) {ULSMg8:;
    SP.Ribbon.PageState.PageStateHandler.ignoreNextUnload = true;
}
SP.Ribbon.PageState.PageStateHandler.SaveBeforeNavigateCallback = function(callbackResponse) {ULSMg8:;
    eval(callbackResponse);
    SP.Ribbon.PageState.PageStateHandler.saveCallbackError = SP.Ribbon.PageState.NativeErrorState.Message;
}
SP.Ribbon.PageState.PageStateHandler.WikiSaveBeforeNavigateCallback = function(message, status) {ULSMg8:;
    if (status) {
        SP.Ribbon.PageState.PageStateHandler.saveCallbackError = message;
    }
}
SP.Ribbon.PageState.PageStateHandler.$6I_1 = function() {ULSMg8:;
    if (SP.Ribbon.SU.$1C(SP.Ribbon.PageState.ImportedNativeData.PageState)) {
        return true;
    }
    else {
        return ((SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsWikiPage']) || (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsWikiPage']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToCurrentUser']));
    }
}
SP.Ribbon.PageState.PageStateHandler.$4Q_1 = function() {ULSMg8:;
    if (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsWikiPage']) {
        return eval('SPAutoSaveIsPageDirty();');
    }
    else {
        return true;
    }
}
SP.Ribbon.PageState.PageStateHandler.$4Y_1 = function($p0, $p1) {
    if (!SP.Ribbon.SU.$1C(window.event)) {
        if (!SP.Ribbon.SU.$2($p1)) {
            eval('window.event.returnValue = \'' + $p1 + '\';');
        }
        else {
            eval('window.event.returnValue = undefined;');
        }
    }
    else {
        if (!SP.Ribbon.SU.$2($p1)) {
            $p0.rawEvent.returnValue = $p1;
        }
    }
}
SP.Ribbon.PageState.PageStateHandler.saveBeforeNavigate = function(evt) {ULSMg8:;
    if (!SP.Ribbon.PageState.PageStateHandler.ignoreNextUnload && SP.Ribbon.PageState.Handlers.isInEditMode() && SP.Ribbon.PageState.PageStateHandler.$4Q_1()) {
        if (SP.Ribbon.PageState.PageStateHandler.$6I_1()) {
            if (!confirm(SP.Res.pageStateSaveBeforeNavigateNotCheckedOutWarning)) {
                SP.Ribbon.PageState.PageStateHandler.$4Y_1(evt, SP.Res.pageStateSaveBeforeNavigateLastChanceWarning);
                return SP.Res.pageStateSaveBeforeNavigateLastChanceWarning;;
                return;
            }
        }
        SP.Ribbon.PageState.PageStateHandler.saveCallbackError = SP.Res.pageStateSaveBeforeNavigateUnknownError;
        eval('\r\n                var __xmlHttpRequest = window.XMLHttpRequest;\r\n                window.XMLHttpRequest = XMLHttpRequest = function() {ULSMg8:;\r\n                    var _xmlHttp = null;\r\n                    if (!__xmlHttpRequest) {\r\n                        try {\r\n                            _xmlHttp = new ActiveXObject(\'Microsoft.XMLHTTP\');\r\n                        }\r\n                        catch(ex) {}\r\n                    }\r\n                    else {\r\n                        _xmlHttp = new __xmlHttpRequest();\r\n                    }\r\n                    \r\n                    if (!_xmlHttp) return null;\r\n                    \r\n                    this.abort = function() {ULSMg8:;return _xmlHttp.abort();}\r\n\r\n                    this.getAllResponseHeaders = function() {ULSMg8:;return _xmlHttp.getAllResponseHeaders();}\r\n                    this.getResponseHeader = function(header) {ULSMg8:;return _xmlHttp.getResponseHeader(header);}\r\n                    this.open = function(method, url, async, user, password) {ULSMg8:;\r\n                        return _xmlHttp.open(method, url, false, user, password);\r\n                    }\r\n                    this.send = function(body) {ULSMg8:;\r\n                        if (_xmlHttp.timeout != undefined)\r\n                        {\r\n                            _xmlHttp.timeout = 15000;\r\n                        }\r\n                        _xmlHttp.send(body);\r\n                        this.readyState = _xmlHttp.readyState;\r\n                        if (this.readyState == 4)\r\n                        {\r\n                            this.responseBody = _xmlHttp.responseBody;\r\n                            this.responseStream = _xmlHttp.responseStream;\r\n                            this.responseText = _xmlHttp.responseText;\r\n                            this.responseXML = _xmlHttp.responseXML;\r\n                            this.status = _xmlHttp.status;\r\n                            this.statusText = _xmlHttp.statusText;\r\n                        }\r\n                        this.onreadystatechange();\r\n                    }\r\n                    this.setRequestHeader = function(name, value) {ULSMg8:;return _xmlHttp.setRequestHeader(name, value);}\r\n                }');
        eval(SP.Ribbon.PageState.ImportedNativeData.CommandHandlers['PageStateSaveBeforeNavigate']);
        eval('window.XMLHttpRequest = __xmlHttpRequest;');
        SP.Ribbon.PageState.PageStateHandler.$4Y_1(evt, SP.Ribbon.PageState.PageStateHandler.saveCallbackError);
        SP.Ribbon.PageState.PageStateHandler.ignoreNextUnload = false;
        if (!SP.Ribbon.SU.$2(SP.Ribbon.PageState.PageStateHandler.saveCallbackError)) {
            return SP.Ribbon.PageState.PageStateHandler.saveCallbackError;;
        }
    }
    else {
        SP.Ribbon.PageState.PageStateHandler.ignoreNextUnload = false;
    }
}
SP.Ribbon.PageState.PageStateHandler.updatePageState = function() {ULSMg8:;
    var $v_0 = 'PageStateUpdatePageState';
    if (!SP.Ribbon.PageState.ImportedNativeData || !SP.Ribbon.PageState.ImportedNativeData.CommandHandlers || !SP.Ribbon.PageState.ImportedNativeData.CommandHandlers[$v_0]) {
        return;
    }
    eval(SP.Ribbon.PageState.ImportedNativeData.CommandHandlers[$v_0]);
}
SP.Ribbon.PageState.PageStateHandler.prototype = {
    
    getFocusedCommands: function() {ULSMg8:;
        return null;
    },
    
    getGlobalCommands: function() {ULSMg8:;
        return [ Commands.CommandIds.ApplicationStateChanged, 'CPEditTab', 'EditAndCheckoutGroup', 'WikiPageTab', 'PublishTab', 'ApproveGroup', 'PageStateGroupOpenMenuSave', 'PageStateGroupOpenMenuCheckin', 'PageStateGroupOpenMenuPublish', 'PageStateGroupQuerySaveMenu', 'PageStateGroupQueryCheckinMenu', 'PageStateGroupQueryPublishMenu', 'PageStateGroupSaveSplit', 'PageStateGroupCheckinSplit', 'PageStateGroupPublishSplit', 'PageStateGroupSave', 'PageStateGroupSaveAndStop', 'PageStateGroupEdit', 'PageStateGroupDontSaveAndStop', 'PageStateGroupCheckin', 'PageStateGroupCheckout', 'PageStateGroupDiscardCheckout', 'PageStateGroupOverrideCheckout', 'PageStateGroupPublish', 'PageStateGroupUnpublish', 'PageStateGroupSubmitForApproval', 'PageStateGroupCancelApproval', 'PageStateGroupApprove', 'PageStateGroupReject', 'ManageGroup', 'DeletePage', 'PageStateGroupStopEditing' ];
    },
    
    canHandleCommand: function(commandId) {ULSMg8:;
        if (!SP.Ribbon.PageState.PageStateHandler.$1Z_1 && (commandId === 'PageStateGroupSaveSplit' || commandId === 'PageStateGroupOpenMenuSave' || commandId === 'PageStateGroupQuerySaveMenu' || commandId === 'PageStateGroupSave' || commandId === 'PageStateGroupSaveAndStop' || commandId === 'PageStateGroupEdit' || commandId === 'PageStateGroupDontSaveAndStop' || commandId === 'PageStateGroupStopEditing')) {
            return false;
        }
        if ('PageStateGroupStopEditing' === commandId) {
            commandId = 'PageStateGroupSaveAndStop';
        }
        if (!SP.Ribbon.SU.$0(SP.Ribbon.PageState.ImportedNativeData.EnabledHandlers[commandId])) {
            return eval(SP.Ribbon.PageState.ImportedNativeData.EnabledHandlers[commandId]);
        }
        else if (!SP.Ribbon.SU.$0(SP.Ribbon.PageState.PageStateHandler.$13_1[commandId])) {
            var $v_0 = false;
            var $v_1 = SP.Ribbon.PageState.PageStateHandler.$13_1[commandId];
            for (var $v_2 = 0; $v_2 < $v_1.length && !$v_0; $v_2++) {
                $v_0 = eval(SP.Ribbon.PageState.ImportedNativeData.EnabledHandlers[$v_1[$v_2]]);
            }
            return $v_0;
        }
        return true;
    },
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        if (!SP.Ribbon.PageState.PageStateHandler.$1Z_1 && (commandId === 'PageStateGroupSaveSplit' || commandId === 'PageStateGroupOpenMenuSave' || commandId === 'PageStateGroupQuerySaveMenu' || commandId === 'PageStateGroupSave' || commandId === 'PageStateGroupSaveAndStop' || commandId === 'PageStateGroupEdit' || commandId === 'PageStateGroupDontSaveAndStop' || commandId === 'PageStateGroupStopEditing')) {
            return false;
        }
        if (Commands.CommandIds.ApplicationStateChanged === commandId) {
            SP.Ribbon.PageStateActionButton.updateState();
            return true;
        }
        if ('PageStateGroupStopEditing' === commandId) {
            if (confirm(SP.Res.pageStateSaveBeforeNavigateNotCheckedOutWarning)) {
                commandId = 'PageStateGroupSaveAndStop';
            }
            else {
                commandId = 'PageStateGroupDontSaveAndStop';
            }
        }
        if (commandId.startsWith('PageStateGroupQuery')) {
            var $v_0 = SP.Ribbon.PageState.PageStateHandler.$5o_1(properties);
            var $v_1 = null;
            if (!$v_0) {
                return false;
            }
            switch (commandId) {
                case 'PageStateGroupQuerySaveMenu':
                    if (SP.Ribbon.PageState.Handlers.isInEditMode()) {
                        properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'SaveAndStop';
                    }
                    else {
                        properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'Edit';
                    }
                    break;
                case 'PageStateGroupQueryCheckinMenu':
                    if (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser']) {
                        properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'OverrideCheckout';
                    }
                    else if (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToCurrentUser']) {
                        properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'Checkout';
                    }
                    else {
                        properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'Checkin';
                    }
                    break;
                case 'PageStateGroupQueryPublishMenu':
                    if (($v_1 = SP.Ribbon.PageState.PageStateHandler.$5n_1('PageStateGroupPublishSplit'))) {
                        properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + SP.Ribbon.PageState.PageStateHandler.getButtonId($v_1);
                    }
                    else if (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsMajorVersion']) {
                        if (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasApproverRights']) {
                            properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'Unpublish';
                        }
                        else {
                            properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'Publish';
                        }
                    }
                    else if ((SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsPendingApproval']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['DocLibWorkflowEnabled'])) {
                        properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'CancelApproval';
                    }
                    else if ((SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToCurrentUser']) || (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsRejected'])) {
                        if ((!SP.Ribbon.PageState.ImportedNativeData.PageState['DocLibWorkflowEnabled']) && ((!SP.Ribbon.PageState.ImportedNativeData.PageState['DocLibApprovalEnabled']) || (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasApproverRights']))) {
                            properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'Publish';
                        }
                        else {
                            properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'SubmitForApproval';
                        }
                    }
                    else if (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser']) {
                        properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'Publish';
                    }
                    else if (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemHasCheckedInVersion']) {
                        if ((!SP.Ribbon.PageState.ImportedNativeData.PageState['DocLibWorkflowEnabled']) && ((!SP.Ribbon.PageState.ImportedNativeData.PageState['DocLibApprovalEnabled']) || (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasApproverRights']))) {
                            properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'Publish';
                        }
                        else {
                            properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'SubmitForApproval';
                        }
                    }
                    else if (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsPendingApproval']) {
                        if ((!SP.Ribbon.PageState.ImportedNativeData.PageState['DocLibWorkflowEnabled']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasApproverRights'])) {
                            properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'Publish';
                        }
                        else {
                            properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'CancelApproval';
                        }
                    }
                    else if (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsScheduled']) {
                        properties[CUI.Controls.DropDownCommandProperties.SelectedItemId] = $v_0 + 'Unpublish';
                    }
                    else {
                        return false;
                    }
                    break;
            }
            return true;
        }
        else if (!SP.Ribbon.SU.$0(SP.Ribbon.PageState.ImportedNativeData.CommandHandlers[commandId])) {
            return SP.Ribbon.PageState.Handlers.showStateChangeDialog(commandId, SP.Ribbon.PageState.ImportedNativeData.CommandHandlers[commandId]);
        }
        else if (properties && !SP.Ribbon.SU.$2(properties['CommandValueId'])) {
            return SP.Ribbon.PageState.Handlers.showStateChangeDialog(properties['CommandValueId'], SP.Ribbon.PageState.ImportedNativeData.CommandHandlers[properties['CommandValueId']]);
        }
        return false;
    },
    
    isFocusable: function() {ULSMg8:;
        return false;
    },
    
    receiveFocus: function() {ULSMg8:;
        return true;
    },
    
    yieldFocus: function() {ULSMg8:;
        return true;
    },
    
    init: function() {ULSMg8:;
        if (SP.Ribbon.PageState.NativeErrorState.ButtonCount > 0 || !SP.Ribbon.SU.$2(SP.Ribbon.PageState.NativeErrorState.ShowErrorDialogScript)) {
            SP.Ribbon.PageState.PageStateHandler.showErrorDialog();
        }
        SP.Ribbon.PageState.PageStateHandler.showPageStatus();
    },
    
    getId: function() {ULSMg8:;
        return 'PageState';
    }
}


SP.Ribbon.PageState.StateChangeDialogHandler = function() {
}
SP.Ribbon.PageState.StateChangeDialogHandler.prototype = {
    enabled: null,
    initialize: null,
    abort: null,
    validate: null
}


SP.Ribbon.PageState.Handlers = function() {
}
SP.Ribbon.PageState.Handlers.isInEditMode = function() {ULSMg8:;
    var $v_0 = SP.Ribbon.WikiPageComponent.$D();
    if (SP.Ribbon.SU.$1C(SP.Ribbon.PageState.ImportedNativeData) || SP.Ribbon.SU.$1C(SP.Ribbon.PageState.ImportedNativeData.PageState)) {
        return $v_0;
    }
    else {
        return ((SP.Ribbon.PageState.ImportedNativeData.PageState['ViewModeIsEdit']) || (SP.Ribbon.PageState.ImportedNativeData.PageState['ViewModeIsWebPartDesign']) || $v_0);
    }
}
SP.Ribbon.PageState.Handlers.isSaveEnabled = function() {ULSMg8:;
    if (SP.Ribbon.PageState.Handlers.isInEditMode() && (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasContributorRights']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInSharedView']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsFormsPage']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser'])) {
        return true;
    }
    return false;
}
SP.Ribbon.PageState.Handlers.isEditEnabled = function() {ULSMg8:;
    if (!SP.Ribbon.PageState.Handlers.isInEditMode() && (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasContributorRights']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsFormsPage']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInSharedView']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser'])) {
        return true;
    }
    return false;
}
SP.Ribbon.PageState.Handlers.isDontSaveAndStopEnabled = function() {ULSMg8:;
    if ((SP.Ribbon.PageState.ImportedNativeData.PageState['ViewModeIsEdit']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsFormsPage']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser'])) {
        return true;
    }
    return false;
}
SP.Ribbon.PageState.Handlers.isSaveAndStopEditEnabled = function() {ULSMg8:;
    if (SP.Ribbon.PageState.Handlers.isInEditMode() && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsFormsPage']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInSharedView'])) {
        return true;
    }
    return false;
}
SP.Ribbon.PageState.Handlers.isCheckoutEnabled = function() {ULSMg8:;
    if ((!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToCurrentUser']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsFormsPage']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasContributorRights']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInLibrary']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInSharedView'])) {
        return true;
    }
    return false;
}
SP.Ribbon.PageState.Handlers.isCheckinEnabled = function() {ULSMg8:;
    if ((SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToCurrentUser']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsFormsPage']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasContributorRights']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInLibrary']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInSharedView'])) {
        return true;
    }
    return false;
}
SP.Ribbon.PageState.Handlers.isDiscardCheckoutEnabled = function() {ULSMg8:;
    if ((SP.Ribbon.PageState.ImportedNativeData.PageState['ItemHasCheckedInVersion']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsFormsPage']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInSharedView']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToCurrentUser'])) {
        return true;
    }
    return false;
}
SP.Ribbon.PageState.Handlers.isOverrideCheckoutEnabled = function() {ULSMg8:;
    if ((SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsFormsPage']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToCurrentUser']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToSystemUser']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInLibrary']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasOverrideCheckoutRights'])) {
        return true;
    }
    return false;
}
SP.Ribbon.PageState.Handlers.isPublishEnabled = function() {ULSMg8:;
    if ((!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsMajorVersion']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsFormsPage']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsPendingApproval']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsScheduled']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInLibrary']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['DocLibMinorVersionsEnabled']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['DocLibWorkflowEnabled']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasContributorRights']) && ((SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasApproverRights']) || (!SP.Ribbon.PageState.ImportedNativeData.PageState['DocLibApprovalEnabled'])) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInSharedView'])) {
        return true;
    }
    return false;
}
SP.Ribbon.PageState.Handlers.isUnpublishEnabled = function() {ULSMg8:;
    if (!SP.Ribbon.PageState.Handlers.isInEditMode() && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsFormsPage']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsScheduled']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInLibrary']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsMajorVersion']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['DocLibMinorVersionsEnabled']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasApproverRights']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasContributorRights']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInSharedView']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToSystemUser'])) {
        return true;
    }
    return false;
}
SP.Ribbon.PageState.Handlers.isSubmitForApprovalEnabled = function() {ULSMg8:;
    if ((!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsMajorVersion']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsFormsPage']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInSharedView']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsPendingApproval']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['DocLibApprovalEnabled']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasContributorRights'])) {
        return true;
    }
    return false;
}
SP.Ribbon.PageState.Handlers.isCancelApprovalEnabled = function() {ULSMg8:;
    if ((!SP.Ribbon.PageState.ImportedNativeData.PageState['ViewModeIsEdit']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsFormsPage']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasContributorRights']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsPendingApproval']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['DocLibMinorVersionsEnabled']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInSharedView'])) {
        return true;
    }
    return false;
}
SP.Ribbon.PageState.Handlers.isApproveEnabled = function() {ULSMg8:;
    if ((!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsMajorVersion']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsFormsPage']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInSharedView']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsPendingApproval']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasApproverRights']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasContributorRights'])) {
        return true;
    }
    return false;
}
SP.Ribbon.PageState.Handlers.isRejectEnabled = function() {ULSMg8:;
    if ((!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsMajorVersion']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsFormsPage']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsInSharedView']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsPendingApproval']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasApproverRights']) && (SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasContributorRights'])) {
        return true;
    }
    return false;
}
SP.Ribbon.PageState.Handlers.isDeleteEnabled = function() {ULSMg8:;
    if ((SP.Ribbon.PageState.ImportedNativeData.PageState['UserHasDeleteRights']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToOtherUser']) && (!SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsDefaultPage'])) {
        return true;
    }
    return false;
}
SP.Ribbon.PageState.Handlers.GenericCompleteHandler = function(cbr) {ULSMg8:;
    SP.Ribbon.PageState.PageStateHandler.dismissWaitScreen();
    eval(cbr);
    SP.Ribbon.PageManager.get_instance().get_commandDispatcher().executeCommand('appstatechanged', null);
    var $v_0 = SP.Ribbon.PageState.ImportedNativeData.CallbackResult['Notification'];
    if (!SP.Ribbon.SU.$2($v_0)) {
        SP.UI.Notify.addNotification($v_0, false);
        SP.Ribbon.PageState.ImportedNativeData.CallbackResult['Notification'] = '';
    }
    SP.Ribbon.PageState.PageStateHandler.showPageStatus();
    if (SP.Ribbon.PageState.NativeErrorState.ButtonCount > 0) {
        SP.Ribbon.PageState.PageStateHandler.showErrorDialog();
    }
}
SP.Ribbon.PageState.Handlers.GenericError = function(cbr) {ULSMg8:;
    alert('callback failed');
}
SP.Ribbon.PageState.Handlers.addStateChangeDialogHandler = function(handler) {ULSMg8:;
    SP.Ribbon.PageState.Handlers.$1z_0.push(handler);
}
SP.Ribbon.PageState.Handlers.setStateChangeDialogFocusOnNode = function(node) {ULSMg8:;
    if (node) {
        SP.Ribbon.PageState.Handlers.$2d_0 = node;
    }
}
SP.Ribbon.PageState.Handlers.onOkButton = function(e) {ULSMg8:;
    SP.Ribbon.PageState.Handlers.$6d_0();
}
SP.Ribbon.PageState.Handlers.onCancelButton = function(e) {ULSMg8:;
    SP.Ribbon.PageState.Handlers.$6c_0();
}
SP.Ribbon.PageState.Handlers.showStateChangeDialog = function(commandId, func) {ULSMg8:;
    SP.Ribbon.PageState.Handlers.$L_0 = new Array(0);
    for (var $v_4 = 0; $v_4 < SP.Ribbon.PageState.Handlers.$1z_0.length; $v_4++) {
        var $v_5 = true;
        var $v_6 = SP.Ribbon.PageState.Handlers.$1z_0[$v_4];
        if ($v_6.enabled) {
            $v_5 = $v_6.enabled(commandId);
        }
        if ($v_5) {
            SP.Ribbon.PageState.Handlers.$L_0.push($v_6);
        }
    }
    if (!SP.Ribbon.PageState.Handlers.$L_0.length) {
        return eval(func);
    }
    SP.Ribbon.PageState.PageStateHandler.ignoreNextUnload = true;
    SP.Ribbon.PageState.Handlers.$2e_0 = func;
    var $v_0 = document.createElement('DIV');
    var $v_1 = 0;
    for (var $v_7 = 0; $v_7 < SP.Ribbon.PageState.Handlers.$L_0.length; $v_7++) {
        var $v_8 = SP.Ribbon.PageState.Handlers.$L_0[$v_7];
        $v_1 += $v_8.initialize(commandId, $v_0);
    }
    var $v_2 = document.createElement('DIV');
    $v_2.style.textAlign = SP.Res.alignRight;
    var $v_9 = document.createElement('INPUT');
    $v_9.value = SP.Res.continueButtonText;
    $v_9.type = 'button';
    $addHandler($v_9, 'click', SP.Ribbon.PageState.Handlers.onOkButton);
    $v_9.style.width = SP.Res.okCancelButtonWidth;
    $v_9.style.margin = '4px';
    $v_9.id = 'statechangedialog_okbutton';
    var $v_A = document.createElement('INPUT');
    $v_A.value = SP.Res.cancelButtonText;
    $v_A.type = 'button';
    $addHandler($v_A, 'click', SP.Ribbon.PageState.Handlers.onCancelButton);
    $v_A.style.width = SP.Res.okCancelButtonWidth;
    $v_A.style.margin = '4px';
    $v_A.id = 'statechangedialog_cancelbutton';
    $v_2.appendChild($v_9);
    $v_2.appendChild($v_A);
    $v_0.appendChild($v_2);
    $v_1 += 32;
    var $v_3 = SP.UI.$create_DialogOptions();
    $v_3.html = $v_0;
    $v_3.width = 400;
    $v_3.height = $v_1;
    $v_3.title = SP.Ribbon.PageState.Handlers.$5q_0(commandId);
    $v_3.dialogReturnValueCallback = SP.Ribbon.PageState.Handlers.$6b_0;
    SP.Ribbon.PageState.Handlers.$1y_0 = SP.UI.ModalDialog.showModalDialog($v_3);
    SP.Ribbon.PageState.Handlers.$2d_0.focus();
    $v_0.parentNode.parentNode.id = 'statechangedialog';
    return true;
}
SP.Ribbon.PageState.Handlers.$5q_0 = function($p0) {
    if (!SP.Ribbon.PageState.Handlers.$20_0) {
        SP.Ribbon.PageState.Handlers.$20_0 = { PageStateGroupApprove: SP.Res.pageStateApproveLabel, PageStateGroupCancelApproval: SP.Res.pageStateCancelApprovalLabel, PageStateGroupCheckin: SP.Res.pageStateCheckinLabel, PageStateGroupCheckout: SP.Res.pageStateCheckoutLabel, PageStateGroupDiscardCheckout: SP.Res.pageStateDiscardCheckoutLabel, PageStateGroupDontSaveAndStop: SP.Res.pageStateDontSaveLabel, PageStateGroupEdit: SP.Res.pageStateEditLabel, PageStateGroupOverrideCheckout: SP.Res.pageStateOverrideCheckoutLabel, PageStateGroupPublish: SP.Res.pageStatePublishLabel, PageStateGroupReject: SP.Res.pageStateRejectLabel, PageStateGroupSave: SP.Res.pageStateSaveLabel, PageStateGroupSaveAndStop: SP.Res.pageStateSaveAndStopEditingLabel, PageStateGroupSubmitForApproval: SP.Res.pageStateSubmitForApprovalLabel, PageStateGroupUnpublish: SP.Res.pageStateUnpublishLabel };
    }
    return SP.Ribbon.PageState.Handlers.$20_0[$p0];
}
SP.Ribbon.PageState.Handlers.$6b_0 = function($p0, $p1) {
    if ($p0 === 1) {
        for (var $v_0 = 0; $v_0 < SP.Ribbon.PageState.Handlers.$L_0.length; $v_0++) {
            var $v_1 = SP.Ribbon.PageState.Handlers.$L_0[$v_0];
            if ($v_1.validate) {
                if (!$v_1.validate()) {
                    return;
                }
            }
        }
        for (var $v_2 = 0; $v_2 < SP.Ribbon.PageState.Handlers.$L_0.length; $v_2++) {
            var $v_3 = SP.Ribbon.PageState.Handlers.$L_0[$v_2];
            if ($v_3.abort) {
                $v_3.abort();
            }
        }
        eval(SP.Ribbon.PageState.Handlers.$2e_0);
    }
    else if (!$p0) {
        for (var $v_4 = 0; $v_4 < SP.Ribbon.PageState.Handlers.$L_0.length; $v_4++) {
            var $v_5 = SP.Ribbon.PageState.Handlers.$L_0[$v_4];
            if ($v_5.abort) {
                $v_5.abort();
            }
        }
    }
}
SP.Ribbon.PageState.Handlers.$6d_0 = function() {ULSMg8:;
    SP.Ribbon.PageState.Handlers.$1y_0.close(1);
}
SP.Ribbon.PageState.Handlers.$6c_0 = function() {ULSMg8:;
    SP.Ribbon.PageState.Handlers.$1y_0.close(0);
}
SP.Ribbon.PageState.Handlers.$5Q = function($p0, $p1) {
    if (!$p1) {
        return 0;
    }
    var $v_0 = document.createElement('DIV');
    $p1.appendChild($v_0);
    $v_0.style.margin = '8px';
    var $v_1 = document.createElement('DIV');
    $v_0.appendChild($v_1);
    var $v_2 = document.createElement('LABEL');
    $v_2.innerText = SP.Res.checkInComments;
    $v_1.appendChild($v_2);
    SP.Ribbon.PageState.Handlers.$Q_0 = document.createElement('TEXTAREA');
    SP.Ribbon.PageState.Handlers.$Q_0.style.margin = '6px';
    SP.Ribbon.PageState.Handlers.$Q_0.style.width = '95%';
    SP.Ribbon.PageState.Handlers.$Q_0.rows = 6;
    SP.Ribbon.PageState.Handlers.$Q_0.id = 'checkincomments';
    $v_0.appendChild(SP.Ribbon.PageState.Handlers.$Q_0);
    SP.Ribbon.PageState.Handlers.setStateChangeDialogFocusOnNode(SP.Ribbon.PageState.Handlers.$Q_0);
    $v_2.htmlFor = SP.Ribbon.PageState.Handlers.$Q_0.id;
    return 148;
}
SP.Ribbon.PageState.Handlers.$5R_0 = function() {ULSMg8:;
    var $v_0 = $get('InputComments');
    $v_0.value = SP.Ribbon.PageState.Handlers.$Q_0.value;
    return true;
}
SP.Ribbon.PageState.Handlers.$5P_0 = function($p0) {
    return (($p0 === 'PageStateGroupCheckin' || $p0 === 'PageStateGroupSubmitForApproval' || $p0 === 'PageStateGroupPublish') && SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsCheckedOutToCurrentUser']) || (($p0 === 'PageStateGroupApprove' || $p0 === 'PageStateGroupReject') && SP.Ribbon.PageState.ImportedNativeData.PageState['ItemIsPendingApproval']);
}
SP.Ribbon.PageState.Handlers.registerCommentsHandler = function() {ULSMg8:;
    var $v_0 = new SP.Ribbon.PageState.StateChangeDialogHandler();
    $v_0.initialize = SP.Ribbon.PageState.Handlers.$5Q;
    $v_0.enabled = SP.Ribbon.PageState.Handlers.$5P_0;
    $v_0.validate = SP.Ribbon.PageState.Handlers.$5R_0;
    SP.Ribbon.PageState.Handlers.addStateChangeDialogHandler($v_0);
}


Type.registerNamespace('SP.Ribbon.TenantAdmin');

SP.Ribbon.TenantAdmin.TenantAdminPageComponent = function() {ULSMg8:;
    SP.Ribbon.TenantAdmin.TenantAdminPageComponent.initializeBase(this);
}
SP.Ribbon.TenantAdmin.TenantAdminPageComponent.initialize = function() {ULSMg8:;
    var $v_0 = SP.Ribbon.PageManager.get_instance();
    if (null !== $v_0) {
        $v_0.addPageComponent(SP.Ribbon.TenantAdmin.TenantAdminPageComponent.$1u_1);
    }
}
SP.Ribbon.TenantAdmin.TenantAdminPageComponent.$5b_1 = function($p0) {
    __doPostBack('__Page', $p0);
    return true;
}
SP.Ribbon.TenantAdmin.TenantAdminPageComponent.$6F_1 = function($p0, $p1) {
    location.reload(null);
}
SP.Ribbon.TenantAdmin.TenantAdminPageComponent.prototype = {
    
    canHandleCommand: function(commandId) {ULSMg8:;
        if ((commandId === 'SiteCollectionsTab') || (commandId === 'SiteCollectionsContributeGroup') || (commandId === 'CreateSiteCollectionClick') || (commandId === 'SiteCollectionsReviewGroup') || (commandId === 'SiteCollectionsManageGroup')) {
            return true;
        }
        return commandEnabled(commandId);
    },
    
    getGlobalCommands: function() {ULSMg8:;
        return [ 'SiteCollectionsTab', 'SiteCollectionsContributeGroup', 'CreateSiteCollectionClick', 'DeleteSiteCollectionsClick', 'SiteCollectionsReviewGroup', 'ViewPropertiesClick', 'SiteCollectionsManageGroup', 'OwnersClick', 'DiskQuotaClick' ];
    },
    
    handleCommand: function(commandId, properties, sequence) {ULSMg8:;
        if (commandId === 'CreateSiteCollectionClick') {
            var $v_0 = SP.UI.$create_DialogOptions();
            $v_0.url = 'TA_CreateSiteCollection.aspx';
            $v_0.width = 850;
            $v_0.height = 480;
            $v_0.title = SP.Res.tenantAdmin_SiteCollectionNewDialogTitle;
            $v_0.dialogReturnValueCallback = SP.Ribbon.TenantAdmin.TenantAdminPageComponent.$6F_1;
            SP.UI.ModalDialog.showModalDialog($v_0);
            return true;
        }
        if (commandId === 'DeleteSiteCollectionsClick') {
            var $v_1 = SP.UI.$create_DialogOptions();
            $v_1.url = 'TA_DeleteSiteCollectionDialog.aspx';
            $v_1.width = 600;
            $v_1.height = 200;
            $v_1.title = SP.Res.tenantAdmin_SiteCollectionDeleteDialogTitle;
            $v_1.dialogReturnValueCallback = null;
            SP.UI.ModalDialog.showModalDialog($v_1);
            return true;
        }
        if (commandId === 'ViewPropertiesClick') {
            var $v_2 = SP.UI.$create_DialogOptions();
            var $v_3 = document.getElementById('ctl00_PlaceHolderMain_singleSelectedSite');
            $v_2.url = 'TA_ViewSiteCollectionPropertiesDialog.aspx?site=' + $v_3.getAttribute('value');
            $v_2.title = SP.Res.tenantAdmin_SiteCollectionPropertiesDialogTitle;
            $v_2.dialogReturnValueCallback = null;
            SP.UI.ModalDialog.showModalDialog($v_2);
            return true;
        }
        if (commandId === 'OwnersClick') {
            var $v_4 = SP.UI.$create_DialogOptions();
            var $v_5 = document.getElementById('ctl00_PlaceHolderMain_singleSelectedSite');
            $v_4.url = 'TA_SiteCollectionOwnersDialog.aspx?site=' + $v_5.getAttribute('value');
            $v_4.width = 640;
            $v_4.height = 340;
            $v_4.title = SP.Res.tenantAdmin_SiteCollectionOwnersDialogTitle;
            $v_4.dialogReturnValueCallback = null;
            SP.UI.ModalDialog.showModalDialog($v_4);
            return true;
        }
        if (commandId === 'DiskQuotaClick') {
            var $v_6 = SP.UI.$create_DialogOptions();
            var $v_7 = document.getElementById('ctl00_PlaceHolderMain_singleSelectedSite');
            $v_6.url = 'TA_SiteCollectionDiskQuotaDialog.aspx?site=' + $v_7.getAttribute('value');
            $v_6.width = 640;
            $v_6.height = 280;
            $v_6.title = SP.Res.tenantAdmin_SiteCollectionDiskQuotaDialogTitle;
            $v_6.dialogReturnValueCallback = null;
            SP.UI.ModalDialog.showModalDialog($v_6);
            return true;
        }
        return SP.Ribbon.TenantAdmin.TenantAdminPageComponent.$5b_1(commandId);
    }
}


SP.BWsaConfig.registerClass('SP.BWsaConfig');
SP.Ticks.registerClass('SP.Ticks');
SP.TimerResetCheck.registerClass('SP.TimerResetCheck');
SP.StreamRowCounters.registerClass('SP.StreamRowCounters');
SP.BWsaDatapoint.registerClass('SP.BWsaDatapoint');
SP.WsaStreamRow.registerClass('SP.WsaStreamRow');
SP.BWsaStream.registerClass('SP.BWsaStream');
SP.BWsaHeader.registerClass('SP.BWsaHeader');
SP.BWsaData.registerClass('SP.BWsaData');
SP.BWsaClient.registerClass('SP.BWsaClient');
SP.Ribbon.Utility.registerClass('SP.Ribbon.Utility');
SP.Ribbon.UtilityInternal.registerClass('SP.Ribbon.UtilityInternal');
SP.Ribbon.SQMUtility.registerClass('SP.Ribbon.SQMUtility');
SP.Ribbon.SU.registerClass('SP.Ribbon.SU');
SP.Ribbon.CommandUIExtensionPageComponent.registerClass('SP.Ribbon.CommandUIExtensionPageComponent', CUI.Page.PageComponent);
SP.Ribbon.ToolbarRibbonAdapterData.registerClass('SP.Ribbon.ToolbarRibbonAdapterData');
SP.Ribbon.ToolbarRibbonAdapter.registerClass('SP.Ribbon.ToolbarRibbonAdapter', CUI.Page.PageComponent);
SP.Ribbon.WebPartPageComponentData.registerClass('SP.Ribbon.WebPartPageComponentData', SP.Ribbon.ToolbarRibbonAdapterData);
SP.Ribbon.WebPartPageComponent.registerClass('SP.Ribbon.WebPartPageComponent', SP.Ribbon.ToolbarRibbonAdapter);
SP.Ribbon.ListViewWebPartPageComponentData.registerClass('SP.Ribbon.ListViewWebPartPageComponentData', SP.Ribbon.WebPartPageComponentData);
SP.Ribbon.PagingInformation.registerClass('SP.Ribbon.PagingInformation');
SP.Ribbon.ECBMenuItem.registerClass('SP.Ribbon.ECBMenuItem', Object);
SP.Ribbon.CLVP.registerClass('SP.Ribbon.CLVP');
SP.Ribbon.ListViewWebPartData.registerClass('SP.Ribbon.ListViewWebPartData', SP.Ribbon.ToolbarRibbonAdapterData);
SP.Ribbon.ListViewWebPartPageComponent.registerClass('SP.Ribbon.ListViewWebPartPageComponent', SP.Ribbon.WebPartPageComponent, SP.Application.UI.ViewInformationRequestor, SP.Application.UI.DefaultFormsInformationRequestor);
SP.Ribbon.ListFormWebPartPageComponentData.registerClass('SP.Ribbon.ListFormWebPartPageComponentData', SP.Ribbon.WebPartPageComponentData);
SP.Ribbon.ListFormWebPartPageComponent.registerClass('SP.Ribbon.ListFormWebPartPageComponent', SP.Ribbon.WebPartPageComponent);
SP.Ribbon.DocLibWebPartPageComponent.registerClass('SP.Ribbon.DocLibWebPartPageComponent', SP.Ribbon.ListViewWebPartPageComponent);
SP.Ribbon.GenericListWebPartPageComponentData.registerClass('SP.Ribbon.GenericListWebPartPageComponentData', SP.Ribbon.ListViewWebPartPageComponentData);
SP.Ribbon.GenericListWebPartPageComponent.registerClass('SP.Ribbon.GenericListWebPartPageComponent', SP.Ribbon.ListViewWebPartPageComponent);
SP.Ribbon.SolutionsPageComponent.registerClass('SP.Ribbon.SolutionsPageComponent', SP.Ribbon.ListViewWebPartPageComponent);
SP.Ribbon.WikiPageComponent.registerClass('SP.Ribbon.WikiPageComponent', CUI.Page.PageComponent);
SP.Ribbon.FetchedDocLibItemInfo.registerClass('SP.Ribbon.FetchedDocLibItemInfo');
SP.Ribbon.DocLibAspxPageComponent.registerClass('SP.Ribbon.DocLibAspxPageComponent', CUI.Page.PageComponent);
SP.Ribbon.WebPartComponent.registerClass('SP.Ribbon.WebPartComponent', CUI.Page.PageComponent);
SP.Ribbon.FetchListViewWebPartPageComponentWorker.registerClass('SP.Ribbon.FetchListViewWebPartPageComponentWorker');
SP.Ribbon.BlogPostWebPartPageComponent.registerClass('SP.Ribbon.BlogPostWebPartPageComponent', SP.Ribbon.DocLibWebPartPageComponent);
SP.Ribbon.PageManager.registerClass('SP.Ribbon.PageManager', CUI.Page.PageManager);
SP.Ribbon.PageStateActionButton.registerClass('SP.Ribbon.PageStateActionButton');
SP.Ribbon.RelatedFieldsFetcher.registerClass('SP.Ribbon.RelatedFieldsFetcher');
SP.Ribbon.RelatedFieldsHelper.registerClass('SP.Ribbon.RelatedFieldsHelper', null, SP.Ribbon.IRelatedFieldsInfoRequestor);
SP.Ribbon.UsageReportPageComponent.registerClass('SP.Ribbon.UsageReportPageComponent', CUI.Page.PageComponent);
SP.Ribbon.GroupBoardWebPartPageComponent.registerClass('SP.Ribbon.GroupBoardWebPartPageComponent', SP.Ribbon.GenericListWebPartPageComponent);
SP.Ribbon.CalendarPageComponentData.registerClass('SP.Ribbon.CalendarPageComponentData', SP.Ribbon.GenericListWebPartPageComponentData);
SP.Ribbon.CalendarListPageComponent.registerClass('SP.Ribbon.CalendarListPageComponent', SP.Ribbon.GenericListWebPartPageComponent);
SP.Ribbon.HelpCommandNames.registerClass('SP.Ribbon.HelpCommandNames');
SP.Ribbon.HelpPageComponent.registerClass('SP.Ribbon.HelpPageComponent', CUI.Page.PageComponent);
SP.Ribbon.SaveConflictHandler.registerClass('SP.Ribbon.SaveConflictHandler');
SP.Ribbon.TrackTabPageComponent.registerClass('SP.Ribbon.TrackTabPageComponent', CUI.Page.PageComponent);
SP.Ribbon.UserInterfacePageComponent.registerClass('SP.Ribbon.UserInterfacePageComponent', CUI.Page.PageComponent);
SP.Ribbon.EMailLink.registerClass('SP.Ribbon.EMailLink');
SP.Ribbon.PageState.PageStateStrings.registerClass('SP.Ribbon.PageState.PageStateStrings');
SP.Ribbon.PageState.PageStateCommands.registerClass('SP.Ribbon.PageState.PageStateCommands');
SP.Ribbon.PageState.PageStateHandler.registerClass('SP.Ribbon.PageState.PageStateHandler', CUI.Page.PageComponent, CUI.Page.ICommandHandler);
SP.Ribbon.PageState.StateChangeDialogHandler.registerClass('SP.Ribbon.PageState.StateChangeDialogHandler');
SP.Ribbon.PageState.Handlers.registerClass('SP.Ribbon.PageState.Handlers');
SP.Ribbon.TenantAdmin.TenantAdminPageComponent.registerClass('SP.Ribbon.TenantAdmin.TenantAdminPageComponent', CUI.Page.PageComponent);
SP.BWsaConfig.defaultMaxStreamRows = 1000;
SP.BWsaConfig.defaultMaxInt32 = 4294967295;
SP.BWsaConfig.defaultRibbonStreamWidth = 8;
SP.Ticks.$1x_0 = 0;
SP.TimerResetCheck.$1c_0 = 0;
SP.StreamRowCounters.maxRowCount = 0;
SP.StreamRowCounters.maxOverwritten = 0;
SP.BWsaClient.$1J_0 = 3 * 4;
SP.Ribbon.Utility.$z_0 = null;
SP.Ribbon.UtilityInternal.$1s_0 = 0;
SP.Ribbon.UtilityInternal.$4W_0 = SP.Ribbon.UtilityInternal.$6U;
SP.Ribbon.CommandUIExtensionPageComponent.$1I_1 = null;
SP.Ribbon.CommandUIExtensionPageComponent.$25_1 = false;
SP.Ribbon.ListViewWebPartPageComponent._LibraryNavigationGroup = 'LibraryNavigationGroup';
SP.Ribbon.ListViewWebPartPageComponent.$4R_3 = new RegExp('[?&]IsDlg=1');
SP.Ribbon.ListFormWebPartPageComponent._DispFormActionsGroup = 'Ribbon.ListForm.Display.ActionsGroup';
SP.Ribbon.WikiPageComponent.$P_1 = false;
SP.Ribbon.WikiPageComponent.$S_1 = null;
SP.Ribbon.WikiPageComponent.$3_1 = null;
SP.Ribbon.WikiPageComponent.$R_1 = null;
SP.Ribbon.WikiPageComponent.$v_1 = null;
SP.Ribbon.WikiPageComponent.$1v_1 = false;
SP.Ribbon.DocLibAspxPageComponent.$3_1 = null;
SP.Ribbon.DocLibAspxPageComponent.$R_1 = null;
SP.Ribbon.WebPartComponent.$3_1 = null;
SP.Ribbon.WebPartComponent.$6P_1 = [];
SP.Ribbon.WebPartComponent.$R_1 = [ 'approveWebpartPage', 'EditInDesigner', 'EditMobileSharedPage', 'EditMobilePersonalPage', 'EditMobilePageMenuOpen', 'insertExistingList', 'insertImageWebPart', 'insertTextWebPart', 'insertWebPart', 'makeHomePage', 'MSOMenu_Close', 'MSOMenu_Delete', 'MSOMenu_Edit', 'MSOMenu_Minimize', 'MSOMenu_Restore', 'rejectWebpartPage', 'Ribbon.WebPartInsert.Tab', 'Ribbon.WebPartOption', 'Ribbon.WebPartPage', 'webPartCommands', 'WebPartContextualGroup', 'WebPartInsertContextualGroup', 'webPartInsertMedia', 'webPartInserts', 'webPartInsertText', 'webPartPageActions', 'webPartPageApproval', 'webPartPageDelete', 'webPartPageEdit', 'webPartPageEditConsole', 'webPartPageEditMenuOpen', 'webPartPageEditQuery', 'webPartPageManage', 'webPartPageStartEdit', 'webPartPageStopEdit', 'webPartProperties', 'RelatedDataToListViewGroup', 'InsertRelatedWebPartToListViewMenuAnchor', 'InsertRelatedWebPartToListView', 'GetRelatedFieldsToListViewMenuXml', 'RelatedDataToListFormGroup', 'InsertRelatedWebPartToListFormMenuAnchor', 'InsertRelatedWebPartToListForm', 'GetRelatedFieldsToListFormMenuXml', 'CommandContextChanged' ];
SP.Ribbon.PageManager.$12_2 = null;
SP.Ribbon.UsageReportPageComponent.$1u_1 = new SP.Ribbon.UsageReportPageComponent();
SP.Ribbon.HelpCommandNames.requestContextualHelp = 'RequestContextualHelp';
SP.Ribbon.HelpPageComponent.$3_1 = null;
SP.Ribbon.SaveConflictHandler.$y_0 = null;
SP.Ribbon.SaveConflictHandler.$w_0 = null;
SP.Ribbon.SaveConflictHandler.$x_0 = null;
SP.Ribbon.TrackTabPageComponent.$3_1 = null;
SP.Ribbon.TrackTabPageComponent.$1t_1 = null;
SP.Ribbon.UserInterfacePageComponent.$3_1 = null;
SP.Ribbon.EMailLink.$1p_0 = null;
SP.Ribbon.EMailLink.$1e_0 = null;
SP.Ribbon.EMailLink.$1h_0 = null;
SP.Ribbon.PageState.PageStateStrings.itemIsWebPartPageStateName = 'ItemIsWebPartPage';
SP.Ribbon.PageState.PageStateStrings.itemIsWikiPageStateName = 'ItemIsWikiPage';
SP.Ribbon.PageState.PageStateStrings.itemIsFormsPageStateName = 'ItemIsFormsPage';
SP.Ribbon.PageState.PageStateStrings.itemIsInLibraryStateName = 'ItemIsInLibrary';
SP.Ribbon.PageState.PageStateStrings.itemIsMajorVersionStateName = 'ItemIsMajorVersion';
SP.Ribbon.PageState.PageStateStrings.itemIsMinorVersionStateName = 'ItemIsMinorVersion';
SP.Ribbon.PageState.PageStateStrings.itemHasCheckedInVersionStateName = 'ItemHasCheckedInVersion';
SP.Ribbon.PageState.PageStateStrings.itemIsCheckedOutToCurrentUserStateName = 'ItemIsCheckedOutToCurrentUser';
SP.Ribbon.PageState.PageStateStrings.itemIsCheckedOutToOtherUserStateName = 'ItemIsCheckedOutToOtherUser';
SP.Ribbon.PageState.PageStateStrings.itemIsCheckedOutToSystemUserStateName = 'ItemIsCheckedOutToSystemUser';
SP.Ribbon.PageState.PageStateStrings.itemIsRejectedStateName = 'ItemIsRejected';
SP.Ribbon.PageState.PageStateStrings.itemHasWorkflowRunningStateName = 'ItemHasWorkflowRunning';
SP.Ribbon.PageState.PageStateStrings.itemIsPendingApprovalStateName = 'ItemIsPendingApproval';
SP.Ribbon.PageState.PageStateStrings.itemIsScheduledStateName = 'ItemIsScheduled';
SP.Ribbon.PageState.PageStateStrings.itemIsInPersonalViewStateName = 'ItemIsInPersonalView';
SP.Ribbon.PageState.PageStateStrings.itemIsInSharedViewStateName = 'ItemIsInSharedView';
SP.Ribbon.PageState.PageStateStrings.itemIsDefaultPageStateName = 'ItemIsDefaultPage';
SP.Ribbon.PageState.PageStateStrings.itemIsMasterPageGalleryFileStateName = 'ItemIsMasterPageGalleryFile';
SP.Ribbon.PageState.PageStateStrings.itemCancelWorkflowEnabledStateName = 'ItemCancelWorkflowEnabled';
SP.Ribbon.PageState.PageStateStrings.itemHasFieldControlsStateName = 'ItemHasFieldControls';
SP.Ribbon.PageState.PageStateStrings.itemHasPersonalizableZonesStateName = 'ItemHasPersonalizableZones';
SP.Ribbon.PageState.PageStateStrings.itemHasCustomizableZonesStateName = 'ItemHasCustomizableZones';
SP.Ribbon.PageState.PageStateStrings.userHasContributorRightsStateName = 'UserHasContributorRights';
SP.Ribbon.PageState.PageStateStrings.userHasOverrideCheckoutRightsStateName = 'UserHasOverrideCheckoutRights';
SP.Ribbon.PageState.PageStateStrings.userHasApproverRightsStateName = 'UserHasApproverRights';
SP.Ribbon.PageState.PageStateStrings.userHasDeleteRightsStateName = 'UserHasDeleteRights';
SP.Ribbon.PageState.PageStateStrings.docLibVersioningEnabledStateName = 'DocLibVersioningEnabled';
SP.Ribbon.PageState.PageStateStrings.docLibCheckoutRequiredStateName = 'DocLibCheckoutRequired';
SP.Ribbon.PageState.PageStateStrings.docLibMinorVersionsEnabledStateName = 'DocLibMinorVersionsEnabled';
SP.Ribbon.PageState.PageStateStrings.docLibApprovalEnabledStateName = 'DocLibApprovalEnabled';
SP.Ribbon.PageState.PageStateStrings.docLibWorkflowEnabledStateName = 'DocLibWorkflowEnabled';
SP.Ribbon.PageState.PageStateStrings.viewModeIsEditStateName = 'ViewModeIsEdit';
SP.Ribbon.PageState.PageStateStrings.viewModeHasSaveConflictStateName = 'ViewModeHasSaveConflict';
SP.Ribbon.PageState.PageStateStrings.viewModeIsWebPartDesignStateName = 'ViewModeIsWebPartDesign';
SP.Ribbon.PageState.PageStateStrings.save = 'Save';
SP.Ribbon.PageState.PageStateStrings.edit = 'Edit';
SP.Ribbon.PageState.PageStateStrings.saveAndStop = 'SaveAndStop';
SP.Ribbon.PageState.PageStateStrings.overrideCheckout = 'OverrideCheckout';
SP.Ribbon.PageState.PageStateStrings.checkout = 'Checkout';
SP.Ribbon.PageState.PageStateStrings.checkin = 'Checkin';
SP.Ribbon.PageState.PageStateStrings.publish = 'Publish';
SP.Ribbon.PageState.PageStateStrings.unpublish = 'Unpublish';
SP.Ribbon.PageState.PageStateStrings.submit = 'SubmitForApproval';
SP.Ribbon.PageState.PageStateStrings.cancelApproval = 'CancelApproval';
SP.Ribbon.PageState.PageStateCommands.pageStateGroupReject = 'PageStateGroupReject';
SP.Ribbon.PageState.PageStateCommands.pageStateGroupApprove = 'PageStateGroupApprove';
SP.Ribbon.PageState.PageStateCommands.pageStateGroupCancelApproval = 'PageStateGroupCancelApproval';
SP.Ribbon.PageState.PageStateCommands.pageStateGroupSubmitForApproval = 'PageStateGroupSubmitForApproval';
SP.Ribbon.PageState.PageStateCommands.pageStateGroupUnpublish = 'PageStateGroupUnpublish';
SP.Ribbon.PageState.PageStateCommands.pageStateGroupPublish = 'PageStateGroupPublish';
SP.Ribbon.PageState.PageStateCommands.pageStateGroupOverrideCheckout = 'PageStateGroupOverrideCheckout';
SP.Ribbon.PageState.PageStateCommands.pageStateGroupDiscardCheckout = 'PageStateGroupDiscardCheckout';
SP.Ribbon.PageState.PageStateCommands.pageStateGroupCheckout = 'PageStateGroupCheckout';
SP.Ribbon.PageState.PageStateCommands.pageStateGroupCheckin = 'PageStateGroupCheckin';
SP.Ribbon.PageState.PageStateCommands.pageStateGroupDontSaveAndStop = 'PageStateGroupDontSaveAndStop';
SP.Ribbon.PageState.PageStateCommands.pageStateGroupEdit = 'PageStateGroupEdit';
SP.Ribbon.PageState.PageStateCommands.pageStateGroupSaveAndStop = 'PageStateGroupSaveAndStop';
SP.Ribbon.PageState.PageStateCommands.pageStateGroupSave = 'PageStateGroupSave';
SP.Ribbon.PageState.PageStateCommands.pageStateGroupStopEditing = 'PageStateGroupStopEditing';
SP.Ribbon.PageState.PageStateHandler.$13_1 = { PageStateGroupSaveSplit: [ 'PageStateGroupSave', 'PageStateGroupSaveAndStop', 'PageStateGroupEdit', 'PageStateGroupDontSaveAndStop', 'PageStateGroupStopEditing' ], PageStateGroupCheckinSplit: [ 'PageStateGroupCheckin', 'PageStateGroupCheckout', 'PageStateGroupDiscardCheckout', 'PageStateGroupOverrideCheckout' ], PageStateGroupPublishSplit: [ 'PageStateGroupPublish', 'PageStateGroupUnpublish', 'PageStateGroupSubmitForApproval', 'PageStateGroupCancelApproval' ] };
SP.Ribbon.PageState.PageStateHandler.$c_1 = null;
SP.Ribbon.PageState.PageStateHandler.$1Z_1 = true;
SP.Ribbon.PageState.PageStateHandler.$C_1 = [];
SP.Ribbon.PageState.PageStateHandler.$2b_1 = SP.Ribbon.PageState.PageStateHandler.saveBeforeNavigate;
SP.Ribbon.PageState.PageStateHandler.$2a_1 = SP.Ribbon.PageState.PageStateHandler.$6H_1;
SP.Ribbon.PageState.PageStateHandler.$1H_1 = false;
SP.Ribbon.PageState.PageStateHandler.ignoreNextUnload = false;
SP.Ribbon.PageState.PageStateHandler.saveCallbackError = null;
SP.Ribbon.PageState.Handlers.$1z_0 = new Array(0);
SP.Ribbon.PageState.Handlers.$L_0 = null;
SP.Ribbon.PageState.Handlers.$2d_0 = null;
SP.Ribbon.PageState.Handlers.$20_0 = null;
SP.Ribbon.PageState.Handlers.$1y_0 = null;
SP.Ribbon.PageState.Handlers.$2e_0 = null;
SP.Ribbon.PageState.Handlers.$Q_0 = null;
SP.Ribbon.TenantAdmin.TenantAdminPageComponent.$1u_1 = new SP.Ribbon.TenantAdmin.TenantAdminPageComponent();

SP.Ribbon.NativeUtility = function SP_Ribbon_nativeUtility()
{
};

SP.Ribbon.NativeUtility.getCtxForView = function SP_Ribbon__nativeUtility$GetCtxForView(id)
{ULSMg8:;
	var ctx = g_ViewIdToViewCounterMap[id];
	if (typeof(ctx) != "undefined" && ctx != null)
            return window["ctx" + ctx];
	return null;
};

SP.Ribbon.NativeUtility.executeClickScript = function SP_Ribbon__nativeUtility$executeClickScript(script, viewId)
{ULSMg8:;
    // We have to hack these away because we are now executing the onclick in the global context
    // so a return statement is not valid.
	script = script.replace(/javascript:return false/g,'');
	script = script.replace(/return false/g,'');
	var currentCtxId = g_ViewIdToViewCounterMap[viewId];
    var strCode = "var event = new Object(); event.fromRibbon=true; ";
    if (!SP.ScriptUtility.isNullOrUndefined(currentCtxId))
        strCode += "event.currentCtx = eval('ctx' + currentCtxId); ";
    eval(strCode + script + ";");	
};

SP.Ribbon.NativeUtility.executeClickScriptSimple = function SP_Ribbon__nativeUtility$executeClickScriptSimple(script)
{ULSMg8:;
   script = script.replace(/javascript:return false/g,'');
   script = script.replace(/return false/g,'');
   eval(script);	
};


SP.Ribbon.NativeUtility.createXMLDocFromString = CUI.NativeUtility.createXMLDocFromString;

SP.Ribbon.NativeUtility.createXMLDocFromStringCore = CUI.NativeUtility.createXMLDocFromStringCore;

SP.Ribbon.NativeUtility.getWSA = function SP_Ribbon__nativeUtility$GetWSA() {ULSMg8:;
  return GetWSA();
};

SP.Ribbon.NativeUtility.addCommandStreamToWSA = function SP_Ribbon__nativeUtility$AddCommandStreamToWSA(commandInfo, startTime, duration) {ULSMg8:;
  if (typeof(commandInfo) == "undefined" || !commandInfo)
      return;
 
  // For alpha, we just completely avoid creating the WSA object if bsqm is disabled.
  if (!WSAEnabled())
      return;

  var thewsa = GetWSA();
  if (!thewsa)
      return;
      
  // Get the command id of the command that was executed in the ribbon
  var dwCommand = 0;
  if (commandInfo.CommandId)
      dwCommand = SP.Ribbon.SQMUtility.calcActionId(commandInfo.CommandId);
  else
      return;  // If there is not command we exit.
  
  // Get the tab id of the currently open tab
  var dwTabId = 0;
  if (commandInfo.TabId)
      dwTabId = SP.Ribbon.SQMUtility.calcActionId(commandInfo.TabId);
  
  var uiLocation = SP.BWsaClient.getSQMLocationFromCUICommandInfo(commandInfo);
  
  // If we have an unknown ui location, then we return at this point
  // REVIEW(JosefL) should we record or return here?
  if (uiLocation == 0)
      return;

  // If we are on a page of a specific list then we record this as the component name
  // long term we would actually like to capture what component or web part actually
  // has focus (listview, webpart, rte etc.) but for now we simply use the main list
  // of this page.
  var dwComponentType = 0;
  var dwComponentId = 0;
  if (g_wsaListTemplateId)
  {  
      // 1 means list view web part
      dwComponentType = 1;      
      dwComponentId = g_wsaListTemplateId;      
  }
  
  // The ui mode and method are always "unknown" because we cannot easily distinguish
  // between clicks and keyboard executions of commands.
  // The structure of the commandInfo Dword in the SQM data point is as follows:
  // 1. 5 bits UIMethod
  // 2. 4 bits Mode
  // 3. 7 bits UILocation
  // 4. 5 bits ComponentType
  // 5. 11 bits Unused
  // Please see JPruitt's ribbon sqm spec for information about all the values.
  var dwCommandInfo = (0 << 0) + (0 << 5) + (uiLocation << 9) + (dwComponentType << 16);  

  thewsa.addToStreamDw8(8327,
                        dwCommandInfo,
                        dwTabId,
                        dwCommand,
                        dwComponentId,
                        startTime,
                        duration,
                        0, 0);
};

SP.Ribbon.NativeUtility.ffClick = function SP_Ribbon__nativeUtility$FFClick(elm) {ULSMg8:;
  var evt = document.createEvent("MouseEvents");
  evt.initMouseEvent("click", true, true, window,
    0, 0, 0, 0, 0, false, false, false, false, 0, null);
  elm.dispatchEvent(evt);
};

SP.Ribbon.NativeUtility.executeECBCommand = function SP_Ribbon__nativeUtility$executeECBCommand(code, myctx) {ULSMg8:;
	eval("var event = new Object();event.fromRibbon = true; event.currentCtx = myctx;" + code + ";");
};

if( typeof(Sys) != "undefined" && Sys && Sys.Application ){
   Sys.Application.notifyScriptLoaded();
}
function DeselectWpWz()
{ULSMg8:;
	var instance = SP.Ribbon.WebPartComponent.get_instance();
	if (instance)
	{
		instance.deselectWebPartAndZone(null, null);
	}
}
function SelectWp(p)
{ULSMg8:;
	var instance = SP.Ribbon.WebPartComponent.get_instance();
	if (instance)
	{
		instance.selectWebPart(p, true);
	}
}
function SelectWz(p, zid)
{ULSMg8:;
	var instance = SP.Ribbon.WebPartComponent.get_instance();
	if (instance)
	{
		instance.selectWebPartZone(p, zid);
	}
}
function ChangeWikiPageMode(editMode)
{ULSMg8:;
	var instance = SP.Ribbon.WikiPageComponent.get_instance();
	if (instance)
	{
		instance.changeWikiPageMode(editMode);
	}
}
function showSaveConflictDialog(lastModifiedUserId, continueStatusHtml, mergeChangesUrl, mergeChangesStatusHtml, discardScript, overwriteScript)
{ULSMg8:;
	var ret = SP.Ribbon.SaveConflictHandler.showSaveConflictDialog(
		lastModifiedUserId, 
		continueStatusHtml, 
		mergeChangesUrl, 
		mergeChangesStatusHtml, 
		discardScript, 
		overwriteScript);
	return ret;
}
var ribbon = {
	SelectWp: SelectWp,
	SelectWz: SelectWz,
        DeselectWpWz: DeselectWpWz,
	ChangeWikiPageMode: ChangeWikiPageMode,
	showSaveConflictDialog: showSaveConflictDialog
};

function WSAEnabled()
{ULSMg8:;
    return typeof(g_wsaEnabled) != "undefined" && g_wsaEnabled;
}

function SendWSA()
{ULSMg8:;
    try
    {
        if (WSAEnabled())
        {
            g_thewsa.uploadWsaData();
        }
    }
    catch(e)
    {
    }
}

/*
        The stream ids are defined in %OTOOLS%\inc\sqm\browserwsaclient.cs
		DATAID_BSQM_COMMANDUIACTION = 8327,
*/

function GetWSA()
{ULSMg8:;
    if (typeof(g_thewsa) == "undefined" || !g_thewsa)
    {
        if (SP)
        {
            if (SP.BWsaClient)
            {
                if (!WSAEnabled())
                    g_wsaEnabled=false;
                
                g_thewsa = new SP.BWsaClient("/_layouts/WsaUpload.ashx", g_wsaEnabled);
                var wsa = g_thewsa;

                // Create the stream for the commands that happen during the session ie "Bold" etc.
                wsa.createStream(8327, 1, 8, 200);

                // Set the page type to "WSS"
                wsa.addCommonDatapoint(59);
                wsa.setDw(59, 89);

                // The page type.  We put a hash of the webtemplate name in here.
                // SPWeb Template Id

                if (g_wsaSiteTemplateId)
                {
                    wsa.addCommonDatapoint(8492);
                    wsa.setDw(8492, SP.Ribbon.SQMUtility.calcActionId(g_wsaSiteTemplateId));
                }

                // Add the LCID datapoint for browser locale
                // This is actually the LCID of the page that was rendered and not the 
                // browser locale.
                if (g_wsaLCID)
                {
                    wsa.addCommonDatapoint(8491);
                    wsa.setDw(8491, g_wsaLCID);
                }
                
                // Add a a listener so that we can send the SQM data to the server before we unload
                // the page.
                if (typeof(addEventListener) != "undefined")
                    addEventListener("beforeunload", SendWSA, false);
                else
                    attachEvent("onbeforeunload", SendWSA);
            }
        }
    }
    return g_thewsa;
}

if( typeof(Sys) != "undefined" && Sys && Sys.Application ){
   Sys.Application.notifyScriptLoaded();
}
if(typeof(NotifyScriptLoadedAndExecuteWaitingJobs) == "function"){
    NotifyScriptLoadedAndExecuteWaitingJobs("sp.ribbon.js");
}

SP.Ribbon.TrackTabPageComponent.registerWithPageManager();
