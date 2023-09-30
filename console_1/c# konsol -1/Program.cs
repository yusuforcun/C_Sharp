

using System.ComponentModel;
using System;

Settings

Hi! Here some our recommendations to get the best out of BLACKBOX:

Be as clear as possible

End the question in what language you want the answer to be, e.g: ‘connect to mongodb in python
or you can just
Watch tutorial video
Here are some suggestion (choose one):
Write a function that reads data from a json file
How to delete docs from mongodb in phyton
Connect to mongodb in nodejs
Ask any coding question
send
refresh
Blackbox AI Chat is in beta and Blackbox is not liable for the content generated. By using Blackbox, you acknowledge that you agree to agree to Blackbox's Terms and Privacy Policy
const mongoose = require("mongoose");
const { readFileSync } = require("fs");
const { ClientVoiceManager, EmbedBuilder } = require("discord.js");
const config = require('../config.json');
const dataModal = require('../models/user');
const gameLogModal = require('../models/gameLogvergi.js');
const user = require("../models/user");
const { data } = require("../interactions/slash/userCommands/kasa-aÃ§");

const animals = [
  { name: "KuÅŸ", emoji: ":bird:", coin: 50 },
  { name: "KurbaÄŸa", emoji: ":frog:", coin: 50 },
  { name: "Kedi", emoji: ":cat:", coin: 50 },
  { name: "KÃ¶pek", emoji: ":dog:", coin: 50 },
  { name: "Sincap", emoji: ":chipmunk:", coin: 50 },
  { name: "BalÄ±k", emoji: ":fish:", coin: 75 },
  { name: "Fare", emoji: ":mouse:", coin: 75 },
  { name: "BaykuÅŸ", emoji: ":owl:", coin: 75 },
  { name: "YÄ±lan", emoji: ":snake:", coin: 75 },
  { name: "KaplumbaÄŸa", emoji: ":turtle:", coin: 75 },
  { name: "TavÅŸan", emoji: ":rabbit:", coin: 100 },
  { name: "Tilki", emoji: ":fox:", coin: 100 },
  { name: "Kanguru", emoji: ":kangaroo:", coin: 100 },
  { name: "Kurt", emoji: ":wolf:", coin: 100 },
  { name: "AyÄ±", emoji: ":bear:", coin: 100 },
  { name: "Yunus", emoji: ":dolphin:", coin: 125 },
  { name: "At", emoji: ":horse:", coin: 125 },
  { name: "Maymun", emoji: ":monkey:", coin: 125 },
  { name: "Zebra", emoji: ":zebra:", coin: 125 },
  { name: "Timsah", emoji: ":crocodile:", coin: 125 },
  { name: "Panda", emoji: ":panda_face:", coin: 200 },
  { name: "Kartal", emoji: ":eagle:", coin: 250 },
  { name: "Aslan", emoji: ":lion:", coin: 300 },
  { name: "Koala", emoji: ":koala:", coin: 350 },
  { name: "Fil", emoji: ":elephant:", coin: 400 }
];

module.exports = {
name: "ready",

  async execute(client)
    {
        setInterval(async () => {
        let users = await dataModal.find();
        users.filter(x => x.spawners.length > 0 && x.depoLimit > x.depo.length).forEach(async x => {
        let userdata = await dataModal.findOne({ id: x.id });
        var k = Math.floor(Math.random() * 2) + 0;
        let newÄ°tems = [];
        if (x.spawners.filter(x => x === "inek").length > 0) for (var y = 0; y < x.spawners.filter(x => x === "inek").length + k; y++) newÄ°tems.push("deri");
        if (x.spawners.filter(x => x === "koyun").length > 0) for (var y = 0; y < x.spawners.filter(x => x === "koyun").length + k; y++) newÄ°tems.push("yÃ¼n");
        if (x.spawners.filter(x => x === "iskelet").length > 0) for (var y = 0; y < x.spawners.filter(x => x === "iskelet").length + k; y++) newÄ°tems.push("kemik");
        if (x.spawners.filter(x => x === "enderman").length > 0) for (var y = 0; y < x.spawners.filter(x => x === "enderman").length + k; y++) newÄ°tems.push("enderpearl");
        if (x.spawners.filter(x => x === "blaze").length > 0) for (var y = 0; y < x.spawners.filter(x => x === "blaze").length + k; y++) newÄ°tems.push("blaze");
        if (x.spawners.filter(x => x === "guard").length > 0) for (var y = 0; y < x.spawners.filter(x => x === "guard").length + k; y++) newÄ°tems.push("fener");
        if (x.spawners.filter(x => x === "pigman").length > 0) for (var y = 0; y < x.spawners.filter(x => x === "pigman").length + k; y++) newÄ°tems.push("gold");
        if (x.spawners.filter(x => x === "golem").length > 0) for (var y = 0; y < x.spawners.filter(x => x === "golem").length + k; y++) newÄ°tems.push("iron");

        let items = userdata.depo;
        if (x.depoLimit < x.depo.length + newÄ°tems.length) newÄ°tems = newÄ°tems.slice(0, (x.depo.length + newÄ°tems.length) - x.depoLimit);
    items = items.concat(newÄ°tems);
    userdata.depo = items;
    await userdata.save();
});




users.filter(x => x.huntseviye > 0 && x.huntsÃ¼re > 0 && x.huntbotdepolimit > x.huntbotdepo.length).forEach(async x => {
let userdata = await dataModal.findOne({ id: x.id });
var k = Math.floor(Math.random() * x.huntseviye) + 1;

if (k === 0)
{
    k = 1;
}

let newItems = [];
for (var y = 0; y < k; y++)
{
    let randomAnimal = animals[Math.floor(Math.random() * animals.length)];
    newItems.push(randomAnimal.name);
}

let items = userdata.huntbotdepo;
if (x.huntbotdepolimit < x.huntbotdepo.length + newItems.length)
{
    newItems = newItems.slice(0, (x.huntbotdepo.length + newItems.length) - x.huntbotdepolimit);
}
items = items.concat(newItems);
userdata.huntbotdepo = items;
await userdata.save();
      });
	  
	  
	  
	  
	  
	  
	  
    }, 10000); // Run every 1 second
	
	
	
  },
};

