-- Generated By protoc-gen-lua Do not Edit
local protobuf = require "protobuf"
module('mail_pb')


local MAILPROTODATA = protobuf.Descriptor();
local MAILPROTODATA_ID_FIELD = protobuf.FieldDescriptor();
local MAILPROTODATA_STATE_FIELD = protobuf.FieldDescriptor();
local MAILPROTODATA_MAILNO_FIELD = protobuf.FieldDescriptor();
local MAILPROTODATA_PICPATH_FIELD = protobuf.FieldDescriptor();
local MAILPROTODATA_HEADPARAMS_FIELD = protobuf.FieldDescriptor();
local MAILPROTODATA_CONTENTPARAMS_FIELD = protobuf.FieldDescriptor();
local MAILPROTODATA_CREATETIME_FIELD = protobuf.FieldDescriptor();
local MAILPROTODATA_ATTACHMENT_FIELD = protobuf.FieldDescriptor();
local MAILREQ = protobuf.Descriptor();
local MAILRESP = protobuf.Descriptor();
local MAILRESP_MAILS_FIELD = protobuf.FieldDescriptor();
local MAILATTACHMENTREQ = protobuf.Descriptor();
local MAILATTACHMENTREQ_ISGETALL_FIELD = protobuf.FieldDescriptor();
local MAILATTACHMENTREQ_MAILID_FIELD = protobuf.FieldDescriptor();
local MAILATTACHMENTRESP = protobuf.Descriptor();
local MAILATTACHMENTRESP_ISGETALL_FIELD = protobuf.FieldDescriptor();
local MAILDELREQ = protobuf.Descriptor();
local MAILDELREQ_ISDELALL_FIELD = protobuf.FieldDescriptor();
local MAILDELREQ_MAILID_FIELD = protobuf.FieldDescriptor();
local MAILDELRESP = protobuf.Descriptor();
local MAILSYNRESP = protobuf.Descriptor();
local MAILSYNRESP_NEWMAILS_FIELD = protobuf.FieldDescriptor();
local MAILSYNRESP_UPDATEMAILS_FIELD = protobuf.FieldDescriptor();
local MAILSYNRESP_DELMAILS_FIELD = protobuf.FieldDescriptor();

MAILPROTODATA_ID_FIELD.name = "id"
MAILPROTODATA_ID_FIELD.full_name = ".mail.MailProtoData.id"
MAILPROTODATA_ID_FIELD.number = 1
MAILPROTODATA_ID_FIELD.index = 0
MAILPROTODATA_ID_FIELD.label = 2
MAILPROTODATA_ID_FIELD.has_default_value = false
MAILPROTODATA_ID_FIELD.default_value = 0
MAILPROTODATA_ID_FIELD.type = 5
MAILPROTODATA_ID_FIELD.cpp_type = 1

MAILPROTODATA_STATE_FIELD.name = "state"
MAILPROTODATA_STATE_FIELD.full_name = ".mail.MailProtoData.state"
MAILPROTODATA_STATE_FIELD.number = 2
MAILPROTODATA_STATE_FIELD.index = 1
MAILPROTODATA_STATE_FIELD.label = 1
MAILPROTODATA_STATE_FIELD.has_default_value = true
MAILPROTODATA_STATE_FIELD.default_value = 0
MAILPROTODATA_STATE_FIELD.type = 5
MAILPROTODATA_STATE_FIELD.cpp_type = 1

MAILPROTODATA_MAILNO_FIELD.name = "mailNo"
MAILPROTODATA_MAILNO_FIELD.full_name = ".mail.MailProtoData.mailNo"
MAILPROTODATA_MAILNO_FIELD.number = 3
MAILPROTODATA_MAILNO_FIELD.index = 2
MAILPROTODATA_MAILNO_FIELD.label = 1
MAILPROTODATA_MAILNO_FIELD.has_default_value = false
MAILPROTODATA_MAILNO_FIELD.default_value = 0
MAILPROTODATA_MAILNO_FIELD.type = 5
MAILPROTODATA_MAILNO_FIELD.cpp_type = 1

MAILPROTODATA_PICPATH_FIELD.name = "picPath"
MAILPROTODATA_PICPATH_FIELD.full_name = ".mail.MailProtoData.picPath"
MAILPROTODATA_PICPATH_FIELD.number = 4
MAILPROTODATA_PICPATH_FIELD.index = 3
MAILPROTODATA_PICPATH_FIELD.label = 1
MAILPROTODATA_PICPATH_FIELD.has_default_value = false
MAILPROTODATA_PICPATH_FIELD.default_value = ""
MAILPROTODATA_PICPATH_FIELD.type = 9
MAILPROTODATA_PICPATH_FIELD.cpp_type = 9

