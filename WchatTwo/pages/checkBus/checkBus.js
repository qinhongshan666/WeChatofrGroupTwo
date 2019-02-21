// pages/checkBus/checkBus.js
Page({
  data: {
    navbar: ["已完成", "待付款", "退款中"],
    currentTab:0,
  },
  navbarTap: function (e) {
    this.setData({
      currentTab: e.currentTarget.dataset.idx
    })
  },
  onLoad: function (options) 
  {
    var that = this;
    wx.getStorage({
      key: 'token',
      success: function(res) {
        wx.request({
          url: 'http://localhost:61984/api/ShoppingCart/busIndents',
          dataType: 'json',
          method: 'get',
          async: false,
          header: {
            'content-type': 'application/json',
            'Authorization': 'BasicAuth ' + res.data
          },
          success: function (options) {
            that.setData({
              infos: options.data,
            })
          }
          
        }),
          wx.request({
            url: 'http://localhost:61984/api/ShoppingCart/getBusIndents',
            dataType: 'json',
            method: 'get',
            async: false,
          header: {
            'content-type': 'application/json',
            'Authorization': 'BasicAuth ' + res.data
          },
            success: function (options) {
              //console.log(options.data);
              that.setData({
                NoPays: options.data,
              })
            }
          }),
          wx.request({
            url: 'http://localhost:61984/api/ShoppingCart/getBusIndent',
            dataType: 'json',
            method: 'get',
            async: false,
          header: {
            'content-type': 'application/json',
            'Authorization': 'BasicAuth ' + res.data
          },
            success: function (options) {
              that.setData({
                back: options.data,
              })
            }
          })  
      },
    })
  },

 
 




  del:function(e){
   var that=this;
wx.getStorage({
  key: 'token',
  success: function(res) {
    wx.showModal({
      title: '提示',
      content: '确认删除吗?',
      success: function (res) {
        if (res.confirm) {
          console.log('用户点击确定')
          wx.request({
            url: 'http://localhost:61984/api/ShoppingCart/DeleteById?ID=' + e.target.id,
            dataType: 'json',
            method: 'get',
            header: {
              'content-type': 'application/json',
              'Authorization': 'BasicAuth ' + res.data
            },
            success: function (options) {
              console.log(options);
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
  }
})
  },



  bindChange: function (e) {
    var that = this;
    that.setData({ currentTab: e.detail.current });
  },

  Gopaid: function (e) {
    var that = this;
    wx.getStorage({
      key: 'token',
      success: function(res) {
        wx.showToast({
          title: '成功',
          icon: 'success',
          duration: 2000
        }) 
        wx.request({
          url: 'http://localhost:61984/api/ShoppingCart/UpdateBusPaid?ID=' + e.target.id,
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
  },


  goNon: function (e) {
    var that = this;
    wx.getStorage({
      key: 'token',
      success: function(res) {
        wx.showModal({
          title: '提示',
          content: '确认退款吗?',
          success: function (res) {
            if (res.confirm) {
              console.log('用户点击确定')
              wx.request({
                url: 'http://localhost:61984/api/ShoppingCart/UpdateBusNonPaymen?ID=' + e.target.id,
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

            }
            else if (res.cancel) {
              console.log('用户点击取消')
            }
          }
        })
      },
    })
  },
})