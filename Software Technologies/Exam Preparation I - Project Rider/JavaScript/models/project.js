const Sequelize = require('sequelize');

module.exports = function (sequelize) {
   //TODO
   //rdy todo only for repository
   let Project = sequelize.define('Project', {
      title:{type: Sequelize.TEXT, allowNull: false,
      },
      description:{
         type: Sequelize.TEXT, allowNull: false,
      },
      budget:{
         type: Sequelize.INTEGER, allowNull: false,
      }
   }, {
      timestamps:false
   });

   return Project;
};