MAILPROTODATA_HEADPARAMS_FIELD.name = "headParams"
MAILPROTODATA_HEADPARAMS_FIELD.full_name = ".mail.MailProtoData.headParams"
MAILPROTODATA_HEADPARAMS_FIELD.number = 5
MAILPROTODATA_HEADPARAMS_FIELD.index = 4
MAILPROTODATA_HEADPARAMS_FIELD.label = 3
MAILPROTODATA_HEADPARAMS_FIELD.has_default_value = false
MAILPROTODATA_HEADPARAMS_FIELD.default_value = {}
MAILPROTODATA_HEADPARAMS_FIELD.type = 9
MAILPROTODATA_HEADPARAMS_FIELD.cpp_type = 9

MAILPROTODATA_CONTENTPARAMS_FIELD.name = "contentParams"
MAILPROTODATA_CONTENTPARAMS_FIELD.full_name = ".mail.MailProtoData.contentParams"
MAILPROTODATA_CONTENTPARAMS_FIELD.number = 6
MAILPROTODATA_CONTENTPARAMS_FIELD.index = 5
MAILPROTODATA_CONTENTPARAMS_FIELD.label = 3
MAILPROTODATA_CONTENTPARAMS_FIELD.has_default_value = false
MAILPROTODATA_CONTENTPARAMS_FIELD.default_value = {}
MAILPROTODATA_CONTENTPARAMS_FIELD.type = 9
MAILPROTODATA_CONTENTPARAMS_FIELD.cpp_type = 9

MAILPROTODATA_CREATETIME_FIELD.name = "createTime"
MAILPROTODATA_CREATETIME_FIELD.full_name = ".mail.MailProtoData.createTime"
MAILPROTODATA_CREATETIME_FIELD.number = 7
MAILPROTODATA_CREATETIME_FIELD.index = 6
MAILPROTODATA_CREATETIME_FIELD.label = 1
MAILPROTODATA_CREATETIME_FIELD.has_default_value = false
MAILPROTODATA_CREATETIME_FIELD.default_value = 0
MAILPROTODATA_CREATETIME_FIELD.type = 3
MAILPROTODATA_CREATETIME_FIELD.cpp_type = 2

MAILPROTODATA_ATTACHMENT_FIELD.name = "attachment"
MAILPROTODATA_ATTACHMENT_FIELD.full_name = ".mail.MailProtoData.attachment"
MAILPROTODATA_ATTACHMENT_FIELD.number = 8
MAILPROTODATA_ATTACHMENT_FIELD.index = 7
MAILPROTODATA_ATTACHMENT_FIELD.label = 1
MAILPROTODATA_ATTACHMENT_FIELD.has_default_value = false
MAILPROTODATA_ATTACHMENT_FIELD.default_value = ""
MAILPROTODATA_ATTACHMENT_FIELD.type = 9
MAILPROTODATA_ATTACHMENT_FIELD.cpp_type = 9

MAILPROTODATA.name = "MailProtoData"
MAILPROTODATA.full_name = ".mail.MailProtoData"
MAILPROTODATA.nested_types = {}
MAILPROTODATA.enum_types = {}
MAILPROTODATA.fields = {MAILPROTODATA_ID_FIELD, MAILPROTODATA_STATE_FIELD, MAILPROTODATA_MAILNO_FIELD, MAILPROTODATA_PICPATH_FIELD, MAILPROTODATA_HEADPARAMS_FIELD, MAILPROTODATA_CONTENTPARAMS_FIELD, MAILPROTODATA_CREATETIME_FIELD, MAILPROTODATA_ATTACHMENT_FIELD}
MAILPROTODATA.is_extendable = false
MAILPROTODATA.extensions = {}
MAILREQ.name = "MailReq"
MAILREQ.full_name = ".mail.MailReq"
MAILREQ.nested_types = {}
MAILREQ.enum_types = {}
MAILREQ.fields = {}
MAILREQ.is_extendable = false
MAILREQ.extensions = {}
MAILRESP_MAILS_FIELD.name = "mails"
MAILRESP_MAILS_FIELD.full_name = ".mail.MailResp.mails"
MAILRESP_MAILS_FIELD.number = 1
MAILRESP_MAILS_FIELD.index = 0
MAILRESP_MAILS_FIELD.label = 3
MAILRESP_MAILS_FIELD.has_default_value = false
MAILRESP_MAILS_FIELD.default_value = {}
MAILRESP_MAILS_FIELD.message_type = MAILPROTODATA
MAILRESP_MAILS_FIELD.type = 11
MAILRESP_MAILS_FIELD.cpp_type = 10

