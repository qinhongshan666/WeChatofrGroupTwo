// pages/Bus_details/Bus_details.js
const app = getApp();
Page({
  data: {
    ticket: 1,
    busPrice: '',
    startingStation: '',
    destinationStation: '',
    startDate: '',
    startTime: '',
    endTime: '',
    count: '',
    name:'',
    phone:'',
    idnumber:'',
  },
  onLoad: function (options) {
    var id = options.busid;
    var that = this;
    wx.request({
      url: 'http://localhost:61984/api/Bus/GetBus',
      method: 'GET',
      data: {
        id: id
      },
      success(res) {
        var list = res.data;
        that.setData({
          busPrice: list.BusPrice,
          startingStation: list.StartingStation,
          destinationStation: list.DestinationStation,
          startDate: list.StartDate,
          startTime: list.StartTime,
          endTime: list.EndTime,
          count: list.Count,
        })
      }
    })
  },
  ticPhone: function (e) {
    this.setData({
      phone: e.detail.value,
    })
  },

  ticName: function (e) {
    this.setData({
      name: e.detail.value,
    })
  },

  ticidnumber: function (e) {
    this.setData({
      idnumber: e.detail.value,
    })
  },
    
    })