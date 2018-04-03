using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace _2018_Group_Project
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            // just an attempt to push to make sure that it works
            // after update
        }

        private void Button_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Praetor"; }
        private void addLegionPraetor(object sender, RoutedEventArgs e) { TextBox.Text = "classid:11 unitid:1601"; }

        private void Button_Click_1(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Centurion"; }
        private void addLegionCenturion(object sender, RoutedEventArgs e) { TextBox.Text = "classid:11 unitid:1801"; }

        private void Button_Click_2(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Command Squad"; }
        private void addCommandSquad(object send, RoutedEventArgs e) { TextBox.Text = "classid:11 unitid:2601 and 2602"; }

        private void Button_Click_3(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Command Tactical Squad"; }
        private void addLegionVeteranTacticalSquad(object sender, RoutedEventArgs e) { TextBox.Text = "classid:12 unitid:2801 and 2802"; }

        private void Button_Click_4(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Destroyer Squad"; }
        private void addLegionDestroyerSquad(object sender, RoutedEventArgs e) { TextBox.Text = "classid:12 unitid:2901 and 2902"; }

        private void Button_Click_5(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Terminator Squad"; }
        private void addLegionTerminatorSquad(object sender, RoutedEventArgs e) { TextBox.Text = "classid:12 unitid:3001 and 3002"; }

        private void Button_Click_6(object sender, RoutedEventArgs e) { TextBox.Text = " Techmarine Covenant"; }
        private void addTechmarineCovenant(object sender, RoutedEventArgs e) { TextBox.Text = "classid:12 unitid:3101 and 3102"; }

        private void Button_Click_7(object sender, RoutedEventArgs e) { TextBox.Text = "Apothicarion Detachment"; }
        private void addApothicarionDetachment(object sender, RoutedEventArgs e) { TextBox.Text = "classid:12 unitid:3201"; }

        private void Button_Click_8(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Rapier Weapons Battery"; }
        private void addLegionRapierWeaponsBattery(object sender, RoutedEventArgs e) { TextBox.Text = "classid:12 unitid:3501 and 3502"; }

        private void Button_Click_9(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Tactical Squad"; }
        private void addLegionTacticalSquad(object sender, RoutedEventArgs e) { TextBox.Text = "classid:13 unitid:4001, 4002, 4101, 4102"; }

        private void Button_Click_10(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Breacher Siege-Squad"; }
        private void addLegionBreacherSiegeSquad(object sender, RoutedEventArgs e) { TextBox.Text = "classid:13 unitid:4201, 4202"; }

        private void Button_Click_11(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Tactical Support Squad"; }
        private void addLegionTacticalSupportSquad(object sender, RoutedEventArgs e) { TextBox.Text = "classid:13 unitid:4301, 4302"; }

        private void Button_Click_12(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Reconnaissance Squad"; }
        private void addLegionReconnaissanceSquad(object sender, RoutedEventArgs e) { TextBox.Text = "classid:13 unitid:4401"; }

        private void legonseekersquad_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Seeker Squad"; }
        private void addLegionSeekerSquad(object sender, RoutedEventArgs e) { TextBox.Text = "classid 15, unitid: 4801, 4802"; }

        private void LegionOutriderSquad_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Outrider Squad"; }
        private void addLegionOutriderSquad(object sender, RoutedEventArgs e) { TextBox.Text = "classid:15, unitid:4901, 4902"; }

        private void Legion_Attack_Bike_Squad_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Attack Bike Squad"; }
        private void addLegionAttackBikeSquad_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:15 unitid: 5001"; }

        private void LegionJetbikeHunterSquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Jetbike Hunter Squadron"; }
        private void addLegionJetbikeHunterSquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:15 unitid: 5101, 5102"; }

        private void Legiontarantulasentrygunbattery_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Tarantula Sentry Gun-Battery"; }
        private void addLegionTarantulaSentryGunBattery(object sender, RoutedEventArgs e) { TextBox.Text = "classid:15 unitid:5401, "; }

        private void Legionjetbikesky_slayersupportsquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Jetbike Sky-Slayer Support Squadron"; }
        private void addLegionJetbikeSkyslayerSupportSquadron(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:6001, 6001"; }


        private void Legionheavysupportsquad_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Heavy Support Squad"; }
        private void addLegionHeavySupportSquad(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:6201 6202"; }

        private void DamoclesCommandRhino_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Damocles Command Rhino"; }
        private void addDamoclesCommandRhino(object sender, RoutedEventArgs e) { TextBox.Text = "classid:11 unitid:2501"; }

        private void LegionRhinoArmouredCarrier__Click(object sender, RoutedEventArgs e) {TextBox.Text = "Legion Rhino Armoured Carrier"; }
        private void addLegionRhinoArmouredCarrier(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:4501"; }

        private void LegionDropPod_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Drop Pod"; }
        private void addLegionDropPod(object sender, RoutedEventArgs e) { TextBox.Text = "classid:14 unitid:4601"; }

        private void LegionDreadnoughtDropPod_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Dreadnought Drop Pod"; }
        private void addLegionDreadnoughtDropPod(object sender, RoutedEventArgs e) { TextBox.Text = "classid:14 unitid:4701"; }

        private void PrimarisLightningStrikeFighter_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Primaris-Lightning Strike Fighter"; }
        private void addPrimarisLightningStrikeFighter(object sender, RoutedEventArgs e) { TextBox.Text = "classid:15 unitid:5201"; }

        private void AnvillusPatternDreadclawDropPod_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Anvillus Pattern Dreadclaw Drop Pod"; }
        private void addAnvillusPatternDreadclawDropPod(object sender, RoutedEventArgs e) { TextBox.Text = "classid:15 unitid:5501"; }

        private void LegionLandSpeederSquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Land Speeder Squadron"; }
        private void addLegionLandSpeederSquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:15 unitid:5601"; }


        private void LegionStormEagleAssaultGunship_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Storm Eagle Assault Gunship"; }
        private void addLegionStormEagleAssaultGunship_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:15 unitid:5701"; }


        private void XiphonPatternInterceptor_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Xiphon Pattern Interceptor"; }
        private void addXiphonPatternInterceptor_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:15 unitid:5801"; }


        private void LegionJavelinAttackSpeederSquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Javelin Attack Speeder Squadron"; }
        private void addLegionJavelinAttackSpeederSquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:15 unitid:5901"; }


        private void DeathStormDropPod_Click(object sender, RoutedEventArgs e) { TextBox.Text = "DeathStorm Drop Pod"; }
        private void addDeathStormDropPod_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:9001"; }


        private void LegionPredatorStrikeSquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Predator Strike Squadron "; }
        private void addLegionPredatorStrikeSquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:6301"; }

        private void LegionLandRaiderBattleSquadronPhobos_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Land Raider Battle Squadron Phobos"; }
        private void addLegionLandRaiderBattleSquadronPhobos_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:6401"; }


        private void LegionLandRaiderBattleSquadronProteus_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Land Raider Battle Squadron Proteus"; }
        private void addLegionLandRaiderBattleSquadronProteus_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:6411"; }

        private void LegionLandRaiderBattleSquadronAchilles_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Land Raider Battle Squadron Achilles"; }
        private void addLegionLandRaiderBattleSquadronAchilles_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:6421"; }


        private void LegionFireRaptorGunship_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Fire Raptor Gunship"; }
        private void addLegionFireRaptorGunship_Click(object sender, RoutedEventArgs e) { TextBox.Text = "class id16 unitid:6601"; }

        private void AchillesAlphaPatternLandRaider_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Achilles-Alpha Pattern Land Raider"; }
        private void addAchillesAlphaPatternLandRaider_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:6701"; }

        private void LegionBasiliskArtillerySquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Basilisk Artillery Squadron"; }
        private void addLegionBasiliskArtillerySquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid6801"; }


        private void LegionMedusaArtilleryTankSquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Medusa Artillery Tank Squadron"; }
        private void addLegionMedusaArtilleryTankSquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:6811"; }


        private void LegionWhirlwindArtilleryTankSquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Whirlwind Artillery Tank Squadron"; }
        private void addLegionWhirlwindArtilleryTankSquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:6821"; }

        private void LegionVindicatorSiegeTankSquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Vindicator Siege Tank Squadron"; }
        private void addLegionVindicatorSiegeTankSquadron_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:6901"; }

        private void LegionSpartanAssaultTank_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Spartan Assault Tank"; }
        private void addLegionSpartanAssaultTank_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:7001"; }


        private void LegionCaestusAssaultRam_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Caestus Assault Ram"; }
        private void addLegionCaestusAssaultRam_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:7101, 7201"; }


        private void LegionSicaranBattleTank_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Sicaran Battle Tank"; }
        private void addLegionSicaranBattleTank_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:7301"; }


        private void LegionKharybdisAssaultClaw_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Kharybdis Assault Claw"; }
        private void addLegionKharybdisAssaultClaw_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:7401"; }


        private void LegionWhirlwindScorpius_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Whirlwind Scorpius"; }
        private void addLegionWhirlwindScorpius_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:8001"; }


        private void LegionMalcadorAssaultTank_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Malcador Assault Tank"; }
        private void addLegionMalcadorAssaultTank_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid:8101"; }


        private void LegionCerberusHeavyTankDestroyer_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Cerberus Heavy Tank Destroyer"; }
        private void addLegionCerberusHeavyTankDestroyer_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:17 unitid:8201"; }

        private void LegionTyphonHeavySiegeTank_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Typhon Heavy Siege Tank"; }
        private void addLegionTyphonHeavySiegeTank_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:17 unitid:8301"; }

        private void LegionFalchionSuperHeavyTankDestroyer_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Falchion Super-Heavy Tank Destroyer"; }
        private void addLegionFalchionSuperHeavyTankDestroyer_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:17 unitid:8401"; }

        private void LegionStormbladeSuperhHeayTank_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion stormblade Super-heay tank"; }
        private void addLegionStormbladeSuperhHeayTank_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:17 unitid:8501"; }

        private void LegionFellbladeSuperHeavyTank_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Fellblade Super-heavy Tank"; }
        private void addLegionFellbladeSuperHeavyTank_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:17 unitid:8601"; }

        private void LegionGlaiveSuperHeavyTank_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Glaive Super-heavy Tank"; }
        private void addLegionGlaiveSuperHeavyTank_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:17 unitid:8701"; }

        private void LegionThunderhawkTransporter_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Thunderhawk Transporter"; }
        private void addLegionThunderhawkTransporter_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:17 unitid:8801"; }

        private void LegionThunderhawkGunship_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Thunderhawk Gunship"; }
        private void addLegionThunderhawkGunship_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:17 unitid:8901"; }

        private void LegionMastodonHeavyAssaultTransport_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Mastodon Heavy Assault Transport"; }
        private void addLegionMastodonHeavyAssaultTransport_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:17 unitid:9001"; }

        private void SokarPatternStormbird_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Sokar Pattern Stormbird"; }
        private void addSokarPatternStormbird_Click(object sender, RoutedEventArgs e) { TextBox.Text = "clasid:17 unitid:9201"; }

        private void LegionDreadnoughtTalon_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Dreadnought Talon"; }
        private void addLegionDreadnoughtTalon_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:12 unitid:3301"; }

        private void ContemptorDreadnoughtTalon_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Contemptor Dreadnought Talon"; }
        private void addContemptorDreadnoughtTalon_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:12 unitid:3401"; }

        private void LegionMortisDreadnought_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Legion Mortis Dreadnought"; }
        private void addLegionMortisDreadnought_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:12 unitid:3601"; }

        private void ContemptorMortisDreadnought_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Contemptor-Mortis Dreadnought"; }
        private void addContemptorMortisDreadnought_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:12 unitid:3701"; }

        private void ContemptorCortusClassDreadnoughtTalon_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Contemptor Cortus Class Dreadnought Talon"; }
        private void addContemptorCortusClassDreadnoughtTalon_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid12 unitid:3801"; }

        private void LeviathanPatternSiegeDreadnoughtTalon_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Leviathan Pattern Siege Dreadnought Talon"; }
        private void addLeviathanPatternSiegeDreadnoughtTalon_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:16 unitid7601"; }

        private void DeredeoPatternDreadnought_Click(object sender, RoutedEventArgs e) { TextBox.Text = "Deredeo Pattern Dreadnought"; }
        private void addDeredeoPatternDreadnought_Click(object sender, RoutedEventArgs e) { TextBox.Text = "classid:? unitid:3301"; }
    }
}
