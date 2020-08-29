require('dotenv').config()
require("module-alias/register")
require('sk-database')

const { Client } = require('discord.js')

const client = new Client();

client.on('ready', () => console.log("I'm Ready! >.<"))

client.on('message', async message =>{
    const args = message.content.slice(process.env.PREFIX.length).trim().split(/ +/g);
	const command = args.shift().toLowerCase();

    if (message.author.bot) return;
    if (message.channel.type === "dm") return;
    if (!message.content.startsWith(process.env.PREFIX)) return;

    try {
		let commandFile = require(`./commands/${command}.js`)
		commandFile.run(client, message, args);

	} catch (err) {
		console.log(err)
		if (err.code == 'MODULE_NOT_FOUND')
			return message.channel.send("That command does not exist!")
		console.log(err)
	}

})

client.login(process.env.TOKEN)