MAILRESP.name = "MailResp"
MAILRESP.full_name = ".mail.MailResp"
MAILRESP.nested_types = {}
MAILRESP.enum_types = {}
MAILRESP.fields = {MAILRESP_MAILS_FIELD}
MAILRESP.is_extendable = false
MAILRESP.extensions = {}
MAILATTACHMENTREQ_ISGETALL_FIELD.name = "isGetAll"
MAILATTACHMENTREQ_ISGETALL_FIELD.full_name = ".mail.MailAttachmentReq.isGetAll"
MAILATTACHMENTREQ_ISGETALL_FIELD.number = 1
MAILATTACHMENTREQ_ISGETALL_FIELD.index = 0
MAILATTACHMENTREQ_ISGETALL_FIELD.label = 1
MAILATTACHMENTREQ_ISGETALL_FIELD.has_default_value = false
MAILATTACHMENTREQ_ISGETALL_FIELD.default_value = false
MAILATTACHMENTREQ_ISGETALL_FIELD.type = 8
MAILATTACHMENTREQ_ISGETALL_FIELD.cpp_type = 7

MAILATTACHMENTREQ_MAILID_FIELD.name = "mailId"
MAILATTACHMENTREQ_MAILID_FIELD.full_name = ".mail.MailAttachmentReq.mailId"
MAILATTACHMENTREQ_MAILID_FIELD.number = 2
MAILATTACHMENTREQ_MAILID_FIELD.index = 1
MAILATTACHMENTREQ_MAILID_FIELD.label = 1
MAILATTACHMENTREQ_MAILID_FIELD.has_default_value = false
MAILATTACHMENTREQ_MAILID_FIELD.default_value = 0
MAILATTACHMENTREQ_MAILID_FIELD.type = 5
MAILATTACHMENTREQ_MAILID_FIELD.cpp_type = 1

MAILATTACHMENTREQ.name = "MailAttachmentReq"
MAILATTACHMENTREQ.full_name = ".mail.MailAttachmentReq"
MAILATTACHMENTREQ.nested_types = {}
MAILATTACHMENTREQ.enum_types = {}
MAILATTACHMENTREQ.fields = {MAILATTACHMENTREQ_ISGETALL_FIELD, MAILATTACHMENTREQ_MAILID_FIELD}
MAILATTACHMENTREQ.is_extendable = false
MAILATTACHMENTREQ.extensions = {}
MAILATTACHMENTRESP_ISGETALL_FIELD.name = "isGetAll"
MAILATTACHMENTRESP_ISGETALL_FIELD.full_name = ".mail.MailAttachmentResp.isGetAll"
MAILATTACHMENTRESP_ISGETALL_FIELD.number = 1
MAILATTACHMENTRESP_ISGETALL_FIELD.index = 0
MAILATTACHMENTRESP_ISGETALL_FIELD.label = 1
MAILATTACHMENTRESP_ISGETALL_FIELD.has_default_value = false
MAILATTACHMENTRESP_ISGETALL_FIELD.default_value = false
MAILATTACHMENTRESP_ISGETALL_FIELD.type = 8
MAILATTACHMENTRESP_ISGETALL_FIELD.cpp_type = 7

MAILATTACHMENTRESP.name = "MailAttachmentResp"
MAILATTACHMENTRESP.full_name = ".mail.MailAttachmentResp"
MAILATTACHMENTRESP.nested_types = {}
MAILATTACHMENTRESP.enum_types = {}
MAILATTACHMENTRESP.fields = {MAILATTACHMENTRESP_ISGETALL_FIELD}
MAILATTACHMENTRESP.is_extendable = false
MAILATTACHMENTRESP.extensions = {}
MAILDELREQ_ISDELALL_FIELD.name = "isDelAll"
MAILDELREQ_ISDELALL_FIELD.full_name = ".mail.MailDelReq.isDelAll"
MAILDELREQ_ISDELALL_FIELD.number = 1
MAILDELREQ_ISDELALL_FIELD.index = 0
MAILDELREQ_ISDELALL_FIELD.label = 1
MAILDELREQ_ISDELALL_FIELD.has_default_value = false
MAILDELREQ_ISDELALL_FIELD.default_value = false
MAILDELREQ_ISDELALL_FIELD.type = 8
MAILDELREQ_ISDELALL_FIELD.cpp_type = 7

