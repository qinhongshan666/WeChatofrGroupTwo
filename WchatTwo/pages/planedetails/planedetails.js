// pages/planedetails/planedetails.js
//获取应用实例
const app = getApp();

Page({

  /**
   * 页面的初始数据
   */
  data: {
    ticket: 1,
    totalsum: '',
    phone: '',
    unitPrice: '',
    leaveCity: '',
    arriveCity: '',
    leaveDate: '',
    leaveTime: '',
    typeID: '',
    inventory: '',
    arriveTime: '',
    orderState: 0,
  },

  /**
   * 生命周期函数--监听页面加载
   */
  onLoad: function (options) {

    var id = options.planeid;
    var that = this;

    wx.request({
      url: 'http://localhost:61984/api/Plane/GetPlane', // 仅为示例，并非真实的接口地址
      method: 'GET',
      data: {
        id: id
      },
      success(res) {
        var list = res.data;
        that.setData({
          unitPrice: list.UnitPrice,
          leaveCity: list.LeaveCity,
          arriveCity: list.ArriveCity,
          arriveTime: list.ArriveTime,
          inventory: list.Inventory,
          leaveDate: list.LeaveDate,
          leaveTime: list.LeaveTime,
          typeID: list.TypeID,
          totalsum: list.UnitPrice,
        })
      }
    })
  },
  //订单支付
  toPay: function () {
    var that = this.data;
    var username = app.globalData.userInfo;

    wx.request({
      url: 'http://localhost:61984/api/Plane/AddPlaneOrder', // 仅为示例，并非真实的接口地址
      method: 'post',
      data: {
        OrderUnitPrice: that.unitPrice,
        OrderLeaveCity: that.leaveCity,
        OrderArriveCity: that.arriveCity,
        OrderArriveTime: that.arriveTime,
        OrderLeaveDate: that.leaveDate,
        OrderLeaveTime: that.leaveTime,
        OrderTypeID: that.typeID,
        OrderTotalsum: that.totalsum,
        OrderTicket: that.ticket,
        OrderPhone: that.phone,
        AccountName: username.nickName,
        OrderState: that.orderState
      },
      success(res) {
        var i = res.data;
        if (i == 1) {
          wx.navigateTo({
            url: '../checkPlane/checkPlane',
          })
        }
      }
    })
  },


  Plus() {
    var tic = this.data.ticket + 1;
    var unitprice = this.data.unitPrice;
    this.setData({
      ticket: tic,
      totalsum: tic * unitprice,
    })
  },
  ticNum: function (e) {
    var unitprice = this.data.unitPrice;
    this.setData({
      ticket: e.detail.value,
      totalsum: e.detail.value * unitprice,
    })
  },
  ticPhone: function (e) {
    this.setData({
      phone: e.detail.value,
    })
  }
})