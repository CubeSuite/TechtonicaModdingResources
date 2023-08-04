using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HarmonyLib;
using UnityEngine;

namespace $safeprojectname$
{
    public static class ModUtils
    {
        /*
         * ModUtils by Equinox. If you have any questions, ideas, feeedback etc.
         * contact me on Discord. @cube_suite_dev
         */

        // Objects & Variables
        public static bool hasGameStateLoaded = false;
        public static bool hasGameDefinesLoaded = false;
        public static bool hasSaveStateLoaded = false;
        public static bool hasTechTreeStateLoaded = false;

        // Events
        public static event EventHandler GameStateLoaded;
        public static event EventHandler GameDefinesLoaded;
        public static event EventHandler SaveStateLoaded;
        public static event EventHandler TechTreeStateLoaded;

        // Public Functions

        #region Resources

        public static ResourceInfo GetResourceInfoByName(string name) {
            if (hasGameDefinesLoaded) {
                foreach (ResourceInfo info in GameDefines.instance.resources) {
                    if (info.displayName == name) {
                        return info;
                    }
                }
            }

            return null;
        }

        public static int? GetResourceIDByName(string name) {
            ResourceInfo info = GetResourceInfoByName(name);
            if (info != null) {
                return SaveState.GetIdForResInfo(info);
            }
            else {
                return null;
            }
        }

        #endregion

        #region Schematics

        public static SchematicsRecipeData FindThresherRecipeFromOutputs(string output1Name, string output2Name) {
            if (!hasGameDefinesLoaded) return null;

            foreach(SchematicsRecipeData schematic in GameDefines.instance.schematicsRecipeEntries) {
                if(schematic.outputTypes.Count() == 2) {
                    if ((schematic.outputTypes[0].displayName == output1Name && schematic.outputTypes[1].displayName == output2Name) ||
                        (schematic.outputTypes[0].displayName == output2Name && schematic.outputTypes[1].displayName == output1Name)) {
                        return schematic;
                    }
                }
            }

            return null;
        }

        #endregion


        #region Tech Tree

        #endregion

        public static bool IsTechUnlocked(string name) {
            if (hasTechTreeStateLoaded) {
                foreach(Unlock tech in TechTreeState.instance.unlockedTechs) {
                    if(tech.displayName == name) {
                        return true;
                    }
                }
            }

            return false;
        }

        // Event Firing

        public static void CheckIfGameStateLoaded() {
            if (GameLogic.instance == null) return;
            if (GameState.instance != null) {
                hasGameStateLoaded = true;
                GameStateLoaded?.Invoke(GameState.instance, EventArgs.Empty);
            }
        }

        public static void CheckIfGameDefinesLoaded() {
            if (GameLogic.instance == null) return;
            if (GameDefines.instance != null) {
                hasGameDefinesLoaded = true;
                GameDefinesLoaded?.Invoke(GameDefines.instance, EventArgs.Empty);
            }
        }

        public static void CheckIfSaveStateLoaded() {
            if (GameLogic.instance == null) return;
            if (SaveState.instance != null) {
                hasSaveStateLoaded = true;
                SaveStateLoaded?.Invoke(SaveState.instance, EventArgs.Empty);
            }
        }

        public static void CheckIfTechTreeStateLoaded() {
            if (MachineManager.instance == null) return;
            if (TechTreeState.instance != null) {
                hasTechTreeStateLoaded = true;
                TechTreeStateLoaded?.Invoke(TechTreeState.instance, EventArgs.Empty);
            }
        }

