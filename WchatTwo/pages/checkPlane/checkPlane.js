// pages/checkBus/checkBus.js
Page({
  data: {
    navbar: ["已完成", "待付款", "退款中"],
    currentTab: 0,
  },
  onLoad: function (options) {
    var that = this;
    wx.getStorage({
      key: 'token',
      success: function(res) {
        wx.request({
          url: 'http://localhost:61984/api/ShoppingCart/GetPaid',
          dataType: 'json',
          method: 'get',
          async: false,
          header: {
            'content-type': 'application/json',
            'Authorization': 'BasicAuth ' + res.data
          },
          success: function (options) {
            console.log(options.data);
            that.setData({
              infos: options.data,
            })
          }

        }),
          wx.request({
            url: 'http://localhost:61984/api/ShoppingCart/GetObligation',
            dataType: 'json',
            method: 'get',
            async: false,
          header: {
            'content-type': 'application/json',
            'Authorization': 'BasicAuth ' + res.data
          },
            success: function (options) {
              that.setData({
                loading: options.data,
              })
            }
          }),
          wx.request({
            url: 'http://localhost:61984/api/ShoppingCart/GetNonPayment',
            dataType: 'json',
            method: 'get',
            async: false,
          header: {
            'content-type': 'application/json',
            'Authorization': 'BasicAuth ' + res.data
          },
            success: function (options) {
              console.log(options.data)
              that.setData({
                baclk: options.data,
              })
            }
          })
      },
    })
  },

  del: function (e) {
    var that = this;
    wx.showModal({
      title: '提示',
      content: '确认删除吗?',
      success: function (res) {
        if (res.confirm) {
          console.log('用户点击确定')
          wx.getStorage({
            key: 'token',
            success: function(res)
             {
              wx.request({
                url: 'http://localhost:61984/api/ShoppingCart/Delete?ID=' + e.target.id,
                dataType: 'json',
                method: 'get',
                header: {
                  'content-type': 'application/json',
                  'Authorization': 'BasicAuth ' + res.data
                },
                success: function (options) {
                  if (options.data > 0) {
                    that.onLoad();
                  }
                }
              })
             },
          })
      
        }
        else if (res.cancel) {
          console.log('用户点击取消')
        }
      }
    }) 
  },
  Gopaid:function(e){
    var that=this;
        wx.showToast({
          title: '成功',
          icon: 'success',
          duration: 2000
        })
        wx.request({
          url: 'http://localhost:61984/api/ShoppingCart/UpdateOrderState?ID=' + e.target.id,
          dataType: 'json',
          method: 'get',
          success: function (options) {
            if (options.data > 0) {
              that.onLoad();
            }
          }
        })
  },

  bindChange: function (e) {
    var that = this;
    that.setData({ currentTab: e.detail.current });
  },
  navbarTap: function (e) {
    this.setData({
      currentTab: e.currentTarget.dataset.idx
    })
  },
  /**
   * 点击tab切换
   */
  swichNav: function (e) {
    var that = this;

    if (this.data.currentTab === e.target.dataset.current) {
      return false;
    } else {
      that.setData({
        currentTab: e.target.dataset.current
      })
    }
  },
  goNon: function (e) {
    var that = this;
        wx.showModal({
          title: '提示',
          content: '确认退款吗?',
          success: function (res) {
            if (res.confirm) {
              console.log('用户点击确定')
              wx.request({
                url: 'http://localhost:61984/api/ShoppingCart/UpdateOrderStateId?ID=' + e.target.id,
                dataType: 'json',
                method: 'get',
                success: function (options) {
                  if (options.data > 0) {
                    that.onLoad();
                  }
                }
              })
            } else if (res.cancel) {
              console.log('用户点击取消')
            }
          }
        })  
  },
})