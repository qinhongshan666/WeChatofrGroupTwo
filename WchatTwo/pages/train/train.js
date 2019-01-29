// pages/train/train.js

var history = require('../../utils/history.js')

Page({
  data:{
    indicatorDots: true,
    vertical: false,
    autoplay: true,
    interval: 3000,
    duration: 2000,

    objectArray: [
      {
        id: 0,
        name: '美国'
      },
      {
        id: 1,
        name: '中国'
      },
      {
        id: 2,
        name: '巴西'
      },
      {
        id: 3,
        name: '日本'
      }
    ],
    index: 0,
    date: '2016-09-01',


  },
  onLoad:function(options){
    // 页面初始化 options为页面跳转所带来的参数
    this.setData({
      trainHistories:history.train
    })
  },
  ChaXun:function(){
    wx.navigateTo({
      url: '../inquire/inquire',
    })
  },
  //选择城市   跳转到城市页面
city: function () {
    wx.navigateTo({
      url: '../switchcity/switchcity',
    })
  },

  rotate_img: function () {//旋转飞机图片
    var animation = wx.createAnimation({
      timingFunction: "ease",
      duration: 400
    })
    this.animation = animation;
    animation.rotateZ(this.data.rotate).step();

    this.setData({
      rotate: -1 * this.data.rotate,
      startCity: this.data.endCity,
      endCity: this.data.startCity,
      animation: animation.export(),
    })

  },


})