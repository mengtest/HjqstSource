﻿-- AutoGenerate, Do not Edit!
local t = {}
local indexs={
'id','type','param1','param2','param3'
}

t.t = {
	[1]={'1','0','1','10','9:0:98:0'},
	[2]={'2','0','11','30','9:0:88:0'},
	[3]={'3','0','31','50','9:0:78:0'},
	[4]={'4','0','51','100','9:0:68:0'},
	[5]={'5','0','101','99999','9:0:58:0'},
	[6]={'6','1','1','10','9:0:880:0'},
	[7]={'7','1','11','30','9:0:720:0'},
	[8]={'8','1','31','50','9:0:690:0'},
	[9]={'9','1','51','100','9:0:610:0'},
	[10]={'10','1','101','99999','9:0:530:0'},
	[11]={'11','2','1','4:10601:2:0','3284'},
	[12]={'12','2','2','4:10350:2:0','267'},
	[13]={'13','2','3','4:50991:20:0','2945'},
	[14]={'14','2','4','2:149:1:1','26'},
	[15]={'15','2','5','8:0:10000:0','2677'},
	[16]={'16','2','6','4:20003:1:0','267'},
	[17]={'17','2','7','4:40002:1:0','267'},
	[18]={'18','2','8','4:51490:2:0','267'},
	[19]={'19','3','1','1','4:51490:40:0'},
	[20]={'20','3','2','3','4:51490:20:0'},
	[21]={'21','3','4','10','4:51490:10:0'},
	[22]={'22','3','11','20','4:51490:5:0'},
	[23]={'23','3','21','50','4:51490:2:0'}
}

function t.ForEach(func)
	if not func then return end
	local ky = nil
	local v = nil
	for i,j in pairs(t.t) do
		local r={}
		ky=tonumber(i)
		for k=1,#indexs do
			v=indexs[k]
			if v and v ~= '' then
				r[v]=j[k]
			end
		end

		if ky then func(ky,r) 
		else func(i,r) end
	end
end

function t.GetItem(id)
	id=tostring(id)
    local item=t[id]
	if item then return item end
	item=t.t[id]
	local result = {}
	local v = nil
	for i=1,#indexs do
		v=indexs[i]
		if v and v ~= '' then
			result[v]=item[i]
		end
	end
	t[id]=result
	return result
end

return t
