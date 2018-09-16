using System.Collections.Generic;
using Newtonsoft.Json;
namespace PddOpenSdk.Models.PddApiResponse
{
    public partial class QueryInvoiceApplicationResponseModel : PddResponseModel
    {
        /// <summary>
/// response
/// </summary>
[JsonProperty("invoice_application_query_response")]
public object InvoiceApplicationQueryResponse {get;set;}
/// <summary>
/// 发票申请列表
/// </summary>
[JsonProperty("invoice_application_list")]
public object InvoiceApplicationList {get;set;}
/// <summary>
/// 修改时间
/// </summary>
[JsonProperty("gmt_modified")]
public int GmtModified {get;set;}
/// <summary>
/// 创建时间
/// </summary>
[JsonProperty("gmt_create")]
public object GmtCreate {get;set;}
/// <summary>
/// 备注
/// </summary>
[JsonProperty("memo")]
public object Memo {get;set;}
/// <summary>
/// 驳回原因
/// </summary>
[JsonProperty("reason")]
public object Reason {get;set;}
/// <summary>
/// 总税额，暂为null
/// </summary>
[JsonProperty("sum_tax")]
public object SumTax {get;set;}
/// <summary>
/// 税率，暂为null
/// </summary>
[JsonProperty("tax_rate")]
public object TaxRate {get;set;}
/// <summary>
/// 不含税金额，暂为null
/// </summary>
[JsonProperty("sum_price")]
public object SumPrice {get;set;}
/// <summary>
/// 开票金额，暂为null，取买家实付
/// </summary>
[JsonProperty("invoice_amount")]
public object InvoiceAmount {get;set;}
/// <summary>
/// 发票类型：0-蓝票，1-红票；目前只支持0
/// </summary>
[JsonProperty("invoice_type")]
public int InvoiceType {get;set;}
/// <summary>
/// 发票种类：0-电子，1-纸质，2-专票；目前只支持0
/// </summary>
[JsonProperty("invoice_kind")]
public int InvoiceKind {get;set;}
/// <summary>
/// 企业税号，抬头为企业类型必填
/// </summary>
[JsonProperty("payer_register_no")]
public object PayerRegisterNo {get;set;}
/// <summary>
/// 发票抬头
/// </summary>
[JsonProperty("payer_name")]
public object PayerName {get;set;}
/// <summary>
/// 抬头类型：0-个人，1-企业
/// </summary>
[JsonProperty("business_type")]
public int BusinessType {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public int MallId {get;set;}
/// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}
/// <summary>
/// 开票申请触发类型：1-申请开票，2-改抬头，3电换纸；目前只支持1
/// </summary>
[JsonProperty("trigger_status")]
public int TriggerStatus {get;set;}
/// <summary>
/// 申请状态：0-已拒绝，1-申请中，2-已同意
/// </summary>
[JsonProperty("application_status")]
public int ApplicationStatus {get;set;}
/// <summary>
/// 申请流水号
/// </summary>
[JsonProperty("application_id")]
public object ApplicationId {get;set;}

    public partial class InvoiceApplicationQueryResponseResponseModel : PddResponseModel
    {
        /// <summary>
/// 发票申请列表
/// </summary>
[JsonProperty("invoice_application_list")]
public object InvoiceApplicationList {get;set;}

}

    public partial class InvoiceApplicationListResponseModel : PddResponseModel
    {
        /// <summary>
/// 修改时间
/// </summary>
[JsonProperty("gmt_modified")]
public int GmtModified {get;set;}
/// <summary>
/// 创建时间
/// </summary>
[JsonProperty("gmt_create")]
public object GmtCreate {get;set;}
/// <summary>
/// 备注
/// </summary>
[JsonProperty("memo")]
public object Memo {get;set;}
/// <summary>
/// 驳回原因
/// </summary>
[JsonProperty("reason")]
public object Reason {get;set;}
/// <summary>
/// 总税额，暂为null
/// </summary>
[JsonProperty("sum_tax")]
public object SumTax {get;set;}
/// <summary>
/// 税率，暂为null
/// </summary>
[JsonProperty("tax_rate")]
public object TaxRate {get;set;}
/// <summary>
/// 不含税金额，暂为null
/// </summary>
[JsonProperty("sum_price")]
public object SumPrice {get;set;}
/// <summary>
/// 开票金额，暂为null，取买家实付
/// </summary>
[JsonProperty("invoice_amount")]
public object InvoiceAmount {get;set;}
/// <summary>
/// 发票类型：0-蓝票，1-红票；目前只支持0
/// </summary>
[JsonProperty("invoice_type")]
public int InvoiceType {get;set;}
/// <summary>
/// 发票种类：0-电子，1-纸质，2-专票；目前只支持0
/// </summary>
[JsonProperty("invoice_kind")]
public int InvoiceKind {get;set;}
/// <summary>
/// 企业税号，抬头为企业类型必填
/// </summary>
[JsonProperty("payer_register_no")]
public object PayerRegisterNo {get;set;}
/// <summary>
/// 发票抬头
/// </summary>
[JsonProperty("payer_name")]
public object PayerName {get;set;}
/// <summary>
/// 抬头类型：0-个人，1-企业
/// </summary>
[JsonProperty("business_type")]
public int BusinessType {get;set;}
/// <summary>
/// 店铺id
/// </summary>
[JsonProperty("mall_id")]
public int MallId {get;set;}
/// <summary>
/// 订单号
/// </summary>
[JsonProperty("order_sn")]
public object OrderSn {get;set;}
/// <summary>
/// 开票申请触发类型：1-申请开票，2-改抬头，3电换纸；目前只支持1
/// </summary>
[JsonProperty("trigger_status")]
public int TriggerStatus {get;set;}
/// <summary>
/// 申请状态：0-已拒绝，1-申请中，2-已同意
/// </summary>
[JsonProperty("application_status")]
public int ApplicationStatus {get;set;}
/// <summary>
/// 申请流水号
/// </summary>
[JsonProperty("application_id")]
public object ApplicationId {get;set;}

}

}
}