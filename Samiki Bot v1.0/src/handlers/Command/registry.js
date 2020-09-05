const fs = require('fs').promises;
const path = require('path');
const { checkCommandModule, checkProperties } = require('./validate');
const { Client } = require('discord.js');

/**
 * Array to save the current status of an command
 */
const commandStatus = []

/**
 * Function to check the existence of commands and create an instance of each in the bot cache
 * @param {Client} client The bot client
 * @param {String} dir The command Folder 
 */
const registerCommands = async (client, dir) => {
    let files = await fs.readdir(path.join(__dirname, dir));
    // Loop through each file.
    for (let file of files) {
        let stat = await fs.lstat(path.join(__dirname, dir, file));
        if (stat.isDirectory()) // If file is a directory, recursive call recurDir
            registerCommands(client, path.join(dir, file));
        else {
            // Check if file is a .js file.
            if (file.endsWith(".js")) {
                let cmdName = file.substring(0, file.indexOf(".js"));
                try {
                    let cmdModule = require(path.join(__dirname, dir, file));
                    if (checkCommandModule(cmdName, cmdModule)) {
                        if (checkProperties(cmdName, cmdModule)) {
                            let { aliases } = cmdModule;
                            client.commands.set(cmdName, { run: cmdModule.run, name: cmdModule.name, help: cmdModule.help });
                            if (aliases.length !== 0)
                                aliases.forEach(alias => client.commands.set(alias, cmdModule.run));
                            commandStatus.push(
                                [`${cmdName}`, `Success`, `${cmdModule.description}`, `${cmdModule.module}`]
                            )
                        }
                    }
                }
                catch (err) {
                    console.log(err);
                    commandStatus.push(
                        [`${cmdName}`, `Failed`, '', '']
                    );
                }
            }
        }
    }
}



module.exports = {
    registerCommands,
    commandStatus,
};