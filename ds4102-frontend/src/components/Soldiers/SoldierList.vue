<template>
    <section>
        <h2>List of soldiers</h2>
        <soldier-item
            v-for="(soldier, i) in soldiers"
            :key="i"
            :soldierId="soldier.soldierId"
            :soldierName="soldier.soldierName"
            :bloodtype="soldier.bloodtype"
            :height="soldier.height"
            :image="soldier.image"
            :isOnMission="soldier.isOnMission"
        ></soldier-item>
    </section>
</template>

<script>
import SoldierItem from "./SoldierItem.vue"
import soldierService from "../../services/soldierService.js"

export default {
    setup(){
        const soldiers = soldierService.getAll();

        return{
            soldiers
        }
    },
    components: {
        SoldierItem
    }   
}
</script>