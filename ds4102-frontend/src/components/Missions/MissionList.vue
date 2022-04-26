<template>
    <section>
        <mission-item
            v-for="(mission, i) in missions"
            :key="i"
            :MissionId="mission.MissionId"
            :MissionName="mission.MissionName"
            :MissionLocation="mission.MissionLocation"
            :SoldiersDeployed="mission.SoldiersDeployed"
        ></mission-item>
    </section>
</template>

<script>
import MissionItem from "./MissionItem.vue"
import missionService from "../../services/missionService.js"

export default {
    setup(){
        const missions = missionService.getAll();

        return{
            missions
        }
    },
    components: {
        MissionItem
    }   
}
</script>