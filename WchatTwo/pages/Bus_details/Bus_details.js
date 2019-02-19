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
        console.log(list.StartDate);
        console.log(list.Count);
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

  toPay: function () {
    var that = this.data;

    wx.getStorage({
      key: 'token',
      success: function (res) {
        console.log(res.data)
        console.log(111111111111)
        wx.request({
          url: 'http://localhost:61984/api/Bus/addbuss',
          method: 'POST',
          data: {
            BusPric: that.busPrice,
            StartingStation: that.startingStation,
            DestinationStation: that.destinationStation,
            StartDate: that.startDate,
            StartTime: that.startTime,
            EndTime: that.endTime,
            Count: that.count

          },
          header: {
            'content-type': 'application/json',
            'Authorization': 'BasicAuth ' + res.data
          },
          success(res) {
            var i = res.data;
            if (i == 1) {
              wx.navigateTo({
                url: '../checkBus/checkBus',
              })
            }

          }
        })
      },
    })
  }
})