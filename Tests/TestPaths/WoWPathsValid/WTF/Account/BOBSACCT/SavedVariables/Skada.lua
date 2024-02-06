
SkadaDB = {
	["namespaces"] = {
		["LibDualSpec-1.0"] = {
			["char"] = {
				["Stickershock - Area 52"] = {
					"DPS", -- [1]
					"DPS", -- [2]
					"Healing", -- [3]
					["enabled"] = true,
				},
				["Dethtongue - Hydraxis"] = {
					"Default", -- [1]
					"Default", -- [2]
					"Dethtongue - Hydraxis", -- [3]
					"Healing", -- [4]
					["enabled"] = true,
				},
			},
		},
	},
	["profileKeys"] = {
		["Reaminated - Area 52"] = "DPS",
		["Snyk - Ursin"] = "Default",
		["Soulitaire - Ursin"] = "Default",
		["Rainjdeeps - Nazgrel"] = "Default",
		["Gracen - Hydraxis"] = "Default",
		["Meteshield - Area 52"] = "DPS",
		["Lunavir - Area 52"] = "Default",
		["Syannide - Ursin"] = "Default",
		["Minimimi - Area 52"] = "Default",
		["Riban - Antonidas"] = "Default",
		["Phloozie - Gul'dan"] = "Default",
		["Komatose - Azjol-Nerub"] = "Default",
		["Leclerk - Velen"] = "Default",
		["Bubblina - Ursin"] = "Default",
		["Gracenn - Vek'nilash"] = "Default",
		["Pocowhontas - Ursin"] = "DPS",
		["Firewood - Azjol-Nerub"] = "Default",
		["Dethtongue - Hydraxis"] = "Dethtongue - Hydraxis",
		["Krosseyed - Area 52"] = "DPS",
		["Hungree - Area 52"] = "Default",
		["Gracen - Ursin"] = "Default",
		["Stickershock - Area 52"] = "Healing",
		["Stickershock - Ursin"] = "Default",
		["Badmoe - Ursin"] = "Default",
		["Moolate - Scilla"] = "Default",
		["Kiyaa - Area 52"] = "DPS",
		["Pocowhontas - Area 52"] = "DPS",
		["Servo - Vek'nilash"] = "Default",
		["Grazzhopper - Scilla"] = "Default",
		["Gracenne - Area 52"] = "Default",
		["Blondebow - Ursin"] = "Default",
		["Keylandrin - Area 52"] = "DPS",
	},
	["profiles"] = {
		["Dethtongue - Hydraxis"] = {
			["windows"] = {
				{
					["y"] = 0,
					["x"] = -291.000244140625,
					["point"] = "BOTTOMRIGHT",
					["barwidth"] = 269.999969482422,
					["mode"] = "DPS",
					["background"] = {
						["height"] = 147.000061035156,
					},
				}, -- [1]
			},
			["versions"] = {
				["1.6.3"] = true,
				["1.6.4"] = true,
				["1.6.7"] = true,
			},
			["modeclicks"] = {
				["DPS"] = 1,
			},
		},
		["Healing"] = {
			["modeclicks"] = {
				["Total healing"] = 5,
				["Healing"] = 3,
			},
			["windows"] = {
				{
					["classicons"] = false,
					["y"] = 5.99868392944336,
					["barfont"] = "2002",
					["title"] = {
						["bordertexture"] = "ArkInventory Tooltip 1",
						["font"] = "2002",
						["fontsize"] = 11,
						["texture"] = "LiteStep",
					},
					["modeincombat"] = "DPS",
					["point"] = "BOTTOMRIGHT",
					["barfontsize"] = 11,
					["mode"] = "DPS",
					["bartexture"] = "Aluminium",
					["barwidth"] = 273.000152587891,
					["background"] = {
						["height"] = 72.0001220703125,
					},
					["x"] = -309.999633789063,
				}, -- [1]
				{
					["titleset"] = true,
					["barheight"] = 18,
					["color"] = {
						["a"] = 0.6,
						["r"] = 0.3,
						["g"] = 0.3,
						["b"] = 0.3,
					},
					["issolidbackdrop"] = false,
					["classicons"] = true,
					["barslocked"] = false,
					["useframe"] = true,
					["clickthrough"] = false,
					["wipemode"] = "Damage",
					["set"] = "current",
					["hidden"] = false,
					["y"] = 97.9997863769531,
					["barfont"] = "2002",
					["name"] = "rtest",
					["display"] = "broker",
					["barfontflags"] = "",
					["isusingelvuiskin"] = true,
					["strata"] = "LOW",
					["classcolortext"] = false,
					["point"] = "BOTTOMRIGHT",
					["barbgcolor"] = {
						["a"] = 0.6,
						["r"] = 0.3,
						["g"] = 0.3,
						["b"] = 0.3,
					},
					["barcolor"] = {
						["a"] = 1,
						["r"] = 0.3,
						["g"] = 0.3,
						["b"] = 0.8,
					},
					["x"] = -369.999145507813,
					["returnaftercombat"] = false,
					["showself"] = true,
					["title"] = {
						["textcolor"] = {
							["a"] = 1,
							["r"] = 0.9,
							["g"] = 0.9,
							["b"] = 0.9,
						},
						["color"] = {
							["a"] = 1,
							["r"] = 0.3,
							["g"] = 0.3,
							["b"] = 0.3,
						},
						["bordercolor"] = {
							["a"] = 1,
							["r"] = 0,
							["g"] = 0,
							["b"] = 0,
						},
						["font"] = "Accidental Presidency",
						["fontsize"] = 13,
						["height"] = 20,
						["fontflags"] = "",
						["bordertexture"] = "None",
						["borderthickness"] = 2,
						["texture"] = "Armory",
					},
					["mode"] = "Threat",
					["roleicons"] = false,
					["barorientation"] = 1,
					["snapto"] = true,
					["background"] = {
						["height"] = 200,
						["bordercolor"] = {
							["a"] = 1,
							["r"] = 0,
							["g"] = 0,
							["b"] = 0,
						},
						["borderthickness"] = 2,
						["tile"] = false,
						["color"] = {
							["a"] = 0.4,
							["r"] = 0,
							["g"] = 0,
							["b"] = 0,
						},
						["bordertexture"] = "Roth",
						["tilesize"] = 0,
						["texture"] = "Solid",
					},
					["scale"] = 1,
					["textcolor"] = {
						["r"] = 0.9,
						["g"] = 0.9,
						["b"] = 0.9,
					},
					["fixedbarwidth"] = false,
					["buttons"] = {
						["report"] = true,
						["menu"] = true,
						["mode"] = true,
						["segment"] = true,
						["reset"] = true,
					},
					["bartexture"] = "BantoBar",
					["barwidth"] = 240,
					["barspacing"] = 0,
					["reversegrowth"] = false,
					["width"] = 180,
					["modeincombat"] = "Threat",
					["enabletitle"] = true,
					["version"] = 1,
					["classcolorbars"] = true,
					["isusingclasscolors"] = true,
					["height"] = 30,
					["barfontsize"] = 15,
					["isonnewline"] = false,
				}, -- [2]
			},
			["icon"] = {
				["minimapPos"] = 136.941312736921,
			},
			["versions"] = {
				["1.6.7"] = true,
				["1.6.4"] = true,
				["1.6.3"] = true,
			},
			["reset"] = {
				["instance"] = 3,
			},
		},
		["Default"] = {
			["modeclicks"] = {
				["DPS"] = 4,
			},
			["modules"] = {
				["ccignoremaintanks"] = true,
			},
			["modulesBlocked"] = {
				["Power"] = false,
			},
			["tooltiprows"] = 5,
			["windows"] = {
				{
					["barheight"] = 16,
					["bartexture"] = "Armory",
					["barwidth"] = 279.000030517578,
					["barfontsize"] = 12,
					["y"] = 111.00089263916,
					["x"] = -131.998413085938,
					["title"] = {
						["color"] = {
							["r"] = 0.6,
							["g"] = 0.6,
							["b"] = 0.8,
						},
						["fontsize"] = 12,
						["borderthickness"] = 0,
						["height"] = 18,
					},
					["point"] = "BOTTOMRIGHT",
					["background"] = {
						["height"] = 107.000091552734,
						["borderthickness"] = 0,
						["texture"] = "None",
					},
					["mode"] = "DPS",
					["modeincombat"] = "DPS",
				}, -- [1]
				{
					["titleset"] = true,
					["barheight"] = 18,
					["color"] = {
						["a"] = 0.6,
						["b"] = 0.3,
						["g"] = 0.3,
						["r"] = 0.3,
					},
					["issolidbackdrop"] = false,
					["classicons"] = true,
					["barslocked"] = false,
					["useframe"] = true,
					["clickthrough"] = false,
					["wipemode"] = "",
					["set"] = "current",
					["hidden"] = false,
					["y"] = 249.003601074219,
					["barfont"] = "Accidental Presidency",
					["name"] = "Heals",
					["display"] = "bar",
					["barfontflags"] = "",
					["isusingelvuiskin"] = true,
					["strata"] = "LOW",
					["classcolortext"] = false,
					["isonnewline"] = false,
					["barbgcolor"] = {
						["a"] = 0.6,
						["b"] = 0.3,
						["g"] = 0.3,
						["r"] = 0.3,
					},
					["barcolor"] = {
						["a"] = 1,
						["b"] = 0.8,
						["g"] = 0.3,
						["r"] = 0.3,
					},
					["returnaftercombat"] = false,
					["barfontsize"] = 13,
					["height"] = 30,
					["title"] = {
						["textcolor"] = {
							["a"] = 1,
							["b"] = 0.9,
							["g"] = 0.9,
							["r"] = 0.9,
						},
						["color"] = {
							["a"] = 1,
							["b"] = 0.3,
							["g"] = 0.3,
							["r"] = 0.3,
						},
						["bordercolor"] = {
							["a"] = 1,
							["b"] = 0,
							["g"] = 0,
							["r"] = 0,
						},
						["font"] = "Accidental Presidency",
						["fontsize"] = 13,
						["fontflags"] = "",
						["height"] = 20,
						["borderthickness"] = 2,
						["bordertexture"] = "None",
						["texture"] = "Armory",
					},
					["snapto"] = true,
					["roleicons"] = false,
					["barorientation"] = 1,
					["mode"] = "Healing",
					["version"] = 1,
					["enabletitle"] = true,
					["modeincombat"] = "Healing",
					["fixedbarwidth"] = false,
					["bartexture"] = "BantoBar",
					["buttons"] = {
						["segment"] = true,
						["menu"] = true,
						["mode"] = true,
						["report"] = true,
						["reset"] = true,
					},
					["barwidth"] = 320.000152587891,
					["barspacing"] = 0,
					["reversegrowth"] = false,
					["width"] = 600,
					["textcolor"] = {
						["b"] = 0.9,
						["g"] = 0.9,
						["r"] = 0.9,
					},
					["scale"] = 1,
					["background"] = {
						["color"] = {
							["a"] = 0.4,
							["b"] = 0,
							["g"] = 0,
							["r"] = 0,
						},
						["bordertexture"] = "Blizzard Party",
						["borderthickness"] = 2,
						["tile"] = false,
						["height"] = 50.9999885559082,
						["bordercolor"] = {
							["a"] = 1,
							["b"] = 0,
							["g"] = 0,
							["r"] = 0,
						},
						["tilesize"] = 0,
						["texture"] = "Solid",
					},
					["classcolorbars"] = true,
					["isusingclasscolors"] = true,
					["showself"] = true,
					["x"] = -110.00048828125,
					["point"] = "BOTTOMRIGHT",
				}, -- [2]
			},
			["versions"] = {
				["1.6.7"] = true,
				["1.6.4"] = true,
				["1.6.3"] = true,
			},
			["icon"] = {
				["minimapPos"] = 189.833511514051,
				["hide"] = true,
			},
			["reset"] = {
				["instance"] = 3,
			},
		},
		["DPS"] = {
			["modeclicks"] = {
				["Damage"] = 3,
				["DPS"] = 7,
				["Interrupts"] = 2,
			},
			["windows"] = {
				{
					["y"] = 3.99920415878296,
					["barfont"] = "2002",
					["title"] = {
						["font"] = "2002",
						["fontsize"] = 11,
					},
					["barfontsize"] = 11,
					["mode"] = "DPS",
					["barwidth"] = 239.999801635742,
					["point"] = "BOTTOMRIGHT",
					["background"] = {
						["height"] = 111.000030517578,
					},
					["x"] = -346.000610351563,
				}, -- [1]
			},
			["icon"] = {
				["hide"] = true,
			},
			["versions"] = {
				["1.6.3"] = true,
				["1.6.4"] = true,
				["1.6.7"] = true,
			},
			["reset"] = {
				["join"] = 2,
			},
		},
	},
}