        public static class ResourceNames {
            public const string Accumulator = "Accumulator";
            public const string AdvancedCircuit = "Advanced Circuit";
            public const string Assembler = "Assembler";
            public const string AssemblerMKII = "Assembler MKII";
            public const string AtlantumIngot = "Atlantum Ingot";
            public const string AtlantumMixture = "Atlantum Mixture";
            public const string AtlantumOre = "Atlantum Ore";
            public const string AtlantumPowder = "Atlantum Powder";
            public const string AtlantumInfusedLimestone = "Atlantum-Infused Limestone";
            public const string Beacon = "Beacon";
            public const string Biobrick = "Biobrick";
            public const string BlueLightStick = "Blue Light Stick";
            public const string CharacterModel = "CharacterModel";
            public const string Container = "Container";
            public const string ConveyorBelt = "Conveyor Belt";
            public const string ConveyorBeltMKII = "Conveyor Belt MKII";
            public const string CoolingSystem = "Cooling System";
            public const string CopperComponents = "Copper Components";
            public const string CopperFrame = "Copper Frame";
            public const string CopperIngot = "Copper Ingot";
            public const string CopperOre = "Copper Ore";
            public const string CopperWire = "Copper Wire";
            public const string CopperInfusedLimestone = "Copper-Infused Limestone";
            public const string CoreComposer = "Core Composer";
            public const string CrankGenerator = "Crank Generator";
            public const string CrankGeneratorMKII = "Crank Generator MKII";
            public const string Crate = "Crate";
            public const string ElectricalComponents = "Electrical Components";
            public const string FastInserter = "Fast Inserter";
            public const string FilterInserter = "Filter Inserter";
            public const string GreenLightStick = "Green Light Stick";
            public const string HighVoltageCable = "High Voltage Cable";
            public const string HoverPack = "Hover Pack";
            public const string Inserter = "Inserter";
            public const string IronComponents = "Iron Components";
            public const string IronFrame = "Iron Frame";
            public const string IronIngot = "Iron Ingot";
            public const string IronOre = "Iron Ore";
            public const string IronInfusedLimestone = "Iron-Infused Limestone";
            public const string Kindlevine = "Kindlevine";
            public const string KindlevineExtract = "Kindlevine Extract";
            public const string KindlevineSeed = "Kindlevine Seed";
            public const string KindlevineStems = "Kindlevine Stems";
            public const string LightStick = "Light Stick";
            public const string Lima = "Lima";
            public const string Limestone = "Limestone";
            public const string LongInserter = "Long Inserter";
            public const string MechanicalComponents = "Mechanical Components";
            public const string MiningCharge = "Mining Charge";
            public const string MiningDrill = "Mining Drill";
            public const string MiningDrillMKII = "Mining Drill MKII";
            public const string MonorailDepot = "Monorail Depot";
            public const string MonorailPole = "Monorail Pole";
            public const string MonorailTrack = "Monorail Track";
            public const string Omniseeker = "Omniseeker";
            public const string OverheadLight = "Overhead Light";
            public const string Planter = "Planter";
            public const string Plantmatter = "Plantmatter";
            public const string PlantmatterFiber = "Plantmatter Fiber";
            public const string PlantmatterFrame = "Plantmatter Frame";
            public const string PowerFloor = "Power Floor";
            public const string ProcessorUnit = "Processor Unit";
            public const string Railrunner = "Railrunner";
            public const string RedLightStick = "Red Light Stick";
            public const string ResearchCore380nmPurple = "Research Core 380nm (Purple)";
            public const string ResearchCore480nmBlue = "Research Core 480nm (Blue)";
            public const string Scanner = "Scanner";
            public const string Shiverthorn = "Shiverthorn";
            public const string ShiverthornBuds = "Shiverthorn Buds";
            public const string ShiverthornCoolant = "Shiverthorn Coolant";
            public const string ShiverthornExtract = "Shiverthorn Extract";
            public const string ShiverthornSeed = "Shiverthorn Seed";
            public const string Sierra = "Sierra";
            public const string Smelter = "Smelter";
            public const string SmelterMKII = "Smelter MKII";
            public const string Soil = "Soil";
            public const string SpectralCubeEmerald = "Spectral Cube (Emerald)";
            public const string SpectralCubeGarnet = "Spectral Cube (Garnet)";
            public const string StackInserter = "Stack Inserter";
            public const string Stairs = "Stairs";
            public const string StandardPickaxe = "Standard Pickaxe";
            public const string TheMOLE = "The M.O.L.E.";
            public const string Thresher = "Thresher";
            public const string ThresherMKII = "Thresher MKII";
            public const string Victor = "Victor";
            public const string VoltageStepper = "Voltage Stepper";
            public const string WaterWheel = "Water Wheel";
        }
    }
}