MAILDELREQ_MAILID_FIELD.name = "mailId"
MAILDELREQ_MAILID_FIELD.full_name = ".mail.MailDelReq.mailId"
MAILDELREQ_MAILID_FIELD.number = 2
MAILDELREQ_MAILID_FIELD.index = 1
MAILDELREQ_MAILID_FIELD.label = 1
MAILDELREQ_MAILID_FIELD.has_default_value = false
MAILDELREQ_MAILID_FIELD.default_value = 0
MAILDELREQ_MAILID_FIELD.type = 5
MAILDELREQ_MAILID_FIELD.cpp_type = 1

MAILDELREQ.name = "MailDelReq"
MAILDELREQ.full_name = ".mail.MailDelReq"
MAILDELREQ.nested_types = {}
MAILDELREQ.enum_types = {}
MAILDELREQ.fields = {MAILDELREQ_ISDELALL_FIELD, MAILDELREQ_MAILID_FIELD}
MAILDELREQ.is_extendable = false
MAILDELREQ.extensions = {}
MAILDELRESP.name = "MailDelResp"
MAILDELRESP.full_name = ".mail.MailDelResp"
MAILDELRESP.nested_types = {}
MAILDELRESP.enum_types = {}
MAILDELRESP.fields = {}
MAILDELRESP.is_extendable = false
MAILDELRESP.extensions = {}
MAILSYNRESP_NEWMAILS_FIELD.name = "newMails"
MAILSYNRESP_NEWMAILS_FIELD.full_name = ".mail.MailSynResp.newMails"
MAILSYNRESP_NEWMAILS_FIELD.number = 1
MAILSYNRESP_NEWMAILS_FIELD.index = 0
MAILSYNRESP_NEWMAILS_FIELD.label = 3
MAILSYNRESP_NEWMAILS_FIELD.has_default_value = false
MAILSYNRESP_NEWMAILS_FIELD.default_value = {}
MAILSYNRESP_NEWMAILS_FIELD.message_type = MAILPROTODATA
MAILSYNRESP_NEWMAILS_FIELD.type = 11
MAILSYNRESP_NEWMAILS_FIELD.cpp_type = 10

MAILSYNRESP_UPDATEMAILS_FIELD.name = "updateMails"
MAILSYNRESP_UPDATEMAILS_FIELD.full_name = ".mail.MailSynResp.updateMails"
MAILSYNRESP_UPDATEMAILS_FIELD.number = 2
MAILSYNRESP_UPDATEMAILS_FIELD.index = 1
MAILSYNRESP_UPDATEMAILS_FIELD.label = 3
MAILSYNRESP_UPDATEMAILS_FIELD.has_default_value = false
MAILSYNRESP_UPDATEMAILS_FIELD.default_value = {}
MAILSYNRESP_UPDATEMAILS_FIELD.message_type = MAILPROTODATA
MAILSYNRESP_UPDATEMAILS_FIELD.type = 11
MAILSYNRESP_UPDATEMAILS_FIELD.cpp_type = 10

MAILSYNRESP_DELMAILS_FIELD.name = "delMails"
MAILSYNRESP_DELMAILS_FIELD.full_name = ".mail.MailSynResp.delMails"
MAILSYNRESP_DELMAILS_FIELD.number = 3
MAILSYNRESP_DELMAILS_FIELD.index = 2
MAILSYNRESP_DELMAILS_FIELD.label = 3
MAILSYNRESP_DELMAILS_FIELD.has_default_value = false
MAILSYNRESP_DELMAILS_FIELD.default_value = {}
MAILSYNRESP_DELMAILS_FIELD.type = 5
MAILSYNRESP_DELMAILS_FIELD.cpp_type = 1

MAILSYNRESP.name = "MailSynResp"
MAILSYNRESP.full_name = ".mail.MailSynResp"
MAILSYNRESP.nested_types = {}
MAILSYNRESP.enum_types = {}
MAILSYNRESP.fields = {MAILSYNRESP_NEWMAILS_FIELD, MAILSYNRESP_UPDATEMAILS_FIELD, MAILSYNRESP_DELMAILS_FIELD}
MAILSYNRESP.is_extendable = false
MAILSYNRESP.extensions = {}

MailAttachmentReq = protobuf.Message(MAILATTACHMENTREQ)
MailAttachmentResp = protobuf.Message(MAILATTACHMENTRESP)
MailDelReq = protobuf.Message(MAILDELREQ)
MailDelResp = protobuf.Message(MAILDELRESP)
MailProtoData = protobuf.Message(MAILPROTODATA)
MailReq = protobuf.Message(MAILREQ)
MailResp = protobuf.Message(MAILRESP)
MailSynResp = protobuf.Message(MAILSYNRESP)
